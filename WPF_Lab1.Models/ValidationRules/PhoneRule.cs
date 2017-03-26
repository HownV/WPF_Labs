using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_Lab1.Models.ValidationRules
{
    public class PhoneRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            ValidationResult result = new ValidationResult(true, null);
            if (value is string phone && phone.Length > 0)
            {
                // +380939780543
                var correctPhone = phone.Replace("+38", "");
                if (correctPhone.Length == 10)
                {
                    foreach (char c in correctPhone)
                    {
                        if (!char.IsDigit(c))
                        {
                            result = new ValidationResult(false, "Incorrect format of the phone number.");
                            break;
                        }
                    }
                }
                else
                {
                    result = new ValidationResult(false, "Incorrect format of the phone number.");
                }
            }
            else
            {
                result = new ValidationResult(false, "Please, enter the phone number.");
            }

            return result;
        }
    }
}
