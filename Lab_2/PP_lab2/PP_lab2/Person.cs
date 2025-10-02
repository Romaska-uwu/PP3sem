using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Phone { get; set; }

    public override string ToString() => $"Имя: {FirstName} {LastName}, Id: {Id}, Дата рождения: {DateOfBirth:dd.MM.yyyy HH:mm:ss}, Телефон: {Phone}";

}