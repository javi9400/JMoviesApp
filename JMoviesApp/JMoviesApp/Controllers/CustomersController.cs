using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JMoviesApp.Context;
using JMoviesApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JMoviesApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly JMoviesAppContext _context;

        public CustomersController(JMoviesAppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList(); //eager loading

            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType)
                            .SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        public IActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel();
            viewModel.MembershipTypes = membershipTypes;
        
            return View(viewModel);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


    }
}