using WebAppGrapQL.Models;

namespace WebAppGrapQL.Abstractions
{
    public interface IStorageService
    {
        IEnumerable<StorageDto> GetStorages();
        int AddStorage(StorageDto storage);
    }
}
