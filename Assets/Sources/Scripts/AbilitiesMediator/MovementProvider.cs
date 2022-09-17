using UnityEngine;
using Agava.MagicCube.Abilities;
using Agava.MagicCube.PlayerMovement;

namespace Agava.MagicCube.AbilitiesMediator
{
    public class MovementProvider : MonoBehaviour, IMovementProvider
    {
        [SerializeField] private Character _character;

        public bool IsMoving => _character.IsMoving;
    }
}
