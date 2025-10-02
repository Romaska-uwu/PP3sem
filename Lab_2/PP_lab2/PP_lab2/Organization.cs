using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Organization : IStaff
{
    private List<JobVacancy> _jobVacancies = new List<JobVacancy>();
    private List<Employee> _employees = new List<Employee>();
    private List<JobTitle> _jobTitles = new List<JobTitle>();
    private List<Reason> Reasons { get; set; } = new List<Reason>();

    public void AddReason(Reason reason)
    {
        Reasons.Add(reason);
    }
    private int _nextEmployeeId = 1;
    private int _nextJobVacancyId = 1;
    private int _nextJobTitleId = 1;

    public int Id { get; private set; }
    public string Name { get; protected set; }
    public string ShortName { get; protected set; }
    public string Address { get; protected set; }
    public DateTime TimeStamp { get; protected set; }

    public Organization(string name, string shortName, string address)
    {
        Name = name;
        ShortName = shortName;
        Address = address;
        TimeStamp = DateTime.Now;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Организация: {Name}, Сокращенное название: {ShortName}, Адрес: {Address}, Время создания: {TimeStamp}");
    }


    public List<JobVacancy> GetJobVacancies() => _jobVacancies;

    public List<Employee> GetEmployees() => _employees;

    public List<JobTitle> GetJobTitles() => _jobTitles;


    public int AddJobTitle(JobTitle jobTitle)
    {
        jobTitle.Id = _nextJobTitleId++;
        _jobTitles.Add(jobTitle);
        return jobTitle.Id;
    }

    public string PrintJobVacancies()
    {
        if (_jobVacancies.Count == 0) return "Вакансий нет.";

        string result = "Вакансии:\n";
        foreach (var vacancy in _jobVacancies)
        {
            result += $"{vacancy.Id}. {vacancy.Title} ({vacancy.Salary})\n";
        }
        return result;
    }


    public bool OpenJobVacancy(JobVacancy jobVacancy)
    {
        jobVacancy.Id = _nextJobVacancyId++;
        _jobVacancies.Add(jobVacancy);
        return true;
    }


    public Employee Recruit(JobVacancy jobVacancy, Person person)
    {
        if (jobVacancy == null || person == null)
        {
            return null;
        }

        if (!_jobVacancies.Any(v => v.Id == jobVacancy.Id) || !_jobTitles.Any(j => j.Id == jobVacancy.Id))
        {
            Console.WriteLine("Ошибка: Неверная вакансия.");
            return null;
        }

        Employee newEmployee = new Employee(person, jobVacancy.JobTitle, jobVacancy.Salary);
        newEmployee.Id = _nextEmployeeId++;
        _employees.Add(newEmployee);
        _jobVacancies.Remove(jobVacancy);
        return newEmployee;
    }


    public bool DelJobTitle(int id)
    {
        var jobTitleToRemove = _jobTitles.FirstOrDefault(jt => jt.Id == id);
        if (jobTitleToRemove == null)
        {
            Console.WriteLine($"Должность с Id {id} не найдена.");
            return false;
        }

        _jobTitles.Remove(jobTitleToRemove);
        _jobVacancies.RemoveAll(jv => jv.JobTitle.Id == id);
        return true;
    }



    public bool CloseJobVacancy(int id)
    {
        var vacancyToClose = _jobVacancies.FirstOrDefault(jv => jv.Id == id);
        if (vacancyToClose == null)
        {
            Console.WriteLine($"Вакансия с Id {id} не найдена.");
            return false;
        }

        _jobVacancies.Remove(vacancyToClose);
        return true;
    }

    public bool Dismiss(int id, Reason reason)
    {
        var employeeToDismiss = _employees.FirstOrDefault(e => e.Id == id);
        if (employeeToDismiss == null)
        {
            Console.WriteLine($"Сотрудник с Id {id} не найден.");
            return false;
        }

        _employees.Remove(employeeToDismiss);
        Console.WriteLine($"Сотрудник с Id {id} уволен по причине: {reason}");
        return true;
    }

    public string PrintEmployees()
    {
        if (_employees.Count == 0)
        {
            return "Сотрудников нет.";
        }
        string result = "Список сотрудников:\n";
        foreach (var employee in _employees)
        {
            result += employee.ToString() + "\n";
        }
        return result;
    }

    public string PrintReasons()
    {
        if (Reasons == null || Reasons.Count == 0)
        {
            return "Причин нет.";
        }
        string result = "Причины:\n";
        foreach (var reason in Reasons)
        {
            result += reason + "\n";
        }
        return result;
    }
}