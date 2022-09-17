using UnityEngine;
using Agava.MagicCube.EnemyHealth.View;

namespace Agava.MagicCube.EnemyHealth.Presenter
{
    internal class HealthViewMediator : MonoBehaviour
    {
        [SerializeField] private HealthSource _healthSource;
        [SerializeField, InterfaceType(typeof(IHealthView))] private MonoBehaviour _healthViewObject;

        private IHealthView _healthView;

        private void Awake()
        {
            _healthView = _healthViewObject as IHealthView;
            _healthView.Render(1f);
        }

        private void Start()
        {
            _healthSource.Health.ValueChanged += OnHealthValueChanged;
        }

        private void OnDestroy()
        {
            _healthSource.Health.ValueChanged -= OnHealthValueChanged;
        }

        private void OnHealthValueChanged()
        {
            _healthView.Render((float)_healthSource.Health.Value / _healthSource.Health.MaxValue);
        }
    }
}
