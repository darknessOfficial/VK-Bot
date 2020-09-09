using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class LightBoxes : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image( "💥 Световые короба (LIGHT-BOX) 💥" +
                          "Вид рекламы, выполненый в виде объёмной конструкции закрытого типа, передняя (лицевая) панель которой сделан" +
                          " из акрилового стекла (прозрачной и прочной поверхности, обеспечивающей пропускание светового потока изнутри). " +
                          "\n На задней части короба устанавливаются крепления для монтажа к зданию, а также – уже на внутренней стороне – светодиоды различных цветов," +
                          " обеспечивающие мягкий свет при работе. Стороны светового короба могут быть окрашены красителем или заламинированы плёнкой." +
                          " Такой вид вывесок широко используется для оформление фасада магазинов, кафе и любых торговых точек." ,
                        457239025, msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "lightBoxes";
        public string[] Aliases => new string[0];
    }
}
