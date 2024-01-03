﻿/********************************************************************
 * Copyright (C) 2015-2017 Antoine Aflalo
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 ********************************************************************/

using System.Drawing;
using System.Windows.Forms;
using SoundSwitch.Localization;

namespace SoundSwitch.Framework.Banner.Position
{
    internal class PositionTopRight : IPosition
    {
        public BannerPositionEnum TypeEnum => BannerPositionEnum.TopRight;
        public string Label => SettingsStrings.positionOptionTopRight;

        public Point GetScreenPosition(Screen screen, int height, int width)
        {
            var positionLeft = screen.Bounds.X + 50;
            var positionRight = screen.Bounds.Width - width - positionLeft;
            var positionTop = screen.Bounds.Y + 60;

            return new Point(positionRight, positionTop);
        }
    }
}