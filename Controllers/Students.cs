using EnrollmentSystem.Data;
using EnrollmentSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnrollmentSystem.Controllers
{
    public class Students : Controller
    {

        private readonly EnrollmentContext _context;

        public Students(EnrollmentContext context)
        {
            _context = context;
        }

        public IActionResult CallForm(string formDirectory)
        {
            return PartialView(formDirectory);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IEnumerable<EnrollmentSystem.Models.Entities.Students>> GetStudentsList()
        {
            return await _context.Students
                .Include(s => s.StudentSubjects)
                .ToListAsync();
        }

        [HttpPost]
        public async Task<ResultClass> SaveStudent(EnrollmentSystem.Models.Entities.Students _data)
        {
            var result = new ResultClass();

            try
            {
                await _context.Students.AddAsync(_data);
                await _context.SaveChangesAsync();

                result.Success = true;
                result.Message = "Student: " + _data.FirstName + " " + _data.LastName + "has been saved!";
            }catch (DbUpdateException ex)
            {
                result.Success = false;
                result.Message = "Error saving student: " + ex.Message;
            }
            catch(Exception ex)
            {
                result.Success = false;
                result.Message = "Something went wrong. An unexpected error occurred: " + ex.Message;
            }

            return result;
        }
    }
}
