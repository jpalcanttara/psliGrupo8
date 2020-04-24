using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Identity.Entities;
using PUC.LDSI.MVC.Models;
using PUC.LDSI.Domain.Interfaces.Repository;

namespace PUC.LDSI.MVC.Controllers
{
    public class AvaliacaoController : BaseController
    {

        private readonly IAvaliacaoAppService _avaliacaoAppService;
        private readonly IAvaliacaoRepository _avaliacaoRepository;

        public AvaliacaoController(UserManager<Usuario> user,
                                     IAvaliacaoAppService avaliacaoAppService,
                                     IAvaliacaoRepository avaliacaoRepository) : base(user)
        {
            _avaliacaoAppService = avaliacaoAppService;
            _avaliacaoRepository = avaliacaoRepository;
        }
        // GET: Avaliacao
        public async Task<IActionResult> Index()
        {
            var result = _avaliacaoRepository.ObterTodos();
            var avaliacoes = Mapper.Map<List<AvaliacaoViewModel>>(result.ToList());
            return View(avaliacoes);
        }




        // GET: Avaliacao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Avaliação/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProfessorId, Disciplina, Materia, Descricao, Id, DataCriacao")] AvaliacaoViewModel avaliacao)
        {
            if (ModelState.IsValid)
            {
                var result = await _avaliacaoAppService.AdicionarAvaliacaoAsync(UsuarioLogado.IntegrationId, avaliacao.disciplina, avaliacao.materia, avaliacao.Descricao);

                if (result.Success)
                    return RedirectToAction(nameof(Index));
                else
                    throw result.Exception;
            }
            return View(avaliacao);
        }

        // GET: Avaliacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacao = await _avaliacaoRepository.ObterAsync(id.Value);

            if (avaliacao == null)
            {
                return NotFound();
            }

            var viewModel = Mapper.Map<AvaliacaoViewModel>(avaliacao);

            return View(viewModel);
        }

        // POST: Avaliacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("ProfessorId,Disciplina,Materia,Descricao,Id,DataCriacao")] Avaliacao avaliacao)
        {
            if (id != avaliacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var result = await _avaliacaoAppService.AlterarAvaliacaoAsync(avaliacao.Id, avaliacao.Disciplina, avaliacao.Materia, avaliacao.Descricao);

                if (result.Success)
                    return RedirectToAction(nameof(Index));
                else
                    throw result.Exception;
            }
            return View(avaliacao);
        }

        // GET: Avaliacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacao = await _avaliacaoRepository.ObterAsync(id.Value);

            if (avaliacao == null)
            {
                return NotFound();
            }

            var viewModel = Mapper.Map<AvaliacaoViewModel>(avaliacao);

            return View(viewModel);
        }

        // POST: Avaliacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _avaliacaoAppService.ExcluirAsync(id);

            if (result.Success)
                return RedirectToAction(nameof(Index));
            else
                throw result.Exception;
        }
    }
}
