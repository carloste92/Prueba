/*
 * Created by SharpDevelop.
 * User: CJ
 * Date: 31/03/2014
 * Time: 5:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Datos
{
	public class clsConexion
	{
		/*Cadenas de conexion para el SGBD Sql server
 		  @"Data Source=ZAY;Initial Catalog=prueba;User ID=ZAY\CJ;password=***"
		  @"Data Source=(local);Initial Catalog=prueba;Integrated Security=True"
		*/
		static String _cadconexion=@"Data Source=(local);Initial Catalog=prueba;Integrated Security=True";
		
		/*Accesos get/set a la propiedad cadconexion(cadena que especifica los parametros de conexion*/
		public static String cadconexion{
			get{
				return _cadconexion;
			}
		}
	}
}
