using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quadro_Operacional.Data;
using Quadro_Operacional.Models;

namespace Quadro_Operacional.Controllers
{
    public class QuadroController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuadroController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Quadro
        public async Task<IActionResult> Index()
        {
            return View(await _context.QUADRO_OPERACIONAL.ToListAsync());
        }

        // GET: Quadro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quadro = await _context.QUADRO_OPERACIONAL
                .FirstOrDefaultAsync(m => m.Matricula == id);
            if (quadro == null)
            {
                return NotFound();
            }

            return View(quadro);
        }

        // GET: Quadro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Operacao,Matricula,Funcionario,Onda,Ps,Logid,Situacao,Celula,Coordenador,Supervisor,Dt_Admissao,Funcao,Entrada,Saida,Intervalo,Dt_Desligamento,Genero,Estado_Civil,Escolaridade,Dt_Nascimento,Cpf,Rg,Uf,Cidade,Bairro,Celular,Dt_Experiencia,Dt_Experiencia_Pg,Dt_Contrato_Temp,Dt_Ferias,Dt_Ferias_Fim")] Quadro quadro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quadro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quadro);
        }

        // GET: Quadro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quadro = await _context.QUADRO_OPERACIONAL.FindAsync(id);
            if (quadro == null)
            {
                return NotFound();
            }
            return View(quadro);
        }

        // POST: Produto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Operacao,Matricula,Funcionario,Onda,Ps,Logid,Situacao,Celula,Coordenador,Supervisor,Dt_Admissao,Funcao,Entrada,Saida,Intervalo,Dt_Desligamento,Genero,Estado_Civil,Escolaridade,Dt_Nascimento,Cpf,Rg,Uf,Cidade,Bairro,Celular,Dt_Experiencia,Dt_Experiencia_Pg,Dt_Contrato_Temp,Dt_Ferias,Dt_Ferias_Fim")] Quadro quadro)
        {
            if (id != quadro.Matricula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quadro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuadroExists(quadro.Matricula))
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
            return View(quadro);
        }

        // GET: Produto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quadro = await _context.QUADRO_OPERACIONAL
                .FirstOrDefaultAsync(m => m.Matricula == id);
            if (quadro == null)
            {
                return NotFound();
            }

            return View(quadro);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quadro = await _context.QUADRO_OPERACIONAL.FindAsync(id);
            _context.QUADRO_OPERACIONAL.Remove(quadro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuadroExists(int id)
        {
            return _context.QUADRO_OPERACIONAL.Any(e => e.Matricula == id);
        }
    }
}
