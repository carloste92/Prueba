/*
 * Created by SharpDevelop.
 * User: CJ
 * Date: 29/03/2014
 * Time: 4:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace ApsParametro
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Int32 cargumentos=args.Length;
		
			System.Console.WriteLine("-M[String]\tMostrar una mensaje");
			
			for(Int16 a=0;a<args.Length;a++){
				MessageBox.Show(""+args[a].ToString(),"MOSTRANDO");
			}
			Application.Run(new MainForm());
		}
		
	}
}
