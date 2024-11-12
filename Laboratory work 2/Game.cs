﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_2
{
    public class Game
    {
        private string name_;
        private decimal price_;
        private int quantity_;
        private Genre genre_;

        public Game(string name, decimal price, int quantity, Genre genre)
        {
            name_ = name;
            price_ = price;
            quantity_ = quantity;
            genre_ = genre;
        }

        public string GetName()
        {
            return name_;
        }

        public decimal GetPrice()
        {
            return price_;
        }

        public int GetQuantity()
        {
            return quantity_;
        }

        public Genre GetGenre()
        {
            return genre_;
        }
    }
}