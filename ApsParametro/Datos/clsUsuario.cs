﻿/*
 * Creado por SharpDevelop.
 * Usuario: CJ
 * Fecha: 31/03/2014
 * Hora: 11:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System.Data.SqlClient;
using System.Data;
using System;

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
			return clsGestionBD.EjecutarComando(comando);
		}
		public static int ModificarUsuario(String nombre,String contra){
			SqlCommand comando=clsGestionBD.CrearComandoProcedimiento("PA_ModificarUsuario");
			comando.Parameters.AddWithValue("@nombre",nombre);
			comando.Parameters.AddWithValue("@contra",contra);
			return clsGestionBD.EjecutarComando(comando);
		}
		public static int ObtenerNumeroUsuarios(){
			int Num=clsGestionBD.DevolverVista("V_ObtenerUsuario").FieldCount;
			clsGestionBD.DevolverVista("V_ObtenerUsuario").Close();
			return Num ;
		}
		public static String ObtenerUsuario(){
			String usuario="";
			SqlDataReader lector=clsGestionBD.DevolverVista("V_ObtenerUsuario");
			while(lector.Read()){
				usuario=lector.GetString(0);
				break;
			}
			clsGestionBD.DevolverVista("V_ObtenerUsuario").Close();
			return usuario;
		}
		public static int ValidarUsuario(String contra){
			SqlCommand comando=clsGestionBD.CrearComandoProcedimiento("PA_ValidarUsuario");
			comando.Parameters.AddWithValue("@contraseña",contra);
			SqlDataReader lector=clsGestionBD.DevolverProcedimiento(comando);
			int resultado=0;
			while(lector.Read()){
				resultado++;
				break;
			}
			return resultado;
		}
	}
}
