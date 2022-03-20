using Photobox.IServices;
using Photobox.WPFClient.helper;
using System.Threading;
using System.Threading.Tasks;

namespace Photobox.ViewModels
{
    public class TakePhotoViewModel : BaseViewModel
    {
        private string _takingPhotoClipPath;

        public string TakingPhotoClipPath
        {
            get { return _takingPhotoClipPath; }
            set { _takingPhotoClipPath = value; }
        }

        ICameraService _cameraService;
        public TakePhotoViewModel(ICameraService cameraService)
        {
            TakingPhotoClipPath = @"E:\Source\Repos\Photobox\Photobox\assets\CountingDown.mp4";
            _cameraService = cameraService;
            TakePhotoAsync();
        }
        private async Task TakePhotoAsync()
        {
            for (int i = 0; i < 6; i++)
            {
                if (CanellationHelper.Instance.CancellationToken)
                    break;
                await _cameraService.TakePhotoAsync(i);
            }
        }
    }
}
