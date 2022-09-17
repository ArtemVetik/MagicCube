using UnityEngine;
using Agava.MagicCube.Abilities.View;
using UnityEngine.Events;

namespace Agava.MagicCube.Abilities.Presenter
{
    internal class SelectAbilityHandler : MonoBehaviour
    {
        [SerializeField] private TimeoutButton _button;
        [SerializeField, InterfaceType(typeof(IAbility))] private Object _abilityObject;

        private IAbility _ability;

        public event UnityAction<SelectAbilityHandler> Selected;

        private void Awake()
        {
            _ability = _abilityObject as IAbility;
        }

        private void OnEnable()
        {
            _button.Clicked += OnAbilityButtonClicked;
            _ability.Used += OnAbilityUsed;
        }

        private void OnDisable()
        {
            _button.Clicked -= OnAbilityButtonClicked;
            _ability.Used -= OnAbilityUsed;
        }

        private void Start()
        {
            _button.Init(new ViewTimeoutAdapter(_ability.Timeout));
        }

        internal bool UseAbility()
        {
            return _ability.Use();
        }

        internal void Deselect()
        {
            _button.RenderUnselected();
        }

        private void OnAbilityUsed()
        {
            _button.RenderUnselected();
        }

        private void OnAbilityButtonClicked()
        {
            Selected?.Invoke(this);
            _button.RenderSelected();
        }
    }
}
