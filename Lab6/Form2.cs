using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public List<Owner> Owners = new List<Owner>();
        [Serializable]
        public class Owner
        {
            [Required(ErrorMessage ="Заполните поле ФИО", AllowEmptyStrings = false)]
            [RegularExpression(@"\w{3}", ErrorMessage = "Поле ФИО должно состоять из 3 символов")]
            public string FIO { get; set; }
            [Required(ErrorMessage = "Заполните поле ID", AllowEmptyStrings = false)]
            [RegularExpression(@"\w{3}", ErrorMessage = "Поле ID должно состоять из 3 символов")]
            public int ID { get; set; }
            public DateTime BirthDate;
            [Required(ErrorMessage = "Заполните поле Passport", AllowEmptyStrings = false)]
            [Passport]
            public string PassportNumber { get; set; }
            public Owner()
            {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CreationDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveClick(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (Owner ownr in Owners)
            {
                if (ownr.ID.ToString() == IdField.Text)
                {
                    flag = false;
                    break;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Данный ID уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Owner owner = new Owner { ID = Int32.Parse(IdField.Text), FIO = FIOField.Text, BirthDate = BirthField.Value, PassportNumber = PassportField.Text };
                var results = new List<ValidationResult>();
                var context = new ValidationContext(owner);
                if (!Validator.TryValidateObject(owner, context, results, true))
                {
                    string strWithError = "";
                    foreach (var error in results)
                    {
                        strWithError += "*" + error.ErrorMessage + Environment.NewLine;
                    }
                    MessageBox.Show(strWithError, "Ошибка: Владелец не прошел валидацию:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Owners.Add(new Owner { ID = Int32.Parse(IdField.Text), FIO = FIOField.Text, BirthDate = BirthField.Value, PassportNumber = PassportField.Text });
                    Close();
                }
            }
        }
    }
    
}
