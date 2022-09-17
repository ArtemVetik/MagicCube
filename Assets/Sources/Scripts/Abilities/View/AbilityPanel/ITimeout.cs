using System;

namespace Agava.MagicCube.Abilities.View
{
    public interface ITimeout
    {
        bool IsCompleted { get; }
        float MaxValue { get; }
        float CurrentValue { get; }
    }
}
