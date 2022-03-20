using Autofac;
using Photobox.CameraService;
using Photobox.IServices;
using Photobox.ViewModels;
using System.Linq;

namespace Photobox.WPFClient
{
    public class ViewModelLocator
    {
        private readonly IContainer container;
        public ViewModelLocator()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterAssemblyTypes(typeof(BaseViewModel).Assembly)
                .Where(t => t.IsSubclassOf(typeof(BaseViewModel)));
            containerBuilder.RegisterType<Camera>().As<ICameraService>();
            container = containerBuilder.Build();
        }
        public ShellViewModel ShellViewModel => container.Resolve<ShellViewModel>();
        public StandByViewModel StandByViewModel => container.Resolve<StandByViewModel>();
        public ServiceMenuViewModel ServiceMenuViewModel => container.Resolve<ServiceMenuViewModel>();
        public LoopViewModel LoopViewModel => container.Resolve<LoopViewModel>();
        public TakePhotoViewModel TakePhotoViewModel => container.Resolve<TakePhotoViewModel>();
    }
}
