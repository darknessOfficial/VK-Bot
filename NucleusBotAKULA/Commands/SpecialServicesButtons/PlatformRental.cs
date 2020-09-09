using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;

namespace NucleusBotAKULA
{
    public class PlatformRental : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image(" 💥 В нашей компании вы можете взять в аренду автовышку по выгодной цене. Высота стрелы 14 метров.",
                457239038, msg.ChatId, -198106962); 
        }
        public void Init(IBot bot, ILoggerService logger)
        {
        }
        public string Command => "platformRental";
        public string[] Aliases => new string[0];
    }
}