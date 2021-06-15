using System.Collections.Generic;

namespace Parent.MSACommerce.Interface
{
	public interface IPageDetailService
	{
		public Dictionary<string, object> loadModel(long spuId);
	}
}
