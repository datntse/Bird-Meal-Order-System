using Microsoft.AspNetCore.Mvc.Rendering;

namespace BMOS.Models
{
    public class ProductInRoutingModel
    {
        public List<SelectListItem> productList { get; set; }
        public string[] productId { get; set; }    
    }
}
