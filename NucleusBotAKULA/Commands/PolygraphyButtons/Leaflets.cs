using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;

namespace NucleusBotAKULA
{
    public class Leaflets : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image("💥 Рекламная листовка 💥" +
             "\n- разновидность печатной рекламы, малоформатное, относительно недорогое печатное рекламное издание без фальцовки (сгибов)," +
             " одностороннее или двухстороннее, с иллюстрациями или без них, в черно-белом или цветном исполнении."+
             " \n \nЛистовки являются широко используемым рекламным материалом. В рекламе различают листовку," +
             " как рекламное средство и методы и способы ее распространения: раздача листовок на улице, рассылка по почте, распространение через специальные раздаточные стойки.",
                457239033 , msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "leaflets";
        public string[] Aliases => new string[0];
    }
}