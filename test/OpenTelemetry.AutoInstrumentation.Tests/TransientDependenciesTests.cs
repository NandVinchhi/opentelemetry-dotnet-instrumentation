// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// This test is defined in NET 9.0 because the tool is written in .NET 9.0
// The actual test is testing .NET Framework 4.6.2 context.
#if NET9_0_OR_GREATER

using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using DependencyListGenerator;
using Xunit;

namespace OpenTelemetry.AutoInstrumentation.Tests;

public class TransientDependenciesTests
{
    [SkippableFact]
    public void DefinedTransientDeps_Are_MatchingGeneratedDeps()
    {
        Skip.IfNot(RuntimeInformation.IsOSPlatform(OSPlatform.Windows), "Supported only on Windows.");

        var currentTestLocation = Assembly.GetExecutingAssembly().Location;
        var testDir = FindParentDir(currentTestLocation, "test");
        var srcDir = Path.Combine(Directory.GetParent(testDir)!.FullName, "src");
        var codeDir = Path.Combine(srcDir, "OpenTelemetry.AutoInstrumentation");
        var projectPath = Path.Combine(codeDir, "OpenTelemetry.AutoInstrumentation.csproj");
        var projectGenPath = Path.Combine(codeDir, "OpenTelemetry.AutoInstrumentation.g.csproj");

        File.Copy(projectPath, projectGenPath, overwrite: true);

        var deps = ReadTransientDeps(projectGenPath);

        CleanTransientDeps(projectGenPath);

        var generatedDeps = Generator
            .EnumerateDependencies(projectGenPath)
            .Select(x => x.Name)
            .ToList();

        // TODO automate detecting new transitive dependencies https://github.com/open-telemetry/opentelemetry-dotnet-instrumentation/issues/3817
        generatedDeps.Add("System.IO.Pipelines");

        File.Delete(projectGenPath);

        Assert.Equal(generatedDeps.Count, deps.Count);
        Assert.Equivalent(generatedDeps, deps);
    }

    private static XElement? GetTransientDepsGroup(XElement projXml)
    {
        const string label = "Transient dependencies auto-generated by GenerateNetFxTransientDependencies";

        return projXml
            .Elements("ItemGroup")
            .FirstOrDefault(x =>
                x.HasAttributes &&
                x.Attribute("Label")?.Value == label);
    }

    private static void CleanTransientDeps(string projPath)
    {
        var projXml = XElement.Load(projPath);
        var depsGroup = GetTransientDepsGroup(projXml);
        if (depsGroup != null)
        {
            depsGroup.Remove();
        }

        projXml.Save(projPath);
    }

    private static ICollection<string> ReadTransientDeps(string projPath)
    {
        var projXml = XElement.Load(projPath);
        var depsGroup = GetTransientDepsGroup(projXml);
        if (depsGroup == null)
        {
            return Array.Empty<string>();
        }

        return depsGroup
            .Descendants("PackageReference")
            .Where(x => x.HasAttributes && x.Attribute("Include") != null)
            .Select(x => x.Attribute("Include")!.Value)
            .ToList();
    }

    private static string FindParentDir(string location, string parentName)
    {
        var parent = Directory.GetParent(location);
        if (parent == null)
        {
            throw new InvalidOperationException("Could not find parent test directory");
        }

        if (parent.Name == parentName)
        {
            return parent.FullName;
        }

        return FindParentDir(parent.FullName, parentName);
    }
}

#endif
