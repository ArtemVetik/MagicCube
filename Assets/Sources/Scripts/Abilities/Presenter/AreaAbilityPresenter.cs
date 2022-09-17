using UnityEngine;
using Agava.MagicCube.Abilities.Model;
using System;

namespace Agava.MagicCube.Abilities.Presenter
{
    public class AreaAbilityPresenter : MonoBehaviour
    {
        private AreaAbility _areaAbility;

        private void Update()
        {
            if (_areaAbility == null)
                return;

            _areaAbility.Update(Time.deltaTime);
            if (_areaAbility.Completed)
                Destroy(gameObject);
        }

        internal void Init(AreaAbility areaAbility)
        {
            if (_areaAbility != null)
                throw new InvalidOperationException("Ability aready initialized");

            _areaAbility = areaAbility;
        }        
    }
}
