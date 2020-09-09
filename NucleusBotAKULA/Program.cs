using System;
using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Enums;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;

namespace NucleusBotAKULA
{
    class Program
    {
        const string vkTokenGroup = "bdf4d3cf1958add7505293c706c1fe8079126a0e0e9d2a9889b6f53ff8be8c85f8fc221d5178a3c57bd17";
        const long groupVkId = 198106962;

        static void Main(string[] args)
        {
            //Создание параметров для бота.
            var settings = new BotSettings()
            {
                GroupId = groupVkId,
                Messenger = MessengerPlatform.Vkontakte,
                VKToken = vkTokenGroup
            };
            //Создание экзмпляра класса бота.
            IBot bot = new Bot(settings, new NoCommand());

            //Установка команд.
            bot.SetCommands(new StartCommand(),
                new ShowCommand(),
                new Services(),
                new Portfolio(),
                new Information(),
                new Сontacts(),
                new Printing(),
                new Promotion(),
                new Polygraphy(),
                new SpecialServices(),
                new BannerPrinting(),
                new FilmPrinting(),
                new Signboards(),
                new LightBoxes(),
                new AutoBranding(),
                new PortableStructures(),
                new StandsAndSigns(),
                new VolumetricLetters(),
                new Booklets(),
                new Calendars(),
                new Leaflets(),
                new Postcards(),
                new BusinessCards(),
                new Design(), 
                new MillingWork(),
                new PlatformRental());

            //Установка сервисов.
            //bot.SetServices(new CounterService());
            
            //Запуск бота
            bot.Start();

            //Чтобы консоль тупо не закрылась))
            Console.ReadLine();
        }
    }
}
