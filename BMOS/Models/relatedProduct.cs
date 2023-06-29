using BMOS.Models.Entities;

namespace BMOS.Models
{

	public class relatedProduct
	{
		public string _id { get; set; }
		public List<TblProduct>? listProduct { get; set; }
		
		BmosContext _context { get; set; }

		public TblProduct getMainProduct()
		{
			var result = listProduct.SingleOrDefault(x => x.ProductId.Equals(this._id));
			return result;
		}

		public List<TblProduct> getRelateProduct(string id)
		{
			List<TblProduct> listRelated = new List<TblProduct>();
			foreach (var item in listProduct)
			{
				if (!item.ProductId.Equals(id))
				{
					listRelated.Add(item);
				}
			}
			return listRelated;
		}

		public bool ChangeLove(string id)
		{

			var result = _context.TblProducts.FirstOrDefault(x => x.ProductId.Equals(id));
			result.IsLoved = !result.IsLoved;
			_context.SaveChanges();
			return (bool)!result.IsLoved;

		}
	}


}
