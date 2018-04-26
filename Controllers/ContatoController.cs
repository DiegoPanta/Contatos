using System.Linq;
using Contatos.ContatoDataContext;
using Contatos.Models;
using Contatos.ViewModels.Contato;
using Microsoft.AspNetCore.Mvc;

namespace Contatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AppDataContext context;
        public ContatoController(AppDataContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public IActionResult Cadastrados()
        {
            var contatos = context.Contatos.ToList();
            return Json(contatos);
        }

        [HttpPost]
        public IActionResult Atualizar(AtualizarContatoViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            Contato contato = context.Contatos.Find(viewModel.Id);
            if (contato == null)
            {
                return Json("Contato não encontrado.");
            }
            contato.Nome = viewModel.Nome;
            contato.Telefone = viewModel.Telefone;
            contato.Email = viewModel.Email;

            context.Contatos.Update(contato);
            context.SaveChanges();
            return Json("Contato atualizado com sucesso");
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarContatoViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Contato contato = new Contato()
            {
                Nome = viewModel.Nome,
                Telefone = viewModel.Telefone,
                Email = viewModel.Email
            };
            context.Add(contato);
            context.SaveChanges();
            return Json("Contato cadastrado com sucesso");
        }

        [HttpPost]
        public IActionResult Remover(IdContatoViewModel viewModel)
        {
            Contato contato = context.Contatos.Find(viewModel.Id);
            if (contato == null)
            {
                return Json("Contato não encontrado.");
            }
            context.Contatos.Remove(contato);
            context.SaveChanges();
            return Json("Removido com sucesso");
        }

    }
}