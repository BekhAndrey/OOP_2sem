using _12_lab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _12_lab
{
    class ViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public ViewModel()
        {
            unitOfWork = new UnitOfWork();
            db = new Context();
            db.Owners.Load(); // загружаем данные
            db.Accounts.Load();
            OwnerList = db.Owners.Local.ToBindingList();
            AccList = db.Accounts.Local.ToBindingList();
            BackUp = db.Owners.Local.ToBindingList();
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
                OnPropertyChanged();
            }
        }

        private BindingList<Owner> _ownerlist;
        public BindingList<Owner> OwnerList
        {
            get { return _ownerlist ?? (_ownerlist = new BindingList<Owner>()); }
            set
            {
                _ownerlist = value;
                OnPropertyChanged();
            }
        }

        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
                OnPropertyChanged("Firstname");
            }
        }

        private string search;
        public string Search
        {
            get { return search; }
            set
            {
                search = value;
                OnPropertyChanged("Search");
            }
        }

        private string lastname;
        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
                OnPropertyChanged("Lastname");
            }
        }

        private string passport;
        public string Passport
        {
            get { return passport; }
            set
            {
                passport = value;
                OnPropertyChanged("Passport");
            }
        }

        private DateTime birthday;
        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged("Birthday");
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

        private RelayCommand del;
        public RelayCommand Del
        {
            get
            {
                return del ??
                    (del = new RelayCommand(obj =>
                    {
                        if (SelectedOwner!=null)
                        {
                                Owner owner = SelectedOwner;
                                unitOfWork.Owners.Delete(owner.Id);
                                OwnerList.Remove(owner);
                        }
                        unitOfWork.Owners.Save();
                    }));
            }
        }

        private RelayCommand add;
        public RelayCommand Add
        {
            get
            {
                return add ??
                    (add = new RelayCommand(obj =>
                    {
                        Owner owner = new Owner();
                        owner.Lastname = Firstname;
                        owner.Firstname = Lastname;
                        owner.Birthday = Birthday;
                        owner.Passport = Passport;
                        OwnerList.Add(owner);
                        unitOfWork.Owners.Create(owner);
                        unitOfWork.Owners.Save();
                    }));
            }
        }

        private RelayCommand srch;
        public RelayCommand Srch
        {
            get
            {
                return srch ??
                    (srch = new RelayCommand(obj =>
                    {
                        string message ="";
                        if (Search != null)
                        {
                            var owners = db.Owners.Where(p => p.Firstname == Search);
                            if(owners.Count()==0)
                            {
                                MessageBox.Show("Not found");
                            }
                            else
                            {
                                foreach (Owner item in owners)
                                {
                                    message += $"\n\nИмя: {item.Firstname}\nФамилия: {item.Lastname}\nДата рождения: {item.Birthday.ToString()}\nПаспорт: {item.Passport}";
                                }
                                MessageBox.Show(message);
                            }
                        }
                    }));
            }
        }


    }
}
