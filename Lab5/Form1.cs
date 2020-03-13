using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        [Serializable]
        class Account
        {
            public int Number { get; set; }
            public string Type { get; set; }
            public string Balance { get; set; }
            public DateTime CreationDate { get; set; }
            public string Sms { get; set; }
            public string Banking { get; set; }
            public Owner owner { get; set; }
            public Account(Owner ownr )
            {
                owner = ownr;
            }
        }
        Owner owner;
        Account account;
        JsonSerializer<Account> _jsonSerializer;
        public Form1()
        {
            InitializeComponent();
            owner = new Owner();
            account = new Account(owner);
            _jsonSerializer = new JsonSerializer<Account>("data.json");
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void CreateOwnerInfo_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.owner = account.owner;
            form.Show();
        }

        private void LoadAll_Click(object sender, EventArgs e)
        {
            try
            {
                InfoBox.Clear();
                var info = _jsonSerializer.Deserialize();
                InfoBox.Text = $"Информация о владельце: \n\nФИО: {info.owner.FIO} \nДата рождения: {info.owner.BirthDate}\nНомер паспорта: {info.owner.PassportNumber}\n\n" +
                $"Информация о счете: \n\nНомер счета: { info.Number}\nТип вклада: { info.Type}\nБаланс: { info.Balance}\nДата создания счета: { info.CreationDate}\n {info.Sms}\n {info.Banking}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Информация не была сохранена");
            }
        }

        private void SaveAll(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NumberField.Text) || string.IsNullOrEmpty(TypeField.Text) ||
              string.IsNullOrEmpty(BalanceField.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NumberField.Text.Length != 5)
            {
                MessageBox.Show("Номер должен состоять из 5 цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(owner.FIO))
            {
                MessageBox.Show("Добавьте информацию о владельце!");
                return;
            }
            else
            {
                string sms = "";
                if (SmsCheckBox.Checked)
                    sms = "Смс оповещение подключено";
                else sms = "Смс оповещение отключено";
                string banking = "";
                if (BankingYes.Checked)
                    banking = "Интернет банкинг подключен";
                if (BankingNo.Checked)
                    banking = "Интернет банкинг отключен";
                account.Number = Int32.Parse(NumberField.Text);
                account.Type = TypeField.Text;
                account.Balance = BalanceField.Text;
                account.CreationDate = CreationDate.Value;
                account.Sms = sms;
                account.Banking = banking;
                _jsonSerializer.Serialize(account);
            }
        }
    }
    [Serializable]
    public class Owner
    {
        public string FIO;
        public DateTime BirthDate;
        public string PassportNumber;
    }
}
