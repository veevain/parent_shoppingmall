﻿using System;
using System.Collections.Generic;

namespace Parent.MSACommerce.Model
{
    public partial class TbStock
    {
        public long SkuId { get; set; }
        public int? SeckillStock { get; set; }
        public int? SeckillTotal { get; set; }
        public int Stock { get; set; }
    }
}
