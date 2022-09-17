namespace Agava.MagicCube.Abilities.Model
{
    internal class HealLaser : LaserAbility
    {
        private const int HealValue = 1;

        internal override void OnAbilityUseFrame(IHealthTarget target)
        {
            target.Heal(HealValue);
        }
    }
}
