using System;

namespace ModelLib
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Book()
        {
            
        }

        public Book(int id,string name, int year, string author, double price, int amount)
        {
            Id = id;
            Name = name;
            Year = year;
            Author = author;
            Price = price;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Year: {Year}, Author: {Author}, Price: {Price}, Amount: {Amount}";
        }
    }
}
