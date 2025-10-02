using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

public interface IStaff
{
    List<JobVacancy> GetJobVacancies();
    List<Employee> GetEmployees();
    List<JobTitle> GetJobTitles();
    int AddJobTitle(JobTitle jobTitle);
    string PrintJobVacancies();
    bool DelJobTitle(int id);
    bool OpenJobVacancy(JobVacancy jobVacancy);
    bool CloseJobVacancy(int id);
    Employee Recruit(JobVacancy jobVacancy, Person person);
    bool Dismiss(int id, Reason reason);

    string PrintEmployees();
}