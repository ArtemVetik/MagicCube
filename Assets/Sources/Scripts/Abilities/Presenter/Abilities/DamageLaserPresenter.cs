using Agava.MagicCube.Abilities.Model;
using UnityEngine;

namespace Agava.MagicCube.Abilities.Presenter
{
    internal class DamageLaserPresenter : LaserPresenter
    {
        protected override LaserAbility CreateLaser(Transform from)
        {
            return new DamageLaser(from);
        }
    }
}
