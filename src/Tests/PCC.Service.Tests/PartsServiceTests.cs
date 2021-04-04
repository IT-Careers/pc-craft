namespace PCC.Service.Tests
{
    using AutoMapperConfiguration;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;
    using PCC.Data;
    using PCC.Data.Models;
    using PCC.Services;
    using PCC.Services.Models.Parts;
    using System;
    using System.Threading.Tasks;

    [TestFixture]
    public class PartsServiceTests
    {
        private PCCDbContext pCCDbContext;

        private IPartsService partService;

        [SetUp]
        public void Setup()
        {
            AutoMapperConfig.RegisterMappings(
                typeof(PCCUser).Assembly.GetTypes(),
                typeof(PartServiceModel).Assembly.GetTypes());

            DbContextOptions<PCCDbContext> options = new DbContextOptionsBuilder<PCCDbContext>()
                .UseInMemoryDatabase($"TESTS-DB-{Guid.NewGuid().ToString()}")
                .Options;

            this.pCCDbContext = new PCCDbContext(options);
            this.partService = new PartsService(this.pCCDbContext);
        }

        [Test]
        public async Task CreateProcessorPart_WithValidData_ShouldCorrectlyCreateEntity()
        {
            ProcessorServiceModel partServiceModel = new ProcessorServiceModel
            {
                Brand = "Intel",
                Model = "Core I9",
                Cores = 8,
                Clockspeed = 4500,
                ElectricalPowerConsumption = 3000,
                Price = 2500,
                Socket = "QWERTY",
                ImageUrl = "https://never-gonna-give-you-up.com/rick.png",
            };

            Processor expectedEntity = new Processor
            {
                Brand = "Intel",
                Model = "Core I9",
                Cores = 8,
                Clockspeed = 4500,
                ElectricalPowerConsumption = 3000,
                Price = 2500,
                Socket = "QWERTY",
                ImageUrl = "https://never-gonna-give-you-up.com/rick.png",
            };

            bool result = await this.partService.CreateProcessorPart(partServiceModel);
            Processor actualEntity = await this.pCCDbContext.Processors.FirstOrDefaultAsync();

            // TODO: Check if result is truthy (should be extracted into separate test)
            Assert.True(result, "CreateProcessorPart() method should return truthy value with valid data.");

            // TODO: This can be a constant message with placeholder
            Assert.AreEqual(expectedEntity.Brand, actualEntity.Brand, "CreateProcessorPart() method does not map Brand property correctly.");
            Assert.AreEqual(expectedEntity.Model, actualEntity.Model, "CreateProcessorPart() method does not map Model property correctly.");
            Assert.AreEqual(expectedEntity.Cores, actualEntity.Cores, "CreateProcessorPart() method does not map Cores property correctly.");
            Assert.AreEqual(expectedEntity.Clockspeed, actualEntity.Clockspeed, "CreateProcessorPart() method does not map Clockspeed property correctly.");
            Assert.AreEqual(expectedEntity.ElectricalPowerConsumption, actualEntity.ElectricalPowerConsumption, "CreateProcessorPart() method does not map ElectricalPowerConsumption property correctly.");
            Assert.AreEqual(expectedEntity.Price, actualEntity.Price, "CreateProcessorPart() method does not map Price property correctly.");
            Assert.AreEqual(expectedEntity.Socket, actualEntity.Socket, "CreateProcessorPart() method does not map Socket property correctly.");
            Assert.AreEqual(expectedEntity.ImageUrl, actualEntity.ImageUrl, "CreateProcessorPart() method does not map ImageUrl property correctly.");
            Assert.NotNull(actualEntity.Id, "CreateProcessorPart() method does not set Id property correctly.");
        }

        [Test]
        public async Task CreateProcessorPart_WithInvalidData_ShouldCorrectlyCreateEntity()
        {
            ProcessorServiceModel partServiceModel = new ProcessorServiceModel
            {
                Brand = null,
                Model = "Core I9",
                Cores = 8,
                Clockspeed = 4500,
                ElectricalPowerConsumption = 3000,
                Price = 2500,
                Socket = "QWERTY",
                ImageUrl = "https://never-gonna-give-you-up.com/rick.png",
            };

            Exception ex = Assert.ThrowsAsync<ArgumentException>(() => this.partService.CreateProcessorPart(partServiceModel));

            Assert.That(ex.Message == "Processor Brand cannot be null or empty!", "CreateProcessorPart() method with invalid Brand property, should throw ArgumentException with correct message.");
        }

        [TearDown]
        public void Dispose()
        {
            this.pCCDbContext.Dispose();
            this.partService = null;
        }
    }
}
