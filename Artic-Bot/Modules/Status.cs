using Artic_Bot.JsSettings;
using System.Reflection;
using System.Threading.Tasks;

namespace Artic_Bot.Status
{
    class Check
    {
        #region Variables
        Setting setting = new Setting();
        #endregion
        #region Methods
        public Task CheckStatus(string boolean)
        {
            var prop = typeof(Setting).GetProperty(boolean, BindingFlags.Public | BindingFlags.IgnoreCase);
            prop.GetValue(setting);
            return CheckStatus(boolean);
        }
        #endregion
    }
}
