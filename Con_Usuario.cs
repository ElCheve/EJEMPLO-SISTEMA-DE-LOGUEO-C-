using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LogueoRecolector
{
    public class Con_Usuario
    {
        public static int CrearCuenta(string pUsuario, string pContraseña, string cedula)
        {
            int resultado = 0;
            try
            {
                SqlConnection conn = Conexionbd.ConectarBD();
                SqlCommand comando = new SqlCommand(string.Format("Insert Into RegistrarUsuario (usuario, constraseña, cedula) values ('{0}', PwdEncrypt('{1}'), '{2}')", pUsuario, pContraseña, cedula), conn);
                resultado = comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                SqlError err = ex.Errors[0];
                string mensajee;
                switch (err.Number)
                {
                    case 2627:
                        mensajee = "Este usuario ya existe";
                        break;
                    default:
                        mensajee = err.ToString();
                        break;
                }
                Console.WriteLine("Error con BBDD: {0}", mensajee);
            }
            return resultado;
        }
        /*public string validar(string usuario, string contraseña, string cedula)
        {
            bool validacion= false;
            string empleado = 0;
            SqlConnection connValidar = Conexionbd.ConectarBD();
            SqlCommand comando = new SqlCommand(string.Format("SELECT (usuario, contraseña, cedula) FROM RegistrarUsuario WHERE usuario='{0}' AND contraseña='{1}' AND cedula='{2}')", usuario, contraseña, cedula), connValidar);
            empleado = comando.ExecuteNonQuery();
            connValidar.Close();
            return empleado;
        }*/

    }
}
