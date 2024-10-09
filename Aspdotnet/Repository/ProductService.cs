using Aspdotnet.Model;

namespace Aspdotnet.Repository
{
	public class ProductService : IProductService
	{
		static List<Product> products = new List<Product>();
		static ProductService()
		{
			products.Add(new Product() { ProductId = 101, ProductName = "Product1", Price = 600 });
			products.Add(new Product() { ProductId = 102, ProductName = "Product2", Price = 1200 });
			products.Add(new Product() { ProductId = 103, ProductName = "Product3", Price = 340 });
			products.Add(new Product() { ProductId = 104, ProductName = "Product4", Price = 780 });
			products.Add(new Product() { ProductId = 105, ProductName = "Product5", Price = 400 });
			products.Add(new Product() { ProductId = 106, ProductName = "Product6", Price = 600 });
		}



		public Product GetProductById(int id)
		{
			return products.Where(p => p.ProductId == id).FirstOrDefault();
		}
		public List<Product> GetProductByName(string name)
		{
			return products.Where(p => p.ProductName == name).ToList();
		}
		public List<Product> GetProducts()
		{
			return products;
		}
		public Product EditProduct(Product product)
		{
			foreach (var item in products)
			{
				if (item.ProductId == product.ProductId)
				{
					item.ProductName = product.ProductName;
					item.Price = product.Price;
					return item;
				}
			}
			return null;
			//return products.Where(p => p.ProductId == id).FirstOrDefault();
		}

		public Product DeleteProduct(Product product)
		{
			throw new NotImplementedException();
		}
		//Product IProductService.GetProductById(int id)
		//{
		//	throw new NotImplementedException();
		//}
	}
}
