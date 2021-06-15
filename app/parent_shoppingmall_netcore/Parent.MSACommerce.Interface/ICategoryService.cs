using System.Collections.Generic;
using Parent.MSACommerce.Model;

namespace Parent.MSACommerce.Interface
{
	public interface ICategoryService
	{

		List<TbCategory> QueryCategoryByPid(long pid);

		List<TbCategory> QueryCategoryByIds(List<long> ids);

		List<TbCategory> QueryAllByCid3(long id);
	}
}
