using System.Threading;
using System.Threading.Tasks;

namespace Photobox.IServices
{
    public interface ICameraService
    {
        public Task TakePhotoAsync(int theadId);
    }
}
