using UnityEngine;
using Agava.MagicCube.PlayerMovement;
using Agava.MagicCube.Abilities.Model;

namespace Agava.MagicCube.AbilitiesMediator
{
    public class MovementProvider : MonoBehaviour, IMovementProvider
    {
        [SerializeField] private Character _character;

        public bool IsMoving => _character.IsMoving;
    }
}
