/* 
 
  <=[Artic-Bot]=>
  
  [Author] - Ilkay Solotov
  [CreationDate] - 12/12/20
  [LastUpdate] - 12/12/20

    i might have a obsessive-compulsive disorder
    but honestly i like formatting all variables, spaces
    and other stuff too soo... feel free to delete this ton of shit and 
    reformat it but i like it so... ;)

*/

/* ɪ ᴋɴᴏᴡ ᴍᴏꜱᴛ ᴏꜰ ᴛʜᴏꜱᴇ ꜰᴏʀᴍᴀᴛᴛɪɴɢ ᴛʏᴘᴇꜱ ᴀʀᴇ ᴄᴏᴍᴘʟᴇᴛᴇʟʏ
    ᴡʀᴏɴɢ, ʙᴜᴛ ɪᴛꜱ ᴍʏ ᴘᴇʀꜱᴏɴᴀʟ ᴡᴀʏ ᴛᴏ ꜰᴏʀᴍᴀᴛ ᴍʏ ᴄᴏᴅᴇ :+) */

using Artic_Bot.JsSettings;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Artic_Bot.Configurations
{
    class Configure
    {
        #region variables
        Setting setting = new Setting();
        #endregion
        #region reset
        public Task Reset()
        {
            setting.Join = true;
            setting.Leave = true;
            setting.ChangeTitle = true;
            return Reset();
        }
        #endregion
        #region change
        public Task Change(string boolean, string flag)
        {
            var prop = typeof(Setting).GetProperty(boolean, BindingFlags.Public | BindingFlags.IgnoreCase);
            prop.SetValue(setting, bool.Parse(flag));
            return Change(boolean, flag);
        }
        #endregion
    }
}