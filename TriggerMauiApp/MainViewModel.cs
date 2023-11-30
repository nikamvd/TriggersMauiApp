using System.ComponentModel;

namespace TriggerMauiApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command EnableCamera { get; set; }
        private bool _isCameraEnabled;
        public bool IsCameraEnabled
        {
            get { return _isCameraEnabled; }
            set 
            {
                _isCameraEnabled = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsCameraEnabled)));
            }
        }
        public MainViewModel()
        {
            IsCameraEnabled = false;
            EnableCamera = new Command(() => ToggleEnableCamera());
        }

        private void ToggleEnableCamera()
        {
            IsCameraEnabled = !_isCameraEnabled;
        }
    }
}
