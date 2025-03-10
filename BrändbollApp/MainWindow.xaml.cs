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

namespace BrändbollApp;



/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
int poängInne = 0;
int poängUte = 0; 
List<string> historik = []; 

    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {


        // Lägg till poäng 
        poängInne += 5;

        txbInne.Text = $"{poängInne}";
        historik.Add("Bollar");
    }

    private void KlickBränning(object sender, RoutedEventArgs e)
    {

        poängInne += 2;

        txbInne.Text = $"{poängInne}";
    }

    private void KlickLyra(object sender, RoutedEventArgs e)
    {
        poängUte += 5; 
        txbUte.Text = $"{poängUte}";
    }
    private void KlickVarv(object sender, RoutedEventArgs e)
    {

        poängUte += 5; 
        txbUte.Text = $"{poängUte}";
    }
    private void UppdateraHistorik()
    {
        txbHistorik.Text = string.Join(Environment.NewLine, historik);
    }
}
