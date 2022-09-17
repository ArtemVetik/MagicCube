using Agava.MagicCube.Abilities.Model;
using UnityEngine;

namespace Agava.MagicCube.Abilities.Presenter
{
    internal abstract class LaserPresenter : MonoBehaviour
    {
        [SerializeField, InterfaceType(typeof(IMovementProvider))] private Object _movementProviderObject;

        private LaserAbility _laser;
        private IMovementProvider _movementProvider;

        private void Awake()
        {
            _movementProvider = _movementProviderObject as IMovementProvider;
            _laser = CreateLaser();
        }

        private void Update()
        {
            if (_movementProvider.IsMoving && _laser.IsActive)
                _laser.Reset();

            _laser.Update(Time.deltaTime);
        }

        public void Use(IHealthTarget target)
        {
            _laser.Use(target);
        }

        protected abstract LaserAbility CreateLaser();
    }
}
