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

namespace SwishaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        clickButton.IsEnabled = false; 
        int kontovärde = Random.Shared.Next(100, 301); 
        txbKonto.Text = $"{}"; 
    }
    private void ClickSwish(object sender, RoutedEventArgs e)
    {
        if(int.TryParse(txbSändning.Text, out int txbSändning)) {

            if(txbSändning => kontovärde) {
                res.Text = "Sickar pengar"; 
            }
            else
            {
                res.Text = "För lite pengar";
            }

        } else {
            res.Text = "Skriv ett number"; 
        }
        
    }
}