using System.Collections.Generic;

public interface IHarvesterFactory
{
    IHarvester CreateHarvester(IList<string> args);
}