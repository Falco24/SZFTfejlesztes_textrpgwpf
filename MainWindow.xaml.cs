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
        int skill_point = 6;


        int strng = 10;
        int dex = 10;
        int intel = 10;
        int cha = 10;
        int fear = 0;

        private void XP_bar_lvlup()
        {
            current_xp = current_xp - max_xp;
            max_xp = (int)(1.2 * max_xp);
            skill_point++;
            Skill_points_rn_Initialized();
            Skill_point_check();
            Xp_bar.Text = $"XP : {current_xp} / {max_xp}";
            MessageBox.Show("Level Up!");
        }
        
        private void Skill_point_check()
        {
            if (skill_point == 0)
            {
                Str_plus.IsEnabled = false;
                Dex_plussz.IsEnabled = false;
                Int_plussz.IsEnabled = false;
                Cha_plussz.IsEnabled = false;
            }

            if (strng > 10)
            {
                Str_minus.IsEnabled = true;
            }

            else
            {
                Str_minus.IsEnabled = false;
            }

            if (dex > 10)
            {
                Dex_minus.IsEnabled = true;
            }

            else 

            if (intel == 10)
            {
                Int_minus.IsEnabled = false;
            }

            if (cha == 10)
            {
                Cha_minus.IsEnabled = false;
            }

            if (skill_point > 0 )
            {
                Str_plus.IsEnabled = true;
                Dex_plussz.IsEnabled = true;
                Int_plussz.IsEnabled = true;
                Cha_plussz.IsEnabled = true;
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
            Xp_bar_Initialized();
            Skill_point_check();
            Skill_points_rn_Initialized();

        }


        private void TextBlock_Initialized(object sender, EventArgs e) // str textblock
        {
            Str.Text = $"Strength : {strng}";
        }

        private void Dex_Initialized(object sender, EventArgs e) // dex textblock
        {
            Dex.Text = $"Dexterity : {dex}";
        }

        private void Int_Initialized(object sender, EventArgs e) // int textblock
        {
            Int.Text = $"Intelligence : {intel}";
        }

        private void Cha_Initialized(object sender, EventArgs e) // cha textblock
        {
            Cha.Text = $"Charisma : {cha}";
        }

        private void Fear_Initialized(object sender, EventArgs e) // fear textblock
        {
            Fear.Text = $"Fear : {fear}";
        }

        private void Str_plus_Click(object sender, RoutedEventArgs e)
        {
            skill_point--;
            strng++;
            Skill_point_check();
            Str.Text = "Strength : " + (int.Parse(Str.Text.Split(':')[1].Trim()) + 1).ToString();
            Skill_points_rn_Initialized();

        }

        private void Str_minus_Click(object sender, RoutedEventArgs e)
        {
            skill_point++;
            strng--;
            Skill_point_check();
            Str.Text = "Strength : " + (int.Parse(Str.Text.Split(':')[1].Trim()) - 1).ToString();
            Skill_points_rn_Initialized();
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

        private void Skill_points_rn_Initialized()
        {
            Skill_points_rn.Text = $"Skill Points : {skill_point}";
        }

        private void xp_dev_add_Click(object sender, RoutedEventArgs e)
        {
            
            current_xp += 10;
            Xp_bar_Initialized();
            if (current_xp >= max_xp)
            {
                XP_bar_lvlup();
            }
        }

    }
}