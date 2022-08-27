using Messanger.Server.Models;
using System.Threading.Tasks;

namespace Messanger.Server.Hubs
{
    public interface IMessageClient
    {
        Task Send(NewMessage message);
    }
}