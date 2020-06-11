using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Qatarlar1.Entities
{
    public class Ball : GameEntity
    {
        public double Diameter { get; set; }

        public override void GameTick(double millisecondsElapsed)
        {
            Position = Position + Velocity * (float)millisecondsElapsed / 1000;
        }

        public override void Draw(Canvas surface)
        {

            Ellipse ball = new Ellipse { Width = 40, Height = 20, Stroke = Brushes.Red, StrokeThickness = 2};
            Canvas.SetLeft(ball, this.Position.X);
            Canvas.SetTop(ball, this.Position.Y);

            surface.Children.Add(ball);
        }
    }
}
