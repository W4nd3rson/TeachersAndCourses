
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models.ViewModels
{
    public class TeatcherViewModel : PageModel
    {
        public Teatcher Teatcher { get; set; }

        [BindProperty]
        [Display(Name = "Cursos")]
        public IEnumerable<Course> Courses { get; set; }
    }
}
