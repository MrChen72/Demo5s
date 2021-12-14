using Volo.Abp.Settings;

namespace Demo5s.Settings
{
    public class Demo5sSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(Demo5sSettings.MySetting1));
        }
    }
}
