using UnityEngine;
using Agava.MagicCube.Abilities;
using Agava.MagicCube.EnemyHealth.Presenter;

namespace Agava.MagicCube.AbilitiesMediator
{
    public class HealthTarget : MonoBehaviour, IHealthTarget
    {
        [SerializeField, InterfaceType(typeof(IHealthSource))] private Object _healthSourceObject;

        private IHealthSource _healthSource;

        public int CurrentHealth => _healthSource.Health.Value;

        private void Awake()
        {
            _healthSource = _healthSourceObject as IHealthSource;
        }

        public void TakeDamage(int value)
        {
            _healthSource.TakeDamage(value);
        }

        public void Heal(int value)
        {
            _healthSource.Heal(value);
        }
    }
}
