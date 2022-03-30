using Photobox.Helpers;
using Photobox.IServices;
using System.Threading.Tasks;
using System.Windows;

namespace Photobox.CameraService
{
    public class Camera : ICameraService
    {
        ///
        /// TO DO:
        /// 1. counting down
        /// 2. taking photo
        /// 3. saving animation
        /// 4. show last photo
        ///

        public async Task TakePhotoAsync(int theadId)
        {
            if (CanellationHelper.Instance.CancellationToken) 
                return;
            await CountingDownAnimationAsync(theadId);
            TakingPhotoAsync(theadId);
        }
        public async Task SavePhotoAsync(int theadId)
        {
            if (CanellationHelper.Instance.CancellationToken)
                return;
            SavingPhotoAsync(theadId);
            await SavingAnimationAsync(theadId);

        }
        private async Task CountingDownAnimationAsync(int theadId)
        {
            await Task.Delay(3000);
            MessageBox.Show("Counting Animation " + theadId.ToString() + " done");
        }
        private async Task TakingPhotoAsync(int theadId)
        {
            MessageBox.Show("Taking photo " + theadId);
            await Task.Delay(1);
        }
        private async Task SavingAnimationAsync(int theadId)
        {
            await Task.Delay(3000);
            MessageBox.Show("Saving Animation " + theadId.ToString() + " done");
        }
        private async Task SavingPhotoAsync(int theadId)
        {
            await Task.Delay(1);
            MessageBox.Show("Photo saved " + theadId);
        }       
    }
}
