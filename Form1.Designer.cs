namespace Direct_Algorithms_Interface
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			textBox2 = new TextBox();
			label3 = new Label();
			textBox3 = new TextBox();
			label4 = new Label();
			comboBox1 = new ComboBox();
			label5 = new Label();
			textBox4 = new TextBox();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox1.Location = new Point(112, 16);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(225, 33);
			textBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 19);
			label1.Name = "label1";
			label1.Size = new Size(94, 24);
			label1.TabIndex = 1;
			label1.Text = "Функция:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial Rounded MT Bold", 15.75F);
			label2.Location = new Point(12, 72);
			label2.Name = "label2";
			label2.Size = new Size(171, 24);
			label2.TabIndex = 2;
			label2.Text = "Интервал поиска:";
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox2.Location = new Point(189, 69);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(47, 33);
			textBox2.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Arial Rounded MT Bold", 15.75F);
			label3.Location = new Point(242, 72);
			label3.Name = "label3";
			label3.Size = new Size(35, 24);
			label3.TabIndex = 4;
			label3.Text = "До";
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox3.Location = new Point(283, 69);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(47, 33);
			textBox3.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Arial Rounded MT Bold", 15.75F);
			label4.Location = new Point(12, 113);
			label4.Name = "label4";
			label4.Size = new Size(202, 24);
			label4.TabIndex = 6;
			label4.Text = "Метод оптимизации:";
			// 
			// comboBox1
			// 
			comboBox1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Метод перебора", "Метод дихотомии", "Метод золотого сечения", "Метод парабол", "Поразрядный поиск" });
			comboBox1.Location = new Point(220, 117);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(163, 23);
			comboBox1.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Arial Rounded MT Bold", 15.75F);
			label5.Location = new Point(12, 158);
			label5.Name = "label5";
			label5.Size = new Size(152, 24);
			label5.TabIndex = 8;
			label5.Text = "Шаг / Точность:";
			// 
			// textBox4
			// 
			textBox4.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox4.Location = new Point(170, 155);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(100, 33);
			textBox4.TabIndex = 9;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Arial Rounded MT Bold", 15.75F);
			label6.Location = new Point(12, 248);
			label6.Name = "label6";
			label6.Size = new Size(244, 24);
			label6.TabIndex = 10;
			label6.Text = "Минимум найден в точке:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Arial Rounded MT Bold", 15.75F);
			label7.Location = new Point(14, 279);
			label7.Name = "label7";
			label7.Size = new Size(35, 24);
			label7.TabIndex = 11;
			label7.Text = "X=";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Arial Rounded MT Bold", 15.75F);
			label8.Location = new Point(12, 314);
			label8.Name = "label8";
			label8.Size = new Size(186, 24);
			label8.TabIndex = 12;
			label8.Text = "Значение функции:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Arial Rounded MT Bold", 15.75F);
			label9.Location = new Point(12, 349);
			label9.Name = "label9";
			label9.Size = new Size(54, 24);
			label9.TabIndex = 13;
			label9.Text = "f(x)=";
			// 
			// button1
			// 
			button1.Font = new Font("Arial Rounded MT Bold", 15.75F);
			button1.Location = new Point(91, 203);
			button1.Name = "button1";
			button1.Size = new Size(203, 33);
			button1.TabIndex = 14;
			button1.Text = "Найти Минимум";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(394, 392);
			Controls.Add(button1);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(textBox4);
			Controls.Add(label5);
			Controls.Add(comboBox1);
			Controls.Add(label4);
			Controls.Add(textBox3);
			Controls.Add(label3);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Direct Algotithms App";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private Label label2;
		private TextBox textBox2;
		private Label label3;
		private TextBox textBox3;
		private Label label4;
		private ComboBox comboBox1;
		private Label label5;
		private TextBox textBox4;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Button button1;
	}
}
