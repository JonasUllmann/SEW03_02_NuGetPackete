using System.Diagnostics;
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

namespace SEW03_02_Alphabet_woopec
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
            
            var will = Turtle.Seymour(); //muss nachher mampfi umgenannt werden

            will.Speed = 25;

            will.PenUp();
            will.GoTo((-700, 250));

            a();

            will.PenUp();
            will.GoTo((-555, 250));

            b();

            will.PenUp();
            will.GoTo((-445, 250));

            c();

            will.PenUp();
            will.GoTo((-300, 250));

            d();

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

            void b()
            {
                o();

                will.PenUp();

                will.SetHeading(180);
                will.Forward(35);

                will.Right(90);
                will.Forward(90);

                will.SetHeading(270);
                will.PenDown();
                will.Forward(210);
                

            }

            void c()
            {
                will.SetHeading(0);
                will.Forward(85);
                will.PenDown();

                will.Left(180);
                will.Forward(50);

                for (int i = 0; i < 4; i++)
                {

                    will.Left(45);
                    will.Forward(50);

                }

            }

            void d()
            {

                o();

                will.PenUp();
                will.SetHeading(0);
                will.Forward(85);

                will.Left(90);
                will.Forward(90);

                will.SetHeading(270);
                will.PenDown();
                will.Forward(210);

            }

            void o()
            {

                will.PenDown();
                will.SetHeading(0);

                will.Forward(50);

                will.Right(45);
                will.Forward(50);

                will.Right(45);
                will.Forward(50);

                will.Right(45);
                will.Forward(50);

                will.Right(45);
                will.Forward(50);

                will.Right(45);
                will.Forward(50);

                will.Right(45);
                will.Forward(50);

                will.Right(45);
                will.Forward(50);
            }

        }
    }
}