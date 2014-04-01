/*
 * Creado por SharpDevelop.
 * Usuario: CJ
 * Fecha: 31/03/2014
 * Hora: 11:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Presentacion
{
	partial class frmNuevoUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoUsuario));
			this.btnOk = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtContra = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(103, 142);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(109, 31);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "LISTO!";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(0, 39);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(100, 36);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "Nombre";
			this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblContraseña
			// 
			this.lblContraseña.Location = new System.Drawing.Point(0, 84);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(100, 32);
			this.lblContraseña.TabIndex = 2;
			this.lblContraseña.Text = "Contraseña";
			this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(103, 39);
			this.txtNombre.Multiline = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(166, 36);
			this.txtNombre.TabIndex = 3;
			// 
			// txtContra
			// 
			this.txtContra.Location = new System.Drawing.Point(103, 81);
			this.txtContra.Multiline = true;
			this.txtContra.Name = "txtContra";
			this.txtContra.PasswordChar = '*';
			this.txtContra.Size = new System.Drawing.Size(166, 35);
			this.txtContra.TabIndex = 4;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStrip1.Size = new System.Drawing.Size(313, 25);
			this.toolStrip1.TabIndex = 5;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// frmNuevoUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 205);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.txtContra);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblContraseña);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.btnOk);
			this.MaximizeBox = false;
			this.Name = "frmNuevoUsuario";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "NUEVO";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TextBox txtContra;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button btnOk;
	}
}
