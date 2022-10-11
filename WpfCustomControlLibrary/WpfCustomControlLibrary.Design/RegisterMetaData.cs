using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Windows.Design;
using Microsoft.Windows.Design.Features;
using Microsoft.Windows.Design.Metadata;

// The ProvideMetadata assembly-level attribute indicates to designers
// that this assembly contains a class that provides an attribute table. 
[assembly: ProvideMetadata(typeof(WpfCustomControlLibrary.Design.RegisterMetaData))]
namespace WpfCustomControlLibrary.Design
{
    public class RegisterMetaData : IProvideAttributeTable
    {
        // Called by the designer to register any design-time metadata. 
        public AttributeTable AttributeTable
        {
            get
            {
                AttributeTableBuilder builder = new AttributeTableBuilder();

                // Set ToolboxBrowsableAttribute to true to display your custom control 
                // in the Toolbox and in the Choose Items... dialog box. 
                builder.AddCustomAttributes(typeof(CustomControl1), new ToolboxBrowsableAttribute(true));
                builder.AddCustomAttributes(typeof(CustomControl2), new ToolboxBrowsableAttribute(false));

                return builder.CreateTable();
            }
        }
    }
}
