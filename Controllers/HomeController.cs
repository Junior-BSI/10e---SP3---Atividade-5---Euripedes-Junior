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
        //instancias do tipo clientes
        Cliente cliente1 = new Cliente(01, "Eurípedes Júnior", "123.456.789-00", "euripedes.junior@aluno.senai.br", "Jimmy");
        Cliente cliente2 = new Cliente(02, "Ozzy Osborn", "569.478.001.56", "ozzy.ozzy@bol.com.br", "Mr. Crowley");
        Cliente cliente3 = new Cliente(03, "Robert Plant", "997.411.904-98", "rob-plant@gmail.br", "Tangerine");
        
        //Lista de Clientes e atribui os clientes
        List<Cliente> listaClientes = new List <Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);

        ViewBag.listaClientes = listaClientes;

        //instancias do tipo fornededor
        Fornecedor fornecedor1 = new Fornecedor(01, "Casa de Ração", "125454/0001-32", "casaderacao@bol.com,br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Pet Pet", "654987/0002-99", "Pet@bol.com.br");

        //Lista de Fornecedor e atribui os Fornecedores
        List<Fornecedor> listaFornecedores = new List <Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);

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
