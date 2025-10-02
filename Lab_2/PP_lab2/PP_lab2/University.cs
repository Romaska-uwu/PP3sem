using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class University
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime TimeStamp { get; set; }
    private List<Faculty> _faculties;

    public University(string name, string address)
    {
        Name = name;
        Address = address;
        TimeStamp = DateTime.Now;
        _faculties = new List<Faculty>();
    }

    public void AddFaculty(Faculty faculty)
    {
        _faculties.Add(faculty);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Университет: {Name}, Адрес: {Address}, Время создания: {TimeStamp:dd.MM.yyyy HH:mm:ss}");
        Console.WriteLine("Факультеты:");
        foreach (var faculty in _faculties)
        {
            faculty.PrintInfo();
        }
    }
}