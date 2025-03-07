using System;
using System.Collections.Generic;

namespace SFyCSm014p3e3;

/// <summary>
/// Класс реализующий контакт телефонной книги
/// </summary>
public class Contact
{
    /// <summary>
    /// Имя
    /// </summary>
    public String? Name { get; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public String? LastName { get; }

    /// <summary>
    /// Телефонный номер
    /// </summary>
    public long PhoneNumber { get; }

    /// <summary>
    /// Адрес электронноый почты
    /// </summary>
    public String? Email { get; }

    /// <summary>
    /// Инициализирует новый экземпляр класса.
    /// </summary>
    public Contact()
    {
        // Конструктор по умолчанию
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса.
    /// </summary>
    /// <param name="name">Имя</param>
    /// <param name="lastName">Фамилия</param>
    /// <param name="phoneNumber">Телефонный номер</param>
    /// <param name="email">Адрес электронноый почты</param>
    public Contact(string name, string lastName, long phoneNumber, String email)
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}
