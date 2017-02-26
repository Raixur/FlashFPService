using FlashFP.Storage;
using Microsoft.Extensions.Options;

namespace FlashFPService.Services
{
    public class InMemoryStorageService : InMemoryStorage
    {
        public InMemoryStorageService(IOptions<InMemoryStorageOptions> options) : base(options.Value.DumpFile)
        {
        }
    }
}