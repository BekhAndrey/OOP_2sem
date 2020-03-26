using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class PassportAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            
            if (value != null)
            {
                string ownerPassport = value.ToString();
                if (ownerPassport.Length==9)
                    return true;
                else
                    this.ErrorMessage = "Номер паспорта должен состоять из 9 символов";
            }
            return false;
        }
    }
}
