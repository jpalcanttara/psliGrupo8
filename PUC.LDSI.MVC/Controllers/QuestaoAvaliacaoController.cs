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
    public class QuestaoAvaliacaoController : Controller
    {
        private readonly AppDbContext _context;

        public QuestaoAvaliacaoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: QuestaoAvaliacao
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Questao.Include(q => q.Avaliacao);
            return View(await appDbContext.ToListAsync());
        }

        // GET: QuestaoAvaliacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questao = await _context.Questao
                .Include(q => q.Avaliacao)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questao == null)
            {
                return NotFound();
            }

            return View(questao);
        }

        // GET: QuestaoAvaliacao/Create
        public IActionResult Create()
        {
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "Id", "Descricao");
            return View();
        }

        // POST: QuestaoAvaliacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AvaliacaoId,Tipo,Enunciado,Id,DataCriacao")] Questao questao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "Id", "Descricao", questao.AvaliacaoId);
            return View(questao);
        }

        // GET: QuestaoAvaliacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questao = await _context.Questao.FindAsync(id);
            if (questao == null)
            {
                return NotFound();
            }
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "Id", "Descricao", questao.AvaliacaoId);
            return View(questao);
        }

        // POST: QuestaoAvaliacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AvaliacaoId,Tipo,Enunciado,Id,DataCriacao")] Questao questao)
        {
            if (id != questao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestaoExists(questao.Id))
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
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "Id", "Descricao", questao.AvaliacaoId);
            return View(questao);
        }

        // GET: QuestaoAvaliacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questao = await _context.Questao
                .Include(q => q.Avaliacao)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questao == null)
            {
                return NotFound();
            }

            return View(questao);
        }

        // POST: QuestaoAvaliacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questao = await _context.Questao.FindAsync(id);
            _context.Questao.Remove(questao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestaoExists(int id)
        {
            return _context.Questao.Any(e => e.Id == id);
        }
    }
}
