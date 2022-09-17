namespace Agava.MagicCube.Abilities
{
    internal class HealLaser : LaserAbility
    {
        private const int HealValue = 1;

        internal HealLaser(IMovementProvider movementProvider)
            : base(movementProvider)
        { }

        internal override void OnAbilityUseFrame(IHealthTarget target)
        {
            target.Heal(HealValue);
        }
    }
}
