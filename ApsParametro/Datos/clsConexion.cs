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
	/// <summary>
	/// Description of clsConexion.
	/// </summary>
	public class clsConexion
	{
		static String _cadconexion=@"Data Source=ZAY;Initial Catalog=prueba;User ID=ZAY\CJ;Password=";
		public static String cadconexion{
			get{
				return _cadconexion;
			}
		}
	}
}
