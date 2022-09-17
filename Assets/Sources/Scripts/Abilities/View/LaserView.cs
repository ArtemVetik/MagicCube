using Agava.MagicCube.Abilities.Model;
using UnityEngine;

namespace Agava.MagicCube.Abilities.Presenter
{
    public class LaserView : MonoBehaviour
    {
        [SerializeField] private LineRenderer _lineTemplate;

        private LineRenderer _lineInstance;
        private Transform _from;
        private IHealthTarget _target;

        private void Update()
        {
            if (_lineInstance == null)
                return;

            if (_target == null || _target.Equals(null))
            {
                Release();
                return;
            }

            _lineInstance.SetPosition(0, _from.position);
            _lineInstance.SetPosition(1, _target.Position);
        }

        public void Create(Transform from, IHealthTarget target)
        {
            _from = from;
            _target = target;

            _lineInstance = Instantiate(_lineTemplate);
        }

        public void Release()
        {
            if (_lineInstance != null)
                Destroy(_lineInstance.gameObject);
        }
    }
}
