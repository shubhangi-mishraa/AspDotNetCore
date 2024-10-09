using Aspdotnet.Model;
using Aspdotnet.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageWebApp.Pages
{
    public class ProductlistModel : PageModel
    {
        // whenever the req is through url or hyperlink -  getrequest gets executed
        //[HttpGet] can also be used

        //no new instance is created to implement loose coupling
        //change in the program.cs file
        IProductService productService;
        public List<Product> Products { get; set; }
        public ProductlistModel(IProductService productService)
        {
            this.productService = productService;
        }
        public ActionResult OnPost(string productName)
        {

            Products = productService.GetProductByName(productName);
            if(Products == null)
            {
                return Redirect("./Error");
            }
            return Page();
        }
        public void OnGet()
        {
            Products = productService.GetProducts();
        }
    }
}
