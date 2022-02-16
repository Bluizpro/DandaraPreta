using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dandara2.Models;

namespace Dandara2.Controllers
{
    public class CadastroVendedorsController : Controller
    {
        private readonly Context _context;

        public CadastroVendedorsController(Context context)
        {
            _context = context;
        }

        // GET: CadastroVendedors
        public async Task<IActionResult> Index()
        {
            return View(await _context.CadastroVendedor.ToListAsync());
        }

        // GET: CadastroVendedors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroVendedor = await _context.CadastroVendedor
                .FirstOrDefaultAsync(m => m.id == id);
            if (cadastroVendedor == null)
            {
                return NotFound();
            }

            return View(cadastroVendedor);
        }

        // GET: CadastroVendedors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroVendedors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Email,Nome,Sobrenome,CPF,RG,Endereco,Bairro,Cidade,Telefone,Estado")] CadastroVendedor cadastroVendedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroVendedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroVendedor);
        }

        // GET: CadastroVendedors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroVendedor = await _context.CadastroVendedor.FindAsync(id);
            if (cadastroVendedor == null)
            {
                return NotFound();
            }
            return View(cadastroVendedor);
        }

        // POST: CadastroVendedors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Email,Nome,Sobrenome,CPF,RG,Endereco,Bairro,Cidade,Telefone,Estado")] CadastroVendedor cadastroVendedor)
        {
            if (id != cadastroVendedor.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroVendedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroVendedorExists(cadastroVendedor.id))
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
            return View(cadastroVendedor);
        }

        // GET: CadastroVendedors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroVendedor = await _context.CadastroVendedor
                .FirstOrDefaultAsync(m => m.id == id);
            if (cadastroVendedor == null)
            {
                return NotFound();
            }

            return View(cadastroVendedor);
        }

        // POST: CadastroVendedors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cadastroVendedor = await _context.CadastroVendedor.FindAsync(id);
            _context.CadastroVendedor.Remove(cadastroVendedor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroVendedorExists(int id)
        {
            return _context.CadastroVendedor.Any(e => e.id == id);
        }
    }
}
