using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using Fooxboy.NucleusBot;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class Services : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            var kb = new KeyboardBuilder(bot);
            kb.AddButton("🖨 Широкоформатная печать", "printing", color: KeyboardButtonColor.Primary);
            kb.AddButton("✍ Наружная реклама", "promotion", color: KeyboardButtonColor.Primary);
            kb.AddLine();
            kb.AddButton("📰 Полиграфия", "polygraphy", color: KeyboardButtonColor.Primary);
            kb.AddButton("📌 Специальные услуги", "specialServices", color: KeyboardButtonColor.Primary);
            kb.AddLine();
            kb.AddButton("Вернуться назад", "show", color: KeyboardButtonColor.Negative);
            sender.Text("Мы предоставляем широкий спектр услуг. А именно:" +
                        "\n➪ Широкоформатная печать" +
                        "\n➪ Наружная реклама" +
                        "\n➪ Полиграфия" +
                        "\nА так же предлагаем вам Специальные услуги(Дизайн и др.)", msg.ChatId, kb.Build());
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "services";
        public string[] Aliases => new string[] {"Услуги ✏", "Услуги", "Что вы умеете?", "Что вы можете сделать?"};
    }
}