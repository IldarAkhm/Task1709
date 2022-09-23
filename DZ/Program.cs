using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Задание 1. Студенты - алкоголики\n\n");
            //double proc = (double)(100d / 17d);

            //Student Ram = new Student();
            //Ram.name = "Ramis";
            //Ram.surname = "Nasrtdinov";
            //Ram.ind = "222100";
            //Ram.date = "23.11.2004";
            //Ram.categoryalco = 'b';
            //Ram.volume = 5;
            //Ram.procent = Ram.volume * proc;

            //Ram.Print();

            //Student Aid = new Student();
            //Aid.name = "Aidar";
            //Aid.surname = "Halilov";
            //Aid.ind = "222101";
            //Aid.date = "10.02.2005";
            //Aid.categoryalco = 'b';
            //Aid.volume = 4;
            //Aid.procent = Aid.volume * proc;

            //Aid.Print();

            //Student DIM = new Student();
            //DIM.name = "Dim";
            //DIM.surname = "Izmailov";
            //DIM.ind = "222102";
            //DIM.date = "05.12.2004";
            //DIM.categoryalco = 'b';
            //DIM.volume = 1;
            //DIM.procent = DIM.volume * proc;

            //DIM.Print();

            //Student Edu = new Student();
            //Edu.name = "Eduard";
            //Edu.surname = "Gareev";
            //Edu.ind = "222103";
            //Edu.date = "18.10.2004";
            //Edu.categoryalco = 'b';
            //Edu.volume = 3;
            //Edu.procent = Edu.volume * proc;

            //Edu.Print();

            //Student Ild = new Student();
            //Ild.name = "Ildar";
            //Ild.surname = "Akhmetov";
            //Ild.ind = "222104";
            //Ild.date = "08.04.2004";
            //Ild.categoryalco = 'b';
            //Ild.volume = 4;
            //Ild.procent = Ild.volume * proc;

            //Ild.Print();

            //Console.Write("\nОбщий объем алкоголя: 17");



            //Console.ReadKey();

            //Console.Write("Задание 2. Вывод информации о типах данных\n");
            //datatypes bol = new datatypes();
            //bol.name = "bool";
            //bol.min = "true";
            //bol.max = "false";

            //datatypes byt = new datatypes();
            //byt.name = "byte";
            //byt.min = "0";
            //byt.max = "255";

            //datatypes sbyt = new datatypes();
            //sbyt.name = "sbyte";
            //sbyt.min = "-128";
            //sbyt.max = "127";

            //datatypes shot = new datatypes();
            //shot.name = "short";
            //shot.min = "-32768";
            //shot.max = "32767";

            //datatypes ushot = new datatypes();
            //ushot.name = "ushort";
            //ushot.min = "0";
            //ushot.max = "65535";

            //datatypes it = new datatypes();
            //it.name = "int";
            //it.min = "-2147483648";
            //it.max = "2147483647";

            //datatypes uit = new datatypes();
            //uit.name = "uint";
            //uit.min = "0";
            //uit.max = "4294967295";

            //datatypes lon = new datatypes();
            //lon.name = "long";
            //lon.min = "-9 223 372 036 854 775 808";
            //lon.max = "9 223 372 036 854 775 807";

            //datatypes ulon = new datatypes();
            //lon.name = "ulong";
            //lon.min = "0";
            //lon.max = "18 446 744 073 709 551 615";

            //datatypes flot = new datatypes();
            //flot.name = "float";
            //flot.min = "-3.4 * 10^38";
            //flot.max = "3.4 * 10^38";

            //datatypes dubl = new datatypes();
            //dubl.name = "double";
            //dubl.min = "+-5.0 * 10^-324";
            //dubl.max = "+-1.7 * 10^308";

            //datatypes dec = new datatypes();
            //dec.name = "decimal";
            //dec.min = "+-1.0 * 10^-28";
            //dec.max = "+-7.9228 * 10^28";

            //datatypes car = new datatypes();
            //car.name = "char";
            //car.min = "Один символ";

            //datatypes str = new datatypes();
            //str.name = "string";
            //str.min = "Строка - любое кол-во символов";

            //datatypes obj = new datatypes();
            //obj.name = "object";
            //obj.min = "Любое значение";

            //bol.Print();
            //byt.Print();
            //sbyt.Print();
            //shot.Print();
            //ushot.Print();
            //it.Print();
            //uit.Print();
            //lon.Print();
            //ulon.Print();
            //flot.Print();
            //dubl.Print();
            //dec.Print();
            //car.Print();
            //str.Print();
            //obj.Print();
            //Console.ReadKey();

            //Console.WriteLine("Задание 3. PINCODE\n");
            //PIN pincode = new PIN();
            //Console.Write("Введите имя: "); pincode.name = Console.ReadLine();
            //Console.Write("Введите название города: "); pincode.city = Console.ReadLine();
            //Console.Write("Введите свой возраст: "); pincode.age = Console.ReadLine();
            //Console.Write("Введите пинкод: "); pincode.pin = Console.ReadLine();

            //pincode.value = $"Имя:{pincode.name} Возраст:{pincode.age} Город:{pincode.city} Пинкод:{pincode.pin}";

            //pincode.Print();
            //Console.ReadKey();

            //Console.Write("Задание 4. Инициалы\nВведите имя: ");
            //string name = Console.ReadLine();
            //Console.Write("Введите фамилию: "); string surname = Console.ReadLine();
            //string ns = $"{name[0]}.{surname[0]}.";
            //Console.Write($"Ваши инициалы: {ns}");
            //Console.ReadKey();

            //Console.Write("Задание 5. Виски\nNormPrice(Цена в обычных магазинах): ");
            //int price = Convert.ToInt32(Console.ReadLine());
            //Console.Write("SalePrice(В процентах): ");
            //double sale = double.Parse(Console.ReadLine());
            //Console.Write("HolidayPrice(Сумма потраченная на отпуск): ");
            //int hol = int.Parse(Console.ReadLine());
            //double saleprice = price - (price * (1 - (sale / 100d)));
            //double dayeco = Convert.ToDouble(hol) / saleprice;
            //Console.WriteLine($"Чтобы окупить отпуск нужно купить {dayeco} бутылок");
            //Console.ReadKey();

            //Console.Write("Задание 6. Таракан\nВведите скорость в км в час: ");
            //int speed = int.Parse(Console.ReadLine());
            //double speedsm = Math.Floor((100000d / 3600d) * speed);
            //Console.Write($"В см в секунду это: {speedsm}");
            //Console.ReadKey();

            //Console.Write("Задание 7. Малый повзрослел\nВведите свою строку: ");
            //string letters = Console.ReadLine();
            //string leters = "";
            //for (int i = 0; i <= letters.Length - 1; i++)
            //{
            //    char let = Convert.ToChar(letters[i]);
            //    int lett = Convert.ToInt32(let);

            //    if (1072 <= lett & lett <= 1103)
            //    {
            //        string lit = Convert.ToString(letters[i]);
            //        lit = Convert.ToString(Convert.ToChar(lett - 32));
            //        leters += lit;
            //    }
            //    else if (1040 <= lett & lett <= 1071)
            //    {
            //        string lit = Convert.ToString(letters[i]);
            //        lit = Convert.ToString(Convert.ToChar(lett + 32));
            //        leters += lit;                                        
            //    }
            //    else if (97 <= lett & lett <= 122)
            //    {
            //        string lit = Convert.ToString(letters[i]);
            //        lit = Convert.ToString(Convert.ToChar(lett - 32));
            //        leters += lit;
            //    }
            //    else if (65 <= lett & lett <= 96)
            //    {
            //        string lit = Convert.ToString(letters[i]);
            //        lit = Convert.ToString(Convert.ToChar(lett + 32));
            //        leters += lit;
            //    }
            //    else
            //    {                    
            //        string lit = Convert.ToString(letters[i]);
            //        leters += lit;
                    
            //    }
                
                
                
            //}
            //Console.Write(leters); Console.ReadKey();
            

            

        }
        struct PIN
        {
            public string name; 
            public string city;
            public string age;
            public string pin;
            public string value;

            public void Print()
            {
                Console.Write($"Информация в правильной последовательности: {value}");
            }
        }
        struct datatypes
        {
            public string name;
            public string min;
            public string max;

            public void Print()
            {
                Console.WriteLine($"{name}:         Минимальное значение: {min}             Максимальное значение: {max}");
            }
        }


        struct Student
        {
            public string name;
            public string surname;
            public string ind;
            public string date;
            public char categoryalco;
            public int volume;
            public double procent;

            public void Print()
            {
                Console.WriteLine($"Имя: {name}\nФамилия: {surname}\nИндетификатор: {ind}" +
                    $"\nДата рождения: {date}\nКатегория алкоголизма: {categoryalco} " +
                    $"\nОбъемы выпитого: {volume} литров\nВыпил {procent}%");

            }




        }
    }
}
