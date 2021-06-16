﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatwingGame.GameObjects
{
    public struct Position
    {
        public int Left { get; set; }
        public int Top { get; set; }

        public Position(int left, int top) : this()
        {
            Left = left;
            Top = top;
        }
    }
}
