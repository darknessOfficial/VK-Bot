using System;
using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class StartCommand : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            var kb = new KeyboardBuilder(bot);
            kb.AddButton("Показать все кнопки", "show", color: KeyboardButtonColor.Positive);
            sender.Text("Здравствуйте. Я чат-бот рекламного агенста 'Акула'." +
                        "\nУ меня вы можете узнать основную информацию о нашей компании, чем мы занимаемся и сколько это будет стоить.", msg.ChatId, kb.Build());
        }

        public void Init(IBot bot, ILoggerService logger)
        {
            Console.WriteLine("ИНИЦИАЛИЗАЦИЯ КОМАНДЫ START...");
            //todo:code...
        }

        public string Command => "start";
        public string[] Aliases => new string[] {"Привет", "привет", "хай", "Здравствуйте", "здравствуйте",
            "Приветствую", "приветствую", "Дарова", "ку", "Начать", "Что ты умеешь?", "что ты умеешь?",
            "ghbdtn", "Plhfdcndeqnt", "Ghbdtn", "plhfdcndeqnt", "Что ты делаешь?", "что ты делаешь?"};
    }
}