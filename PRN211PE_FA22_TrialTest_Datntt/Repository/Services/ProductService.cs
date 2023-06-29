using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System.Linq;

namespace ElectricStore_Datnt.Services
{
	public class ProductService : ServicesBase<Product>
	{
		public IQueryable<Product> GetAll()
		{
			return _context.Products.Include(p => p.Category);
		}
	}
}
