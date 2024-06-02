using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;
using Project1.ViewModels;

namespace Project1.Controllers
{
    public class NewTrainerController : VerifyUserRoles
    {
        private readonly UserManager<ProjectUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ProjectDbContext _context;

        public NewTrainerController(UserManager<ProjectUser> userManager, SignInManager<ProjectUser> signInManager, RoleManager<ApplicationRole> roleManager, ProjectDbContext context) : base(userManager, signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        // GET: NewTrainer
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trainer.ToListAsync());
        }

        // GET: NewTrainer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainer
                .FirstOrDefaultAsync(m => m.TrainerID == id);
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }

        // GET: NewTrainer/Create
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }

            var member = _context.Member.FirstOrDefault(m => m.AspID == user.Id);
            if (member == null)
            {
                return NotFound("Member not found");
            }

            var model = new Trainer
            {
                MemberID = member.MemberID,
                TrainerName = member.Name,
                Status = "尚未審核" // 設置審核狀態為"尚未審核"
            };
            return View(model);
        }

        // POST: NewTrainer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TrainerID,MemberID,TrainerName,SpecializationID,Experience,Qualifications,Status,Photo")] Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return NotFound();
                }

                var member = _context.Member.FirstOrDefault(m => m.AspID == user.Id);
                if (member == null)
                {
                    return NotFound("Member not found");
                }

                trainer.MemberID = member.MemberID;

                _context.Add(trainer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            return View(trainer);
        }

        // GET: NewTrainer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainer.FindAsync(id);
            if (trainer == null)
            {
                return NotFound();
            }
            return View(trainer);
        }

        // POST: NewTrainer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TrainerID,MemberID,TrainerName,SpecializationID,Experience,Qualifications,Status,Photo")] Trainer trainer)
        {
            if (id != trainer.TrainerID)
            {
                return NotFound();
            }

           

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainerExists(trainer.TrainerID))
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
            return View(trainer);
        }

        // GET: NewTrainer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainer
                .FirstOrDefaultAsync(m => m.TrainerID == id);
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }

        // POST: NewTrainer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainer = await _context.Trainer.FindAsync(id);
            if (trainer != null)
            {
                _context.Trainer.Remove(trainer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainerExists(int id)
        {
            return _context.Trainer.Any(e => e.TrainerID == id);
        }
    }
}
