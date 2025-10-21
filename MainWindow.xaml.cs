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
using L_R_2_Khasanova_BPI_23_01.Classes;

namespace L_R_2_Khasanova_BPI_23_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FunctionCalculator calculator;
        public MainWindow()
        {
            InitializeComponent();

            calculator = new FunctionCalculator();

            R1ComboF.Items.Add(4);
            R1ComboF.Items.Add(5);
            R1ComboF.Items.Add(6);
            R1ComboF.Items.Add(7);
            R1ComboF.Items.Add(8);
            R1ComboF.Items.Add(9);

            R2ComboF.Items.Add(10);
            R2ComboF.Items.Add(20);
            R2ComboF.Items.Add(30);
            R2ComboF.Items.Add(40);

            R3ComboC.Items.Add(0);
            R3ComboC.Items.Add(1);

            R3ComboD.Items.Add(-1);
            R3ComboD.Items.Add(0);
            R3ComboD.Items.Add(1);
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            if(Radio1.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R1TextA.Text);
                double f = Convert.ToDouble(R1ComboF.Text);
                this.Title = "Ответ: " + Math.Sin(f * a).ToString("F");
            }

            if (Radio2.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R2TextA.Text);
                double b = Convert.ToDouble(R2TextB.Text);
                double f = Convert.ToDouble(R2ComboF.Text);
                this.Title = "Ответ: "
                    + (Math.Cos(f * a) + Math.Sin(f * b)).ToString("F");
            }

            if (Radio3.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R3TextA.Text);
                double b = Convert.ToDouble(R3TextB.Text);
                double c = Convert.ToDouble(R3ComboC.Text);
                double d = Convert.ToDouble(R3ComboD.Text);
                this.Title = "Ответ: "
                     + (c * a * a + d * b * b).ToString("F");
            }

            if (Radio4.IsChecked.GetValueOrDefault())
            {
                int n = Convert.ToInt32(R4TextN.Text);
                int k = Convert.ToInt32(R4TextK.Text);
                double a = Convert.ToDouble(R4TextA.Text);
                double x = Convert.ToDouble(R4TextX.Text);
                double f = Convert.ToDouble(R4TextF.Text);
                double y = Convert.ToDouble(R4TextY.Text);

                calculator.N = n;
                calculator.K = k;
                calculator.A = a;
                calculator.X = x;
                calculator.Y = y;
                calculator.F = f;

                double result = calculator.CalculateVariant16();

                this.Title = "Ответ: " + result.ToString("F");

            }

        }
        }
        

       
    }
