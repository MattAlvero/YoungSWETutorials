using Moq;
using YoungSWE.UnitTesting.Domain.Models;
using YoungSWE.UnitTesting.Repository.Interfaces;
using YoungSWE.UnitTesting.Service;

namespace YoungSWE.UnitTesting.Test
{
    public class ExampleServiceTests
    {

        private ExampleService service;
        private Mock<IExampleRepo> exampleRepo;

        [SetUp]
        public void Setup()
        {
            exampleRepo = new Mock<IExampleRepo>();
            service = new ExampleService(exampleRepo.Object);
        }

        [Test]
        public void Test1()
        {
            // Arrange
            Person fake = new Person();
            fake.First_Name = "Test";
            fake.Last_Name = "Test";
            fake.Email = "Test";
            fake.Phone = "Test";
            exampleRepo.Setup(s => s.GetPerson(It.IsAny<string>())).Returns(fake);

            // Act
            string actual = service.GetPerson("Test");

            // Assert
            exampleRepo.Verify(s => s.GetPerson(It.IsAny<string>()), Times.Once());
            Assert.IsNotEmpty(actual);

        }
    }
}