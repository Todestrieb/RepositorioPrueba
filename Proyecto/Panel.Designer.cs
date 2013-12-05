/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 28/11/2013
 * Time: 07:08 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Panel
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(41, 55);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 74);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1Captura";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(226, 55);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 74);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2 RegisPagos";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(409, 55);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 71);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3 Consultas";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(139, 181);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 71);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4 Reportes";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(358, 182);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(114, 70);
			this.button5.TabIndex = 4;
			this.button5.Text = "button5 Catalogos";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(408, 359);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(114, 50);
			this.button6.TabIndex = 5;
			this.button6.Text = "button6 Salir";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// Panel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 432);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Panel";
			this.Text = "Panel";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
