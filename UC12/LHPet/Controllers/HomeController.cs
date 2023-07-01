using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Fulano1", "000.000.000-00", "email@1", "dog" );
        Cliente cliente2 = new Cliente(02, "Fulano2", "000.000.000-00", "email@1", "dog" );
        Cliente cliente3 = new Cliente(03, "Fulano3", "000.000.000-00", "email@1", "dog" );
        Cliente cliente4 = new Cliente(04, "Fulano4", "000.000.000-00", "email@1", "dog" );
        Cliente cliente5 = new Cliente(05, "Fulano5", "000.000.000-00", "email@1", "dog" );

        List<Cliente> listaClientes = new List<Cliente>();

        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;
    

        Fornecedor fornecedor1 = new Fornecedor(01, "Ciclano1", "000.000.000-00", "email@1");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ciclano2", "000.000.000-00", "email@1");
        Fornecedor fornecedor3 = new Fornecedor(03, "Ciclano3", "000.000.000-00", "email@1");
        Fornecedor fornecedor4 = new Fornecedor(04, "Ciclano4", "000.000.000-00", "email@1");
        Fornecedor fornecedor5 = new Fornecedor(05, "Ciclano5", "000.000.000-00", "email@1");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();

        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);
        
        ViewBag.listaFornecedores=listaFornecedores;


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
