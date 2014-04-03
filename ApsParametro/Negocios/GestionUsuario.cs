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
	/// <summary>
	/// Description of GestionUsuario.
	/// </summary>
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
			string Usuario=Datos.clsUsuario.ObtenerUsuario();

			return Usuario;
		}
	}
}
