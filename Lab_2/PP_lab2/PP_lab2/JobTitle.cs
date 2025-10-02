using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class JobTitle
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public override string ToString() => $"Должность: {Title}, Id: {Id}, Описание: {Description}";

}