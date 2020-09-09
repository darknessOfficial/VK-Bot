﻿﻿using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class Promotion : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            var kb = new KeyboardBuilder(bot);
            kb.AddButton("Вывески", "signboards", color: KeyboardButtonColor.Primary);
            kb.AddButton("Объёмные буквы", "volumetricLetters", color: KeyboardButtonColor.Primary);
            kb.AddLine();
            kb.AddButton("Световые короба", "lightBoxes", color: KeyboardButtonColor.Primary);
            kb.AddButton("Стенды и указатели", "standsAndSigns", color: KeyboardButtonColor.Primary);
            kb.AddLine();
            kb.AddButton("Брендирование авто", "autoBranding", color: KeyboardButtonColor.Primary);
            kb.AddButton("Переносные конструкции", "portableStructures", color: KeyboardButtonColor.Primary);
            kb.AddLine();
            kb.AddButton("Вернуться к списку услуг", "services", color: KeyboardButtonColor.Positive);
            kb.AddButton("В главное меню", "show", color: KeyboardButtonColor.Negative);
            sender.Text("Выберите интересующий вас вариант", msg.ChatId, kb.Build());
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "promotion";
        public string[] Aliases => new string[] {"Наружная реклама", "наружная реклама"};
    }
}