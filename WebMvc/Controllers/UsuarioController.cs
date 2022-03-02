
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Validators;
using System.Collections.Generic;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IBaseService<Usuario> _baseService;
        private readonly IMapper _mapper;
        public UsuarioController(IBaseService<Usuario> baseService, IMapper mapper)
        {
            this._baseService = baseService;
            this._mapper = mapper;
        }
        // GET: UsuarioController
        public ActionResult Index()
        {
            IEnumerable<Usuario> usuarios = _baseService.Get<Usuario>();

            var resultado = _mapper.Map<List<UsuarioViewModel>>(usuarios);

            return View(resultado);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Detalhes(int id)
        {
            Usuario usuario = _baseService.GetById<Usuario>(id);

            var resultado = _mapper.Map<UsuarioViewModel>(usuario);

            return View(resultado);
        }

        // GET: UsuarioController/Create
        public ActionResult Adicionar()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        public ActionResult Adicionar(Usuario usuario)
        {
            if (!ModelState.IsValid) return View(usuario);

            var u = _mapper.Map<UsuarioViewModel>(usuario);
            _baseService.Add<Usuario, UsuarioViewModel, UsuarioValidator>(usuario);

            if (usuario == null) return View(usuario);

            return RedirectToAction("Index");
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Editar(int id)
        {
            var usuarioViewModel = Detalhes(id);

            if (usuarioViewModel == null)
            {
                return NotFound();
            }

            return View(usuarioViewModel);


        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Usuario usuario)
        {
            if (id != usuario.Id) return NotFound();

            if (!ModelState.IsValid) return View(usuario);

            var usuarioMapper = _mapper.Map<UsuarioViewModel>(usuario);
            _baseService.Update<Usuario, UsuarioViewModel, UsuarioValidator>(usuario);

            if (usuario == null) return View(Detalhes(id));

            return RedirectToAction("Index");
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Excluir(int id)
        {
            if (id == 0) return NotFound();

            _baseService.Delete(id);
            return RedirectToAction("Index");
        }



    }
}
