using Agava.MagicCube.Abilities.Model;
using UnityEngine;

namespace Agava.MagicCube.Abilities.Presenter
{
    internal class HealLaserPresenter : LaserPresenter
    {
        protected override LaserAbility CreateLaser(Transform from)
        {
            return new HealLaser(from);
        }
    }
}
