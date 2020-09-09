using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;

namespace NucleusBotAKULA
{
    public class Calendars : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image("💥 КАЛЕНДАРЬ 💥" +
                         "\n - один из самых популярных видов рекламной полиграфии." +
                         "\n Виды календарей:" +
                         "\n \n✅ Карманный, настольный (домик перекидной, домик обычный, пирамидка, кубик, кубарик, отрывной и прочие варианты)," +
                         "\n \n✅ Настенный календарь (перекидной, отрывной, листовой):" +
                         "\n одноблочные — показывают текущий месяц" +
                         "\n двухблочные — отображают текущий и будущий месяц" +
                         "\n трехблочные (квартальные) – дают возможность видеть текущий, прошедший и будущий месяц одновременно" +
                         "\n \n Самые распространенными фирменными календарями являются карманные, квартальные, настенные и настольные перекидные календари.",
                457239035 , msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "calendars";
        public string[] Aliases => new string[0];
    }
}