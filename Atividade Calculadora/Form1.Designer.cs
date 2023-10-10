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
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblOper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(37, 164);
            this.btnMais.Margin = new System.Windows.Forms.Padding(4);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(96, 32);
            this.btnMais.TabIndex = 0;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(200, 164);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(96, 32);
            this.btnMenos.TabIndex = 1;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(37, 215);
            this.btnMult.Margin = new System.Windows.Forms.Padding(4);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(96, 32);
            this.btnMult.TabIndex = 2;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(200, 215);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(96, 32);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(37, 77);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 29);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(196, 77);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 29);
            this.txt2.TabIndex = 5;
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Location = new System.Drawing.Point(163, 80);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(13, 21);
            this.lblOper.TabIndex = 6;
            this.lblOper.Text = ".";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 506);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMais;
        private Button btnMenos;
        private Button btnMult;
        private Button btnDiv;
        private TextBox txt1;
        private TextBox txt2;
        private Label lblOper;
    }
}