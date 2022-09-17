using UnityEngine;
using UnityEngine.UI;

namespace Agava.MagicCube.EnemyHealth.View
{
    public class HealthBarView : MonoBehaviour, IHealthView
    {
        [SerializeField] private Slider _health;

        public void Render(float normalizedValue)
        {
            _health.value = normalizedValue;
        }
    }
}
