/*
 * Creado por SharpDevelop.
 * Usuario: CJ
 * Fecha: 01/04/2014
 * Hora: 12:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
namespace Presentacion
{
	/// <summary>
	/// Description of clsDialogos.
	/// </summary>
	public class clsDialogos
	{
		public clsDialogos()
		{
			
		}
		public static void MensajeExito(String titulo,String contenido){
			MessageBox.Show(contenido,titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		public static void MensajeError(String titulo,String contenido){
			MessageBox.Show(contenido,titulo,MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
	}
}
