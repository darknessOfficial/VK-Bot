﻿using Fooxboy.NucleusBot;
using Fooxboy.NucleusBot.Interfaces;
using Fooxboy.NucleusBot.Models;
using VkNet.Enums.SafetyEnums;

namespace NucleusBotAKULA
{
    public class BannerPrinting : INucleusCommand
    {
        public void Execute(Message msg, IMessageSenderService sender, IBot bot)
        {
            sender.Image("💥 Печать баннеров 💥" +
                         "\n \nРАЗНОВИДНОСТЬ БАННЕРНОЙ ТКАНИ И ПРИМЕНЕНИЯ:" +
                         "\n \n✅ Рекламный баннер \nБаннерная ткань (Фронтлит) - обычный баннер который вы привыкли видеть, на улицах и заборах в Улан-Удэ, и респ. Бурятия, это самый распространенный и дешевый вид печать для наружной рекламы в Улан-Удэ." +
                         " Цена печати баннера зависит от толщины баннер. \n \n✅ Баннер сетка (перфо баннер) \nБлагодаря ячеистой структуре баннерной сетки воздух способен свободно проникать сквозь материал, тем самым, предотвращает разрыв баннера из-за ветров." +
                         " Баннерная сетка применяется в изделиях особо крупного формата, например, при размещении рекламы на фасадах зданий. " +
                         "\n \n✅ Баннер бэклит транслюцентный \nБэклиты или, как ещё их называют, транслюцентные баннеры предназначены для производства световой рекламы," +
                         " в которой используется внутренняя подсветка. Рекламные баннера один из самых популярных и дешевых видов наружной рекламы.",
                            457239022, msg.ChatId, -198106962);
        }

        public void Init(IBot bot, ILoggerService logger)
        {
        }

        public string Command => "BannerPrinting";
        public string[] Aliases => new string[] {"Печать на баннере", "пеачть на баннере"};
    }
}