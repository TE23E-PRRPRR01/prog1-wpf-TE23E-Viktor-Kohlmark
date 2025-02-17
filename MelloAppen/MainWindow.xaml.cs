using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MelloAppen;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Variabler för att räkna röster
    private int antalRöd = 0;
    private int antalBlå = 0;
    private int antalGrön = 0;
    private int antalLila = 0;
    private int antalGul = 0;


    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRösta(object sender, RoutedEventArgs e)
    {

        if (sender == röd)
        {
            antalRöd++;
        }
        else if (sender == blå)
        {
            antalBlå++;
        }
        else if (sender == grön)
        {
            antalGrön++;
        }
        else if (sender == gul) {
            antalGul++;
        }
        else if (sender == lila ) {
            antalLila++;
        }

        // Uppdaterar resultatet i textfältet
        txbResultat.Text = $"Röd: {antalRöd}, Blå: {antalBlå}, Grön: {antalGrön}, Lila: {antalLila}, Gul: {antalGul}";
    }
    private void TaBortRöster(object sender, RoutedEventArgs e)
    {
        antalRöd = 0;
        antalBlå = 0;
        antalGrön = 0;
        antalLila = 0;
        antalGul = 0;
        
        txbResultat.Text = $"Röd: {antalRöd}, Blå: {antalBlå}, Grön: {antalGrön}, Lila: {antalLila}, Gul: {antalGul}";

    }
}