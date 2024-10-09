using Aspdotnet.Model;
using Aspdotnet.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageWebApp.Pages
{
    public class EditPageModel : PageModel
    {
        IProductService productService;
        public EditPageModel(IProductService productService)
        {
            this.productService = productService;
        }
        public Product Product { get; set; }
        public void OnGet(int productId)
        {
            Product = productService.GetProductById(productId);
        }

        //after save redirect to the page mentioned
        public ActionResult OnPost(Product product)
        {
            Product = productService.EditProduct(product);
            //return Page("");
            return Redirect("./ProductList");

		}
        
    }
}
