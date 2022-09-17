using Agava.MagicCube.EnemyHealth.Model;
using UnityEngine;

namespace Agava.MagicCube.EnemyHealth.Presenter
{
    internal class HealthSource : MonoBehaviour, IHealthSource
    {
        [SerializeField] private int _healthValue;

        private Health _health;

        public IHealth Health => _health;

        private void Awake()
        {
            _health = new Health(_healthValue);
        }

        void IHealthSource.Heal(int value)
        {
            _health.Heal(value);
        }

        void IHealthSource.TakeDamage(int value)
        {
            _health.TakeDamage(value);
        }
    }
}
