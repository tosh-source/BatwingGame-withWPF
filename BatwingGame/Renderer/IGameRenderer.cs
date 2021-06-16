using BatwingGame.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BatwingGame.Renderer
{
    public interface IGameRenderer
    {
        void Clear();

        void Draw(params GameObject[] gameObject);

    }
}