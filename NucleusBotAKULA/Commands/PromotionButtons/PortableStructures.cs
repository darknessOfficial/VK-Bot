using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class PortableStructures : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image( "💥 Предоставляем услуги по продаже и изготовлению переносных (мобильных) конструкций:" + 
                          "\n \n✅ Roll-up (Ролл-ап) - раздвижной мобильный стенд с механизмом автоматического сматывания в рулон информационного полотна. " +
                          "\n \n✅ Х-банер 'Паук' - простейший мобильный баннерный стенд. В основе стенда находится рекламное полотно из баннерной ткани, закрепленное на 4-х стержнях."+
                          "\n \n✅ Press Wall (Пресс Волл) - зарекомендовал себя, как отличное дополнение к любому мероприятию, будь то свадьба, день рождение, презентация." +
                          "\n \n✅ Штендер - выносная мобильная конструкция наружной рекламы, имеющие одну или две рекламные поверхности.",
                          457239026, msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "portableStructures";
        public string[] Aliases => new string[0];
    }
}