using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHpet.Models;

namespace LHpet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()

    {   // Instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Rosimere Maira", "946.032.950-41", "Rosemaria@gmail.com","kuro");
        Cliente cliente2 = new Cliente(02, "Amos Pedro M da Silva", "857.032.950-41", "amospedrom@gmail.com","Quiiana");
        Cliente cliente3 = new Cliente(03, "Rute Souza", "857.000.950-41", "rute18@gmail.com","Miauzinho");
        Cliente cliente4 = new Cliente(04, "Severino", "753.032.980-41", "severino5@gmail.com","Talia");
        Cliente cliente5 = new Cliente(05, "Gerald D Rivia", "666.032.950-41", "geraldodrivia666@gmail.com","Carpiado");

        // instancias do tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Rações Recife LTDA", "14.182.102/00001-80","racoesrecife@hotmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Petsafe LTDA", "19.132.152/00001-60","petsafe@hotmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Produtospet LTDA", "23.882.302/00001-70","produtospet@hotmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Chanin LTDA", "89.322.160/00001-90","chaninhotmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "igienepet LTDA", "91.432.142/00001-55","igienepet@hotmail.com");


        // Lista de clientes

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        
        ViewBag.listaClientes = listaClientes;
        

         // Lista de fornecedores
        
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
