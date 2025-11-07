using Guia_Examen_13.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Examen_13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemaController : ControllerBase
    {
        static Sistema miEmpresa = new Sistema();
        // GET: api/<SistemaController>
        [HttpGet("camionesCargados")]
        public ActionResult<string[]> Get()
        {

            string[] lista = miEmpresa.CamionesCargados();

            if (lista.Length < 0)
            {
                throw new Exception("La lista esta vacia");
            }
            return Ok(lista);
        }

        [HttpPost("descargaCamion")]
        public ActionResult PostDescargarCamion(IFormFile manifiesto)
        {
            Stream s = manifiesto.OpenReadStream();
            miEmpresa.Descargar(s);
            return Ok();

        }
        [HttpGet("listaPaqietes")]
        public ActionResult<List<Paquete>> GetListaPaquetes()
        {
            return miEmpresa.listaPaquetes;
            return Ok();

        }

        [HttpGet("agregarPaqueteAlCamion/{posicion}")]
        public ActionResult<double> PostAgregarPaqueteAlCamion(int posicion)
        {

            Paquete paquete = null;

            paquete = BuscarPaquete("3");
            if (paquete == null) paquete = BuscarPaquete("2");
            if (paquete == null) paquete = BuscarPaquete("1");

            double pesoCamion = miEmpresa.CargarPaquete(posicion, paquete);

            return Ok(pesoCamion);
        }
        protected Paquete BuscarPaquete(string zona)
        {
            Paquete paquete = null;
            for (int i = 0; i < miEmpresa.listaPaquetes.Count && paquete == null; i++)
            {
                if (miEmpresa.listaPaquetes[i].ZonaDestino == zona)
                {
                    paquete = miEmpresa.listaPaquetes[i];
                }
            }

            return paquete;




        }
        [HttpGet("VerCargaCamion/{posicion}")]
        public ActionResult<List<Paquete>> GetVerCargaCamion(int posicion)
        {

          string [] lista= miEmpresa.VerCargaCamion(posicion);
            return Ok(lista);
        }
    }
}
