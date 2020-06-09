using MoneySaver.Controller;
using MoneySaver.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MoneySaver
{
    /// <summary>
    /// Interaction logic for TransactionDetails.xaml
    /// </summary>
    public partial class TransactionDetails : Window
    {
        TransactionController tc;
        public TransactionDetails()
        {
            InitializeComponent();
        }
        public TransactionDetails(TransactionController tc )
        {
            InitializeComponent();
            this.tc = tc;
        }

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Ok_Click(object sender, RoutedEventArgs e)
        {
            tc.AddTransaction(new Transaction()
            {
                Name = txt_Name.Text,
                Details = txt_Details.Text,
                Person = txt_Person.Text,
                Value = Convert.ToDecimal(txt_Value.Text)
            });
            this.Close();
        }
    }
}
