﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BMOS.Models.Entities;
using BMOS.Models;
using X.PagedList;

namespace BMOS.Controllers
{
    public class FeedbackManagerController : Controller
    {
        private readonly BmosContext _context;

        public FeedbackManagerController(BmosContext context)
        {
            _context = context;
        }

        // GET: FeedbackManager
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewData["SearchParameter"] = searchString;
            ViewBag.CurrentSort = sortOrder;
            ViewData["NameSortParm"] = sortOrder == "name" ? "name_desc" : "name";
            ViewData["PriceSortParm"] = sortOrder == "price" ? "price_desc" : "price";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;
            var feedback = from f in _context.TblFeedbacks
                           join p in _context.TblProducts on f.ProductId equals p.ProductId
                           //join u in _context.TblUsers on f.UserId equals u.UserId
                           select new FeedbackInfo()
                           {
                               FeedbackId = f.FeedbackId,
                               Name = p.Name,
                               Content = f.Content,
                               Star = f.Star,
                               date = f.Date,
                           };

            if (!String.IsNullOrEmpty(searchString))
            {
                feedback = feedback.Where(s => s.Name.Contains(searchString));
                int count = feedback.Count();
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
                    feedback = feedback.OrderBy(s => s.Name);
                    break;
                case "name_desc":
                    feedback = feedback.OrderByDescending(s => s.Name);
                    break;
                case "price":
                    feedback = feedback.OrderBy(s => s.Star);
                    break;
                case "price_desc":
                    feedback = feedback.OrderByDescending(s => s.Star);
                    break;
                default:
                    feedback = feedback.OrderBy(s => s.FeedbackId);
                    break;
            }
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(feedback.ToPagedList(pageNumber, pageSize));
        }
    

        // GET: FeedbackManager/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TblFeedbacks == null)
            {
                return NotFound();
            }
            var feedback = from f in _context.TblFeedbacks
                           join p in _context.TblProducts on f.ProductId equals p.ProductId
                           //join u in _context.TblUsers on f.UserId equals u.UserId
                           select new FeedbackInfo()
                           {
                               FeedbackId = f.FeedbackId,
                               Name = p.Name,
                               Content = f.Content,
                               Star = f.Star,
                               date = f.Date,
                           };
            var tblFeedback = await feedback
                .FirstOrDefaultAsync(m => m.FeedbackId == id);
            if (tblFeedback == null)
            {
                return NotFound();
            }

            return View(tblFeedback);
        }


        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.TblFeedbacks == null)
            {
                return NotFound();
            }

            var feedback = from f in _context.TblFeedbacks
                           join p in _context.TblProducts on f.ProductId equals p.ProductId
                           //join u in _context.TblUsers on f.UserId equals u.UserId
                           select new FeedbackInfo()
                           {
                               FeedbackId = f.FeedbackId,
                               Name = p.Name,
                               Content = f.Content,
                               Star = f.Star,
                               date = f.Date,
                           };

            var tblFeedback = await feedback
                .FirstOrDefaultAsync(m => m.FeedbackId == id);
            if (tblFeedback == null)
            {
                return NotFound();
            }

            return View(tblFeedback);
        }

        // POST: FeedbackManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var feedback = from f in _context.TblFeedbacks
                           join p in _context.TblProducts on f.ProductId equals p.ProductId
                           //join u in _context.TblUsers on f.UserId equals u.UserId
                           select new FeedbackInfo()
                           {
                               FeedbackId = f.FeedbackId,
                               Name = p.Name,
                               Content = f.Content,
                               Star = f.Star,
                               date = f.Date,
                           };
         
            var tblFeedback = await _context.TblFeedbacks
                .FirstOrDefaultAsync(m => m.FeedbackId == id);
            if (tblFeedback != null)
            {
                _context.TblFeedbacks.Remove(tblFeedback);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblFeedbackExists(string id)
        {
          return (_context.TblFeedbacks?.Any(e => e.FeedbackId == id)).GetValueOrDefault();
        }
    }
}