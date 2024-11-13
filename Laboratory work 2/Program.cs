﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesReport report = new SalesReport();

            report.AddSale(new SalesRealization(1, new Game("The Witcher 3: Wild Hunt", 2923.00, 10, Genre.Action)));
            report.AddSale(new SalesRealization(1, new Game("Red Dead Redemption II", 1690.00, 8, Genre.Adventure)));
            report.AddSale(new SalesRealization(2, new Game("The Elder Scrolls V: Skyrim", 1391.00, 5, Genre.RPG)));

            Console.WriteLine("Отчёт: ");
            report.PrintReport();
        }
    }
}
