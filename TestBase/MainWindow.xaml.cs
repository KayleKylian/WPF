using System.Windows;
using TestBase.ControlExtension;


namespace TestBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtName.Text) && !lstName.Items.Contains(txtName.Text))
            {
                lstName.Items.Add(txtName.Text);
                TextExtensor.Clear(txtName);
                TextExtensor.CountChanger(DisplayName, "+");
            }
        }

        private void btnRmvName_Click(object sender, RoutedEventArgs e)
        {
            if(lstName.SelectedIndex != -1) 
            {
                var value = lstName.SelectedValue;
                lstName.Items.Remove(value);
                TextExtensor.CountChanger(DisplayName, "-");
            }
        }
    }
}
