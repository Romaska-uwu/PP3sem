using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;


public class Program
{
    public static void Main(string[] args)
    {
        University university = new University("БГТУ", "Минск, Свердлова 13А");
        Faculty faculty1 = new Faculty("Факультет Информационных Технологий", "Шиман Д.В.", "Минск");
        Faculty faculty2 = new Faculty("Факультет Химической технологии и техники", "Ширма И.Д.", "Минск");
        university.AddFaculty(faculty1);
        university.AddFaculty(faculty2);
        university.PrintInfo();

        List<Reason> reasons = new List<Reason>()
        {
            new Reason { Description = "Несоответствие квалификации" },
            new Reason { Description = "Низкая производительность" }
        };

        Console.WriteLine("Причины увольнения:");
        foreach (var reason in reasons)
        {
            Console.WriteLine(reason);
        }

        Person person_1 = new Person { Id = 1, FirstName = "Виталий", LastName = "Дяченко", DateOfBirth = DateTime.Now.AddYears(-30), Phone = "(44)77-57-7-97" };
        Person person_2 = new Person { Id = 2, FirstName = "Генадий", LastName = "Васильев", DateOfBirth = DateTime.Now.AddYears(-35), Phone = "(44)17-42-7-93" };

        Console.WriteLine("Человек:");
        Console.WriteLine(person_1);
        Console.WriteLine(person_2);

        JobTitle jobTitle_1 = new JobTitle { Id = 1, Title = "Программист", Description = "Разработка ПО" };
        JobTitle jobTitle_2 = new JobTitle { Id = 2, Title = "Преподаватель", Description = "Дисциплина: ООП" };
        Console.WriteLine("Должность:");
        Console.WriteLine(jobTitle_1);
        Console.WriteLine(jobTitle_2);

        JobVacancy jobVacancy_1 = new JobVacancy { Id = 1, Title = "Обслуживающий тех. оборудования", Salary = 2000 };
        JobVacancy jobVacancy_2 = new JobVacancy { Id = 2, Title = "Преподаватель по ООП", Salary = 1500 };
        Console.WriteLine("Вакансия:");
        Console.WriteLine(jobVacancy_1);
        Console.WriteLine(jobVacancy_2);

        Employee employee_1 = new Employee(person_1, jobTitle_1, 60000);
        Employee employee_2 = new Employee(person_2, jobTitle_2, 60000);
        Console.WriteLine("Работник после увальнения:");
        Console.WriteLine(employee_1);
        Console.WriteLine(employee_2);
    }
}




public class C1
{
    public string Name { get; set; };

    public C1(string name)
    {
        Name = name;
    };
    public void Info
    {
        Console.WriteLine(Name);
        };
  }

public class C2 : C1
{
    public C2(string name) : base(name);
}


static void Main(string[] args)
{

    C1 Name1 = new C1(Pasha);

}