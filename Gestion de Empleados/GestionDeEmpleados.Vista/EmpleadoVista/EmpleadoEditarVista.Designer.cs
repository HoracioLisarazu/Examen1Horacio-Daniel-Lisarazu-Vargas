namespace GestionDeEmpleados.Vista.EmpleadoVista
{
    partial class EmpleadoEditarVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox5 = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(389, 210);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(173, 23);
            textBox5.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(427, 355);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 21;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(389, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(389, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(389, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(389, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 255);
            label5.Name = "label5";
            label5.Size = new Size(152, 15);
            label5.TabIndex = 16;
            label5.Text = "FECHA DE CONTRATACION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 125);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 15;
            label3.Text = "APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 81);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 14;
            label4.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 213);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 13;
            label2.Text = "SALARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 169);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 12;
            label1.Text = "PUESTO";
            // 
            // EmpleadoEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmpleadoEditarVista";
            Text = "EmpleadoEditarVista";
            Load += EmpleadoEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}