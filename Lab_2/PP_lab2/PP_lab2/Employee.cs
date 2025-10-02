using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    public int Id { get; set; }
    public Person Person { get; set; }
    public JobTitle JobTitle { get; set; }
    public int Salary { get; set; }
    public DateTime DateHired { get; set; }

    public Employee(Person person, JobTitle jobTitle, int salary)
    {
        Person = person;
        JobTitle = jobTitle;
        Salary = salary;
        DateHired = DateTime.Now;
    }

    public override string ToString() => $"Сотрудник {Person.FirstName} {Person.LastName}, Id: {Id}, Должность: {JobTitle.Title}, Зарплата: {Salary}, Дата найма: {DateHired:dd.MM.yyyy}";
}
