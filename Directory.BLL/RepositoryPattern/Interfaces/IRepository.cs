using Directory.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Directory.BLL.RepositoryPattern.Interfaces
{
	public interface IRepository<T> where T : BaseEntity  //IRepository methodları 
	{
		List<T> GetActives();
		T GetById(int id);
		void Add(T item);
		void Update(T item);
		void Delete(int id);
		List<T> GetByFilter(Expression<Func<T,bool>> filter);
		bool Any (Expression<Func<T,bool>> exp);


	}
}
