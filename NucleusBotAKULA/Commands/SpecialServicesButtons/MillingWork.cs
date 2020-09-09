using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;

namespace NucleusBotAKULA
{
    public class MillingWork : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image(" 💥 По услугам фрезерной резки мы предлагаем:" +
            "\n \n✅ Фрезеровка дерева" +
            "\n✅ Фрезеровка фанеры" +
            "\n✅ Фрезеровка МДФ" +
            "\n✅ Фрезеровка композитных материалов" +
            "\n✅ Фрезеровка пвх" +
            "\n✅ Фрезеровка сотового поликарбоната" +
            "\n✅ Фрезеровка оргстекла" +
            "\n✅ Фрезеровка пластика" + 
            "\n✅ Резка материалов (резка пвх, резка дибонда, резка оргстекла)" +
            "\n✅ Резка и раскрой листа (раскрой пвх, раскрой дибонда, раскрой оргстекла)" +
            "\n✅ Объемная 3D фрезеровка", 457239020, msg.ChatId, -198106962); 
        }
        public void Init(IBot bot, ILoggerService logger)
        {
        }
        public string Command => "millingWork";
        public string[] Aliases => new string[0];
    }
}