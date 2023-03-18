using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Library
{
    class Book
    {
      public string BookName { get; set; }
        public override string ToString()
        {
            return BookName.ToString();
        }
    }
    class Library
    {
        Book[] bookArr;
        public Library(int size)
        {
            bookArr = new Book[size];
        }
        public int Length
        { 
            get { return bookArr.Length; } 
        }
        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < bookArr.Length)
                {
                    return bookArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                bookArr[index] = value;
            }
        }
        public int FindByName(string name)
        {
            for (int i = 0; i < bookArr.Length; i++)
            {
                if (bookArr[i].BookName == name)
                {
                    return i;
                }
            }
            return -1;
        }
        public Book this[string name]
        {
            get
            {
               return this[FindByName(name)];
            }
            set 
            {
               bookArr[0] = value; 
            }
        }
       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library book = new Library(3);
            book[0] = new Book
            {
                BookName = "Война и мир"
            }; 
           
            book[1] = new Book
            {
                BookName = "Золотой телёнок"
            }; 
           
            book[2] = new Book
            {
                BookName = "Горе от ума"
            };

            try
            {
                for (int i = 0; i < book.Length; i++)
                {
                    WriteLine(book[i]);
                }
                WriteLine();
                
                WriteLine($"Название книги: {book["Горе от ума"]}");
                WriteLine($"Название книги: {book["Война и мир"]}");
                WriteLine($"Название книги: {book["Золотой телёнок"]}");
                WriteLine($"Название книги: {book["Капитанская дочка"]}");

            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}