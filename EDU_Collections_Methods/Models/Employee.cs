using System;

namespace EDU_Collections_Methods.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public long Salary { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Position}, {Salary}$, {BirthDate})";
        }
    }
}
