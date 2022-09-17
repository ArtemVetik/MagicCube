using UnityEngine;

namespace Agava.MagicCube.PlayerMovement
{
    public interface ICharacterInputSource
    {
        Vector3 MovementInput { get; }
    }
}