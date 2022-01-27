using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpeakGlobal.Data;
using SpeakGlobal.Models;
using SpeakGlobal.Repository;
using SpeakGlobal.Repository.IRepository;

namespace SpeakGlobal.Areas.admin.Controllers
{
    [Area("admin")]
    public class ServiceController : Controller
    {
        //private readonly AppDbContext _context;
        private readonly IServiceRepository _serviceRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ServiceController(IServiceRepository serviceRepository, IWebHostEnvironment webHostEnvironment)
        {
            //_context = context;
            _serviceRepository = serviceRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: admin/Service
        public IActionResult Index()
        {
            return View(_serviceRepository.GetAll());
        }

        // GET: admin/Service/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var service = await _context.Services
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (service == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(service);
        //}

        //// GET: admin/Service/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: admin/Service/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(Service service)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (service.ImageFile != null && (service.ImageFile.ContentType == "image/jpeg" || service.ImageFile.ContentType == "image/png"))
        //        {
        //            if (service.ImageFile.Length <= 2097152)
        //            {
        //                string fileName = Guid.NewGuid() + "-" + service.ImageFile.FileName;
        //                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

        //                using (var stream = new FileStream(filePath, FileMode.Create))
        //                {
        //                    service.ImageFile.CopyTo(stream);
        //                }

        //                service.Image = fileName;
        //                _context.Add(service);
        //                await _context.SaveChangesAsync();
        //                return RedirectToAction(nameof(Index));
        //            }
        //        }
        //    }
        //    return View(service);
        //}

        //// GET: admin/Service/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var service = await _context.Services.FindAsync(id);
        //    if (service == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(service);
        //}

        //// POST: admin/Service/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Image,Title,Content")] Service service)
        //{
        //    if (id != service.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(service);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ServiceExists(service.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(service);
        //}

        //// GET: admin/Service/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var service = await _context.Services
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (service == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(service);
        //}

        //// POST: admin/Service/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var service = await _context.Services.FindAsync(id);
        //    _context.Services.Remove(service);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool ServiceExists(int id)
        //{
        //    return _context.Services.Any(e => e.Id == id);
        //}
    }
}
