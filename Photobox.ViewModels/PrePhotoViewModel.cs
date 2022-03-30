using Photobox.Helpers;
using Photobox.IServices;
using System.Threading.Tasks;

namespace Photobox.ViewModels
{
    public class PrePhotoViewModel : BaseViewModel
    {
        private string _takingPhotoClipPath;

        public string TakingPhotoClipPath
        {
            get { return _takingPhotoClipPath; }
            set
            {
                _takingPhotoClipPath = value;
                OnPropertyChanged();
            }
        }

        private readonly ICameraService _cameraService;
        private readonly IAssetsHelper _assetsHelper;

        public PrePhotoViewModel(ICameraService cameraService, IAssetsHelper assetsHelper)
        {
            _cameraService = cameraService;
            _assetsHelper = assetsHelper;
            TakePhotoAsync();
        }
        private async Task TakePhotoAsync()
        {
            for (int i = 0; i < 3; i++)
            {
                if (CanellationHelper.Instance.CancellationToken)
                    break;
                TakingPhotoClipPath = _assetsHelper.GetPrePhotoVideo();
                await _cameraService.TakePhotoAsync(i);
                TakingPhotoClipPath = _assetsHelper.GetPostPhotoVideo();
                await _cameraService.SavePhotoAsync(i);
            }
        }
    }
}
