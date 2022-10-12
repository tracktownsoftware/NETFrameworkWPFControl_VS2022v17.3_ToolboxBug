# NETFrameworkWPFControl_VS2022v17.3_ToolboxBug
The BUG: VS2022 v17.3.x includes ALL controls for a custom .NET Framework WPF library in the VS toolbox rather than controls filtered by the DesignTools assembly using ToolboxBrowsableAttribute(true). This appeared to work correctly in VS2022 v17.2.7 and earlier.

**The VS 2022 17.3.x toolbox bug is reproduced by a simple WpfCustomControlLibrary in this repo. The WPFCustomLibrary.sln contains:**
- WpfCustomControlLibrary - A .NET Framework 4.6.2 project with two custom controls: CustomControl1 (which we want in the VS toolbox) and CustomControl2 (we do not want in the VS toolbox)
- WpfCustomControlLibrary.DesignTools for VS2022 - A .NET Framework 4.7.2. project that specifies which controls initialize into the VS2022 toolbox (*this part is not working*), and contains a DefaultInitializer for each control that sets Background color and size (*this part is working in VS2022 on the WPF design surface*).
- WpfCustomControlLibrary.Design for VS2019 - A .NET Framework 4.6.2. project that specifies which controls initialize into the VS2019 toolbox. Our product supoprts both VS2019 and VS2022, so I'm including this Design assembly.
- WPFCustomControls_VS2019VS2022 - Builds an msi installer that includes WpfCustomControlLibrary, WpfCustomControlLibrary.DesignTools for VS2022, and WpfCustomControlLibrary.Design for VS2019.
- WPFCustomControls_VS2022 - Builds an msi installer that includes  WpfCustomControlLibrary and only WpfCustomControlLibrary.DesignTools for VS2022. *This is only for targeted testing of VS2022 and DesignTools*

**Note: The above installer projects use the Microsoft Visual Studio Installer Projects 2022 extension**

The RegisterMetaData class implements Microsoft.VisualStudio.DesignTools.Extensibility.Metadata.IProvideAttributeTable. The bug is VS2022 v17.3.x does not use this code to filter which .NET Framework WPF controls initialize into the VS toolbox."
```
// Specify which controls initialize into the VS2022 toolbox
builder.AddCustomAttributes("WpfCustomControlLibrary.CustomControl1", new ToolboxBrowsableAttribute(true));
builder.AddCustomAttributes("WpfCustomControlLibrary.CustomControl2", new ToolboxBrowsableAttribute(false));
```
_Update: VS2022 v17.2.7 was pulling this ToolboxBrowsableAttribute information from a Design.dll assembly in our control library intended for VS2019; Microsoft corrected this but still has not added ToolboxBrowsableAttribute support in the DesignTools.dll assembly for VS2022._

This GitHub repo is a work-in-progress. Check back later for improved description and VS2022 toolbox image examples.

In the "Installers" folder I uploaded installers made from installer projects in WpfCustomControlLibrary.sln. Copy the setup.exe and WpfCustomControlLibrary.msi to a test machine from one of the subfolders below:
1. "WPFCustomControls_VS2019VS2022 x86" has design-time support in VS2019 and VS2022. The old WPF surface in VS2019 uses design.dll and the new WPF surface in VS2022 uses designtools.dll. The library is installed to "Program Files (x86)" and makes WOW6432Node registry entries. To create this installer build WPFCustomControls_VS2019VS2022.vdproj.



2. "WPFCustomControls_VS2022 x86" has WPF surface design-time support in VS2022 provided by the designtools.dll. The library is installed to "Program Files (x86)" and makes WOW6432Node registry entries. To create this installer build WPFCustomControls_VS2022.vdproj with TargetPlatorm x86.





