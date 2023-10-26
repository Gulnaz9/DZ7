using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    internal class Task
    {
        private string tasks;
        public string Tasks { get { return tasks; } }

        private WorkGroup adresedTo;
        public WorkGroup AdresedTo { get { return adresedTo; } }

        public Task(string tasks, WorkGroup adresedTo)
        {
            this.tasks = tasks;
            this.adresedTo = adresedTo;
        }
    }
}
