using EnrollmentSystem.Data;
using EnrollmentSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnrollmentSystem.Controllers
{
    public class Subjects : Controller
    {
        private readonly EnrollmentContext _context;
        public Subjects(EnrollmentContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CallForm(string formDirectory)
        {
            return PartialView(formDirectory);
        }

        [HttpGet]
        public async Task<IEnumerable<EnrollmentSystem.Models.Entities.Subjects>> GetSubjectList()
        {
            return await _context.Subjects.ToListAsync();
        }

        public async Task<ActionResult<ResultClass>> AddSubject(EnrollmentSystem.Models.Entities.Subjects _data)
        {

            var result = new ResultClass();

            await _context.Subjects.AddAsync(_data);
            await _context.SaveChangesAsync();

            result.Success = true;
            result.Message = "Subject: " + _data.SubjectName + "has been saved!";

            return result;
        }
    }
}
