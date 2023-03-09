using Requisition.Model;
using System.Threading.Tasks;

namespace Requisition.IRepository
{
	public interface IAccountUserRepository : IGenericRepository<User>
	{
		public Task<User> GetByUsername(string username);
	}
}
