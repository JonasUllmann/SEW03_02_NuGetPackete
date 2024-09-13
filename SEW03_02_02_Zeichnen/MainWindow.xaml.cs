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

            var seymour = Turtle.Seymour();

            seymour.Left(45);
            seymour.Forward(100);
            seymour.Right(45);
            seymour.Forward(50);
        }
    }
}