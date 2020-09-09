using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class Signboards : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image(" Наша компания занимается изготовлением вывесок следующих видов:" +

                         "\n \n✅ Простые вывески. Деревянная или металлическая конструкция, обтянутая баннерной тканью или оклеенная пленкой. Такой тип вывесок используется как бюджетный вариант оформления торговой точки." +

                         "\n \n✅ Вывеска из ПВХ. Пластиковая основая любой формы, оклееная нарезкой из пленки или пленкой, с нанесением изображения." +

                         "\n \n✅ Вывеска из композита. Такая вывеска может быть любых форм и размеров, как и из ПВХ, но надежнее и долговечнее благодаря использованию в основе композита, представляющего из себя сэндвич из металла и пластика",
                457239027, msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "signboards";
        public string[] Aliases => new string[0];
    }
}