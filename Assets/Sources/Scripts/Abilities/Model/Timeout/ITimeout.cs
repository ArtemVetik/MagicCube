using System;

namespace Agava.MagicCube.Abilities.Model
{
    public interface ITimeout
    {
        event Action Started;
        bool Completed { get; }
        float MaxValue { get; }
        float CurrentValue { get; }
    }
}
