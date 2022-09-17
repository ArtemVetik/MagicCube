
namespace Agava.MagicCube.Abilities
{
    public interface IHealthTarget
    {
        int CurrentHealth { get; }
        void TakeDamage(int value);
        void Heal(int value);
    }
}
