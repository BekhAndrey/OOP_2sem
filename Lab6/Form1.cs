using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Lab5
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            OwnerList.Items.Add("Добавить владельца");
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            DateStatus.Text = DateTime.Now.ToLongDateString();
            TimeStatus.Text = DateTime.Now.ToLongTimeString();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void ClearClick(object sender, EventArgs e)
        {
            NumberField.Clear();
            TypeField.Clear();
            BalanceField.Clear();
            SmsCheckBox.Checked = false;
            BankingNo.Checked = false;
            BankingYes.Checked = false;
            ActionStatus.Text = "Clear";
        }


        public List<Account> accountslist = new List<Account>();
        public List<Form2.Owner> ownerslist = new List<Form2.Owner>();

        private void OwnerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OwnerList.SelectedItem.ToString() == "Добавить владельца")
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                foreach (Form2.Owner owner in form2.Owners)
                {
                    if (owner.ID.ToString().Length > 0)
                    {
                        OwnerList.Items.Add(owner.FIO);
                        ownerslist.Add(owner);
                    }
                    OwnerList.SelectedItem = owner.FIO;
                }
            }
        }
        XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
        XmlSerializer serializer2 = new XmlSerializer(typeof(List<Form2.Owner>));

        private void WriteToFileButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("accounts.xml", FileMode.Create))
            {
                serializer.Serialize(fs, accountslist);
            }

            using (FileStream fs2 = new FileStream("owners.xml", FileMode.Create))
            {
                serializer2.Serialize(fs2, ownerslist);
            }

            accountslist.Clear();
            ownerslist.Clear();
            ActionStatus.Text = "Write to file";
        }

        private void ReadFromFileButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("accounts.xml", FileMode.Open))
            {
                accountslist.Clear();
                accountslist = (List<Account>)serializer.Deserialize(fs);
            }

            using (FileStream fs2 = new FileStream("owners.xml", FileMode.Open))
            {
                ownerslist.Clear();
                ownerslist = (List<Form2.Owner>)serializer2.Deserialize(fs2);
            }
            Form3 form3 = new Form3();
            form3.ShowDialog();
            ActionStatus.Text = "Read from file";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string sms=null;
            string banking=null;
            if (BankingYes.Checked)
            {
                banking = "Интернет банкинг подключен";
            }
            if(BankingNo.Checked)
            {
                banking = "Интернет банкинг отключен";
            }
            if (SmsCheckBox.Checked)
            {
                sms = "Смс оповещение подключено";
            }
            else sms = "Cмс оповещение отключено";
            if(OwnerList.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите владельца!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                bool flag = true;
                foreach (Account account in accountslist)
                {
                    if (account.Number == NumberField.Text)
                    {
                        flag = false;
                        break;
                    }
                }
                if(!flag)
                {
                    MessageBox.Show("Данный номер счета уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Account acc = new Account { Number = NumberField.Text, Type = TypeField.Text, Balance = BalanceField.Text, CreationDate = CreationDate.Value, Sms = sms, Banking = banking, Owner = OwnerList.SelectedItem.ToString() };
                    var results = new List<ValidationResult>();
                    var context = new ValidationContext(acc);
                    if (!Validator.TryValidateObject(acc, context, results, true))
                    {
                        string strWithError = "";
                        foreach (var error in results)
                        {
                            strWithError += "*" + error.ErrorMessage + Environment.NewLine;
                        }
                        MessageBox.Show(strWithError, "Ошибка: Аккаунт не прошел валидацию:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        accountslist.Add(new Account { Number = NumberField.Text, Type = TypeField.Text, Balance = BalanceField.Text, CreationDate = CreationDate.Value, Sms = sms, Banking = banking, Owner = OwnerList.SelectedItem.ToString() });
                    }
                }
            }
            int accounts = accountslist.Count;
            int owners = OwnerList.Items.Count-1;
            int result = accounts + owners;
            AmountStatus.Text = result.ToString();
            ActionStatus.Text = "Сохранить";
        }

        private void SearchMenuItem_Click(object sender, EventArgs e)
        {
            Search searchform = new Search(accountslist,ownerslist);
            searchform.Activate();
            searchform.Show();
            ActionStatus.Text = "Search";
        }

        private void AboutProgrammMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия: "+ System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()+"\nФИО разработчика: Бэх А.Ю.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActionStatus.Text = "Info";
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            NumberField.Clear();
            TypeField.Clear();
            BalanceField.Clear();
            SmsCheckBox.Checked = false;
            BankingNo.Checked = false;
            BankingYes.Checked = false;
            ActionStatus.Text = "Clear";
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\nФИО разработчика: Бэх А.Ю.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActionStatus.Text = "Info";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search searchform = new Search(accountslist, ownerslist);
            searchform.Activate();
            searchform.Show();
            ActionStatus.Text = "Search";
        }
    }
}
