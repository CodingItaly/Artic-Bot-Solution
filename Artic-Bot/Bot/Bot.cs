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

using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Artic_Bot.Global;

namespace Artic_Bot.Bot
{
    class Start
    {
        #region globals
        Variable var = new Variable();
        readonly ITelegramBotClient _client;
        #endregion
        #region listen
        public void listen(bool status)
        {
            if (status == true) 
                _client.StartReceiving();
            else
                _client.StopReceiving(); 
        }
        #endregion
        #region onEvent
        public Start(ITelegramBotClient client)
        { 
            _client = client; 
            client.OnMessage += OnMessage; 
        }
        #endregion
        #region methods
        private void OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            #region vars
            var.chatId                 = messageEventArgs.Message.Chat.Id;
            var.chatDescription = messageEventArgs.Message.Chat.Description;
            var.chatFirstName   = messageEventArgs.Message.Chat.FirstName;
            var.chatLastName    = messageEventArgs.Message.Chat.LastName;
            var.chatTitle             = messageEventArgs.Message.Chat.Title;
            var.chatInviteLink    = messageEventArgs.Message.Chat.InviteLink;
            var.chatPhoto           = messageEventArgs.Message.Chat.Photo;
            var.chatUserName   = messageEventArgs.Message.Chat.Username;
            var message = messageEventArgs.Message;
            #endregion

            switch (message.Type)  {
                case MessageType.Text             : break;
                case MessageType.ChatMembersAdded : break;
                case MessageType.ChatMemberLeft   : break;
                case MessageType.ChatTitleChanged : break;
                default                           : break;
            }
        }
        #endregion
        #region modules
        private async void Join()
        {

        } 
        #endregion
    }
}
