using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PUC.LDSI.DataBase.Repository
{
    public class PublicacaoRepository : Repository<Publicacao>, IPublicacaoRepository
    {
        private readonly AppDbContext _context;

        public PublicacaoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Publicacao> ObterAsync(int id)
        {
            var publicacao = await _context.Publicacao
                .Include(x => x.Avaliacao).ThenInclude(y => y.Provas)
                .Include(x => x.Turma)
                .FirstOrDefaultAsync(m => m.Id == id);

            return publicacao;
        }

        public Task<List<Publicacao>> ListarPublicacoesDoProfessorAsync(int professorId)
        {
            var publicacao = _context.Publicacao
                .Include(x => x.Avaliacao)
                .Include(x => x.Turma)
                .Where(x => x.Avaliacao.ProfessorId == professorId).ToListAsync();

            return publicacao;
        }

        public Task<List<Publicacao>> ListarPublicacoesDoAlunoAsync(int alunoId)
        {
            var publicacao = _context.Publicacao
                .Include(x => x.Avaliacao).ThenInclude(y => y.Provas)
                .Include(x => x.Turma).ThenInclude(y => y.Alunos)
                .Where(x => x.Turma.Alunos.Any(y => y.Id == alunoId)).ToListAsync();

            return publicacao;
        }
    }
}