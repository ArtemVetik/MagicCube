using System;

namespace Agava.MagicCube.EnemyHealth.Model
{
    internal class Health : IHealth
    {
        private readonly int _maxValue;

        private int _value;

        internal Health(int value)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value) + " should be greater ther zero");

            _maxValue = value;
            _value = value;
        }

        public event Action ValueChanged;

        public int Value => _value;
        public int MaxValue => _maxValue;

        internal void TakeDamage(int damageValue)
        {
            if (damageValue < 0)
                throw new ArgumentOutOfRangeException(nameof(damageValue));

            _value -= damageValue;
            if (_value < 0)
                _value = 0;

            ValueChanged?.Invoke();
        }

        internal void Heal(int healValue)
        {
            if (healValue < 0)
                throw new ArgumentOutOfRangeException(nameof(healValue));

            _value += healValue;
            if (_value > _maxValue)
                _value = _maxValue;

            ValueChanged?.Invoke();
        }
    }
}
