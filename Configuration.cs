﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WinDock
{
    class Configuration
    {
        static Configuration()
        {
            TaskbarPinnedDirectory = "\\Microsoft\\Internet Explorer\\Quick Launch\\User Pinned\\TaskBar";
            CanvasHeight = 200;
            CanvasWidth = 1280;
            DockHeight = 45;
            DockSideSlope = 25;
            DockBackgroundAlpha = 0.9;
            DockBackgroundColor = Color.FromArgb(120, 120, 120);
            IconSize = 50;
            IconMargin = 6;
        }

        // Paths
        public static String TaskbarPinnedDirectory { get; set; }

        // Canvas
        public static int CanvasHeight { get; set; }
        public static int CanvasWidth { get; set; }

        // Dock
        public static int DockHeight { get; set; }
        public static int DockSideSlope { get; set; }
        public static double DockBackgroundAlpha { get; set; }
        public static Color DockBackgroundColor { get; set; }

        // Icons
        public static int IconSize { get; set; }
        public static int IconMargin { get; set; }
        public static double IconMagnificationFactor { get; set; }
    }
}