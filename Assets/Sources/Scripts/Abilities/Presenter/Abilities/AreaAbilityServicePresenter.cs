using UnityEngine;
using Agava.MagicCube.Abilities.Model;

namespace Agava.MagicCube.Abilities.Presenter
{
    public class AreaAbilityServicePresenter : MonoBehaviour
    {
        [SerializeField] private AreaAbilityPresenter _template;

        private AreaAbilityService _abilityService;

        public ITimeout Timeout => _abilityService.Timeout;

        private void Awake()
        {
            _abilityService = new AreaAbilityService();
        }

        public void Create(Vector3 position)
        {
            var ability = _abilityService.Create(position);
            Instantiate(_template).Init(ability);
        }
    }
}
