using UnityEngine;

namespace Agava.MagicCube.Abilities.Presenter
{
    public class SelectAbilityListHandler : MonoBehaviour
    {
        private SelectAbilityHandler[] _handlers;

        private SelectAbilityHandler _activeHandler;

        private void Awake()
        {
            _handlers = GetComponentsInChildren<SelectAbilityHandler>();
        }

        private void OnEnable()
        {
            foreach (var handler in _handlers)
                handler.Selected += OnAbilitySelected;
        }

        private void OnDisable()
        {
            foreach (var handler in _handlers)
                handler.Selected -= OnAbilitySelected;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_activeHandler == null)
                    return;

                if (_activeHandler.UseAbility())
                {
                    _activeHandler.Deselect();
                    _activeHandler = null;
                }
            }
        }

        private void OnAbilitySelected(SelectAbilityHandler selectAbilityHandler)
        {
            _activeHandler?.Deselect();
            _activeHandler = selectAbilityHandler;
        }
    }
}
