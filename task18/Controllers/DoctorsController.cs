using Microsoft.AspNetCore.Mvc;
using task18.Data;
using task18.Models;

namespace task18.Controllers
{
    public class DoctorsController : Controller
    {
        private ApplicationDBContext _context = new ApplicationDBContext();

        public IActionResult Index()
        {
            var doctors = _context.Doctors.ToList();
            return View(doctors);
        }
        
        public IActionResult CompleteAppointment(int doctorId)
        {
            var doctor = _context.Doctors.Find(doctorId);
            if (doctor!=null) return View(doctor);
            return RedirectToAction("NotFound");
        }
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
