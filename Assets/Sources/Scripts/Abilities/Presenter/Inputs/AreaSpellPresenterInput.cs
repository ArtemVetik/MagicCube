using Agava.MagicCube.Abilities.Model;
using System;
using UnityEngine;

namespace Agava.MagicCube.Abilities.Presenter
{
    public class AreaSpellPresenterInput : MonoBehaviour, IAbility
    {
        [SerializeField] private AreaAbilityServicePresenter _areaSpell;

        private Camera _mainCamera;

        public event Action Used;

        public ITimeout Timeout => _areaSpell.Timeout;

        private void Awake()
        {
            _mainCamera = Camera.main;
        }

        public bool Use()
        {
            var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                _areaSpell.Create(hitInfo.point);
                Used?.Invoke();
                return true;
            }

            return false;
        }
    }
}
