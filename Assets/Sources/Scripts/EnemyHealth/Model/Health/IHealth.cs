using System;

namespace Agava.MagicCube.EnemyHealth.Model
{
    public interface IHealth
    {
        event Action ValueChanged;
        int Value { get; }
        int MaxValue { get; }
    }
}
