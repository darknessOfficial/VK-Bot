using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class VolumetricLetters : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image("💥 Световые объёмные буквы 💥" +
                         "\n \nБуквы из пластика могут быть использованы в качестве фасадной вывески или рекламного объявления. " +
                         "Возможность использования с другими рекламными средствами делает данный вид рекламы одним из самых востребованных на современном рынке." +
                         " Наиболее распространенный вариант – объемные буквы с внутренней светодиодной подсветкой. Светодиодные модули используется для подсветки букв." +
                         " Они могут быть выполнены как на стене, так и в виде крышной установки. Такой вид вывесок широко используется для оформление фасада магазина." +
                         " Такой вид вывесок широко используется для оформление фасада магазина.",
                457239030, msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "volumetricLetters";
        public string[] Aliases => new string[0];
    }
}