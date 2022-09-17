using Agava.MagicCube.Abilities.Model;
using UnityEngine;

namespace Agava.MagicCube.Abilities.Presenter
{
    public class LaserInputTest : MonoBehaviour
    {
        [SerializeField] private DamageLaserPresenter _laser;

        private Camera _mainCamera;

        private void Awake()
        {
            _mainCamera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                TrySetTarget(Input.mousePosition);
        }

        private void TrySetTarget(Vector3 screenPosition)
        {
            var ray = _mainCamera.ScreenPointToRay(screenPosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.TryGetComponent(out IHealthTarget healthTarget))
                {
                    _laser.Use(healthTarget);
                }
            }
        }
    }
}
