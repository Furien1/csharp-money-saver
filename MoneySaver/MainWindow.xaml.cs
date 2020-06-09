using MoneySaver.Controller;
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

namespace MoneySaver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly TransactionController tc = new TransactionController();
        public MainWindow()
        {
            InitializeComponent();
            dg_money.ItemsSource = tc.GetItems();
            tc.Items.ListChanged += OnItemsChanged;
            UpdateSavingLabel();
            this.Focus();
        }

        public void Button_New_Click(object sender, RoutedEventArgs e)
        {
            TransactionDetails td = new TransactionDetails(tc);
            td.Owner = this;
            td.ShowDialog();
        }

        public void OnItemsChanged(object sender, EventArgs e)
        {
            UpdateSavingLabel();
        }

        private void UpdateSavingLabel()
        {
            lbl_Savings.Foreground = tc.GetSavings() > 0 ? lbl_Savings.Foreground = Brushes.Green : Brushes.Red;
            lbl_Savings.Content = tc.GetSavings();
        }
    }
}
