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
		 	SqlCommand Com= new SqlCommand(PA,Con);
		    Com = Con.CreateCommand();
		    Com.CommandType = CommandType.StoredProcedure;
		    return Com;
		}
		public static Int16 EjecutarComando(SqlCommand Com)
		{
			try
    		{
		        Com.Connection.Open();
		        return comando.ExecuteNonQuery();
    		}
    		catch { 
				throw; 
			}
    		finally
    		{
        		Com.Connection.Dispose();
        		Com.Connection.Close();
    		}
		}
		public static DataTable EjecutarComandoSelect(SqlCommand Com){
			DataTable tabla = new DataTable();
    		try{
		        comando.Connection.Open();
		        SqlDataAdapter adaptador = new SqlDataAdapter();
		        adaptador.SelectCommand = comando;
		        adaptador.Fill(tabla);
    		}
   			catch (Exception ex)
		    { 
   				throw ex;
   			}
		    finally
    		{ 
		    	comando.Connection.Close(); }
    			return tabla;
			}
	}
}
