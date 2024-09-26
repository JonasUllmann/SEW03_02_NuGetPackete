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

            /*
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
            */

            will.PenUp();
            will.GoTo((-700, 340));

            L();

            will.PenUp();
            will.GoTo((-555, 250));

            u();

            will.PenUp();
            will.GoTo((-400, 340));

            k();



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

            void B()
            {

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

                for (int i = 0; i < 7; i++)
                {
                    will.Right(45);
                    will.Forward(50);
                }


            }

            void L()
            {
                will.PenDown();

                will.SetHeading(270);
                will.Forward(210);

                will.SetHeading(0);
                will.Forward(120);


            }

            void u()
            {
                will.PenDown();
                will.SetHeading(270);
                will.Forward(85);

                for (int i = 0;i < 3; i++)
                {
                    will.Left(45);
                    will.Forward(50);
                }

                will.SetHeading(90);
                will.Forward(85);





            }

            void k()
            {
                will.PenDown();

                will.SetHeading(270);
                will.Forward(210);

                will.PenUp();
                will.SetHeading(90);
                will.Forward(50);

                will.SetHeading(45);
                will.PenDown();
                will.Forward(85);

                will.PenUp();
                will.SetHeading(225);
                will.Forward(42.5);
                will.SetHeading(290);
                will.PenDown();
                will.Forward(85);





            }

        }
    }
}