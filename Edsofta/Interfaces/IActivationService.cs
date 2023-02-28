using System.Threading.Tasks;

namespace EdSofta.Interfaces
{
    internal interface IActivationService
    {
        Task<bool> activateByKeyAsync(string key);

        Task<bool> activateByPinAsync(string pin);

    }
}