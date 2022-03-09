using System;
using System.Collections.Generic;
using System.Text;

namespace lab_class {
    class Book {
        private string name, author, category;
        private int pages, year;

        private static int price;

        public Book(string name, string author) {
            setBook(name, author, "Другое", 0, 0);
        }

        public Book(string name, string author, string category, int pages, int year) {
            setBook(name, author, category, pages, year);
        }

        public void show() {
            Console.WriteLine($"[{name}] by {author}, {pages} стр.");
            Console.WriteLine($"Год печати: {year};");
            Console.WriteLine($"Категория: {category};");
            Console.WriteLine($"Все книги можно арендовывать по {price}р/день, либо по {price*7}р/неделю.");
        }

        public void setBook(string name, string author, string category, int pages, int year) {
            this.name = name;
            this.author = author;
            this.category = category;
            this.pages = pages;
            this.year = year;
        }

        static Book() {
            price = 10;
        }
    }
}
