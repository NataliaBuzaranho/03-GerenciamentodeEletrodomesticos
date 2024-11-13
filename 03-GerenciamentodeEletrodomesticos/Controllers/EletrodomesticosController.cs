using _03_GerenciamentodeEletrodomesticos.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03_GerenciamentodeEletrodomesticos.Controllers
{
    public class EletrodomesticosController : Controller
    {
            public IActionResult Index()
            {
                List<Eletrodomestico> eletrodomestico = new List<Eletrodomestico>
            {
                new Geladeira { Marca = "Electrolux", Modelo = "Frost Free", ConsumoEnergetico = 35.3, CapacidadeLitros = 400, TemFreezer = true},
                new Televisor { Marca = "Samsung", Modelo = "Smart TV", ConsumoEnergetico = 145, TamanhoTela = 65, EhSmart = true},
                new Geladeira { Marca = "Brastemp", Modelo = "French Door 3 Portas", ConsumoEnergetico = 56.6, CapacidadeLitros = 554, TemFreezer = true},
            };
                return View(eletrodomestico);
            }
        }
    }
