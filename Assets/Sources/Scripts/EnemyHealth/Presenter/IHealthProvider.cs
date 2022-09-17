using Agava.MagicCube.EnemyHealth.Model;

namespace Agava.MagicCube.EnemyHealth.Presenter
{
    public interface IHealthProvider
    {
        IHealth Health { get; }
    }
}
