using Aspdotnet.Model;

namespace Aspdotnet.Repository
{
	public interface IProductService
	{
		List<Product> GetProducts();
		Product GetProductById(int id);
		List<Product> GetProductByName(string name);
		Product EditProduct(Product product);
		Product DeleteProduct(Product product);
	}
}
