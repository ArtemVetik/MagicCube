using System;

namespace Agava.MagicCube.Abilities.Model
{
    internal class Timeout : ITimeout
    {
        private readonly float _value;

        private float _currentValue;

        public Timeout(float value)
        {
            _value = value;
            _currentValue = 0f;
        }

        public bool Completed => _currentValue == 0;
        public float MaxValue => _value;
        public float CurrentValue => _currentValue;

        public void Start()
        {
            if (_currentValue != 0)
                throw new InvalidOperationException("Timeout already executed");

            _currentValue = _value;
        }

        public void Update(float deltaTime)
        {
            _currentValue -= deltaTime;
            if (_currentValue < 0)
                _currentValue = 0;
        }
    }
}
