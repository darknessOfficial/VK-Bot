using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class Printing : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            var kb = new KeyboardBuilder(bot);
            kb.AddButton("✅ Печать на баннере", "BannerPrinting", color: KeyboardButtonColor.Default);
            kb.AddButton("✅ Печать на плёнке", "FilmPrinting", color: KeyboardButtonColor.Default);
            kb.AddLine();
            kb.AddButton("Вернуться к списку услуг", "services", color: KeyboardButtonColor.Positive);
            kb.AddButton("В главное меню", "show", color: KeyboardButtonColor.Negative);
            sender.Text("Выберите интересующий вас вариант", msg.ChatId, kb.Build());
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "printing";
        public string[] Aliases => new string[] {"Широкоформатная печать", "широкоформатная печать"};
    }
}