using System.Collections.Generic;

interface ICommando : ISpecialisedSoldier
{
    IList<IMission> Missions { get; }
}
