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
    public class ClienteCadastroesController : Controller
    {
        private readonly Context _context;

        public ClienteCadastroesController(Context context)
        {
            _context = context;
        }

        // GET: ClienteCadastroes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClienteCadastro.ToListAsync());
        }

        // GET: ClienteCadastroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteCadastro = await _context.ClienteCadastro
                .FirstOrDefaultAsync(m => m.id == id);
            if (clienteCadastro == null)
            {
                return NotFound();
            }

            return View(clienteCadastro);
        }

        // GET: ClienteCadastroes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClienteCadastroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Email,Nome,Sobrenome,CPF,Endereco,Bairro,Cidade,Telefone,Estado,Foto,CartaoCredito")] ClienteCadastro clienteCadastro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clienteCadastro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clienteCadastro);
        }

        // GET: ClienteCadastroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteCadastro = await _context.ClienteCadastro.FindAsync(id);
            if (clienteCadastro == null)
            {
                return NotFound();
            }
            return View(clienteCadastro);
        }

        // POST: ClienteCadastroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Email,Nome,Sobrenome,CPF,Endereco,Bairro,Cidade,Telefone,Estado,Foto,CartaoCredito")] ClienteCadastro clienteCadastro)
        {
            if (id != clienteCadastro.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clienteCadastro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteCadastroExists(clienteCadastro.id))
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
            return View(clienteCadastro);
        }

        // GET: ClienteCadastroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteCadastro = await _context.ClienteCadastro
                .FirstOrDefaultAsync(m => m.id == id);
            if (clienteCadastro == null)
            {
                return NotFound();
            }

            return View(clienteCadastro);
        }

        // POST: ClienteCadastroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clienteCadastro = await _context.ClienteCadastro.FindAsync(id);
            _context.ClienteCadastro.Remove(clienteCadastro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteCadastroExists(int id)
        {
            return _context.ClienteCadastro.Any(e => e.id == id);
        }
    }
}
