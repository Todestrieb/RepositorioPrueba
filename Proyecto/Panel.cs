
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
	
	public partial class Panel : Form
	{
		
		
		public Panel()
		{
			
			InitializeComponent();
			
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
            Polizas poliza = new Polizas();
            poliza.Show();
            this.Visible = false;
            
            
            
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Reportes reportes = new Reportes();
			reportes.Show();
			this.Visible = false;
		}
	}
}
