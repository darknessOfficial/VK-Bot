using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;

namespace NucleusBotAKULA
{
    public class BusinessCards : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image("💥 Визитная карточка 💥" +
                         "\n – это небольшой лист тонкого картона (или плотной бумаги ), на котором напечатаны основные сведения о ее владельце. " + 
                         "В современной деловой жизни визитная карточка - обязательный атрибут." +
                        "\nВизитки, бывают следующих видов:" +
                        "\n \n✅ стандартная визитная карточка сотрудника фирмы;" +
                        "\n \n✅ представительская карточка сотрудника фирмы;" +
                        "\n \n✅ семейная визитная карточка;" +
                        "\n \n✅ прочие визитные карточки.",
                457239032 , msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "businessCards";
        public string[] Aliases => new string[0];
    }
}