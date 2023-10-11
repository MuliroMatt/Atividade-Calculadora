namespace Atividade_Calculadora
{
    partial class Calculadora
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
            btnMais = new Button();
            btnMenos = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            txt1 = new TextBox();
            txt2 = new TextBox();
            lblOper = new Label();
            btnIgual = new Button();
            lblResultado = new Label();
            label1 = new Label();
            btnLimpar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnMais
            // 
            btnMais.Location = new Point(12, 123);
            btnMais.Margin = new Padding(4);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(96, 32);
            btnMais.TabIndex = 0;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = true;
            btnMais.Click += btnMais_Click;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(137, 123);
            btnMenos.Margin = new Padding(4);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(96, 32);
            btnMenos.TabIndex = 1;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(12, 163);
            btnMult.Margin = new Padding(4);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(96, 32);
            btnMult.TabIndex = 2;
            btnMult.Text = "X";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(137, 163);
            btnDiv.Margin = new Padding(4);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(96, 32);
            btnDiv.TabIndex = 3;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(12, 12);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 29);
            txt1.TabIndex = 4;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // txt2
            // 
            txt2.Location = new Point(137, 12);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 29);
            txt2.TabIndex = 5;
            txt2.TextChanged += txt2_TextChanged;
            // 
            // lblOper
            // 
            lblOper.AutoSize = true;
            lblOper.Location = new Point(118, 15);
            lblOper.Name = "lblOper";
            lblOper.Size = new Size(13, 21);
            lblOper.TabIndex = 6;
            lblOper.Text = ".";
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(137, 202);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(96, 32);
            btnIgual.TabIndex = 7;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(39, 59);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(13, 21);
            lblResultado.TabIndex = 8;
            lblResultado.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(21, 21);
            label1.TabIndex = 9;
            label1.Text = "=";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 202);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(96, 32);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 73);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 249);
            Controls.Add(label2);
            Controls.Add(btnLimpar);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(btnIgual);
            Controls.Add(lblOper);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnMenos);
            Controls.Add(btnMais);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMais;
        private Button btnMenos;
        private Button btnMult;
        private Button btnDiv;
        private TextBox txt1;
        private TextBox txt2;
        private Label lblOper;
        private Button btnIgual;
        private Label lblResultado;
        private Label label1;
        private Button btnLimpar;
        private Label label2;
    }
}