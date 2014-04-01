/*
 * Creado por SharpDevelop.
 * Usuario: CJ
 * Fecha: 31/03/2014
 * Hora: 11:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
	/// <summary>
	/// Description of clsUsuario.
	/// </summary>
	public class clsUsuario
	{
		public clsUsuario()
		{
			
		}
		public static int InsertarUsuario(String nombre,String contra){
			SqlCommand comando=clsGestionBD.CrearComandoProcedimiento("PA_InsertarUsuario");
			comando.Parameters.AddWithValue("@nombre",nombre);
			comando.Parameters.AddWithValue("@contra",contra);
		}
		public static int ModificarUsuario(String nombre,String contra){
			SqlCommand comando=clsGestionBD.CrearComandoProcedimiento("PA_InsertarUsuario");
			comando.Parameters.AddWithValue("@nombre",nombre);
			comando.Parameters.AddWithValue("@contra",contra);
		}
		
	}
}
