using Microsoft.VisualStudio.DesignTools.Extensibility.Model;

namespace WpfCustomControlLibrary1.DesignTools
{
    internal class CustomControl1DefaultInitializer : DefaultInitializer
    {
        public CustomControl1DefaultInitializer() 
            : base()
        {
        }

        public override void InitializeDefaults(ModelItem item)
        {
            item.Properties["Height"].SetValue("100");
            item.Properties["Width"].SetValue("250");
            item.Properties["Background"].SetValue("LightGreen");
            base.InitializeDefaults(item);
        }
    }
}
