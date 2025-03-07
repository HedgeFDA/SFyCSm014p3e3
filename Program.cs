using System;
using System.Collections.Generic;

namespace SFyCSm014p3e3;

class Program
{

    /// <summary>
    /// Процедура реализующая основной алгоритм работы приложения.
    /// </summary>
    static void PerformMain()
    {
        //  создаём пустой список с типом данных Contact
        var phoneBook = new List<Contact>();

        // добавляем контакты
        phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igorexample.com"));
        phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "sergeexample.com"));
        phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatolyexample.com"));
        phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valeraexample.com"));
        phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "sergexample.com"));
        phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentiiexample.com"));

        // Сортировка
        var sortedPhoneBook = phoneBook
            .OrderBy(contact => contact.Name)
            .ThenBy(contact => contact.LastName)
            .ToList();

        // Задание 14.2.10
        Console.WriteLine("Выберете страницу:");

        while (true)
        {
            var input = Console.ReadKey().KeyChar;

            var parsed = Int32.TryParse(input.ToString(), out int pageNumber);

            if (!parsed || pageNumber < 1 || pageNumber > 3)
            {
                Console.WriteLine();
                Console.WriteLine("Страницы не существует");

                break;
            }
            else
            {
                var pageContent = sortedPhoneBook.Skip((pageNumber - 1) * 2).Take(2);

                Console.WriteLine();

                foreach (var entry in pageContent)
                    Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);

                Console.WriteLine();
            }
        }
    }

    /// <summary>
    /// Главная точка входа приложения
    /// </summary>
    /// <param name="args">Аргументы командной строки при запуске приложения.</param>
    static void Main(string[] args)
    {
        PerformMain();
    }
}
