﻿using System;
using System.Collections.Generic;

namespace Parent.MSACommerce.Model
{
	public partial class TbSpecGroup
	{
		public long Id { get; set; }
		public long Cid { get; set; }
		public string Name { get; set; }

		public List<TbSpecParam> Params = new List<TbSpecParam>();
	}
}
