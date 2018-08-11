using AspNetVS2017.Capitulo03.Mvc.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetVS2017.Capitulo03.Mvc.Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
          

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContatoViewModel viewModel) // O POST sempre tem como parametro de entrada a MODEL.
        {
            if (!ModelState.IsValid) //validação no back end tambem.
            {
                return View(viewModel);
            }

            var portfolioConnectionString = ConfigurationManager.ConnectionStrings["porftolioConnectionString"].ConnectionString;

            using (var conexao = new SqlConnection(portfolioConnectionString)) // conexão com o banco. 
            {
                conexao.Open(); //Abrindo conexao com o banco.

                const string instrucao = @"
                                         INSERT INTO [dbo].[Contato]
                                         ([Nome]
                                        ,[Email]
                                        ,[Mensagem])
                                         VALUES
                                        (@Nome
                                        ,@Email
                                        ,@Mensagem)
		                                             
";
                using (var comando = new SqlCommand(instrucao, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", viewModel.Nome);
                    comando.Parameters.AddWithValue("@Email", viewModel.Email);
                    comando.Parameters.AddWithValue("@Mensagem", viewModel.Mensagem);

                    comando.ExecuteNonQuery();
                }


                //conexao.Close();
            }

            ModelState.Clear();

            return View();
        }
    }
}