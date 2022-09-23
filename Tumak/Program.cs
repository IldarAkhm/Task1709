using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Threading;

namespace Tumak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Задание 1. Банк");
            //Console.Write("Введите то, что хотите узнать(сберегательный - savings или текущий - current): ");      
            //Bank bank = (Bank)Enum.Parse(typeof(Bank), Console.ReadLine(), ignoreCase: true);
            //Console.WriteLine((int)bank);
            //Console.ReadKey();


            //Console.Write("Задание 2. Структура Банка\n\n");

            //Bankk ban = new Bankk();
            //ban.num = "08042004";
            //ban.type = "current";
            //ban.balance = "1";

            //ban.print();
            //Console.ReadKey();

            //Console.Write("Задание 3. Вузы\n\n");

            //worker ildar = new worker();
            //ildar.name = "Ильдар";
            //string strr = Convert.ToString(univer.KGU);
            //ildar.univer = strr;

            //ildar.printplz();
            //Console.ReadKey();
        }
        enum univer
        {
            KGU,
            KAI,
            KHTI
        }
        struct worker
        {
            public string name;
            public string univer;

            public void printplz()
            {
                Console.WriteLine($"Данного сотрудника зовут: {name}\nРаботает он в {univer}");
            }
        }
        struct Bankk
        {
            public string num;
            public string type;
            public string balance;

            public void print()
            {
                Console.WriteLine($"Номер счета: {num}\nТип: {type}\nБаланс: {balance}");
            }
        }
        
        enum Bank
        {
            current = 11000,
            savings = 11111111
        }
    }
}
