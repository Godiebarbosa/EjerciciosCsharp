using System.Windows;
namespace MiAplicacionWPF
{
 public partial class MainWindow : Window
 {
 public MainWindow()
 {
 InitializeComponent();
 }
 private void button1_Click(object sender, RoutedEventArgs e)
 {
 MessageBox.Show("¡Hola, mundo!");
 }
 }
}
