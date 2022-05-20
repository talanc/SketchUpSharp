# SketchUpSharp

## Getting Started
Run `setup-sdk.cmd` to unzip the native SDK (includes DLLs and header files).
Open the solution and build.
Run one of the QuickStart programs.

## Generating bindings
This step is not required if you just want to use SketchUpSharp. The Getting Started section is enough.
Install ClangSharpPInvokeGenerator via `dotnet tool install --global ClangSharpPInvokeGenerator --version 14.0.0-beta2`
Run `generate-bindings.cmd`