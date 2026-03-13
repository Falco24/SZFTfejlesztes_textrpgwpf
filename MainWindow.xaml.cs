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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int current_xp = 0;
        int max_xp = 100;

        private void XP_bar_lvlup()
        {
            current_xp = 0;
            max_xp = (int)(1.08 * max_xp);
            Xp_bar.Text = $"XP : {current_xp} / {max_xp}";
            MessageBox.Show("Level Up!");
        }

        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void TextBlock_Initialized(object sender, EventArgs e) // str textblock
        {
            Str.Text = "Strength : 10";
        }

        private void Dex_Initialized(object sender, EventArgs e) // dex textblock
        {
            Dex.Text = "Dexterity : 10";
        }

        private void Int_Initialized(object sender, EventArgs e) // int textblock
        {
            Int.Text = "Intelligence : 10";
        }

        private void Cha_Initialized(object sender, EventArgs e) // cha textblock
        {
            Cha.Text = "Charisma : 10";
        }

        private void Fear_Initialized(object sender, EventArgs e) // fear textblock
        {
            Fear.Text = "Fear : 0";
        }

        private void Str_plus_Click(object sender, RoutedEventArgs e)
        {
            Str.Text = "Strength : " + (int.Parse(Str.Text.Split(':')[1].Trim()) + 1).ToString();
            
        }

        private void Str_minus_Click(object sender, RoutedEventArgs e)
        {
            Str.Text = "Strength : " + (int.Parse(Str.Text.Split(':')[1].Trim()) - 1).ToString();
        }

        private void Dex_plussz_Click(object sender, RoutedEventArgs e)
        {
            Dex.Text = "Dexterity : " + (int.Parse(Dex.Text.Split(':')[1].Trim()) + 1).ToString();
        }

        private void Dex_minus_Click(object sender, RoutedEventArgs e)
        {
            Dex.Text = "Dexterity : " + (int.Parse(Dex.Text.Split(':')[1].Trim()) - 1).ToString();
        }

        private void Int_plussz_Click(object sender, RoutedEventArgs e)
        {
            Int.Text = "Intelligence : " + (int.Parse(Int.Text.Split(':')[1].Trim()) + 1).ToString();
        }

        private void Int_minus_Click(object sender, RoutedEventArgs e)
        {
            Int.Text = "Intelligence : " + (int.Parse(Int.Text.Split(':')[1].Trim()) - 1).ToString();
        }

        private void Cha_plussz_Click(object sender, RoutedEventArgs e)
        {
            Cha.Text = "Charisma : " + (int.Parse(Cha.Text.Split(':')[1].Trim()) + 1).ToString();
        }

        private void Cha_minus_Click(object sender, RoutedEventArgs e)
        {
            Cha.Text = "Charisma : " + (int.Parse(Cha.Text.Split(':')[1].Trim()) - 1).ToString();
        }

        private void Xp_bar_Initialized()
        {
            Xp_bar.Text = $"XP : {current_xp} / {max_xp}";
        }

        private void xp_dev_add_Click(object sender, RoutedEventArgs e)
        {
            
            current_xp += 10;
            Xp_bar_Initialized();
            if (current_xp >= 100)
            {
                XP_bar_lvlup();
            }
        }

    }
}