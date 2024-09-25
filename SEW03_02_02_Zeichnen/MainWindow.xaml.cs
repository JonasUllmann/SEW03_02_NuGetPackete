using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Woopec.Core;

namespace SEW03_02_02_Zeichnen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static void TurtleMain()
        {

            var will = Turtle.Seymour();

            will.Speed = 25;

            will.PenUp();
            will.GoTo((-225, 150));

            j();

            will.PenUp();
            will.GoTo((-150, 35));
            will.PenColor = new Woopec.Core.Color(255, 0, 0);

            o();

            will.PenUp();
            will.GoTo((-25, 35));
            will.PenColor = new Woopec.Core.Color(0, 0, 255);

            n();

            will.PenUp();
            will.GoTo((125, 35));
            will.PenColor = new Woopec.Core.Color(255, 0, 255);

            a();

            will.PenUp();
            will.GoTo((325, 5));
            will.PenColor = new Woopec.Core.Color(150, 53, 75);

            s();
            will.PenColor = new Woopec.Core.Color(12, 200, 100);

            void j()
            {
                will.PenDown();
                will.SetHeading(270);

                will.Forward(200);
                
                

                for (int i = 0; i < 3; i++)
                {
                    will.Right(45);
                    will.Forward(50);
                }

            }

            void o()
            {

                will.PenDown();
                will.SetHeading(0);

                will.Forward(50);

                for (int i = 0; i < 7; i++)
                {
                    will.Right(45);
                    will.Forward(50);
                }


            }
        

            void n()
            {

                will.PenDown();
                will.SetHeading(270);

                will.Forward(115);

                will.Right(180);
                will.Forward(90);

                will.Right(45);
                will.Forward(20);

                will.Right(45);
                will.Forward(50);

                will.Right(45);
                will.Forward(20);

                will.Right(45);
                will.Forward(94);

            }

            void a()
            {

                o();
                will.PenUp();
                will.SetHeading(0);
                
                will.Forward(85);
                will.PenDown();

                will.Right(90);
                will.Forward(125);
                

            }

            void s()
            {

                will.SetHeading(135);
                will.PenDown();

                will.Forward(22);



                will.Left(45);
                will.Forward(50);

                for (int i = 0; i < 3; i++)
                {
                    will.Left(45);
                    will.Forward(22);
                }

                will.Left(45);
                will.Forward(50);                

                for (int i = 0; i < 3; i++)
                {
                    will.Right(45);
                    will.Forward(22);
                }

                will.Right(45);
                will.Forward(50);


            }
        }
    }
}