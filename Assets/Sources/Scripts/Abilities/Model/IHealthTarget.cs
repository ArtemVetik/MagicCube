
using UnityEngine;

namespace Agava.MagicCube.Abilities.Model
{
    public interface IHealthTarget
    {
        Vector3 Position { get; }
        int CurrentHealth { get; }
        void TakeDamage(int value, Transform from);
        void Heal(int value, Transform from);
    }
}
