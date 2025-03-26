using System.Collections;
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

namespace AritmetikApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void OnCalculateClick(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(txtTal1.Text, out int tal1))
        {
            if (txtOperator.Text == "+" || txtOperator.Text == "-" || txtOperator.Text == "*" || txtOperator.Text == "/")
            {
                // Kör metoder 
                lblResultat.Content = $"Du har valt operatör {txtOperator.Text}";
                string operatör = txtOperator.Text;

                string inputTal1 = txtTal1.Text;
                string inputTal2 = txtTal2.Text;

                if (beräkningar(operatör, inputTal1, inputTal2) != 0)
                {
                    lblResultat.Content = beräkningar(operatör, inputTal1, inputTal2);
                }
                else
                {
                    lblResultat.Content = "Du får inte dela med noll eller andra ogitliga numer";
                }
            }
            else
            {
                lblResultat.Content = "Felaktig operator";
            }
        }
        else
        {
            lblResultat.Content = "Felaktigt tal";
        }
    }
    private double beräkningar(string operatör, string inputTal1, string inputTal2)
    {

        if (double.TryParse(inputTal1.Trim(), out double parsedTal1) && double.TryParse(inputTal2.Trim(), out double parsedTal2))
        {

            switch (operatör)
            {
                case "+":
                    return parsedTal1 + parsedTal2;
                case "-":
                    return Math.Round((double)parsedTal1 / parsedTal2, 2);
                case "/":
                    return parsedTal1 / parsedTal2;
                case "*":
                    return parsedTal1 * parsedTal2;
                default:
                    return 0;

            }

        }
        else
        {
            // Return 0 or an appropriate default value if parsing fails
            return 0;
        }
    }
}
