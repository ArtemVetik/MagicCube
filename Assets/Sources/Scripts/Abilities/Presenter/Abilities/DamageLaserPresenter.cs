using Agava.MagicCube.Abilities.Model;

namespace Agava.MagicCube.Abilities.Presenter
{
    internal class DamageLaserPresenter : LaserPresenter
    {
        protected override LaserAbility CreateLaser()
        {
            return new DamageLaser();
        }
    }
}
