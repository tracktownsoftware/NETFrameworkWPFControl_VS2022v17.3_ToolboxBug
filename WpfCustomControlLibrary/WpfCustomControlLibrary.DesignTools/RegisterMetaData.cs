using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DesignTools.Extensibility;
using Microsoft.VisualStudio.DesignTools.Extensibility.Features;
using Microsoft.VisualStudio.DesignTools.Extensibility.Metadata;

// The ProvideMetadata assembly-level attribute indicates to designers
// that this assembly contains a class that provides an attribute table. 
[assembly: ProvideMetadata(typeof(WpfCustomControlLibrary.DesignTools.RegisterMetaData))]

namespace WpfCustomControlLibrary.DesignTools
{
    public class RegisterMetaData : IProvideAttributeTable
    {

        public AttributeTable AttributeTable
        {
            get 
            {
                AttributeTableBuilder builder = new AttributeTableBuilder();

                // Specify which controls initialize into the VS2022 toolbox
                builder.AddCustomAttributes("WpfCustomControlLibrary.CustomControl1", new ToolboxBrowsableAttribute(true));
                builder.AddCustomAttributes("WpfCustomControlLibrary.CustomControl2", new ToolboxBrowsableAttribute(false));

                builder.AddCustomAttributes(
                    "WpfCustomControlLibrary.CustomControl1",
                    new FeatureAttribute(typeof(CustomControl1DefaultInitializer)));

                // Add the FormulaBar default initializer to the design-time metadata.
                builder.AddCustomAttributes(
                    "WpfCustomControlLibrary.CustomControl2",
                    new FeatureAttribute(typeof(CustomControl2DefaultInitializer)));

                return builder.CreateTable();
            }
        }
    }
}
