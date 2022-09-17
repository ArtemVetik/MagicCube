using System;
using System.Collections.Generic;
using UnityEngine;

namespace Agava.MagicCube.Abilities.Model
{
    internal class AreaAbilityService
    {
        private const float TimeoutValue = 5f;

        private List<AreaAbility> _activeAbilities;
        private Timeout _timeout;

        internal AreaAbilityService()
        {
            _activeAbilities = new List<AreaAbility>();
            _timeout = new Timeout(TimeoutValue);
        }

        internal ITimeout Timeout => _timeout;

        internal void Update(float deltaTime)
        {
            _timeout.Update(deltaTime);

            for (int i = _activeAbilities.Count - 1; i >= 0; i--)
            {
                _activeAbilities[i].Update(deltaTime);
                if (_activeAbilities[i].Completed)
                    _activeAbilities.RemoveAt(i);
            }
        }

        internal AreaAbility Create(Vector3 center)
        {
            if (_timeout.Completed == false)
                throw new InvalidOperationException("Timeout not completed");

            var ability = new AreaAbility(center);
            _activeAbilities.Add(ability);

            return ability;
        }
    }
}
