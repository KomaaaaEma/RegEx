using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void RegexThis(string pattern, string task)
        {
            Console.WriteLine($"К строке {task} применен {pattern}");
            foreach (Match item in Regex.Matches(task, pattern))
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Проверить является ли заданная строка шестизначным числом, записанным в десятичной системе счисления без нулей в старших разрядах.");
            Console.WriteLine();
            string pattern = @"\b[1-9]\d{5}\b";
            string task = "123456 234567 1234567 12345 012345";
            RegexThis(pattern, task);
            Console.ReadKey(true);

            Console.WriteLine(@"2. Написать регулярное выражение, определяющее является ли заданная строка правильным MACадресом. Адрес состоит из 6-ти чисел, записанных в шестнадцатеричной системе счисления от 0 до FF и разделенных символом «:».");
            Console.WriteLine();
            pattern = @"\b([\dA-Fa-f]{2}:){5}[\dA-Fa-f]{2}\b";
            task = "01:32:54:67:89:AB aE:dC:cA:56:76:54 01:33:47:65:89:ab:cd 01:23:45:67:89:Az";
            RegexThis(pattern, task);
            Console.ReadKey(true);

            Console.WriteLine(@"3.Написать регулярное выражение, определяющее является ли данная строчка шестнадцатиричным идентификатором цвета в HTML. Где #FFFFFF для белого, #000000 для черного, #FF0000 для красного и.т.д.");
            Console.WriteLine();
            pattern = @"#[A-Fa-f\d]{6}\b";
            task = "#FFFFFF #FF3421 #00ff00 232323 f#fddee #fd2";
            RegexThis(pattern, task);
            Console.ReadKey(true);
            
            Console.WriteLine(@"4.Проверить, надежно ли составлен пароль. Пароль считается надежным, если он состоит из 8 или более символов. Где символом может быть английская буква, цифра и знак подчеркивания. Пароль должен содержать хотя бы одну заглавную букву, одну маленькую букву и одну цифру.");
            Console.WriteLine();
            pattern = @"\b(?=.*[A - Z])(?=.*[0 - 9])(?=.*[a - z])[\w]{ 8,}\b";
            task = "C00l_Pass SupperPas1 Cool_pass C00l";
            RegexThis(pattern, task);
            Console.ReadKey(true);

            
            Console.WriteLine(@"5.В сообщении может содержаться дата в формате дд.мм.гггг. В заданном формате дд - целое число из диапазона от 1 до 31, мм - целое число из диапазона от 1 до 12, а гггг - целое число из диапазона от 1900 до 2012 (если какая-то часть формата нарушена,то данная подстрока в качестве даты не рассматривается). Найти все даты, которые относятся к текущему году.");
            Console.WriteLine();
            pattern = @"\b(([0 - 2][0 - 9]) | ([3][01]))[.]([0][0 - 9] |[1][0 - 2])[.]2021\b";
            task = "01.01.1901 02.02.2002 03.05.1997 05.05.2021";
            RegexThis(pattern, task);
            Console.ReadKey(true);
            
            Console.WriteLine(@"6.В сообщении может содержаться время в формате чч:мм:сс. В заданном формате чч - целое число из диапазона от 00 до 24, мм и сс - целые числа из диапазона от 00 до 60 (если какая-то часть формата нарушена, то данная подстрока в качестве даты не рассматривается).");
            Console.WriteLine();
            pattern = @"\b([0-1][0-9]|[2][0-3])(:[0-5][0-9]){2}\b";
            task = "12:12:12 24:53:89 00:00:00 123:85:96";
            RegexThis(pattern, task);
            Console.ReadKey(true);

            
            Console.WriteLine(@"7.Разработать программу (Python, C#) для поиска в тексте всех корректно записанных римских чисел (от 1 до 3999) и их замены на соответствующее “арабское” число.");
            Console.WriteLine();
            pattern = @"\bM{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})\b";
            task = "DCCC  MMMCMXCIX MMMM MMMCDUTI BISQUIT";
            RegexThis(pattern, task);
            Console.ReadKey(true);
        }
    }
}
