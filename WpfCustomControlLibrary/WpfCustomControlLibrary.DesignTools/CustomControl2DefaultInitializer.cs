using Microsoft.VisualStudio.DesignTools.Extensibility.Model;

namespace WpfCustomControlLibrary.DesignTools
{
    internal class CustomControl2DefaultInitializer : DefaultInitializer
    {
        public CustomControl2DefaultInitializer()
            : base()
        {
        }

        public override void InitializeDefaults(ModelItem item)
        {
            item.Properties["Height"].SetValue("100");
            item.Properties["Width"].SetValue("250");
            item.Properties["Background"].SetValue("LightPink");
            base.InitializeDefaults(item);
        }
    }
}