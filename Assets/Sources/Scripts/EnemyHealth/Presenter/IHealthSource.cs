
namespace Agava.MagicCube.EnemyHealth.Presenter
{
    public interface IHealthSource : IHealthProvider
    {
        void TakeDamage(int value);
        void Heal(int value);
    }
}
