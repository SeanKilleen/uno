﻿#nullable enable

using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Uno.UI.SourceGenerators.Helpers;
using System.Diagnostics;
using Uno.Extensions;
using Uno.Roslyn;

namespace Uno.UI.SourceGenerators.HotRestart;

[Generator]
public partial class HotRestartGenerator : ISourceGenerator
{
	public void Initialize(GeneratorInitializationContext context)
	{
	}

	public void Execute(GeneratorExecutionContext context)
	{
		if (!DesignTimeHelper.IsDesignTime(context)
			&& PlatformHelper.IsIOS(context)
			&& PlatformHelper.IsUnoHead(context))
		{
			var generator = new Generator(context);
			generator.Run();
		}
	}

	private class Generator
	{
		private readonly GeneratorExecutionContext _context;

		public Generator(GeneratorExecutionContext context)
		{
			_context = context;
		}

		public void Run()
		{
			if (!IsGenerationEnabled())
			{
				return;
			}

			var mauiAppDelegate = _context.Compilation.GetTypeByMetadataName("Microsoft.Maui.MauiUIApplicationDelegate");
			var shouldDefineAppDelegate = (mauiAppDelegate is null).ToString().ToLowerInvariant();

			var appType = GetApplicationDefinitionType();

			if (appType is null)
			{
				return;
			}

			var document = $$"""
				#if DEBUG
				// <auto-generated>
				// *************************************************************
				// This file has been generated by Uno.UI ({{nameof(HotRestartGenerator)}})
				// *************************************************************
				// </auto-generated>

				#if {{shouldDefineAppDelegate}}
				namespace Microsoft.Maui
				{
					[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
					internal class MauiUIApplicationDelegate : global::UIKit.UIApplicationDelegate
					{
					}
				}
				#endif

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal class __UnoHotRestartDelegate : global::Microsoft.Maui.MauiUIApplicationDelegate
				{
					public override bool FinishedLaunching(global::UIKit.UIApplication uiApplication, global::Foundation.NSDictionary launchOptions)
					{
						global::Microsoft.UI.Xaml.Application.Start(_ => new {{appType}}());
						return base.FinishedLaunching(uiApplication, launchOptions);
					}
				}
				#endif
				""";

			_context.AddSource("HotRestartHelper.g.cs", document);
		}

		private bool IsGenerationEnabled()
			=> bool.TryParse(_context.GetMSBuildPropertyValue("UnoDisableHotRestartHelperGeneration", "false"), out var result) ? result : true;

		private string? GetApplicationDefinitionType()
		{
			var appDefinitionFile = _context.GetMSBuildItemsWithAdditionalFiles("ApplicationDefinition").FirstOrDefault();

			if (appDefinitionFile?.File.GetText()?.ToString() is { } text)
			{
				// Read the xml file to get the x:Class attribute on the first node
				var appDefinitionXml = System.Xml.Linq.XDocument.Parse(text);
				var xClassAttribute = appDefinitionXml.Root?.Attributes().FirstOrDefault(a => a.Name.LocalName == "Class");

				if (xClassAttribute is not null)
				{
					return "global::" + xClassAttribute.Value;
				}
				else
				{
					_context.ReportDiagnostic(Diagnostic.Create(_descriptorMissingXClass, null));
					return null;
				}
			}
			else
			{
				_context.ReportDiagnostic(Diagnostic.Create(_descriptorMissingAppDefinition, null));
				return null;
			}
		}
	}
}

