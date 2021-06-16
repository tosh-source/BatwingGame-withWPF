using BatwingGame.Engine;
using BatwingGame.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BatwingGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal GameEngine Engine { get; private set; }

        public MainWindow()
        {
            this.InitializeComponent();
            var gameRenderer = new WPFGameRenderer(this.GameCanvas);
            this.Engine = new GameEngine(gameRenderer);
            this.Engine.InitializeGame();
            this.Engine.StartGame();

            #region UITests
            //var rectangle = new Rectangle
            //{
            //    Width = 100,
            //    Height = 200,
            //    Fill = Brushes.Brown
            //};
            //this.GameCanvas.Children.Add(rectangle);

            //Canvas.SetLeft(rectangle, 200);
            //Canvas.SetTop(rectangle, 100);

            //this.Content = new StackPanel
            //{
            //    Background = Brushes.Purple
            //};
            #endregion
        }
    }
}
