using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Services;
using VkNet.Enums.SafetyEnums;
using VkNet.Model.Attachments;
using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;
using Message = Fooxboy.NucleusBot.Models.Message;

namespace NucleusBotAKULA
{
    public class Portfolio : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image("Итак, представляю вам наше портфолио. В нём собрано множество фотографий наших работ." +
                         "\n Перейти на сайт: http://akula03.ru/portfolio/", 457239020, msg.ChatId, -198106962); 
        }
        public void Init(IBot bot, ILoggerService logger)
        {
        }
        public string Command => "portfolio";
        public string[] Aliases => new string[] {"Портфолио 💼", "Портфолио", "Фотографии"};
    }
}