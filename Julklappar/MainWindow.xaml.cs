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

namespace Julklappar;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    List<string> ListJulklappar = new List<string>(); 
    int MaxJulklappar = 0; 

    public MainWindow()
    {
        InitializeComponent();
        stpInmatning.IsEnabled = false; 
        stpList.IsEnabled = false; 
    }
    private void KlickAnge(object sender, RoutedEventArgs e)
    {   
        // Tillse att antal Julklappar är ett positivt heltal 
        if (string.IsNullOrWhiteSpace(TxbAntal.Text))
        {
            TxbStatus.Text = "Ange ett heltral, rutan är tom";
            return;
        }
        else if (int.TryParse(TxbAntal.Text, out int antal) && antal > 0)
        {
            antal = MaxJulklappar; 

            // Koppla List till ListBox
            LsbJulklappar.ItemsSource = ListJulklappar; 

            TxbStatus.Text = $"Bra jobbat du har givit {MaxJulklappar}"; 
            stpInmatning.IsEnabled = true; 
            stpList.IsEnabled = true; 
        }
        else 
        {
            TxbStatus.Text = "Ange ett heltral"; 
        }
    }
    private void KlickLäggTill(object sender, RoutedEventArgs e)
    {
        if(string.IsNullOrWhiteSpace(TbxJulklapp.Text) && string.IsNullOrWhiteSpace(TxbMottagare.Text)) 
          {
            TxbStatus.Text = "Ange ett ord"; 
        }
        else
        {
        // Läs av text rutorna
        string julklapp = TbxJulklapp.Text; 
        string mottagare = TxbMottagare.Text; 

        ListJulklappar.Add($"{julklapp} Till {mottagare}");
        LsbJulklappar.Items.Refresh();
        }
    }
    private void KlickBytUt(object sender, RoutedEventArgs e)
    {
        
    }
}