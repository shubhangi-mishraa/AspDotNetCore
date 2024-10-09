using Aspdotnet.Model;
using Aspdotnet.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageWebApp.Pages
{
    public class PDetailsModel : PageModel
    {
        IProductService productService;
        public Product Product { get; set; }
        public PDetailsModel(IProductService productService)
        {
            this.productService = productService;
        }
        public void OnGet(int productId)
        {
           Product = productService.GetProductById(productId);
        }
    }
}
