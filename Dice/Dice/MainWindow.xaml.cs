using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string DiceResult_str;
        
        //public static object Dice_T6 { get => dice_T6; set => dice_T6 = value; }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void dice6()
        {
            Random random = new Random();
            int theDice6 = random.Next(1,6);
            diceResult.Text = theDice6.ToString();
        }

        private void diceResult_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
        }

        private void btnRoll_dice_Click(object sender, RoutedEventArgs e)
        {
            if (diceResult.Text == "0")
                dice6();
            else
                diceResult.Text = "Reset";
            
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            diceResult.Text = "0";
        }

        private void btnD4_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int theDice6 = random.Next(1, 4);
            diceResult.Text = theDice6.ToString();
        }

        private void btnD6_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int theDice6 = random.Next(1, 6);
            diceResult.Text = theDice6.ToString();
        }

        private void btnD8_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int theDice6 = random.Next(1, 8);
            diceResult.Text = theDice6.ToString();
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int theDice6 = random.Next(1, 10);
            diceResult.Text = theDice6.ToString();
        }

        private void btnD12_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int theDice6 = random.Next(1, 12);
            diceResult.Text = theDice6.ToString();
        }

        private void btnD20_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int theDice6 = random.Next(1, 20);
            diceResult.Text = theDice6.ToString();
        }

        private void btnD100_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int theDice6 = random.Next(1, 100);
            diceResult.Text = theDice6.ToString();
        }
    }
}
