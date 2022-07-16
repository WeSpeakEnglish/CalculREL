/*
 * Created by SharpDevelop.
 * User: Pinus
 * Date: 15.09.2011
 * Time: 12:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CalculRel
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 128);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Резисторы из номинального ряда:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.maskedTextBox1);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(146, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(332, 151);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры расчёта";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.AsciiOnly = true;
			this.maskedTextBox1.BackColor = System.Drawing.SystemColors.Info;
			this.maskedTextBox1.BeepOnError = true;
			this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.maskedTextBox1.ForeColor = System.Drawing.Color.SteelBlue;
			this.maskedTextBox1.Location = new System.Drawing.Point(229, 53);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(97, 20);
			this.maskedTextBox1.TabIndex = 7;
			this.maskedTextBox1.Text = "0,5";
			this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1MaskInputRejected);
			// 
			// radioButton2
			// 
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton2.ForeColor = System.Drawing.Color.SaddleBrown;
			this.radioButton2.Location = new System.Drawing.Point(9, 79);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(214, 20);
			this.radioButton2.TabIndex = 5;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Расчёт соотношения R1/R2:";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton1.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton1.Location = new System.Drawing.Point(9, 53);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(226, 20);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Требуемое соотношение R1/R2:";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"E6 (±20%)",
									"E12 (±10%)",
									"E24 (±5%)",
									"E48 (±2%)",
									"E96 (±1%)",
									"E192 (±0.5%)"});
			this.comboBox1.Location = new System.Drawing.Point(219, 11);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(107, 24);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Text = "Ном. ряд";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.maskedTextBox3);
			this.groupBox2.Controls.Add(this.maskedTextBox2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(6, 70);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(320, 77);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// maskedTextBox3
			// 
			this.maskedTextBox3.AsciiOnly = true;
			this.maskedTextBox3.BackColor = System.Drawing.SystemColors.Info;
			this.maskedTextBox3.BeepOnError = true;
			this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.maskedTextBox3.Location = new System.Drawing.Point(223, 51);
			this.maskedTextBox3.Name = "maskedTextBox3";
			this.maskedTextBox3.Size = new System.Drawing.Size(75, 20);
			this.maskedTextBox3.TabIndex = 8;
			this.maskedTextBox3.Text = "3,3";
			this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.AsciiOnly = true;
			this.maskedTextBox2.BackColor = System.Drawing.SystemColors.Info;
			this.maskedTextBox2.BeepOnError = true;
			this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.maskedTextBox2.Location = new System.Drawing.Point(223, 29);
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(75, 20);
			this.maskedTextBox2.TabIndex = 8;
			this.maskedTextBox2.Text = "5,0";
			this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox2MaskInputRejected);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(3, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(195, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Напряжение с делителя (U2):";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(223, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Введите исходное напряжение (U1):";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 164);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(466, 124);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "Расcчёт будет здесь...";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.DarkMagenta;
			this.button1.Location = new System.Drawing.Point(13, 140);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Рассчитать!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(490, 300);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "CalculRel";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox3;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
