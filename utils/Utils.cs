﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList.utils
{
    class Utils
    {
        public static string initUserName = "123";
        public static string initPwd = "123";

        public static Color getColorFromRGB(int r, int g, int b)
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(r)))), ((int)(((byte)(g)))), ((int)(((byte)(b)))));
        }
    }
}
