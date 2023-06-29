using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
	public class ProductModel
	{
		public int productId { get; set; }
		public string productName { get; set; }
		public string productCode { get; set; }
		public decimal? price { get; set; }
		public string date { get; set; }
		public int categoryId { get; set; }
		public string categoryName { get; set; }

	}
}
