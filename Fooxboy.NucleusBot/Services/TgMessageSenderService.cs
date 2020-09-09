using Fooxboy.NucleusBot.Enums;
using Fooxboy.NucleusBot.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;
using VkNet;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams;

namespace Fooxboy.NucleusBot.Services
{
    public class TgMessageSenderService : IMessageSenderService
    {
        public static ITelegramBotClient tgbot;
        private IBotSettings _settings;
        private ILoggerService _logger;

        public MessengerPlatform Platform => MessengerPlatform.Telegam;

        public TgMessageSenderService(IBotSettings settings, ILoggerService logger)
        {
            _settings = settings;
            _logger = logger;
        }
        public void Image(string text, long photoId, long to, long from, INucleusKeyboard keyboard = null)
        {
            throw new NotImplementedException();
        }
// photo-198106962_457239020
//new List<MediaAttachment>{ new Photo { Id = 274583795, OwnerId = 198106962}}
        public void Text(string text, long to, INucleusKeyboard keyboard = null, long from = 0)
        {
            tgbot= tgbot?? new TelegramBotClient(_settings.TGToken);
            
            if (keyboard != null)
            {
                var replyKeyboardMarkup = ConvertToTgKeyboard(keyboard);
                Task.Run(() =>
                {
                    tgbot.SendTextMessageAsync(
                        chatId: to,
                        text: text,
                        replyMarkup: replyKeyboardMarkup
                    );
                });
            }
            else
            {
                Task.Run(() =>
                {
                    tgbot.SendTextMessageAsync(
                        chatId: to,
                        text: text
                    );
                });
            }

            
        }

        private ReplyKeyboardMarkup ConvertToTgKeyboard(INucleusKeyboard keyboard)
        {
            var keyboardArray = new List<List<KeyboardButton>>();
            foreach (var buttons in keyboard.Buttons)
            {
                var line = new List<KeyboardButton>();
                foreach (var button in buttons)
                {
                    var tgButton = new KeyboardButton();
                    tgButton.RequestContact = button.RequestContact;
                    tgButton.RequestLocation = button.RequestLocation;
                    tgButton.Text = button.Caption;
                    line.Add(tgButton);
                }
                keyboardArray.Add(line);
            }
            var replyKeyboardMarkup = new ReplyKeyboardMarkup();
            replyKeyboardMarkup.Keyboard = keyboardArray;
            replyKeyboardMarkup.ResizeKeyboard = true;
            replyKeyboardMarkup.OneTimeKeyboard = keyboard.OneTimeKeyboard;
            return replyKeyboardMarkup;
        }
    }
}
