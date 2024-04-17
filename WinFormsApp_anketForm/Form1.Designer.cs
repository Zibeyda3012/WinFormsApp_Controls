namespace WinFormsApp_anketForm
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            Load_Button = new Button();
            panel2 = new Panel();
            label10 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            panel3 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            Save_Button = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Load_Button);
            panel1.Location = new Point(5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 41);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 27);
            textBox1.TabIndex = 1;
            // 
            // Load_Button
            // 
            Load_Button.BackColor = SystemColors.ActiveCaption;
            Load_Button.Location = new Point(312, 5);
            Load_Button.Name = "Load_Button";
            Load_Button.Size = new Size(94, 29);
            Load_Button.TabIndex = 0;
            Load_Button.Text = "Load";
            Load_Button.UseVisualStyleBackColor = false;
            Load_Button.Click += Load_Button_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(5, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 503);
            panel2.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 450);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 17;
            label10.Text = "Gender";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(133, 315);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(273, 27);
            textBox8.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 385);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 7;
            label9.Text = "Birthday";
            // 
            // panel3
            // 
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton1);
            panel3.Location = new Point(115, 440);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 37);
            panel3.TabIndex = 15;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(161, 10);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(18, 8);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 318);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 14;
            label8.Text = "Username";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(156, 380);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 256);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 12;
            label7.Text = "Phone number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 223);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 11;
            label6.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 190);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 10;
            label5.Text = "Country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 122);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 9;
            label4.Text = "Father";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 89);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 8;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 52);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 7;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 6;
            label1.Text = "Anket";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(133, 253);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(273, 27);
            textBox7.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(133, 220);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(273, 27);
            textBox6.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 187);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(273, 27);
            textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(133, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(273, 27);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(273, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 27);
            textBox2.TabIndex = 0;
            // 
            // Save_Button
            // 
            Save_Button.BackColor = SystemColors.ActiveCaption;
            Save_Button.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Save_Button.ForeColor = SystemColors.ActiveCaptionText;
            Save_Button.Location = new Point(12, 573);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(412, 37);
            Save_Button.TabIndex = 2;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = false;
            Save_Button.Click += Save_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 622);
            Controls.Add(Save_Button);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button Load_Button;
        private Panel panel2;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Panel panel3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button Save_Button;
        private Label label10;
        private TextBox textBox8;
    }
}
