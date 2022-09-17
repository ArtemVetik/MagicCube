namespace Agava.MagicCube.Abilities
{
    internal class DamageLaser : LaserAbility
    {
        private const int DamageValue = 1;

        internal DamageLaser(IMovementProvider movementProvider)
            :base(movementProvider)
        { }

        internal override void OnAbilityUseFrame(IHealthTarget target)
        {
            target.TakeDamage(DamageValue);
        }
    }
}
