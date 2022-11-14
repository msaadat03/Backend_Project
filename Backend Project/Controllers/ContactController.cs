using Backend_Project.Data;
using Backend_Project.Models;
using Backend_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Contact contact = await _context.Contacts.Where(m => !m.IsDeleted).FirstOrDefaultAsync();
            SendMessage sendMessage = await _context.SendMessages.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

            ContactVM contactVM = new ContactVM
            {
                Contact = contact,
                SendMessage = new SendMessage()
            };


            return View(contactVM);
        }

        [HttpPost]
        public async Task<IActionResult> Index(SendMessage sendMessage)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction(nameof(Index));
                }

                bool isExist = await _context.SendMessages.AnyAsync(m =>
                m.Name.Trim() == sendMessage.Name.Trim() &&
                m.Email.Trim() == sendMessage.Email.Trim() &&
                m.Phone.Trim() == sendMessage.Phone.Trim() &&
                m.Message.Trim() == sendMessage.Message.Trim() &&
                m.Subject.Trim() == sendMessage.Subject.Trim());

                if (isExist)
                {
                    ModelState.AddModelError("Name", "Subject already exist!");
                }

                await _context.SendMessages.AddAsync(sendMessage);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
