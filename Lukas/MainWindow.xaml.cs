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

namespace Lukas
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

            var mampfi = Turtle.Seymour();

            mampfi.Speed = 30;

            //L
            mampfi.PenUp();
            mampfi.GoTo((-350, 150));

            
            mampfi.PenDown();

            mampfi.SetHeading(270);
            mampfi.Forward(210);

            mampfi.SetHeading(0);
            mampfi.Forward(105);


            //u
            mampfi.PenUp();
            mampfi.GoTo((-225, 60));

            mampfi.PenDown();
            mampfi.SetHeading(270);
            mampfi.Forward(85);

            for (int i = 0; i < 3; i++)
            {
                mampfi.Left(45);
                mampfi.Forward(50);
            }

            mampfi.SetHeading(90);
            mampfi.Forward(85);


            //k

            mampfi.PenUp();
            mampfi.GoTo((-75, 150));

            mampfi.PenDown();

            mampfi.SetHeading(270);
            mampfi.Forward(210);

            mampfi.PenUp();
            mampfi.SetHeading(90);
            mampfi.Forward(50);

            mampfi.SetHeading(45);
            mampfi.PenDown();
            mampfi.Forward(85);

            mampfi.PenUp();
            mampfi.SetHeading(225);
            mampfi.Forward(42.5);
            mampfi.SetHeading(290);
            mampfi.PenDown();
            mampfi.Forward(85);

            //a
            mampfi.PenUp();
            mampfi.GoTo((55, 60));

            mampfi.PenDown();
            mampfi.SetHeading(0);

            mampfi.Forward(50);

            for (int i = 0; i < 7; i++)
            {
                mampfi.Right(45);
                mampfi.Forward(50);
            }
            mampfi.PenUp();

            mampfi.SetHeading(0);

            mampfi.Forward(85);
            mampfi.PenDown();

            mampfi.Right(90);
            mampfi.Forward(125);


            //s
            mampfi.PenUp();
            mampfi.GoTo((260, 35));

            mampfi.SetHeading(135);
            mampfi.PenDown();

            mampfi.Forward(22);

            mampfi.Left(45);
            mampfi.Forward(50);

            for (int i = 0; i < 3; i++)
            {
                mampfi.Left(45);
                mampfi.Forward(22);
            }

            mampfi.Left(45);
            mampfi.Forward(50);

            for (int i = 0; i < 3; i++)
            {
                mampfi.Right(45);
                mampfi.Forward(22);
            }

            mampfi.Right(45);
            mampfi.Forward(50);

        }

    }
}