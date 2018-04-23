using System.Collections.Generic;

public interface IProviderFactory
{
    IProvider CreateProvider(IList<string> args);
}