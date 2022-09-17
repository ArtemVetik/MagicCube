using UnityEngine;

namespace Agava.MagicCube.Abilities.Model
{
    internal class DamageLaser : LaserAbility
    {
        private const int DamageValue = 1;

        internal DamageLaser(Transform from)
            : base(from)
        { }

        internal override void OnAbilityUseFrame(IHealthTarget target, Transform from)
        {
            target.TakeDamage(DamageValue, from);
        }
    }
}
