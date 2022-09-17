
namespace Agava.MagicCube.Abilities.Model
{
    public interface ITimeout
    {
        bool Completed { get; }
        float MaxValue { get; }
        float CurrentValue { get; }
    }
}
