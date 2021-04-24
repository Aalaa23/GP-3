using System.Threading.Tasks;

namespace Gp_3.Controllers
{
    internal interface IMessageService
    {
        Task Send(string email, string v1, string v2);
    }
}