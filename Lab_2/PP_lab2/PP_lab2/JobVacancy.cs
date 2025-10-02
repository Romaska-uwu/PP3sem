using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class JobVacancy
{
    public int Id { get; set; }
    public JobTitle JobTitle { get; set; }
    public int Salary { get; set; }
    public string Title { get; set; }
    public override string ToString() => $"Id: {Id}, Должность: {Title}";

}