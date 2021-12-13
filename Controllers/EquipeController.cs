using E_JOGOSS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_JOGOSS.Controllers
{
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            //viewbag -> armazena as informacoes do backend para serem acessadas pelo frontend. da controller para a view
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }



        /*public IActionResult Cadastrar(IFormCollection form)
        {

        }*/
    }
}
