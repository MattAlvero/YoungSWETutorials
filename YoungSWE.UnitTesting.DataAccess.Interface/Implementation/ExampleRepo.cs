using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoungSWE.UnitTesting.Domain.DbContexts;
using YoungSWE.UnitTesting.Domain.Models;
using YoungSWE.UnitTesting.Repository.Interfaces;

namespace YoungSWE.UnitTesting.Repository.Implementation
{
    public class ExampleRepo : IExampleRepo
    {
        private readonly ExampleContext _context;

        public ExampleRepo(ExampleContext context)
        {
            _context = context;
        }

        public Person AddPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Person DeletePerson(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(string firstName)
        {
            Person result = new Person();
            try
            {
                using (_context)
                {
                    result = _context.Persons.Single(p => p.First_Name == firstName);
                }
            }
            catch (Exception ex) 
            {}
            return result;
        }

        public Person UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
