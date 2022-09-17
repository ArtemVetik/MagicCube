using Agava.MagicCube.Abilities.Model;
using System;
using UnityEngine;

namespace Agava.MagicCube.Abilities.Presenter
{
    public class LaserPresenterInput : MonoBehaviour, IAbility
    {
        [SerializeField] private LaserPresenter _laser;
        [SerializeField] private LaserView _view;

        private Camera _mainCamera;

        public event Action Used;

        public ITimeout Timeout => _laser.Timeout;

        private void Awake()
        {
            _mainCamera = Camera.main;
        }

        private void OnEnable()
        {
            _laser.Reseted += OnLaserReseted;
        }

        private void OnDisable()
        {
            _laser.Reseted -= OnLaserReseted;
        }

        public bool Use()
        {
            var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.TryGetComponent(out IHealthTarget healthTarget))
                {
                    _laser.Use(healthTarget);
                    _view.Create(transform, healthTarget);
                    Used?.Invoke();
                    return true;
                }
            }

            return false;
        }

        private void OnLaserReseted()
        {
            _view.Release();
        }
    }
}
