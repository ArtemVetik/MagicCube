using UnityEngine;

namespace Agava.MagicCube.Abilities.Model
{
    internal class AreaAbility
    {
        private const float MaxLifetime = 15f;
        private const float Radius = 15;
        private const int HealValue = 1;

        private readonly Transform _center;

        private float _lifeTime;

        internal AreaAbility(Transform center)
        {
            _center = center;
        }

        public bool Completed => _lifeTime >= MaxLifetime;

        internal void Update(float deltaTime)
        {
            _lifeTime += deltaTime;
            if (Completed)
                return;

            var colliders = Physics.OverlapSphere(_center.position, Radius);
            foreach (var collider in colliders)
                if (collider.TryGetComponent(out IHealthTarget healTarget))
                    healTarget.Heal(HealValue, _center);
        }
    }
}
