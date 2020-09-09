using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;

namespace NucleusBotAKULA
{
    public class Design : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image("💥 Дизайн 💥" +
                         "\n – это творческая деятельность, целью которой является определение формальных качеств промышленных изделий. " +
                         "Наша компания может изготовить для вас дизайн (иллюстрацию, макет, эскиз): визиток, листовок, буклетов, баннеров, вывесок. " +
                         "Реализуем ваши любые идеи или поможем подобрать нужный дизайн.", 457239036, msg.ChatId, -198106962); 
        }
        public void Init(IBot bot, ILoggerService logger)
        {
        }
        public string Command => "design";
        public string[] Aliases => new string[0];
    }
}