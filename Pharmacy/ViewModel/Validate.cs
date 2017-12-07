using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PharmacyCourseProject.ViewModel
{
    public class Validate
    {
        public Validate() {}

        public bool IsDate(string someString)
        {
            DateTime a;
            return DateTime.TryParse(someString, out a);
        }

        public string ReturnErrorsString(string someString, string name, int length)
        {
            if (string.IsNullOrWhiteSpace(someString))
                return name + ":\nЗаполните корректно поле " + '\n';
            else if (someString.Length > length)
                return name + "\nМакс. длина поля " + '-' + length + '\n';
            else return null;
        }

        public string ReturnErrorsInt(string someCount,string name, int length)
        {
            int a;
            if(string.IsNullOrWhiteSpace(someCount))
                return name + ":\nЗаполните корректно поле " + '\n';
            if (!int.TryParse(someCount, out a))
                return name + ":\nДолжен быть числом" + '\n';
            else if (someCount.Length > length)
                return name + ":\nВведите корректное значение" + '\n';
            else
                return null;
        }

        public string ReturnErrorsInt_(string someCount, string name, int max)
        {
            int a;
            if (string.IsNullOrWhiteSpace(someCount))
                return name + ":\nЗаполните корректно поле " + '\n';
            if (!int.TryParse(someCount, out a))
                return name + ":\nДолжен быть числом" + '\n';
            else if (int.Parse(someCount) < 0 || int.Parse(someCount) > max)
                return name + ":\nДопускает значение от 0 до " + max + '\n';
            else return null;
        }

        public string ReturnErrorsDate(string someString,string name)
        {
            if (string.IsNullOrWhiteSpace(someString))
                return name + ":\nЗаполните корректно поле " + '\n';
            else if (!IsDate(someString))
                return name + ":\nДолжен быть датой!" + '\n';
            else
                return null;
        }

        public string ReturnErrorsString_(string someString, string name, int length)
        {
            if (string.IsNullOrWhiteSpace(someString))
                return name + ":\nЗаполните корректно поле " + '\n';
            else if (someString.Length > length)
                return name + "\nМакс. длина поля " + '-' + length + '\n';
            else
                return null;
        }
    }
}
