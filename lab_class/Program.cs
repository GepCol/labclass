using System;

namespace lab_class {
    class Program {
        static void Main(string[] args) {
            Book book = new Book("Война и Мир", "Л.Н.Толстой", "Художественные", 99999, 2014);
            book.show();
            Console.WriteLine("Но кому нужны эти книги? Мы ж технари, давайте треугольники считать! Введите 3 стороны треугольника одной строкой.");
            string[] sts = Console.ReadLine().Split();
            Triangle t = new Triangle(double.Parse(sts[0]), double.Parse(sts[1]), double.Parse(sts[2]));
            Console.WriteLine($"Так, сей треугольник вообще может существовать? Похоже, что {(t.possible()?"да":"нет")}.");
            Console.WriteLine($"Периметр его будет равен {t.perim()}, а площадь - {t.square()}.");
            Console.WriteLine($"Вот на что способен наш {t}!");


        }
    }
}
