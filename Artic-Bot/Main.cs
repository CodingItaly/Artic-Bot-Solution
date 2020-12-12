using System;
using Telegram.Bot;
using Artic_Bot.Global;
using Artic_Bot.Bot;
namespace Artic_Bot
{
    class MainClass
    {
        static Variable var = new Variable();
        static void Main(string[] args)
        {

            var botClient = new TelegramBotClient(var.token);
            var start = new Start(botClient);
            start.listen(true);
        }
    }
}
