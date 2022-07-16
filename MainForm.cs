/*
 * Created by SharpDevelop.
 * User: Pinus
 * Date: 15.09.2011
 * Time: 12:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculRel
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Delitel Relation = new Delitel();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			radioButton1.Checked = true; // Отмеченный radio по умолчанию
			comboBox1.SelectedIndex=2;
		}
	//	Delitel Relation;// = new Delitel();
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		//	System.Windows.Forms.ComboBox.
		//  string StrCombo=		comboBox1.Text;
		switch (comboBox1.Text){
				case "E6 (±20%)" 	: 	Relation.LineIS=6; 		break;
				case "E12 (±10%)" 	: 	Relation.LineIS=12; 	break;
				case "E24 (±5%)" 	: 	Relation.LineIS=24; 	break;
				case "E48 (±2%)" 	: 	Relation.LineIS=48; 	break;
				case "E96 (±1%)" 	: 	Relation.LineIS=96; 	break;
				case "E192 (±0.5%)" : 	Relation.LineIS=192;	break; 
		}
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			if(radioButton1.Checked) Relation.TypeOfCalc =0;
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			if(radioButton2.Checked) Relation.TypeOfCalc =1;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Text = "Начинаем рассчёт..."+Environment.NewLine;
			switch (Relation.TypeOfCalc){
			 	case 0 : textBox1.Text += 	"Расcчёт ведётся по точному соотношению сопротивлений:"+Environment.NewLine+
			 								"R1/R2 eq " + maskedTextBox1.Text + Environment.NewLine;
			 		 					 				
			 	Relation.CalculateRelation(System.Convert.ToDouble(maskedTextBox1.Text));	break; // отправляем соотношение на расчёт
				case 1 : textBox1.Text += "Расcчёт ведётся по значениям напряжений:"+Environment.NewLine; 
						 Relation.CalculateRelation(System.Double.Parse(maskedTextBox2.Text)/System.Double.Parse(maskedTextBox3.Text)-1.0e0);	// отправляем соотношение на расчёт
						 textBox1.Text += "R1/R2 eq " + System.Convert.ToString(Relation.SourceW) + Environment.NewLine;
						 break;
						 
			}
			// выводим результат, используя преобразования в строку и округления
			double UpRelation = Relation.Up_Value_i/Relation.Up_Value_j; // "верхнее" соотношение
			double DownRelation = Relation.Down_Value_i/Relation.Down_Value_j; //"нижнее" соотношение
			
			textBox1.Text  += "Варианты:"+Environment.NewLine+
				Relation.Up_Value_i.ToString()+"/"+Relation.Up_Value_j.ToString()+" eq "+System.Convert.ToString(Math.Round(UpRelation,7))+" ("+ System.Convert.ToString(Math.Round((100*UpRelation)/Relation.SourceW,3)) +"%)"+Environment.NewLine +
			  	Relation.Down_Value_i.ToString()+"/"+Relation.Down_Value_j.ToString()+" eq "+System.Convert.ToString(Math.Round(DownRelation,7))+" ("+ System.Convert.ToString(Math.Round((100*DownRelation)/Relation.SourceW,3)) +"%)"+Environment.NewLine;
			if(Relation.TypeOfCalc==1){
				Relation.SetU1(System.Convert.ToDouble(maskedTextBox2.Text));
				Relation.GetU2(UpRelation);
				textBox1.Text  += "При напряжении на входе (U1="+maskedTextBox2.Text+"):"+Environment.NewLine+" напряжение на выходе в первом случае: U2 = "+System.Convert.ToString(Math.Round(Relation.U2,5))+Environment.NewLine;
				Relation.GetU2(DownRelation);
				textBox1.Text  += " во втором случае U2 = "+System.Convert.ToString(Math.Round(Relation.U2,5))+Environment.NewLine;
			}
			//корректируем метки
			double DifferenceUp=(Relation.SourceW-UpRelation > 0.0)? Relation.SourceW-UpRelation : UpRelation-Relation.SourceW ;   //разница с "верхним" соотношением
			double DifferenceDown = (Relation.SourceW-DownRelation > 0.0)? Relation.SourceW-DownRelation : DownRelation-Relation.SourceW ; // разница с "нижним" соотношением
			
				if(DifferenceUp < DifferenceDown){ // либо верхнее, если ближе
				label4.Text=System.Convert.ToString(Math.Round(Relation.Up_Value_i,7));
				label5.Text=System.Convert.ToString(Math.Round(Relation.Up_Value_j,7));
				}
				else{                               //либо нижнее 
				label4.Text=System.Convert.ToString(Math.Round(Relation.Down_Value_i,7));
				label5.Text=System.Convert.ToString(Math.Round(Relation.Down_Value_j,7));
			    }
		}
		
		void MaskedTextBox2MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			
		}
		
		void MaskedTextBox1MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("v0.9\nРасчет делителей из резисторов \nстандартных номинальных рядов\n\n заказы на прикладное программирование на fisitik@gmail.com:\n" +
			                " программирование микроконтроллеров MSP430;\n простые приложения на WinAPI;\n ручная вёрстка HTML+ JavaScript; \n дизайн лицевых панелей; \n трассировка ПП; \n проектирование принципиальных схем \n www.nir-nsk.ru","О программе CalculRel\n  by RA3TVD");
		}
		
	}
}
