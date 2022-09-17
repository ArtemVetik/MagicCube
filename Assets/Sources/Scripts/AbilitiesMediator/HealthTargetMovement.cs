using UnityEngine;

namespace Agava.MagicCube.AbilitiesMediator
{
    public class HealthTargetMovement : MonoBehaviour
    {
        private const float Speed = 0.02f;

        [SerializeField] private HealthTarget _healthTarget;

        private void OnEnable()
        {
            _healthTarget.Damaged += OnTargetDamaged;
            _healthTarget.Healing += OnTargetHealing;
        }

        private void OnDisable()
        {
            _healthTarget.Damaged -= OnTargetDamaged;
            _healthTarget.Healing -= OnTargetHealing;
        }

        private void OnTargetDamaged(Transform from)
        {
            var shift = (_healthTarget.transform.position - from.position).normalized;
            shift.y = 0;
            _healthTarget.transform.position += shift * Speed;
        }

        private void OnTargetHealing(Transform from)
        {
            var shift = (from.position - _healthTarget.transform.position).normalized;
            shift.y = 0;
            _healthTarget.transform.position += shift * Speed;
        }
    }
}
