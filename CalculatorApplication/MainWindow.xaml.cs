using System.Windows;
using System.Windows.Controls;

namespace CalculatorApplication;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    double prevNum = 0;
    string operation = "";
    bool newNumber = true;

    public MainWindow()
    {
        InitializeComponent();
    }

    private TextBox txtResult;
    private void OpenParenthesisButton_Click(object sender, RoutedEventArgs e)
    {
        
    }

    private void D1Button_Click(object sender, RoutedEventArgs e)
    {
       
    }
}