namespace BilForhandler
{
    partial class frmMain
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
            this.txtRegNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaerke = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVaegt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbJa = new System.Windows.Forms.RadioButton();
            this.rbNej = new System.Windows.Forms.RadioButton();
            this.btnOpret = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUdtraek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegNr
            // 
            this.txtRegNr.Location = new System.Drawing.Point(10, 59);
            this.txtRegNr.Name = "txtRegNr";
            this.txtRegNr.Size = new System.Drawing.Size(128, 20);
            this.txtRegNr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrerings Nummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bil mærke:";
            // 
            // txtMaerke
            // 
            this.txtMaerke.Location = new System.Drawing.Point(12, 112);
            this.txtMaerke.Name = "txtMaerke";
            this.txtMaerke.Size = new System.Drawing.Size(126, 20);
            this.txtMaerke.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bilens vægt:";
            // 
            // btnVaegt
            // 
            this.btnVaegt.Location = new System.Drawing.Point(12, 162);
            this.btnVaegt.Name = "btnVaegt";
            this.btnVaegt.Size = new System.Drawing.Size(126, 20);
            this.btnVaegt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Afhængertræk?";
            // 
            // rbJa
            // 
            this.rbJa.AutoSize = true;
            this.rbJa.Location = new System.Drawing.Point(12, 215);
            this.rbJa.Name = "rbJa";
            this.rbJa.Size = new System.Drawing.Size(36, 17);
            this.rbJa.TabIndex = 7;
            this.rbJa.TabStop = true;
            this.rbJa.Text = "Ja";
            this.rbJa.UseVisualStyleBackColor = true;
            // 
            // rbNej
            // 
            this.rbNej.AutoSize = true;
            this.rbNej.Location = new System.Drawing.Point(12, 238);
            this.rbNej.Name = "rbNej";
            this.rbNej.Size = new System.Drawing.Size(41, 17);
            this.rbNej.TabIndex = 8;
            this.rbNej.TabStop = true;
            this.rbNej.Text = "Nej";
            this.rbNej.UseVisualStyleBackColor = true;
            // 
            // btnOpret
            // 
            this.btnOpret.Location = new System.Drawing.Point(6, 263);
            this.btnOpret.Name = "btnOpret";
            this.btnOpret.Size = new System.Drawing.Size(75, 23);
            this.btnOpret.TabIndex = 9;
            this.btnOpret.Text = "&Opret Bil";
            this.btnOpret.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birger Børges Bil-Biks";
            // 
            // btnUdtraek
            // 
            this.btnUdtraek.Location = new System.Drawing.Point(87, 263);
            this.btnUdtraek.Name = "btnUdtraek";
            this.btnUdtraek.Size = new System.Drawing.Size(75, 23);
            this.btnUdtraek.TabIndex = 11;
            this.btnUdtraek.Text = "&Udtræk Bil";
            this.btnUdtraek.UseVisualStyleBackColor = true;
            this.btnUdtraek.Click += new System.EventHandler(this.btnUdtraek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 291);
            this.Controls.Add(this.btnUdtraek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOpret);
            this.Controls.Add(this.rbNej);
            this.Controls.Add(this.rbJa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVaegt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaerke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegNr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaerke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox btnVaegt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbJa;
        private System.Windows.Forms.RadioButton rbNej;
        private System.Windows.Forms.Button btnOpret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUdtraek;
    }
}

