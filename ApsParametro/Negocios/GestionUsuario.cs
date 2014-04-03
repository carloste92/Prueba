/*
 * Creado por SharpDevelop.
 * Usuario: CJ
 * Fecha: 31/03/2014
 * Hora: 11:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Negocios
{
	public class GestionUsuario
	{
		public GestionUsuario()
		{
			
		}
		
		public static int InsertarUsuario(String nombre,String contra){
			return Datos.clsUsuario.InsertarUsuario(nombre,contra);
		}
		public static int ObtenerNumeroUsuarios(){
			return Datos.clsUsuario.ObtenerNumeroUsuarios();
		}
		public static String ObtenerUsuario(){
			return Datos.clsUsuario.ObtenerUsuario();
		}
		public static int ValidarUsuario(String contra){
			return  Datos.clsUsuario.ValidarUsuario(contra);
		}
	}
}
