using Fooxboy.NucleusBot.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.NucleusBot.Interfaces
{
    public interface IMessageSenderService
    {
        /// <summary>
        /// Месседжер, с которого будет отправлено сообщение
        /// </summary>
        MessengerPlatform Platform { get; }
        /// <summary>
        /// Отправить текст 
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="to">Кому отправить</param>
        /// <param name="keyboard">Клавиатура</param>
        /// <param name="from">От кого</param>
        void Text(string text, long to, INucleusKeyboard keyboard = null, long from = 0);
        /// <summary>
        /// Отправить изображение
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="photoId">ID Изображения</param>
        /// <param name="to">Кому отправить</param>
        /// <param name="from">От кого</param>
        /// <param name="keyboard">Клавиатура</param>
        void Image(string text, long photoId, long to, long from, INucleusKeyboard keyboard = null);
    }
}
