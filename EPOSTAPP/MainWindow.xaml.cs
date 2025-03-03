
using System.Windows;
using System.Net.Mail;
using System.Net;
using System.Data.Common;
namespace EPOSTAPP;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        string epost = tbxEpost.Text;
        string meddelande = tbxMeddelande.Text; 

        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true; 
        smtp.Credentials = new NetworkCredential("user", "pass");

        if (epost != "" && meddelande != "")
        {
            smtp.Send("komsadef@gmail.com", "epost", "Epost från appen", meddelande ); 
            lblStatus.Content="✅ ";

        }
        else
        {
            lblStatus.Content="❌ ";
        }
    }
}