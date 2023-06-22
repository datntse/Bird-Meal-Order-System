using System;
using System.Collections.Generic;
namespace BMOS.Models
{
	public class ProductInfoModel
	{
		public string ProductId { get; set; } = null!;

		public string? Name { get; set; }

		public double? Price { get; set; }

		public string? Description { get; set; }

		public bool? IsAvailable { get; set; }

		public bool? IsLoved { get; set; }

		public string? UrlImage { get; set; } 
	}
}
