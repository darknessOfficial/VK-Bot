using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class ShowCommand : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            var kb = new KeyboardBuilder(bot);
            kb.AddButton("Услуги ✏", "services", color: KeyboardButtonColor.Primary);
            kb.AddButton("Портфолио 💼", "portfolio", color: KeyboardButtonColor.Primary);
            kb.AddLine();
            kb.AddButton("О нас ℹ", "info", color: KeyboardButtonColor.Primary);
            kb.AddButton("Контакты 📞", "contacts", color: KeyboardButtonColor.Primary);
            sender.Text("Всегда рад вам помочь. Что хотите узнать?", msg.ChatId, kb.Build());
            
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "show";
        public string[] Aliases => new string[0];
    }
}