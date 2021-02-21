# CEFSimplifiedVS17
A Visual Studio 2017 C# Windows Forms App (.NET Framework) project for testing ClickOnce. 

The project uses NuGet package CefSharp.WinForms version 87.1.132

Error "Could not load file or assembly'CefSharp.Core.Runtie.dll'." occurred on running the setup.exe created by clickOnce in Visual Studio 2017. The error did not occur in Visual Studio 2019.

To solve the error property CefSharpBuildAction is added to the .csproj projectfile for a x64 target framework. Furthermore extra tags are added to the .csproj projectfile for removing duplicate entries in the manifest file.
