namespace Agava.MagicCube.Abilities
{
    internal abstract class LaserAbility
    {
        private readonly IMovementProvider _movementProvider;
        private IHealthTarget _healthTarget;

        internal LaserAbility(IMovementProvider movementProvider)
        {
            _movementProvider = movementProvider;
        }

        internal void Use(IHealthTarget target)
        {
            _healthTarget = target;
        }

        internal void Update()
        {
            if (_movementProvider.IsMoving)
                _healthTarget = null;

            if (_healthTarget == null)
                return;

            OnAbilityUseFrame(_healthTarget);
        }

        internal abstract void OnAbilityUseFrame(IHealthTarget target);
    }
}
