using FlashFP;
using FlashFP.Storage;
using Microsoft.Extensions.Options;

namespace FlashFPService.Services
{
    public class FlashFpService : FlashFp
    {
        public FlashFpService(IOptions<FlashConfig> options, IStorage storage) : base(options.Value, storage)
        {
            
        }
    }
}