namespace CPR_program
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpPersoner = new System.Windows.Forms.GroupBox();
            this.txtResultKoen = new System.Windows.Forms.TextBox();
            this.txtResultNavn = new System.Windows.Forms.TextBox();
            this.btnBeregn = new System.Windows.Forms.Button();
            this.txtCPR = new System.Windows.Forms.TextBox();
            this.txtEfternavn = new System.Windows.Forms.TextBox();
            this.txtFornavn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPersoner.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aldersberegning";
            // 
            // grpPersoner
            // 
            this.grpPersoner.Controls.Add(this.txtResultKoen);
            this.grpPersoner.Controls.Add(this.txtResultNavn);
            this.grpPersoner.Controls.Add(this.btnBeregn);
            this.grpPersoner.Controls.Add(this.txtCPR);
            this.grpPersoner.Controls.Add(this.txtEfternavn);
            this.grpPersoner.Controls.Add(this.txtFornavn);
            this.grpPersoner.Controls.Add(this.label4);
            this.grpPersoner.Controls.Add(this.label3);
            this.grpPersoner.Controls.Add(this.label2);
            this.grpPersoner.Location = new System.Drawing.Point(30, 89);
            this.grpPersoner.Name = "grpPersoner";
            this.grpPersoner.Size = new System.Drawing.Size(422, 166);
            this.grpPersoner.TabIndex = 1;
            this.grpPersoner.TabStop = false;
            this.grpPersoner.Text = "Personoplysninger";
            // 
            // txtResultKoen
            // 
            this.txtResultKoen.Enabled = false;
            this.txtResultKoen.Location = new System.Drawing.Point(249, 88);
            this.txtResultKoen.Name = "txtResultKoen";
            this.txtResultKoen.Size = new System.Drawing.Size(167, 20);
            this.txtResultKoen.TabIndex = 8;
            // 
            // txtResultNavn
            // 
            this.txtResultNavn.Enabled = false;
            this.txtResultNavn.Location = new System.Drawing.Point(249, 45);
            this.txtResultNavn.Name = "txtResultNavn";
            this.txtResultNavn.Size = new System.Drawing.Size(167, 20);
            this.txtResultNavn.TabIndex = 7;
            // 
            // btnBeregn
            // 
            this.btnBeregn.Location = new System.Drawing.Point(170, 122);
            this.btnBeregn.Name = "btnBeregn";
            this.btnBeregn.Size = new System.Drawing.Size(75, 23);
            this.btnBeregn.TabIndex = 6;
            this.btnBeregn.Text = "&Beregn";
            this.btnBeregn.UseVisualStyleBackColor = true;
            this.btnBeregn.Click += new System.EventHandler(this.btnBeregn_Click);
            // 
            // txtCPR
            // 
            this.txtCPR.Location = new System.Drawing.Point(72, 95);
            this.txtCPR.Name = "txtCPR";
            this.txtCPR.Size = new System.Drawing.Size(100, 20);
            this.txtCPR.TabIndex = 5;
            // 
            // txtEfternavn
            // 
            this.txtEfternavn.Location = new System.Drawing.Point(72, 59);
            this.txtEfternavn.Name = "txtEfternavn";
            this.txtEfternavn.Size = new System.Drawing.Size(100, 20);
            this.txtEfternavn.TabIndex = 4;
            // 
            // txtFornavn
            // 
            this.txtFornavn.Location = new System.Drawing.Point(72, 32);
            this.txtFornavn.Name = "txtFornavn";
            this.txtFornavn.Size = new System.Drawing.Size(100, 20);
            this.txtFornavn.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cprnummer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Efternavn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fornavn:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 290);
            this.Controls.Add(this.grpPersoner);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aldersberegner";
            this.grpPersoner.ResumeLayout(false);
            this.grpPersoner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPersoner;
        private System.Windows.Forms.TextBox txtResultKoen;
        private System.Windows.Forms.TextBox txtResultNavn;
        private System.Windows.Forms.Button btnBeregn;
        private System.Windows.Forms.TextBox txtCPR;
        private System.Windows.Forms.TextBox txtEfternavn;
        private System.Windows.Forms.TextBox txtFornavn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

