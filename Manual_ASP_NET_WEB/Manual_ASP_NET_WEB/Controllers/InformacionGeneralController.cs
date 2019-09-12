using Manual_ASP_NET_WEB.Models;
using Manual_ASP_NET_WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Manual_ASP_NET_WEB.Controllers
{
    public class InformacionGeneralController : Controller
    {
        //Establece la conexión con el modelo para poder ejecutar
        //consultas con linq
        private Manual_ASP_NET_DBEntities db = new Manual_ASP_NET_DBEntities();
        // GET: InformacionGeneral
        public ActionResult Index()
        {
            //Se obtienen los datos para mandarle a la vista
            //Se obtiene la cantidad de médicos registrados
            int cantidadMedicos = db.Medicos.Count();
            //Se obtiene la cantidad de pacientes registrados
            int cantidadPacientes = db.Pacientes.Count();
            //Se obtiene la cantidad de contultas registradas
            int cantidadConsultas = db.Consultas.Count();
            //Se crea el objeto con los datos obtenidos para
            //enviarle a la vista
            int cantidadMayor =  db.Pacientes.Where(Paciente => Paciente.Peso > 60).Count();
            var informacionObtenidaViewModel = new InformacionGeneralViewModel
            {
                CantidadMedicos = cantidadMedicos,
                CantidadPacientes = cantidadPacientes,
                CantidadConsultas = cantidadConsultas,
                CantidadMayor = cantidadMayor
             };
            //Se retorna la vista con la cantidad de medicos,
            //pacientes, y consultas actuales
             return View(informacionObtenidaViewModel);
        }
    }
}