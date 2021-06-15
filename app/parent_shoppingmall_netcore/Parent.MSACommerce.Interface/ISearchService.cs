using Parent.MSACommerce.Model.Search;

namespace Parent.MSACommerce.Interface
{
	public interface ISearchService
	{
		SearchResult<Goods> search(SearchRequest searchRequest);
		public void ImpDataBySpu();
		public SearchResult<Goods> GetData(SearchRequest  searchRequest);
		public Goods GetGoodsBySpuId(long spuId);
	}
}
