using Photobox.Helpers;
using System.Windows.Input;

namespace Photobox.ViewModels
{
    public class LoopViewModel : BaseViewModel
    {
        private string _selectedView;

        public string SelectedView
        {
            get { return _selectedView; }
            set
            {
                _selectedView = value;
                OnPropertyChanged();
            }
        }
        public ICommand ChangeViewCommand { get; private set; }
        public LoopViewModel()
        {
            ChangeViewCommand = new DelegateCommand<string>(ChangeView);
            ChangeView(string.Empty);
        }
        private void ChangeView(string view)
        {
            switch (SelectedView)
            {
                case "StandByView.xaml":
                    SelectedView = "PrePhotoView.xaml";
                    CanellationHelper.Instance.CancellationToken = false;
                    break;
                case "PrePhotoView.xaml":
                    SelectedView = "StandByView.xaml";
                    CanellationHelper.Instance.CancellationToken = true;
                    break;
                default:
                    SelectedView = "StandByView.xaml";
                    CanellationHelper.Instance.CancellationToken = false;
                    break;
            }
        }
    }
}
