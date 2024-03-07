using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    //Modelo clase del login
    public class CorreoDTO
    {
        public string Para { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }

    }
}