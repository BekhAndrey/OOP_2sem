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
    /// Логика взаимодействия для AddAcc.xaml
    /// </summary>
    public partial class AddAcc : Window
    {
        public Owner owner;
        public AddAcc(Owner own)
        {
            InitializeComponent();
            owner = own;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                Account acc = new Account();
                acc.ID = Convert.ToInt32(number.Text);
                acc.Type = type.Text;
                acc.Ballance = Convert.ToInt32(balance.Text);
                acc.CreationDate = DateTime.Now;
                acc.OwnerId = owner.Id;
                db.Accounts.Add(acc);
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
