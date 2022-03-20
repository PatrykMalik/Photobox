using Photobox.IServices;
using Photobox.WPFClient.helper;
using System.Threading;
using System.Threading.Tasks;

namespace Photobox.ViewModels
{
    public class TakePhotoViewModel : BaseViewModel
    {
        ICameraService _cameraService;
        public TakePhotoViewModel(ICameraService cameraService)
        {
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
