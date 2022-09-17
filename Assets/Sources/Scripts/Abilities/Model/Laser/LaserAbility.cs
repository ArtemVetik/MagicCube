using System;

namespace Agava.MagicCube.Abilities.Model
{
    internal abstract class LaserAbility
    {
        private const float TimeoutValue = 0.5f;

        private IHealthTarget _healthTarget;
        private readonly Timeout _timeout;

        internal LaserAbility()
        {
            _timeout = new Timeout(TimeoutValue);
        }

        internal bool IsActive => _healthTarget != null;
        internal ITimeout Timeout => _timeout;

        internal void Use(IHealthTarget target)
        {
            if (_timeout.Completed == false)
                throw new InvalidOperationException("Timeout not completed");

            _healthTarget = target;
        }

        internal void Reset()
        {
            _healthTarget = null;
            _timeout.Start();
        }

        internal void Update(float deltaTime)
        {
            _timeout.Update(deltaTime);

            if (_healthTarget == null)
                return;

            OnAbilityUseFrame(_healthTarget);
        }

        internal abstract void OnAbilityUseFrame(IHealthTarget target);
    }
}
