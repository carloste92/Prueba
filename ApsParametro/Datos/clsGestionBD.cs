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
using System;
using System.Globalization;

namespace Datos
{

	public class clsGestionBD
	{
		public clsGestionBD()
		{
			
		}
		
		/*Funcion que se encarga de instanciar y devolver un comando de tipo Text*/
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
		/*Funcion que se encarga de instanciar y devolver un comando de tipo Procedimiento*/
		public static SqlCommand CrearComandoProcedimiento(String PA)
		{
		    String cadconexion = clsConexion.cadconexion;
		    SqlConnection Con = new SqlConnection();
		 	Con.ConnectionString=cadconexion;
		 	SqlCommand Com= new SqlCommand(PA,Con);
		    Com = Con.CreateCommand();
		    Com.CommandType = CommandType.StoredProcedure;
		    Com.CommandText=PA;
		    return Com;
		}
		/*Funcion que se encarga de instanciar y devolver un comando ingresando una vista*/
		public static SqlCommand CrearComandoVista(String V)
		{
		    String cadconexion = clsConexion.cadconexion;
		    SqlConnection Con = new SqlConnection();
		 	Con.ConnectionString=cadconexion;
		 	SqlCommand Com= new SqlCommand("select * from "+V,Con);
		    Com = Con.CreateCommand();
		    return Com;
		}
		/*Funcion que se encarga de ejecutar un comando ingresado como parametro*/
		public static int EjecutarComando(SqlCommand Com)
		{
			try
    		{
		        Com.Connection.Open();
		        return Com.ExecuteNonQuery();
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
		/*Funcion que se encarga de devolver los resultados de una vista en un objeto Datareader*/
		public static SqlDataReader DevolverVista(String consulta)
		{
			SqlDataReader Lector;
    		try{
				SqlCommand Com=CrearComandoVista(consulta);
		        Com.Connection.Open();
		        Com.CommandText="select * from "+consulta;
		        Lector=Com.ExecuteReader();
    		}
   			catch (Exception ex)
		    { 
   				throw ex;
   			}
		    finally
    		{ 
		    	
		    }
    		return Lector;
		}
		
		/*Funcion que se encarga de devolver la salida de un Procedimiento Almacenado en un objeto Datareader*/
		public static SqlDataReader DevolverProcedimiento(SqlCommand Com)
		{
			SqlDataReader Lector;
    		try{
		        Com.Connection.Open();
		        Lector=Com.ExecuteReader();
    		}
   			catch (Exception ex)
		    { 
   				throw ex;
   			}
		    finally
    		{ 
		    	
		    }
    		return Lector;
		}
		
		/*Funcion que devuelve el resultado de una vista en un objeto datatable(necesario para los Datagridview :))*/
		public static DataTable DevolverProcedimiento(String vista )
		{
			DataTable tabla = new DataTable();
    		try{
		        Com.Connection.Open();
		        SqlDataAdapter adaptador = new SqlDataAdapter();
		        adaptador.SelectCommand = Com;
		        adaptador.Fill(tabla);
    		}
   			catch (Exception ex)
		    { 
   				throw ex;
   			}
		    finally
    		{ 
		    	Com.Connection.Close(); 
		    }
    		return tabla;
		}
	}
}
