using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPoo
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date HiringDate { get; set; }
        public Date BirthDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"{Id}-{FirstName} {LastName}"+
                $"\n\tBirth:...................{$"{BirthDate}",18}"+
                $"\n\tHiring Date:.............{$"{HiringDate}",18}"+
                $"\n\tIs Active:...............{$"{BirthDate}",18}";
        }
    }
}
