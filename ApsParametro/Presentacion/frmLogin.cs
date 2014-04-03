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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}
		
		//Metodos Adicionales
		private void DecidirInterfaz(){
			if(Negocios.GestionUsuario.ObtenerNumeroUsuarios()<1){
				new frmNuevoUsuario().Visible=true;
			}
		}
		private void AsignarUsuario(){
			lblUsuario.Text=Negocios.GestionUsuario.ObtenerUsuario();
		}
		
		//Eventos
		void Button1Click(object sender, EventArgs e)
		{
			int resultado=Negocios.GestionUsuario.ValidarUsuario(txtContraseña.Text);
			if(resultado==0){
				clsDialogos.MensajeExito("Contraseña Incorrecta","Vuelve a ingresar tu contraseña ;)");
			}else if(resultado==1){
				this.Visible=false;
				new frmCuentas().Visible=true;
			}
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
		
		void TstOpcionesItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}
	}
}
