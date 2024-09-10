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
using NLog;

namespace SEW03_02_01_Rechnen_NuGet_Log
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        int num1;
        int num2;
        int erg;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            logger.Info("pressed addbutton");



            try
            {
                logger.Info("num1 convert start");
                num1 = Convert.ToInt32(tbxnum1.Text);

                logger.Info("num2 convert start");
                num2 = Convert.ToInt32(tbxnum2.Text);

            }

            catch(Exception ex)
            {
                logger.Error("convert fehlgeschlagen");
                tbkerg.Text = ex.ToString();

            }

            

            try
            {
                logger.Info("add");
                erg = num1 + num2;
            }
            catch(Exception ex) 
            {
                logger.Error("add fehlgeschlagen");
            };

            tbkerg.Text = erg.ToString();

            logger.Info("Erfolgreich addiert!");



        }
    }
}