using ElectricStore_Datnt.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
	public class ProductService : ServiceBase<Product>
	{

		public IQueryable<Product> GetAll()
		{
			return _context.Products.Include(p => p.Category);
		}
	}
}
