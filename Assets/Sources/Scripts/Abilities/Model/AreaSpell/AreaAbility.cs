using UnityEngine;

namespace Agava.MagicCube.Abilities.Model
{
    internal class AreaAbility
    {
        private const float MaxLifetime = 15f;
        private const float Radius = 5;
        private const int HealValue = 1;

        private readonly Vector3 _center;

        private float _lifeTime;

        internal AreaAbility(Vector3 center)
        {
            _center = center;
        }

        public bool Completed => _lifeTime >= MaxLifetime;

        internal void Update(float deltaTime)
        {
            _lifeTime += deltaTime;
            if (Completed)
                return;

            var colliders = Physics.OverlapSphere(_center, Radius);
            foreach (var collider in colliders)
                if (collider.TryGetComponent(out IHealthTarget healTarget))
                    healTarget.Heal(HealValue);
        }
    }
}
