using UnityEngine;
using Agava.MagicCube.EnemyHealth.Presenter;
using Agava.MagicCube.Abilities.Model;
using UnityEngine.Events;

namespace Agava.MagicCube.AbilitiesMediator
{
    public class HealthTarget : MonoBehaviour, IHealthTarget
    {
        [SerializeField, InterfaceType(typeof(IHealthSource))] private Object _healthSourceObject;

        private IHealthSource _healthSource;

        public event UnityAction<Transform> Damaged;
        public event UnityAction<Transform> Healing;

        public int CurrentHealth => _healthSource.Health.Value;

        private void Awake()
        {
            _healthSource = _healthSourceObject as IHealthSource;
        }

        public void TakeDamage(int value, Transform from)
        {
            _healthSource.TakeDamage(value);
            Damaged?.Invoke(from);

            if (_healthSource.Health.Value == 0)
                Destroy(gameObject);
        }

        public void Heal(int value, Transform from)
        {
            _healthSource.Heal(value);
            Healing?.Invoke(from);
        }
    }
}
