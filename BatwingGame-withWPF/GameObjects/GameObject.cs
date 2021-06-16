using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatwingGame.GameObjects
{
    public abstract class GameObject
    {
        public Position Position { get; set; }
        public Size Bounds { get; set; }
    }
}
