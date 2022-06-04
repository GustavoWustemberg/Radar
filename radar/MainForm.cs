/*
 * Created by SharpDevelop.
 * User: Mateus Moreira
 * Date: 27/09/2021
 * Time: 20:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace radar
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();	
		}
		void Button1Click(object sender, EventArgs e)
		{
			float p1, p2, t, vm;
			p1 = float.Parse(textBox1.Text);
			p2 = float.Parse(textBox2.Text);
			t = float.Parse(textBox3.Text);
			vm = (p2 - p1)/t;
			label6.Text = ("A Sua velocidade foi: " + vm + " Km/h").ToString();
				
			if(vm <= 80){
			
				label7.Text = ("Você está dentro do limite " +
				               "de velocidade.").ToString();
				pictureBox2.Load("poze.jpg");
				
				
			} else{
			
				label7.Text = ("Você está acima do limite" +
			               	   "de velocidade.").ToString();
				pictureBox2.Load("irmão.jpg");
			}
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
	}
}
