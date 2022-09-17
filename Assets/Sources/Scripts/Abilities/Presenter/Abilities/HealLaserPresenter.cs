using Agava.MagicCube.Abilities.Model;

namespace Agava.MagicCube.Abilities.Presenter
{
    internal class HealLaserPresenter : LaserPresenter
    {
        protected override LaserAbility CreateLaser()
        {
            return new HealLaser();
        }
    }
}
