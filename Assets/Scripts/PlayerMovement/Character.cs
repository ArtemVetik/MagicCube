using UnityEngine;
using UnityEngine.AI;

namespace Agava.MagicCube.PlayerMovement
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class Character : MonoBehaviour
    {
        [SerializeField, InterfaceType(typeof(ICharacterInputSource))] private MonoBehaviour _inputSourceBehaviour;
        
        private ICharacterInputSource _inputSource;
        private NavMeshAgent _agent;

        private void Awake()
        {
            _inputSource = _inputSourceBehaviour as ICharacterInputSource;
            _agent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            var movement = new Vector3(_inputSource.MovementInput.x, 0f, _inputSource.MovementInput.y);
            _agent.SetDestination(transform.position + movement);
        }
    }
}
