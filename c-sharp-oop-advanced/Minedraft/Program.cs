using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        IHarvesterFactory harvesterFactory = new HarvesterFactory();
        IEnergyRepository energyRepository = new EnergyRepository();
        IHarvesterController harvesterController = new HarvesterController(harvesterFactory, new List<IHarvester>(), energyRepository);
        IProviderController providerController = new ProviderController(energyRepository);
        ICommandInterpreter commandInterpreter = new CommandInterpreter(harvesterController, providerController);
        IReader reader = new Reader();
        IWriter writer = new Writer();

        Engine engine = new Engine(reader, writer, commandInterpreter);
        engine.Run();
    }
}