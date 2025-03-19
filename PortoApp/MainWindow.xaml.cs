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

namespace PortoApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void klickBeräkna(object sender, RoutedEventArgs e)
    {

        if (int.TryParse(txbInput.Text, out int input))
        {
            
            txbResultat.Text = Beräkna(input);
        }
        else
        {
            txbResultat.Text = "Skriv ett numer ";
        }

    }

    private string Beräkna(int input) {

        int pris = 0;
        int frimärken = 0;

        if (input < 50 && input > 0)
        {
            pris = 22;
            frimärken = 1;
        }
        else if (input < 100)
        {
            pris = 44;
            frimärken = 2;
        }
        else if (input < 250)
        {
            pris = 66;
            frimärken = 3;
        }
        else if (input < 500)
        {
            pris = 88;
            frimärken = 4;
        }
        else if (input < 1000)
        {
            pris = 132;
            frimärken = 6;
        }
        else if (input < 2000)
        {
            pris = 154;
            frimärken = 7;
        }
        else
        {
            return "För stort paket"; 
        }

        string result = $"Pris: {pris} kr, Frimärken: {frimärken}";
        return result; 
    }
}