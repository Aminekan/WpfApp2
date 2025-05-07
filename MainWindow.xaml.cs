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

namespace WpfApp2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int first;
    int second;

    char op;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Button btn = (Button)sender;
        Txtresult.Text += btn.Content.ToString();
        
    }

    private void durch_Click(object sender, RoutedEventArgs e)
    {
        first = Int32.Parse(Txtresult.Text);
        op = '/';
        Txtresult.Clear();

    }

    private void Mal_Click(object sender, RoutedEventArgs e)
    {
        first = Int32.Parse(Txtresult.Text);
        op = '*';
        Txtresult.Clear();
    }

    private void Plus_Click(object sender, RoutedEventArgs e)
    {
        first = Int32.Parse(Txtresult.Text);
        op = '+';
        Txtresult.Clear();
    }
    private void Minus_Click(object sender, RoutedEventArgs e)
    {
        first = Int32.Parse(Txtresult.Text);
        op = '-';
        Txtresult.Clear();
    }
    private void Gleichung_Click(object sender, RoutedEventArgs e)
    {
        second = Int32.Parse(Txtresult.Text);
        int result = 0;

        if (op == '+')
        {
            result = first + second;
        }
        else if (op == '-')
        {
            result = first - second;
        }
        else if (op == '/')
        {
            if (second != 0)
            {
                result = first / second;
            }
            else
            {
                Txtresult.Text = "Fehler: /0";
                return;
            }
        }
        else if (op == '*')
        {
            result = first * second;
        }

        Txtresult.Text = result.ToString();
    }

    private void Clear_Click(object sender, RoutedEventArgs e)
    {
        Txtresult.Clear();
    }

    
}