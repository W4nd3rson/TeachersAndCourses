using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using TeatchersAndCourses.DataAccess.Context;
using DataAccess.Repository.IRepository;
using Domain.Models.ViewModels;
using Services.IServices;

namespace TeachersAndCourses.Controllers
{
    public class TeatchersController : Controller
    {
        private ITeatcherService teatcherService;
        private ICourseService courseService;
        public TeatchersController(
                                   ITeatcherService teatcherService,
                                   ICourseService courseService)
        {
            this.teatcherService = teatcherService;
            this.courseService = courseService;
        }

        // GET: Teatchers
        public async Task<IActionResult> Index()
        {
            return View(await teatcherService.GetAll());
        }

        // GET: Teatchers/Details/5
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }

                var teatcher = await teatcherService.GetAsyncById(id);


                if (teatcher == null)
                {
                    return NotFound();
                }

                return View(teatcher);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: Teatchers/Create
        public IActionResult Create()
        {
            var viewModel = new TeatcherViewModel() { Courses = courseService.GetAll().Result };

            return View(viewModel);
        }

        // POST: Teatchers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeatcherViewModel teatcherViewModel)
        {
            var coursesSelectedIds = new List<int>();
            var teatcher = new Teatcher() { Name = teatcherViewModel.Teatcher.Name };

            if (!string.IsNullOrEmpty(Request.Form["Courses"].ToString()))
            {
                coursesSelectedIds = Request.Form["Courses"].ToString().Split(',').Select(Int32.Parse).ToList();
                var courses = await courseService.GetByIdsAsync(coursesSelectedIds);

                foreach (var course in courses)
                {
                    var teatcherCourse = new TeatcherCourse { Teatcher = teatcherViewModel.Teatcher, Course = course };
                    teatcher.TeatcherCourses.Add(teatcherCourse);
                }
            }

            if (ModelState.IsValid)
            {
                await teatcherService.AddTeatcher(teatcher);
                return RedirectToAction(nameof(Index));
            }
            return View(teatcher);
        }

        // GET: Teatchers/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var teatcher = await teatcherService.GetAsyncById(id);

            if (teatcher == null)
            {
                return NotFound();
            }



            return View(teatcher);
        }

        // POST: Teatchers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id,CreationDate")] Teatcher teatcher)
        {
            if (id != teatcher.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await teatcherService.UpdateTeatcher(teatcher);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeatcherExists(teatcher.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(teatcher);
        }

        // GET: Teatchers/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var teatcher = await teatcherService.GetAsyncById(id);

            if (teatcher == null)
            {
                return NotFound();
            }

            return View(teatcher);
        }

        // POST: Teatchers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await teatcherService.DeleteTeatcher(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TeatcherExists(int id)
        {
            return teatcherService.GetAll().Result.Any(e => e.Id == id);
        }
    }
}
