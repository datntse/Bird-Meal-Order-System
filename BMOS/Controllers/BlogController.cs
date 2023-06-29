using BMOS.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace BMOS.Controllers
{
	public class BlogController : Controller
	{
		private readonly BmosContext _context;

		public BlogController(BmosContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Blog(string sortOrder, string currentFilter, string searchString, int? page)
		{
			ViewData["SearchParameter"] = searchString;
			ViewBag.CurrentSort = sortOrder;
			ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name" : "";
			ViewData["NameDescSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
			ViewData["DateSortParm"] = String.IsNullOrEmpty(sortOrder) ? "date" : "";
			ViewData["DateDescSortParm"] = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "";

			if (searchString != null)
			{
				page = 1;
			}
			else
			{
				searchString = currentFilter;
			}

			ViewBag.CurrentFilter = searchString;

			var blogs = from tblBlog in _context.TblBlogs where tblBlog.Status == true select tblBlog;
			if (!String.IsNullOrEmpty(searchString))
			{
				blogs = blogs.Where(s => s.Name.Contains(searchString));
				int count = blogs.Count();
				if (count == 0)
				{
					ViewBag.Message = "No matches found";
				}
				else
				{
					ViewBag.Message = "Có " + count + " kết quả tìm kiếm với từ khóa: " + searchString;
				}
			}


			switch (sortOrder)
			{
				case "name":
					blogs = blogs.OrderBy(s => s.Name);
					break;
				case "name_desc":
					blogs = blogs.OrderByDescending(s => s.Name);
					break;
				case "date":
					blogs = blogs.OrderBy(s => s.Date);
					break;
				case "date_desc":
					blogs = blogs.OrderByDescending(s => s.Date);
					break;
				default:
					blogs = blogs.OrderBy(s => s.BlogId);
					break;
			}
			int pageSize = 8;
			int pageNumber = (page ?? 1);
			return View(blogs.ToPagedList(pageNumber, pageSize));
		}


	}
}
