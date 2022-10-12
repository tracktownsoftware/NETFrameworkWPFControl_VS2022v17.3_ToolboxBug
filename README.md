# NETFrameworkWPFControl_VS2022v17.3_ToolboxBug
The BUG: VS2022 v17.3.x includes ALL controls for a custom .NET Framework WPF library in the VS toolbox rather than controls filtered by the DesignTools assembly using ToolboxBrowsableAttribute(true). This appeared worked correctly in VS2022 v17.2.7 and earlier (update: VS2022 v17.2.7 was pulling this ToolboxBrowsableAttribute(false) information from a Design.dll assembly in our control library intended for VS2019; Microsft corrected this but still has not added ToolboxBrowsableAttribute(false) support in the DesignTools.dll assembly for VS2022).

This GitHub repo is a work-in-progress. Check back later for improved description and VS2022 toolbox image examples.

In the "Installers" folder I uploaded installers made from installer projects in WpfCustomControlLibrary.sln. Copy the setup.exe and WpfCustomControlLibrary.msi to a test machine from one of the subfolders below:
1. "WPFCustomControls_VS2019VS2022 x86" has design-time support in VS2019 and VS2022. The old WPF surface in VS2019 uses design.dll and the new WPF surface in VS2022 uses designtools.dll. The library is installed to "Program Files (x86)" and makes WOW6432Node registry entries. To create this installer build WPFCustomControls_VS2019VS2022.vdproj.
2. "WPFCustomControls_VS2022 x86" has WPF surface design-time support in VS2022 provided by the designtools.dll. The library is installed to "Program Files (x86)" and makes WOW6432Node registry entries. To create this installer build WPFCustomControls_VS2022.vdproj with TargetPlatorm x86.
3. "WPFCustomControls_VS2022 x64" has WPF surface design-time support in VS2022 provided by designtools.dll. It installs the library to "Program Files" and makes 64bit registry entries. To create this installer build WPFCustomControls_VS2022.vdproj with TargetPlatform x64. NOTE: This is a FAIL. In testing this installer the 64-bit registry entries do not cause the VS2022 toolbox to initialize with  .NET Framework WPF controls from this library.




