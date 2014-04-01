/*
 * Created by SharpDevelop.
 * User: CJ
 * Date: 31/03/2014
 * Time: 5:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System.Data.SqlClient;
using System.Data;

namespace Datos
{
	/// <summary>
	/// Description of clsGestionBD.
	/// </summary>
	public class clsGestionBD
	{
		public clsGestionBD()
		{
			
		}
		public static SqlCommand CrearComando()
		{
		    String cadconexion = clsConexion.cadconexion;
		    SqlConnection Con = new SqlConnection();
		 	Con.ConnectionString=cadconexion;
		    SqlCommand Com= new SqlCommand();
		    Com = Con.CreateCommand();
		    Com.CommandType = CommandType.Text;
		    return Com;
		}
		public static SqlCommand CrearComandoProcedimiento(String PA)
		{
		    String cadconexion = clsConexion.cadconexion;
		    SqlConnection Con = new SqlConnection();
		 	Con.ConnectionString=cadconexion;
		    SqlCommand Com= new SqlCommand();
		    Com = Con.CreateCommand();
		    Com.CommandType = CommandType.StoredProcedure;
		    return Com;
		}
	}
}
