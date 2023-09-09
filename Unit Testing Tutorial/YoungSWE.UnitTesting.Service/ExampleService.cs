using Azure.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoungSWE.UnitTesting.Domain.Models;
using YoungSWE.UnitTesting.Infrastructure.Interfaces;
using YoungSWE.UnitTesting.Repository.Interfaces;

namespace YoungSWE.UnitTesting.Service
{
    public class ExampleService : IExampleService
    {
        private readonly IExampleRepo exampleRepo;
        public ExampleService(IExampleRepo exampleRepo) 
        {
            this.exampleRepo = exampleRepo;
        }

        public Person AddPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Person DeletePerson(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public string GetPerson(string firstName)
        {
            Person request = exampleRepo.GetPerson(firstName);
            string result = JsonConvert.SerializeObject(request);
            return result;
        }

        public Person UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
