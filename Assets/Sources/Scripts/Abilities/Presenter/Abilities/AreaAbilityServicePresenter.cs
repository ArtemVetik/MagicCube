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
            var abilityPresenter = Instantiate(_template);
            abilityPresenter.transform.position = position;

            var ability = _abilityService.Create(abilityPresenter.transform);
            abilityPresenter.Init(ability);
        }
    }
}
