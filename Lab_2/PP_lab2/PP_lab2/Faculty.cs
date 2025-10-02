using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Faculty
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Dean { get; set; }
    public string Address { get; set; }
    public DateTime TimeStamp { get; set; }


    public Faculty(string name, string dean, string address)
    {
        Name = name;
        Dean = dean;
        Address = address;
        TimeStamp = DateTime.Now;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"\tФакультет: {Name}, Декан: {Dean}, Адрес: {Address}, Время создания: {TimeStamp:dd.MM.yyyy HH:mm:ss}");
    }
}