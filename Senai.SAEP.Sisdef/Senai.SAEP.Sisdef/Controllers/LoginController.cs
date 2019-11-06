using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Senai.SAEP.Sisdef.Contextos;
using Senai.SAEP.Sisdef.Domains;

namespace Senai.SAEP.Sisdef.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly SisdefContext _context;

        public UsuarioController(SisdefContext context)
        {
            _context = context;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuario.ToListAsync());
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Usuario.FirstOrDefault(x => x.Email == usuario.Email && x.Senha == usuario.Senha);
                if(user == null)
                {
                    ViewBag.Erro = ("Usuario não existe");
                }
                
                HttpContext.Session.SetString("email", user.Email);
                return RedirectToAction("Create", "RegDef");
            }
            return View(usuario);
        }
    }
}
