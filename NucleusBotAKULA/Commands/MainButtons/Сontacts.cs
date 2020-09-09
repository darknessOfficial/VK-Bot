using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.Attachments;
using Message = Fooxboy.NucleusBot.Models.Message;

namespace NucleusBotAKULA
{
    public class Сontacts : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Text("Наш офис располагается по адресу - г.Улан-Удэ, ул.Чертенкова 6. " +
                        "\nНаш основной телефон: 8(3012)39-39-39" +
                        "\nE-Mail: uuakula@gmail.com" +
                        "\n \nПредставляю вам контакты наших клиент-менеджеров: " +
                        "\nАнжелика Хомякова - тел. 672222" +
                        "\nВалентина Савельева - тел. 677904" +
                        "\nЕкатерина Румянцева - тел. 572222" , msg.ChatId);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "contacts";
        public string[] Aliases => new string[] { "Контакты 📞", "Контакты", "Позвонить", "Номера телефонов"};
    }
}