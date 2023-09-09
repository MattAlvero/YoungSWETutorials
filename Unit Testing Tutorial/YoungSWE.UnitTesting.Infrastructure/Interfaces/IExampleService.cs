using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoungSWE.UnitTesting.Domain.Models;

namespace YoungSWE.UnitTesting.Infrastructure.Interfaces
{
    public interface IExampleService
    {
        public string GetPerson(string firstName);
        public Person AddPerson(Person person);
        public Person UpdatePerson(Person person);
        public Person DeletePerson(string firstName, string lastName);

    }
}
