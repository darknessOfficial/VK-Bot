using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class AutoBranding : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image(" 💥 Реклама на транспорте – идеальный способ ознакомить потребителей с новыми торговыми марками и укрепить имидж уже существующих. " +
                         "По сути, реклама на авто – это рекламный щит, который передвигается по всему городу. Однако стоимость такой рекламы значительно ниже. " +
                         "\n Рекламные изображения печатают на самоклеющейся виниловой пленке. Красители устойчивы к выцветанию и обычно держатся до 5 лет. " +
                         "Для того чтобы дополнительно защитить красители от воздействия внешней среды, изображение ламинируют. " +
                         "При нанесении отдельных фрагментов рекламного изображения и аппликаций применяют плоттерную резку.",
                        457239024 , msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "autoBranding";
        public string[] Aliases => new string[0];
    }
}