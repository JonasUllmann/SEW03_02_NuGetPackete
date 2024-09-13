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

            will.Speed = 5;

            will.PenUp();
            will.GoTo((-225, 150));

            j();

            will.PenUp();
            will.GoTo((-125, 50));



            void j()
            {
                will.PenDown();
                will.SetHeading(270);

                will.Forward(200);
                
                will.Right(45);
                will.Forward(50);
                
                will.Right(45);
                will.Forward(50);

                will.Right(45);
                will.Forward(50);

            }

            void o()
            {



            }
        }
    }
}