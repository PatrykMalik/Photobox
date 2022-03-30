using Photobox.IServices;

namespace Photobox.ViewModels
{
    public class StandByViewModel : BaseViewModel
    {
        private string _clickOnMe;
        private readonly IAssetsHelper _assetsHelper;

        public string ClickOnMe
        {
            get { return _clickOnMe; }
            set
            {
                _clickOnMe = value;
                OnPropertyChanged();
            }
        }
        public StandByViewModel(IAssetsHelper assetsHelper)
        {
            _assetsHelper = assetsHelper;
            ClickOnMe = _assetsHelper.GetPostPhotoVideo();
        }
    }
}
