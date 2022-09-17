namespace Agava.MagicCube.Abilities.Presenter
{
    public class ViewTimeoutAdapter : View.ITimeout
    {
        private readonly Model.ITimeout _modelTimeout;

        public ViewTimeoutAdapter(Model.ITimeout modelTimeout)
        {
            _modelTimeout = modelTimeout;
        }

        public bool IsCompleted => _modelTimeout.Completed;
        public float MaxValue => _modelTimeout.MaxValue;
        public float CurrentValue => _modelTimeout.CurrentValue;
    }
}
