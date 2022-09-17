namespace Agava.MagicCube.Abilities.Model
{
    internal class DamageLaser : LaserAbility
    {
        private const int DamageValue = 1;

        internal override void OnAbilityUseFrame(IHealthTarget target)
        {
            target.TakeDamage(DamageValue);
        }
    }
}
