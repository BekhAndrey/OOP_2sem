using System;
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
        public Form1()
        {
            InitializeComponent();
            OwnerList.Items.Add("Добавить владельца");
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
        }

        private void NumberField_Leave(object sender, EventArgs e)
        {
            if (NumberField.Text.Length < 5 || NumberField.Text.Contains(" "))
            {
                MessageBox.Show("Номер должен состоять из 5 цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string sms = "";
            string banking = "";
            if (String.IsNullOrEmpty(NumberField.Text) || String.IsNullOrEmpty(TypeField.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(OwnerList.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите владельца!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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
                if (String.IsNullOrEmpty(sms) || String.IsNullOrEmpty(banking))
                {
                    MessageBox.Show("Пожалуйста, заполните поля смс оповещения и интернет банкинга!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else accountslist.Add(new Account(Int32.Parse(NumberField.Text), TypeField.Text, BalanceField.Text, CreationDate.Value, sms, banking, OwnerList.SelectedItem.ToString()));

            }
        }
    }
}
