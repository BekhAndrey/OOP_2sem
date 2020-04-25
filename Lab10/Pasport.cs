using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Laba7_8
{
    class Pasport : DependencyObject
    {
        public static readonly DependencyProperty PassportNumberProperty;
        static Pasport()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);
            PassportNumberProperty = DependencyProperty.Register("PassportNumber",
            typeof(string),
            typeof(Pasport), metadata,
            new ValidateValueCallback(ValidateValue));
        }
        private static bool ValidateValue(object value)
        {
            string currentValue = (string)value;
            if (currentValue.Contains("MP"))
                return true;
            return false;
        }
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            string currentValue = (string)baseValue;
            if (currentValue == ("MPP"))
                return "MP";
            return baseValue;
        }
        public string PassportNumber
        {
            get { return (string)GetValue(PassportNumberProperty); }
            set { SetValue(PassportNumberProperty, value); }
        }
    }
}
