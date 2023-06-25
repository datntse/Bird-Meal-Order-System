using BMOS.Models.Entities;
using System.Collections.Generic;
namespace BMOS.Models
{
    public class RelatedProductModel
    {
        public string _id { get; set; }
        public List<TblProduct>? listProduct { get; set; }


        public string getMainImage(string id)
        {
            foreach (var item in listProduct)
            {
                if (!item.ProductId.Equals(id))
                {
                    // get main image product.. add to view. and compete add to cart and check out.
                }
            }
            return listRelated;
        }
    }
}
