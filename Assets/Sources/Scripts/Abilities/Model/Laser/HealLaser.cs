using UnityEngine;

namespace Agava.MagicCube.Abilities.Model
{
    internal class HealLaser : LaserAbility
    {
        private const int HealValue = 1;

        internal HealLaser(Transform from)
            : base(from)
        { }

        internal override void OnAbilityUseFrame(IHealthTarget target, Transform from)
        {
            target.Heal(HealValue, from);
        }
    }
}
