namespace Ejercicio_09
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            button1 = new Button();
            lblresult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(259, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 0;
            label1.Text = "NÚMERO MAYOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(187, 91);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 1;
            label2.Text = "Número 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(187, 171);
            label3.Name = "label3";
            label3.Size = new Size(136, 37);
            label3.TabIndex = 2;
            label3.Text = "Número 2";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(187, 250);
            label4.Name = "label4";
            label4.Size = new Size(136, 37);
            label4.TabIndex = 3;
            label4.Text = "Número 3";
            // 
            // txt1
            // 
            txt1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(357, 91);
            txt1.Name = "txt1";
            txt1.Size = new Size(128, 43);
            txt1.TabIndex = 4;
            // 
            // txt2
            // 
            txt2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txt2.Location = new Point(357, 165);
            txt2.Name = "txt2";
            txt2.Size = new Size(128, 43);
            txt2.TabIndex = 5;
            // 
            // txt3
            // 
            txt3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txt3.Location = new Point(357, 244);
            txt3.Name = "txt3";
            txt3.Size = new Size(128, 43);
            txt3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(357, 324);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 7;
            button1.Text = "EJECUTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblresult.Location = new Point(318, 368);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(167, 46);
            lblresult.TabIndex = 8;
            lblresult.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblresult);
            Controls.Add(button1);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "EJECUTAR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private Button button1;
        private Label lblresult;
    }
}