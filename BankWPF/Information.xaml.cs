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
using System.Windows.Shapes;

namespace BankWPF
{
    /// <summary>
    /// Логика взаимодействия для Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        public Information()
        {
            InitializeComponent();
        }

        private void AddDeposit(object sender, RoutedEventArgs e)
        {
            Adding deposit = new Adding(true);
            this.Hide();
            deposit.ShowDialog();
            this.Show();
        }

        private void AddCredit(object sender, RoutedEventArgs e)
        {
            Adding credit = new Adding(false);
            this.Hide();
            credit.ShowDialog();
            this.Show();
        }
    }
}
