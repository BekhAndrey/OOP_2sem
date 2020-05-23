using _12_lab.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace _12_lab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public bool IsSorted;
        public bool IsSorted2;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private Owner selectedOwner;
        public Owner SelectedOwner
        {
            get { return selectedOwner; }
            set
            {
                selectedOwner = value;
                OnPropertyChanged("SelectedOwner");
            }
        }

        private BindingList<Account> _accList;

        public BindingList<Account> AccList
        {
            get { return _accList ?? (_accList = new BindingList<Account>()); }
            set
            {
                _accList = value;
                OnPropertyChanged("AccList");
            }
        }

        private BindingList<Owner> _ownerlist;
        public BindingList<Owner> OwnerList
        {
            get { return _ownerlist ?? (_ownerlist = new BindingList<Owner>()); }
            set
            {
                _ownerlist = value;
                OnPropertyChanged("OwnerList");
            }
        }

        private BindingList<Owner> _backup;
        public BindingList<Owner> BackUp
        {
            get { return _backup ?? (_backup = new BindingList<Owner>()); }
            set
            {
                _backup = value;
                OnPropertyChanged();
            }
        }

        private Owner selectedAccount;
        public Owner SelectedAccount
        {
            get { return selectedAccount; }
            set
            {
                selectedAccount = value;
                OnPropertyChanged("SelectedAccount");
            }
        }
        Context db;
        UnitOfWork unitOfWork;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
            IsSorted = false;
            IsSorted2 = false;
        }


        private void AddAccount(object sender, RoutedEventArgs e)
        {
            if (view1.SelectedItems != null) 
            {
                Owner owner = view1.SelectedItem as Owner;
                AddAcc wnd = new AddAcc(owner);
                wnd.Show();
            }
        }

        private void Firstname_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(view1.ItemsSource);
            if (IsSorted)
            {
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription("Firstname", ListSortDirection.Ascending));
            }
            else
            {
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription("Firstname", ListSortDirection.Descending));
            }
            //if (IsSorted)
            //{
            //    OwnerList.Clear();
            //    var asc = db.Owners.OrderBy(p => p.Firstname);
            //    foreach (Owner item in asc)
            //    {
            //        OwnerList.Add(item);
            //    }
            //}
            //else
            //{
            //    OwnerList.Clear();
            //    var desc = db.Owners.OrderByDescending(p => p.Firstname);
            //    foreach (Owner item in desc)
            //    {
            //        OwnerList.Add(item);
            //    }
            //}
            IsSorted = !IsSorted;
        }

        private void Lastname_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(view1.ItemsSource);
            if (IsSorted)
            {
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription("Lastname", ListSortDirection.Ascending));
            }
            else
            {
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription("Lastname", ListSortDirection.Descending));
            }
            //if (IsSorted)
            //{
            //    OwnerList.Clear();
            //    var asc = db.Owners.OrderBy(p => p.Lastname);
            //    foreach (Owner item in asc)
            //    {
            //        OwnerList.Add(item);
            //    }
            //}
            //else
            //{
            //    OwnerList.Clear();
            //    var desc = db.Owners.OrderByDescending(p => p.Lastname);
            //    foreach (Owner item in desc)
            //    {
            //        OwnerList.Add(item);
            //    }
            //}
            IsSorted = !IsSorted;
        }

        private void Creationdate_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //if (IsSorted)
            //{
            //    OwnerList.Clear();
            //    var asc = db.Owners.OrderBy(p => p.Birthday);
            //    foreach (Owner item in asc)
            //    {
            //        OwnerList.Add(item);
            //    }
            //}
            //else
            //{
            //    OwnerList.Clear();
            //    var desc = db.Owners.OrderByDescending(p => p.Birthday);
            //    foreach (Owner item in desc)
            //    {
            //        OwnerList.Add(item);
            //    }
            //}
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(view1.ItemsSource);
            if (IsSorted)
            {
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription("Birthday", ListSortDirection.Ascending));
            }
            else
            {
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription("Birthday", ListSortDirection.Descending));
            }
            IsSorted = !IsSorted;
        }

        private void Passport_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (IsSorted)
            {
                OwnerList.Clear();
                var asc = db.Owners.OrderBy(p => p.Passport);
                foreach (Owner item in asc)
                {
                    OwnerList.Add(item);
                }
            }
            else
            {
                OwnerList.Clear();
                var desc = db.Owners.OrderByDescending(p => p.Passport);
                foreach (Owner item in desc)
                {
                    OwnerList.Add(item);
                }
            }
            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(view1.ItemsSource);
            //if (IsSorted)
            //{
            //    view.SortDescriptions.Clear();
            //    view.SortDescriptions.Add(new SortDescription("Passport", ListSortDirection.Ascending));
            //}
            //else
            //{
            //    view.SortDescriptions.Clear();
            //    view.SortDescriptions.Add(new SortDescription("Passport", ListSortDirection.Descending));
            //}
            //IsSorted = !IsSorted;
        }

        private void Number_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (IsSorted2)
            {
                AccList.Clear();
                var asc = db.Accounts.OrderBy(p => p.ID);
                foreach (Account item in asc)
                {
                    AccList.Add(item);
                }
            }
            else
            {
                AccList.Clear();
                var desc = db.Accounts.OrderByDescending(p => p.ID);
                foreach (Account item in desc)
                {
                    AccList.Add(item);
                }
            }
            IsSorted = !IsSorted;
        }

        private void Type_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (IsSorted2)
            {
                AccList.Clear();
                var asc = db.Accounts.OrderBy(p => p.Type);
                foreach (Account item in asc)
                {
                    AccList.Add(item);
                }
            }
            else
            {
                AccList.Clear();
                var desc = db.Accounts.OrderByDescending(p => p.Type);
                foreach (Account item in desc)
                {
                    AccList.Add(item);
                }
            }
            IsSorted = !IsSorted;
        }

        private void Balance_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (IsSorted2)
            {
                AccList.Clear();
                var asc = db.Accounts.OrderBy(p => p.Ballance);
                foreach (Account item in asc)
                {
                    AccList.Add(item);
                }
            }
            else
            {
                AccList.Clear();
                var desc = db.Accounts.OrderByDescending(p => p.Ballance);
                foreach (Account item in desc)
                {
                    AccList.Add(item);
                }
            }
            IsSorted = !IsSorted;
        }

        private void Creation_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (IsSorted2)
            {
                AccList.Clear();
                var asc = db.Accounts.OrderBy(p => p.CreationDate);
                foreach (Account item in asc)
                {
                    AccList.Add(item);
                }
            }
            else
            {
                AccList.Clear();
                var desc = db.Accounts.OrderByDescending(p => p.CreationDate);
                foreach (Account item in desc)
                {
                    AccList.Add(item);
                }
            }
            IsSorted = !IsSorted;
        }

        private void OwnerId_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (IsSorted2)
            {
                AccList.Clear();
                var asc = db.Accounts.OrderBy(p => p.OwnerId);
                foreach (Account item in asc)
                {
                    AccList.Add(item);
                }
            }
            else
            {
                AccList.Clear();
                var desc = db.Accounts.OrderByDescending(p => p.OwnerId);
                foreach (Account item in desc)
                {
                    AccList.Add(item);
                }
            }
            IsSorted = !IsSorted;
        }

        private void AddToAccount(object sender, RoutedEventArgs e)
        {
            if (view2.SelectedItems != null)
            {
                Account acc = view2.SelectedItem as Account;
                AddtoAcc wnd = new AddtoAcc(acc.ID, acc.Ballance);
                wnd.ShowDialog();
            }
        }

        //private void SearchName(object sender, TextChangedEventArgs e)
        //{
        //    BindingList<Owner> save = new BindingList<Owner>();
        //    if(Search.Text!=null)
        //    {
        //        OwnerList.Clear();
        //        var owners = db.Owners.Where(p => p.Firstname == Search.Text );
        //        foreach (Owner item in owners)
        //        {
        //            OwnerList.Add(item);
        //        }

        //    }
        //}

        private void SearchLostFocus(object sender, RoutedEventArgs e)
        {
            Search.Clear();
            //OwnerList.Clear();
            //OwnerList = db.Owners.Local.ToBindingList();
            foreach(Owner item in OwnerList)
            {
                MessageBox.Show("X");
            }
        }
    }
}
