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
    public class Station : GameEntity
    {
        public string name { get; set; }

        public override void GameTick(double millisecondsElapsed)
        {

        }

        public override void Draw(Canvas surface)
        {
            Ellipse station = new Ellipse{ Width=10, Height=10, Stroke=Brushes.Blue, StrokeThickness=1 };

            surface.Children.Add(station);
        }
    }
}
