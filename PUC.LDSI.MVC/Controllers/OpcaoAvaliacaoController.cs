using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PUC.LDSI.DataBase;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.MVC.Controllers
{
    public class OpcaoAvaliacaoController : Controller
    {
        private readonly AppDbContext _context;

        public OpcaoAvaliacaoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OpcaoAvaliacao
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.OpcaoAvaliacao.Include(o => o.Questao);
            return View(await appDbContext.ToListAsync());
        }

        // GET: OpcaoAvaliacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcaoAvaliacao = await _context.OpcaoAvaliacao
                .Include(o => o.Questao)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opcaoAvaliacao == null)
            {
                return NotFound();
            }

            return View(opcaoAvaliacao);
        }

        // GET: OpcaoAvaliacao/Create
        public IActionResult Create()
        {
            ViewData["QuestaoId"] = new SelectList(_context.Questao, "Id", "Enunciado");
            return View();
        }

        // POST: OpcaoAvaliacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestaoId,Descricao,Verdadeira,Id,DataCriacao")] OpcaoAvaliacao opcaoAvaliacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opcaoAvaliacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QuestaoId"] = new SelectList(_context.Questao, "Id", "Enunciado", opcaoAvaliacao.QuestaoId);
            return View(opcaoAvaliacao);
        }

        // GET: OpcaoAvaliacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcaoAvaliacao = await _context.OpcaoAvaliacao.FindAsync(id);
            if (opcaoAvaliacao == null)
            {
                return NotFound();
            }
            ViewData["QuestaoId"] = new SelectList(_context.Questao, "Id", "Enunciado", opcaoAvaliacao.QuestaoId);
            return View(opcaoAvaliacao);
        }

        // POST: OpcaoAvaliacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestaoId,Descricao,Verdadeira,Id,DataCriacao")] OpcaoAvaliacao opcaoAvaliacao)
        {
            if (id != opcaoAvaliacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(opcaoAvaliacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpcaoAvaliacaoExists(opcaoAvaliacao.Id))
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
            ViewData["QuestaoId"] = new SelectList(_context.Questao, "Id", "Enunciado", opcaoAvaliacao.QuestaoId);
            return View(opcaoAvaliacao);
        }

        // GET: OpcaoAvaliacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcaoAvaliacao = await _context.OpcaoAvaliacao
                .Include(o => o.Questao)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opcaoAvaliacao == null)
            {
                return NotFound();
            }

            return View(opcaoAvaliacao);
        }

        // POST: OpcaoAvaliacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var opcaoAvaliacao = await _context.OpcaoAvaliacao.FindAsync(id);
            _context.OpcaoAvaliacao.Remove(opcaoAvaliacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpcaoAvaliacaoExists(int id)
        {
            return _context.OpcaoAvaliacao.Any(e => e.Id == id);
        }
    }
}
