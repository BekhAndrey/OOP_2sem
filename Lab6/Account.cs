using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    [Serializable]
    public class Account
    {
        [Required(ErrorMessage ="Заполните поле \"Номер\"", AllowEmptyStrings = false)]
        [RegularExpression(@"\d{5}", ErrorMessage = "Номер должен состоять из 5 цифр")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Заполните поле \"Тип вклада\"", AllowEmptyStrings = false)]
        [RegularExpression(@"\D*", ErrorMessage = "Поле \"Тип вклада\" не должно содержать цифр")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Заполните поле баланс", AllowEmptyStrings = false)]
        [MinLength(5,ErrorMessage = "Минимальное количество символов в в поле Баланр равно 1")]
        public string Balance { get; set; }
        public DateTime CreationDate;
        public string Sms { get; set; }
        [Required(ErrorMessage = "Выберите необходимую опцию для интернет банкинга", AllowEmptyStrings = false)]
        public string Banking { get; set; }
        [Required(ErrorMessage = "Заполните информацию о владельце", AllowEmptyStrings = false)]
        public string Owner { get; set; }
        public Account()
        {

        }
        public override string ToString()
        {
            return $"Номер: {Number}\nТип: {Type}\nБаланс: {Balance}\nДата создания: {CreationDate}\nВладелец: {Owner}\n\n";
        }
    }
}
