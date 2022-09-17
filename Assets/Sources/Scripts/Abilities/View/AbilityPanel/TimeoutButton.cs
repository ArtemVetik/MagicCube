using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Agava.MagicCube.Abilities.View
{
    [RequireComponent(typeof(Button))]
    public class TimeoutButton : MonoBehaviour
    {
        [SerializeField] private Image _frame;

        private Button _button;
        private ITimeout _timeout;

        public event UnityAction Clicked;

        private void Awake()
        {
            _button = GetComponent<Button>();
            RenderUnselected();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClicked);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClicked);
        }

        private void Update()
        {
            _button.interactable = _timeout.CurrentValue == 0;
            
            _button.image.fillAmount = 1f - _timeout.CurrentValue / _timeout.MaxValue;
            _button.image.color = _timeout.CurrentValue == 0 ? Color.green : Color.gray;
        }

        public void Init(ITimeout timeout)
        {
            _timeout = timeout;
        }

        public void RenderSelected()
        {
            _frame.enabled = true;
        }

        public void RenderUnselected()
        {
            _frame.enabled = false;
        }

        private void OnButtonClicked()
        {
            Clicked?.Invoke();
        }
    }
}
