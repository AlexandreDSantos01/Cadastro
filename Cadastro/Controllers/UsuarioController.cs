using Cadastro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Cadastro.Controllers
{
    public class UsuarioController : Controller
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        public IActionResult Create()

        {
            ViewBag.Sexos = Enum.GetValues(typeof(Usuario.Sexo));
            return View();
        }

        //Processa o cadastro
        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.IdUsuario = usuarios.Count + 1; //simula a criaçaõ de um ID
                usuarios.Add(usuario);
                return RedirectToAction("Index");
            }
            ViewBag.Sexos = Enum.GetValues(typeof(Usuario.Sexo));
            return View(usuario);
        }

        //Lista os usuarios cadastrados
        public IActionResult Index()
        {
            return View(usuarios);
        }




    }
}
