# 0.7.5

- [Fix] Added support for dotnet build system

# 0.7.4

- [Fix] Fixed Cake addin target version (#95, thanks @crash-dive)
- [Fix] Removed Newtonsoft.Json as package dependency from MSBuild task (#96)
- [Fix] Tweaked Visual Studio dependencies for VSIX package to work on older Visual Studio versions (#93)
- [Fix] Changed build property failures to a warning for better Mono support (#92)

# 0.7.3

- [Feature] Adds option to continue on MSBuild task failures (#37)
- [Fix] Adds assembly binding attributes to the Visual Studio extension (#89)
- [Fix] No longer uses a timeout for reading stdin

# 0.7.2

- [Fix] Removed the System.IO.FileSystem.Primitives dependency from the MSBuild task (#84)
- [Fix] Adds a check for undefined solution paths (#81)
- [Fix] Passes data from MSBuild task to Scripty via stdin instead of CLI (#80, #87)
- [Fix] MSBuild task now fails the build if Scripty fails (#37)

# 0.7.1

- [Fix] Fix for binding redirects in NuGet package

# 0.7.0

- [Refactoring] Updated all packages, including Roslyn which provides C# 7 support
- [Feature] Updated VSIX for Visual Studio 2017 (#73)
- [Feature] Support for #load directives to load .cs files (#76, thanks @StingyJack)

# 0.6.0

- [Refactoring] Updated and consolidated some package versions
- [Fix] The Scripty MSBuild task now runs "BeforeBuild" (#68, thanks @reduckted)
- [Feature] Adds support for passing MSBuild project properties to Scripty (#66, thanks @reduckted)
- [Feature] Adds a `Debugging.md` file to explain how to start with Scripty development (#65, thanks @StingyJack)

# 0.5.0

- [Feature] CLI now accepts relative paths to project files
- [Feature] Adds `ScriptFiles` to the list of available build actions in Visual Studio (#45, thanks @ap0llo)
- [Feature] CLI now scans for `.csx` files in project if none are explicitly specified (#5)
- [Feature] Automatic indentation support (#15)
- [Feature] Support for the Roslyn formatter to automatically format output (#47, thanks @thebigb)
- [Feature] Implements a Cake addin for out-of-band Scripty evaluation during Cake builds (#31, thanks @agc93).

# 0.4.0

- [Feature][Breaking Change] New project tree abstraction (#13). If you were using the `Project` property previous to this release, you can now get to the Roslyn project object using the `Project.Analysis` property.
- [Feature] Added `SetExtension()` and `SetFilePath()` methods to `OutputFileCollection` allowing you to change the extension or file path of the default output file (#19).
- [Feature] The `OutputFile` class now exposes a fluent API for chaining calls like `WriteLine()` (#26, thanks @Tydude4Christ).

# 0.3.0

- [Feature] All output file objects now derive from a common `OutputFile` base class.
- [Feature] Added the `Scripty.Core` namespace and assembly to the script.
- [Feature] Moved the globals into a `ScriptContext` class and exposed it as a `Context` property.
- [Refactoring] Renamed the MSBuild item group item to `ScriptyFile` (#6).

# 0.2.0

- [Feature] Added a Visual Studio single file generator (a.k.a "custom tool").

# 0.1.0

- Initial public release!