using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoungSWE.UnitTesting.Domain.Models;

namespace YoungSWE.UnitTesting.Repository.Interfaces
{
    public interface IExampleRepo
    {
        public Person GetPerson(string firstName);
        public Person AddPerson(Person person);
        public Person UpdatePerson(Person person);
        public Person DeletePerson(string firstName, string lastName);
    }
}
