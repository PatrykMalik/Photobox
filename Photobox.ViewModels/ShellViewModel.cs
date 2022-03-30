using Photobox.Helpers;
using System.Windows.Input;

namespace Photobox.ViewModels
{
    public class ShellViewModel : BaseViewModel
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
        public ICommand ShowViewCommand { get; private set; }
        public ICommand CloseCommand { get; private set; }
        public ShellViewModel()
        {
            ShowViewCommand = new DelegateCommand<string>(ShowView);
            CloseCommand = new DelegateCommand<string>(CloseView);
        }
        
        private void ShowView(string view)
        {
            CanellationHelper.Instance.CancellationToken = true;
            SelectedView = view;
        }
        private void CloseView(string view)
        {

        }
    }
}
