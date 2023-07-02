using Microsoft.AspNetCore.Mvc.Rendering;

namespace BMOS.Models
{
    public class CreateRoutingByProductIdModel
    {
        public string SelectedProduct { get; set; }
        public List<SelectListItem> selectProductList { get; set; }

    }
}
