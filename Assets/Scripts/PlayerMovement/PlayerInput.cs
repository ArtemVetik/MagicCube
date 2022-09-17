using UnityEngine;

namespace Agava.MagicCube.PlayerMovement
{
    public class PlayerInput : MonoBehaviour, ICharacterInputSource
    {
        public Vector3 MovementInput { get; private set; }

        private void Update()
        {
            MovementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            MovementInput.Normalize();
        }
    }
}