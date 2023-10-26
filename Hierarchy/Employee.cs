using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    enum WorkGroup
    {
        Boss,
        Vice,
        systemer,
        developer
    }
    internal class Employee
    {
        private string name;
        private string jobTitle;
        private WorkGroup wgroup;
        private List<Employee> superiors = new List<Employee>();
        public string Name { get { return name; } set { name = value; } }
        public string JobTitle { get { return jobTitle; } set { jobTitle = value; } }
        public WorkGroup Wgroup { get { return wgroup; } set { wgroup = value; } }
        public List<Employee> Superiors { get { return superiors; } set { superiors = value; } }

        public Employee(string NAme, string JoBTitle, WorkGroup WGroup, params Employee[] superiors)
        {
            Name = NAme;
            JobTitle = JoBTitle;
            Wgroup = WGroup;
            this.superiors.AddRange(superiors);
        }




    }
}
