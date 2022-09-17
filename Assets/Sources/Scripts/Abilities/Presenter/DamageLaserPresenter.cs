using UnityEngine;

namespace Agava.MagicCube.Abilities
{
    public class DamageLaserPresenter : MonoBehaviour
    {
        [SerializeField, InterfaceType(typeof(IMovementProvider))] private Object _movementProviderObject;

        private DamageLaser _laser;
        private IMovementProvider _movementProvider;

        private void Awake()
        {
            _movementProvider = _movementProviderObject as IMovementProvider;
            _laser = new DamageLaser(_movementProvider);
        }

        private void Update()
        {
            _laser.Update();
        }

        public void Use(IHealthTarget target)
        {
            _laser.Use(target);
        }
    }
}
