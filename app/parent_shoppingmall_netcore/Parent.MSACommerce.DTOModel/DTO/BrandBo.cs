using System;
using System.Collections.Generic;
using System.Text;

namespace Parent.MSACommerce.Model.DTO
{

	public class BrandBo
	{
        public long id { get; set; }
		public string name { get; set; }
		public string image { get; set; }
		public List<long> cids { get; set; }
		public char letter { get; set; }

	}
}
