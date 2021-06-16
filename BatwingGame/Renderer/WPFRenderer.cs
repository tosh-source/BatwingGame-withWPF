using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using BatwingGame.GameObjects;

namespace BatwingGame.Renderer
{
    class WPFGameRenderer : IGameRenderer
    {
        public Canvas GameCanvas { get; private set; }

        public WPFGameRenderer(Canvas gameCanvas)
        {
            this.GameCanvas = gameCanvas;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Draw(params GameObject[] gameObject)
        {
            throw new NotImplementedException();
        }
    }
}
