/*
 * Created by SharpDevelop.
 * User: CJ
 * Date: 31/03/2014
 * Time: 4:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
	/// <summary>
	/// Description of frmLogin.
	/// </summary>
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//METODOS ADICIONALES
		private void DecidirInterfaz(){
			if(Negocios.GestionUsuario.ObtenerNumeroUsuarios()<1){
				new frmNuevoUsuario().Visible=true;
			}
		}
		private void AsignarUsuario(){
			lblUsuario.Text=Negocios.GestionUsuario.ObtenerUsuario();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		
		void FrmLoginLoad(object sender, EventArgs e)
		{
			DecidirInterfaz();
			AsignarUsuario();
		}
		
		void TstbtnConfigurarClick(object sender, EventArgs e)
		{
			DialogResult opcion=clsDialogos.DialogoInformacion("¿QUIERES SALIR?","¿Estas seguro que desear salir?");
			clsDialogos.DialogoSalir(opcion,this);
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			this.WindowState= FormWindowState.Minimized;		
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
	}
}
