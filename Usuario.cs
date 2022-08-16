using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LogueoRecolector
{
    public class Usuario
    {
        public String cedula { get; set; }
        public String Usuarioo { get; set; }
        public String Contraseñaa { get; set; }
        public String NombreEmpleado { get; set; }
        public String ApellidoEmpleado { get; set; }
        public String Cargoo { get; set; }
        public String Telefono { get; set; }
        public String direccioncasa { get; set; }
        public String CorreoElectronicoo { get; set; } 

        public Usuario() { }
        public Usuario(String cc, String usu, String contra, String NE, String AE, String Puesto, String tel, String direcc, String correoE)
        {
            this.cedula = cc;
            this.Usuarioo = usu;
            this.Contraseñaa = contra;
            this.NombreEmpleado = NE;
            this.ApellidoEmpleado = AE;
            this.Cargoo = Puesto;
            this.Telefono = tel;
            this.direccioncasa = direcc;
            this.CorreoElectronicoo = correoE;
        }
    }
}
