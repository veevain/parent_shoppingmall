using System.Collections.Generic;
using Parent.MSACommerce.Model;
using Parent.MSACommerce.Model.DTO;

namespace Parent.MSACommerce.Interface
{
    public interface IGoodsService
    {
        PageResult<TbSpu> QuerySpuByPage(int page, int rows, string key, bool? saleable);

        TbSpuDetail QuerySpuDetailBySpuId(long spuId);

        List<TbSku> QuerySkuBySpuId(long spuId);

        void DeleteGoodsBySpuId(long spuId);

        void AddGoods(TbSpu spu);

        void UpdateGoods(TbSpu spu);

        void HandleSaleable(TbSpu spu);

        TbSpu QuerySpuBySpuId(long spuId);

        List<long> QuerySpuIdsPage(int page, int pageSize);
        List<TbSku> QuerySkusByIds(List<long> ids);

        void DecreaseStock(List<CartDto> cartDtos);


        List<SeckillGoods> QuerySeckillGoods();

        /**
         * 添加秒杀商品
         * @param seckillParameter
         */
        void AddSeckillGoods(SeckillParameter seckillParameter);
    }
}
