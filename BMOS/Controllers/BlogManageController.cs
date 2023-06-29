﻿using BMOS.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using X.PagedList;

namespace Demo.Controllers
{
	public class BlogManageController : Controller
	{
		private readonly BmosContext _context;

		public BlogManageController(BmosContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> BlogManage(string sortOrder, string currentFilter, string searchString, int? page)
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

			var blogs = from s in _context.TblBlogs
						select s;
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
		public IActionResult Create()
		{
			return View();
		}
		public async Task<IActionResult> Details(string? id)
		{
			if (id == null || _context.TblBlogs == null)
			{
				return NotFound();
			}

			var tblBlog = await _context.TblBlogs
				.FirstOrDefaultAsync(m => m.BlogId == id);
			if (tblBlog == null)
			{
				return NotFound();
			}

			return View(tblBlog);
		}
		[HttpPost]
		public async Task<IActionResult> Create([Bind("BlogId, Name, Description, Date, Status")] TblBlog tblBlog)
		{
			if (ModelState.IsValid)
			{
				_context.TblBlogs.Add(tblBlog);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(BlogManage));
			}
			return View(tblBlog);
		}
		public async Task<IActionResult> Edit(string id)
		{
			if (id == null || _context.TblBlogs == null)
			{
				return NotFound();
			}

			var tblBlog = await _context.TblBlogs.FindAsync(id);
			if (tblBlog == null)
			{
				return NotFound();
			}
			return View(tblBlog);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(string id, [Bind("BlogId, Name, Description, Date, Status")] TblBlog tblBlog)
		{
			if (id != tblBlog.BlogId)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(tblBlog);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!TblBlogExists(tblBlog.BlogId))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(BlogManage));
			}
			return View(tblBlog);
		}

		private bool TblBlogExists(string blogId)
		{
			throw new NotImplementedException();
		}
		public async Task<IActionResult> Delete(string id)
		{
			if (id == null || _context.TblBlogs == null)
			{
				return NotFound();
			}

			var tblUser = await _context.TblBlogs
				.FirstOrDefaultAsync(m => m.BlogId == id);
			if (tblUser == null)
			{
				return NotFound();
			}

			return View(tblUser);
		}
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(string id)
		{
			if (_context.TblBlogs == null)
			{
				return Problem("Entity set 'BmosContext.TblBlogs'  is null.");
			}
			var tblBlog = await _context.TblBlogs.FindAsync(id);
			if (tblBlog != null)
			{
				_context.TblBlogs.Remove(tblBlog);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(BlogManage));
		}
	}
}
