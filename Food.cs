using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewResturantManagementSystem
{
    public abstract class Food
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
       
        public Food(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
           
        }
       
    }
    public class Appetizer : Food
    {
        public Appetizer(string name, string description, double price) : base(name, description, price)
        {
        }
    }
    public class MainCourse : Food
    {
        public MainCourse(string name, string description, double price) : base(name, description, price)
        {
        }
    }
    public class Dessert : Food
    {
        public Dessert(string name, string description, double price) : base(name, description, price)
        {
        }
    }
    public class Drinks : Food
    {
        public Drinks(string name, string description, double price) : base(name, description, price)
        {
        }
    }



}
