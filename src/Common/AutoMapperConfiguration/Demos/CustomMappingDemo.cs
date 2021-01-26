using AutoMapper;

namespace AutoMapperConfiguration.Demos
{
    internal class DemoOrigin : IMapTo<DemoDestination>, IHaveCustomMappings
    {
        public string Origin { get; set; }

        public void CreateMappings(IMapperConfigurationExpression mapperConfig)
        {
            mapperConfig.CreateMap<DemoOrigin, DemoDestination>()
                .ForMember(destination => destination.Destination, opts => opts.MapFrom(origin => origin.Origin));
        }
    }

    internal class DemoDestination
    {
        public string Destination { get; set; }
    }

    class CustomMappingDemo
    {
        public void Run()
        {
            AutoMapperConfig.RegisterMappings(
                typeof(DemoOrigin).Assembly.GetTypes(),
                typeof(DemoDestination).Assembly.GetTypes());

            DemoOrigin origin = new DemoOrigin();
            origin.Origin = "Test";

            DemoDestination destination = origin.To<DemoDestination>();
            System.Console.WriteLine(destination.Destination); // Should be equal to "Test"
        }
    }
}
