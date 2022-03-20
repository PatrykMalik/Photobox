namespace Photobox.ViewModels
{
    public class StandByViewModel : BaseViewModel
    {
        private string _clickOnMe;

        public string ClickOnMe
        {
            get { return _clickOnMe; }
            set
            {
                _clickOnMe = value;
                OnPropertyChanged();
            }
        }
        public StandByViewModel()
        {
            ClickOnMe = @"E:\Source\Repos\Photobox\Photobox\assets\Sleep.mp4";
        }
    }
}
