using Agava.MagicCube.EnemyHealth.Model;
using UnityEngine;

namespace Agava.MagicCube.EnemyHealth.Presenter
{
    public class HealthSource : MonoBehaviour
    {
        [SerializeField] private int _healthValue;

        private Health _health;

        public IHealth Health => _health;

        private void Awake()
        {
            _health = new Health(_healthValue);
        }
    }
}
