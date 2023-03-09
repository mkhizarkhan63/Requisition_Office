using Requisition.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Requisition.IRepository
{
	public interface IGenericRepository<T> where T : class
	{
		Task<T> Get(int id);
		Task<IEnumerable<T>> GetAll();
		Task<bool> Add(T entity);
		Task<bool> Delete(T id);
		Task<bool> Update(T entity);
	}
}
