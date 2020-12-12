/* 
 
  <=[Artic-Bot]=>
  
  [Author] - Ilkay Solotov
  [CreationDate] - 12/12/20
  [LastUpdate] - 12/12/20

    i might have a obsessive-compulsive disorder
    but honestly i like formatting all variables, spaces
    and shit soo... feel free to delete this ton of shit and 
    reformat it but i like it so... ;)

*/

/* ɪ ᴋɴᴏᴡ ᴍᴏꜱᴛ ᴏꜰ ᴛʜᴏꜱᴇ ꜰᴏʀᴍᴀᴛᴛɪɴɢ ᴛʏᴘᴇꜱ ᴀʀᴇ ᴄᴏᴍᴘʟᴇᴛᴇʟʏ
    ᴡʀᴏɴɢ, ʙᴜᴛ ɪᴛꜱ ᴍʏ ᴘᴇʀꜱᴏɴᴀʟ ᴡᴀʏ ᴛᴏ ꜰᴏʀᴍᴀᴛ ᴍʏ ᴄᴏᴅᴇ :+) */

using Telegram.Bot.Types;

namespace  Artic_Bot.Global {
public class Variable              {

        public string token 
        { 
           get { return token; } 
           set { token = "token"; }
        }
 
        public long     chatId         { get; set; }
        public string  chatDescription { get; set; }
        public string  chatFirstName   { get; set; }
        public string  chatLastName    { get; set; }
        public string  chatUserName    { get; set; }
        public string  chatTitle       { get; set; }
        public string  chatInviteLink  { get; set; }

        public ChatPhoto chatPhoto = new ChatPhoto();

    }
}
