using Agava.MagicCube.Abilities.Model;
using System;
using UnityEngine;

namespace Agava.MagicCube.Abilities.Presenter
{
    internal abstract class LaserPresenter : MonoBehaviour
    {
        [SerializeField, InterfaceType(typeof(IMovementProvider))] private UnityEngine.Object _movementProviderObject;

        private LaserAbility _laser;
        private IMovementProvider _movementProvider;

        public event Action Reseted;

        public ITimeout Timeout => _laser.Timeout;

        private void Awake()
        {
            _movementProvider = _movementProviderObject as IMovementProvider;
            _laser = CreateLaser(transform);
        }

        private void Update()
        {
            if (_movementProvider.IsMoving && _laser.IsActive)
            {
                _laser.Reset();
                Reseted?.Invoke();
            }

            _laser.Update(Time.deltaTime);
        }

        public void Use(IHealthTarget target)
        {
            if (_movementProvider.IsMoving)
                throw new InvalidOperationException("It is impossible to use a laser, since the movement is not stopped");

            _laser.Use(target);
        }

        protected abstract LaserAbility CreateLaser(Transform from);
    }
}
