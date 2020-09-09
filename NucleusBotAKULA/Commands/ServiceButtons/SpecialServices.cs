using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class SpecialServices : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            var kb = new KeyboardBuilder(bot);
            kb.AddButton("Дизайн", "design", color: KeyboardButtonColor.Primary);
            kb.AddButton("Аренда автовышки", "platformRental", color: KeyboardButtonColor.Primary);
            kb.AddLine();
            kb.AddButton("Фрезерные работы", "millingWork", color: KeyboardButtonColor.Primary);
            kb.AddLine();
            kb.AddButton("Вернуться к списку услуг", "services", color: KeyboardButtonColor.Positive);
            kb.AddButton("В главное меню", "show", color: KeyboardButtonColor.Negative);
            sender.Text("Выберите интересующий вас вариант", msg.ChatId, kb.Build());
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "specialServices";
        public string[] Aliases => new string[] {"Специальные услуги", "специальные услуги", "другие услуги", "Другие услуги", "Дизайн", "дизайн"};
    }
}