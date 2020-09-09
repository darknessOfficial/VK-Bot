using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;

namespace NucleusBotAKULA
{
    public class Postcards : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image("💥 Открытки 💥" +
                         "\n \nВид открыток с годами не меняется. Напечатаны они на бумаге А3, А4, А5, с односторонней и двусторонней печатью от 130 до 300 граммовой бумаге." +
                         " , обычно сложены вдвое или в виде карточки. Ассортимент их всегда был широк, поэтому они отлично подходят для поздравлений с любыми праздниками. " +
                         "\n Открытки бывают : " +
                         "\n \n✅ художественные - в качестве изображения на лицевой стороне используют репродукции картин или авторские рисунки;" +
                         "\n \n✅ документальные - на лицевой стороне помещают пейзажные или репортажные фотографии, иллюстрирующие исторические события,виды," +
                         " изображения исторических личностей, моментов, характерных для того или иного отрезка истории.",
                457239034 , msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "postcards";
        public string[] Aliases => new string[0];
    }
}