using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatwingGame.Renderer;
using BatwingGame.GameObjects;

namespace BatwingGame.Engine
{
    class GameEngine  //Game logic is placed here.
    {
        public IGameRenderer GameRenderer { get; private set; }

        public GameEngine(IGameRenderer gameRenderer)
        {
            this.GameRenderer = gameRenderer;
        }

        internal void InitializeGame()
        {
            throw new NotImplementedException();
        }

        internal void StartGame()
        {

        }
    }
}
