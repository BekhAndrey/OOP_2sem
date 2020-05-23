using _12_lab.Models;
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

namespace _12_lab
{
    /// <summary>
    /// Логика взаимодействия для AddtoAcc.xaml
    /// </summary>
    public partial class AddtoAcc : Window
    {
        public int number;
        public int balance;
        public AddtoAcc(int ID, int Balance)
        {
            InitializeComponent();
            balance = Balance;
            number = ID;
        }

        private void AddAmount(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            using (Context db = new Context())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        balance = balance + Convert.ToInt32(amount.Text);
                        db.Database.ExecuteSqlCommand(@"UPDATE Accounts SET Ballance = " + balance +  "WHERE ID = " + number + " ");
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
            MainWindow wnd = new MainWindow();
            wnd.Show();
            foreach (Window item in Application.Current.Windows)
            {
                if (item != wnd)
                    item.Close();
            }
        }
    }
}
