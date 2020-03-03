using Microsoft.AspNetCore.Mvc;
using Phonebook.Data;
using Phonebook.Data.Models;
using System.Text.RegularExpressions;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            var namePattern = new Regex(@"^([A-Z][a-z]+)(( [A-Z][a-z]+){0,1}){0,2}$");
            var numPattern = new Regex(@"^(\+359|0)\d{9,}$");
            if (namePattern.IsMatch(contact.Name) && numPattern.IsMatch(contact.Number))
            {
                DataAccess.Contacts.Add(contact);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}