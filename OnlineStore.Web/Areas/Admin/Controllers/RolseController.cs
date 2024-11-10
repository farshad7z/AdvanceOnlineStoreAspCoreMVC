using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineStore.BLL.Interfaces;
using OnlineStore.BLL.Services;
using OnlineStore.DAL.Context;
using OnlineStore.Core.Entities.Models;

namespace OnlineStore.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RolseController : Controller
    {
        private readonly IRolseServices _rolseServices;

        public RolseController(IRolseServices rolseServices)
        {
            _rolseServices = rolseServices;
        }

        // GET: Admin/Rolses
        public async Task<IActionResult> Index()
        {
            return View(await _rolseServices.GetAllRolseAsync());
        }

        // GET: Admin/Rolses/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var rolse =await _rolseServices.GetByRolseIdAsync(id);
            if (rolse == null)
            {
                return NotFound();
            }

            return View(rolse);
        }

        // GET: Admin/Rolses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Rolses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoleId,RoleTitle,RoleName")] Rolse rolse)
        {
            if (ModelState.IsValid)
            {
                 await _rolseServices.AddRolseAsync(rolse);
                return RedirectToAction(nameof(Index));
            }
            return View(rolse);
        }

        // GET: Admin/Rolses/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var rolse = await _rolseServices.GetByRolseIdAsync(id);
            if (rolse == null)
            {
                return NotFound();
            }
            return View(rolse);
        }

        // POST: Admin/Rolses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoleId,RoleTitle,RoleName")] Rolse rolse)
        {
            if (id != rolse.RoleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _rolseServices.UpdateRolseAsync(rolse);
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("", "There was an issue updating the role. Please try again.");

                }
                return RedirectToAction(nameof(Index));
            }
            return View(rolse);
        }

        // GET: Admin/Rolses/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
         
            var rolse = await _rolseServices.GetByRolseIdAsync(id);
              
            if (rolse == null)
            {
                return NotFound();
            }

            return View(rolse);
        }

        // POST: Admin/Rolses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rolse = await _rolseServices.DeleteRolseAsync(id);

            return RedirectToAction(nameof(Index));
        }

     }
}
