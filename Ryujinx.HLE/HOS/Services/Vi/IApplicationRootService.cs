using Ryujinx.HLE.HOS.Services.Vi.RootService;

namespace Ryujinx.HLE.HOS.Services.Vi
{
    [Service("vi:u")]
    class IApplicationRootService : IpcService
    {
        public IApplicationRootService(ServiceCtx context) : base(new ServerBase("ViServer")) { }

        [Command(0)]
        // GetDisplayService(u32) -> object<nn::visrv::sf::IApplicationDisplayService>
        public ResultCode GetDisplayService(ServiceCtx context)
        {
            int serviceType = context.RequestData.ReadInt32();

            MakeObject(context, new IApplicationDisplayService());

            return ResultCode.Success;
        }
    }
}