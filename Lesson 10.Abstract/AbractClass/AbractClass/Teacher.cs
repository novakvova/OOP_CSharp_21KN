﻿using Bogus;
using System.Text.RegularExpressions;

namespace AbractClass;

public class Teacher : Person
{
    /// <summary>
    /// Предмети
    /// </summary>
    private string _subject = String.Empty;
    /// <summary>
    /// Посада
    /// </summary>
    private string _position = String.Empty;
    /// <summary>
    /// Зарплата
    /// </summary>
    private decimal _salary;

    public Teacher()
    {
        _subject = "Програмування C#";
        _position = "Куди вітер дує";
        _salary = 0;
    }
    public Teacher(bool isRandom = false)
    : base(isRandom)
    {
        Faker faker = new Faker();
        _salary = faker.Random.Decimal(3000, 8000);
    }
    public override void ViewInfo()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        base.ViewInfo();
        Console.WriteLine($"Предмети {_subject}");
        Console.WriteLine($"Посада {_position}");
        Console.WriteLine($"Зарплата {_salary}");
        Console.ForegroundColor = ConsoleColor.White;
    }




}
