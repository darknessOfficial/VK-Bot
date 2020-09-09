using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using Fooxboy.NucleusBot;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class Information : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image("Рекламное агентство «Акула» создано топ-менеджерами в области маркетинга, дизайна и рекламы." +
                         "Основным критерием работы является высокий профессионализм и качество выполняемых работ," +
                         " креативный и комплексный подход в решении поставленных задач.\nЗа долгие годы работы наше агентство приобрело постоянных клиентов в разных сверах бизнеса." +
                         " Это позволило нам еще лучше разбиратсья в рекламе  и находить для каждого клиента свои пути развития и процветания компании." +
                         "\nТак же у нас есть свой сайт, там вы сможете ознакомится со всей информацией о нас: http://akula03.ru/",
                        457239021, msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "info";
        public string[] Aliases => new string[] {"О нас ℹ", "Расскажите о себе", "Информация", "О вас", "О нас"};
    }
}