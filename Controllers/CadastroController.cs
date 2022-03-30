using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Controle.Models;
using Controle.Repositorio;

namespace Controle.Controllers
{
    public class CadastroControllers : Controller

        private readonly ICadastroRepositorio _cadastroRepositorio;

        public CadastroController (ICadastroRepositorio cadastroRepositorio)

    {
    }
    public IActionResult Criar()
    {
        return View();
    }

    public IActionResult Index()
        {
       List<CadastroModel> cadastro = _cadastroRepositorio.BuscarTodos();

            return View(cadastro);
        }
       
        public IActionResult Editar(int id)
        {
        CadastroModel cadastro = _cadastroRepositorio.ListarPorID(id);
            return View (cadastro);
        }

    public IActionResult Apagar(int id)

    {
        _cadastroRepositorio.Apagar(id);
        return RedirectToAction("Index");
    }

    public IActionResult ApagarConfirmar(int id)
    {
        CadastroModel cadastro = _cadastroRepositorio.ListarPorID(id);
        return View(cadastro);
    }
      



    [HttpPost]
    public public IActionResult Criar(CadastroModel cadastro)
    {
        if (ModelState.IsValid) 
        {
            _cadastroRepositorio.Adicionar(cadastro);

            return RedirectToActionResult("Index");
        }

        return View(cadastro);
    }

    [HttpPost]
    public public IActionResult Editar(CadastroModel cadastro)
    {
        if (ModelState.IsValid)
        {
            _cadastroRepositorio.Atualizar(cadastro);
            return RedirectToActionResult("Index");
        }
        return View(cadastro);
    }
}
