using UnityEngine;

namespace Agava.MagicCube.Utils
{
    public class LookToCamera : MonoBehaviour
    {
        private Camera _mainCamera;

        private void Awake()
        {
            _mainCamera = Camera.main;
        }

        private void LateUpdate()
        {
            transform.rotation = Quaternion.LookRotation(_mainCamera.transform.forward, Vector3.up);
        }
    }
}
