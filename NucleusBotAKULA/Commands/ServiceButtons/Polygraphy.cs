using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class Polygraphy : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            var kb = new KeyboardBuilder(bot);
            kb.AddButton("Визитки", "businessCards", color: KeyboardButtonColor.Primary);
            kb.AddButton("Листовки", "leaflets", color: KeyboardButtonColor.Primary);
            kb.AddLine();
            kb.AddButton("Буклеты", "booklets", color: KeyboardButtonColor.Primary);
            kb.AddButton("Календари", "calendars", color: KeyboardButtonColor.Primary);
            kb.AddLine();
            kb.AddButton("Открытки", "postcards", color: KeyboardButtonColor.Primary);
            kb.AddLine();
            kb.AddButton("Вернуться к списку услуг", "services", color: KeyboardButtonColor.Positive);
            kb.AddButton("В главное меню", "show", color: KeyboardButtonColor.Negative);
            sender.Text("Выберите интересующий вас вариант", msg.ChatId, kb.Build());
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "polygraphy";
        public string[] Aliases => new string[] {"Полиграфия", "полиграфия"};
    }
}