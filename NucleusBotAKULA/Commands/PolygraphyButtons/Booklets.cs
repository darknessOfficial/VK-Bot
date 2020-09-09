using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;

namespace NucleusBotAKULA
{
    public class Booklets : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image("💥 Рекламный буклет 💥" +
                         "\n — это разновидность полиграфической продукции, которая отпечатывается на листе А3 или А4, с одним и более сгибов (бигов)."+
                         "По форме буклеты можно разделить на следующие виды:"+
                         "\n \n✅ Буклет - листовой рекламный материал с одной линией сгиба (один фальц)."+
                         "\n \n✅ Евробуклет (другое название - лифлет) представляет собой листовой рекламный материал с двумя линиями сгиба (два фальца).,"+
                         "\n \n✅ Многостраничный буклет (брошюра) - рекламный материал состоящий из нескольких листов скрепленных между собой скрепкой, пружиной или термоклеем (стоимость печати брошюр).",
                457239031 , msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "booklets";
        public string[] Aliases => new string[0];
    }
}