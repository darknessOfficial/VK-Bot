using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class StandsAndSigns : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image("💥 Стенды, указатели, таблички 💥" +
                         "Это изделия из ПВХ (пластика) оклееные пленкой с нанесеным изображением. В оформление стенда можно использовать карманы(плоски и объемные) или зажимы. " +
                         "Например: режим работы, график работы, уголок покупателя, информационный стенд, ростовые фигуры, адресная табличка, уголок детский сад. " +
                         "Также из ПВХ можно делать оформление детских садов, развлекательных зон и др.",
                457239028, msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "standsAndSigns";
        public string[] Aliases => new string[0];
    }
}