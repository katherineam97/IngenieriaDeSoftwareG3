using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manual_ASP_NET_WEB.ViewModels
{
    //Modelo a utilizar en la vista de información general
    public class InformacionGeneralViewModel
    {
        //Cantidad de pacientes
        public int CantidadPacientes { get; set; }

        //Cantidad de médicos
        public int CantidadMedicos { get; set; }
        //Cantidad de consultas
        public int CantidadConsultas { get; set; }

        public int CantidadMayor { get; set; }
    }
}