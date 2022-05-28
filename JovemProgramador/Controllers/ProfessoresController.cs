using JovemProgramador.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace JovemProgramador.Controllers
{
    public class ProfessoresController : Controller
    {
        private readonly IConfiguration _configuration;

        public ProfessoresController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscarEndereco2(string cep)
        {
            EnderecoModel enderecoModel = new();

            try
            {
                cep = cep.Replace("-", "");

                using var client = new HttpClient();
                var result = await client.GetAsync(_configuration.GetSection("ApiCep")["BaseUrl"] + cep + "/json");

                if (result.IsSuccessStatusCode)
                {
                    enderecoModel = JsonSerializer.Deserialize<EnderecoModel>(
                        await result.Content.ReadAsStringAsync(), new JsonSerializerOptions() { });

                    //se cep.complemento for vazio atribui o valor "Nenhum" para variavel
                    if (enderecoModel.complemento == "")
                    {
                        enderecoModel.complemento = "Nenhum";

                    }
                }



                else
                {
                    ViewData["Mensagem"] = "Erro na busca do endereço!";
                    return View("Index");
                }
            }









            catch (Exception e)
            {

            }

            return View("BuscarEndereco2", enderecoModel);











        }
    }
}