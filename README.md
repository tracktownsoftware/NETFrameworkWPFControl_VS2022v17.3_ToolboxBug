# NETFrameworkWPFControl_VS2022v17.3_ToolboxBug
The BUG: VS2022 v17.3.x includes ALL controls for a custom .NET Framework WPF library in the VS toolbox rather than just ToolboxBrowsableAttribute(true) controls. This worked correctly in VS2022 v17.2.7 and earlier.

This is a work-in-progress. Check back later for more description and VS2022 toolbox image examples.

In the "Installers" folder I uploaded installers made from installer projects in WpfCustomControlLibrary.sln. Copy the setup.exe and WpfCustomControlLibrary.msi to a test machine from one of the subfolders below:
1. "WPFCustomControls_VS2019VS2022 x86" supports WPF surface design-time support in VS2019 and VS2022. The design.dll provides design-time support for VS2019 and designtools.dll provides design-time support in VS2022.
2. "WPFCustomControls_VS2022 x86" supports WPF surface design-time support in VS2022. The designtools.dll provides design-time support in VS2022. This installs the custom library to "Program Files (x86)" and makes WOW6432Node registry entries.
3. "WPFCustomControls_VS2022 x64" supports WPF surface design-time support in VS2022. The designtools.dll provides design-time support in VS2022. This installs the custom library to "Program Files" and makes 64bit registry entries.




