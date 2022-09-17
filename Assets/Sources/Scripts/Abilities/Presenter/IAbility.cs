using Agava.MagicCube.Abilities.Model;
using System;

namespace Agava.MagicCube.Abilities.Presenter
{
    public interface IAbility
    {
        event Action Used;
        ITimeout Timeout { get; }
        bool Use();
    }
}
