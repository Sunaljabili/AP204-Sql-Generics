using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Models
{
     public  abstract class Product
     {
        private static int _id;
        public  int Id { get; }
        public Product(string name, double price)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
        }
       
        public string Name { get; set; }
        public double Price { get; set; }
        public  int Count  { get; set; }
        public double TotalIncome { get;protected  set; }

        public abstract void Sell();

        public abstract void ShowInfo();
    }
} 
