namespace Avis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBundt = new System.Windows.Forms.CheckBox();
            this.txtAntal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVægt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLøsAvis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBundter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUdregn = new System.Windows.Forms.Button();
            this.labPris = new System.Windows.Forms.Label();
            this.txtPrisTons = new System.Windows.Forms.TextBox();
            this.txtPrisLøsAvis = new System.Windows.Forms.TextBox();
            this.txtPrisBundter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labDato = new System.Windows.Forms.Label();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNavne = new System.Windows.Forms.ComboBox();
            this.lstAntal = new System.Windows.Forms.ListBox();
            this.btnSlet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBundt);
            this.groupBox1.Controls.Add(this.txtAntal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leverede enheder";
            // 
            // chkBundt
            // 
            this.chkBundt.AutoSize = true;
            this.chkBundt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBundt.Location = new System.Drawing.Point(219, 15);
            this.chkBundt.Name = "chkBundt";
            this.chkBundt.Size = new System.Drawing.Size(147, 17);
            this.chkBundt.TabIndex = 2;
            this.chkBundt.Text = "Er aviserne buntede?";
            this.chkBundt.UseVisualStyleBackColor = true;
            // 
            // txtAntal
            // 
            this.txtAntal.Location = new System.Drawing.Point(102, 12);
            this.txtAntal.Name = "txtAntal";
            this.txtAntal.Size = new System.Drawing.Size(85, 20);
            this.txtAntal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antal aviser:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVægt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLøsAvis);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBundter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(26, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Afregningsgrundlag";
            // 
            // txtVægt
            // 
            this.txtVægt.Enabled = false;
            this.txtVægt.Location = new System.Drawing.Point(465, 28);
            this.txtVægt.Name = "txtVægt";
            this.txtVægt.Size = new System.Drawing.Size(91, 20);
            this.txtVægt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vægt i kg =";
            // 
            // txtLøsAvis
            // 
            this.txtLøsAvis.Enabled = false;
            this.txtLøsAvis.Location = new System.Drawing.Point(328, 28);
            this.txtLøsAvis.Name = "txtLøsAvis";
            this.txtLøsAvis.Size = new System.Drawing.Size(18, 20);
            this.txtLøsAvis.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Antal løse aviser =";
            // 
            // txtBundter
            // 
            this.txtBundter.Enabled = false;
            this.txtBundter.Location = new System.Drawing.Point(111, 28);
            this.txtBundter.Name = "txtBundter";
            this.txtBundter.Size = new System.Drawing.Size(50, 20);
            this.txtBundter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Antal bundter =";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUdregn);
            this.groupBox3.Controls.Add(this.labPris);
            this.groupBox3.Controls.Add(this.txtPrisTons);
            this.groupBox3.Controls.Add(this.txtPrisLøsAvis);
            this.groupBox3.Controls.Add(this.txtPrisBundter);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(26, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Afregning";
            // 
            // btnUdregn
            // 
            this.btnUdregn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUdregn.Location = new System.Drawing.Point(481, 88);
            this.btnUdregn.Name = "btnUdregn";
            this.btnUdregn.Size = new System.Drawing.Size(75, 23);
            this.btnUdregn.TabIndex = 7;
            this.btnUdregn.Text = "Beregn";
            this.btnUdregn.UseVisualStyleBackColor = true;
            this.btnUdregn.Click += new System.EventHandler(this.btnUdregn_Click);
            // 
            // labPris
            // 
            this.labPris.AutoSize = true;
            this.labPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPris.Location = new System.Drawing.Point(359, 99);
            this.labPris.Name = "labPris";
            this.labPris.Size = new System.Drawing.Size(0, 13);
            this.labPris.TabIndex = 6;
            // 
            // txtPrisTons
            // 
            this.txtPrisTons.Enabled = false;
            this.txtPrisTons.Location = new System.Drawing.Point(185, 93);
            this.txtPrisTons.Name = "txtPrisTons";
            this.txtPrisTons.Size = new System.Drawing.Size(100, 20);
            this.txtPrisTons.TabIndex = 5;
            // 
            // txtPrisLøsAvis
            // 
            this.txtPrisLøsAvis.Enabled = false;
            this.txtPrisLøsAvis.Location = new System.Drawing.Point(185, 64);
            this.txtPrisLøsAvis.Name = "txtPrisLøsAvis";
            this.txtPrisLøsAvis.Size = new System.Drawing.Size(100, 20);
            this.txtPrisLøsAvis.TabIndex = 4;
            // 
            // txtPrisBundter
            // 
            this.txtPrisBundter.Enabled = false;
            this.txtPrisBundter.Location = new System.Drawing.Point(185, 38);
            this.txtPrisBundter.Name = "txtPrisBundter";
            this.txtPrisBundter.Size = new System.Drawing.Size(100, 20);
            this.txtPrisBundter.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Antal tons a\' 15 Kr.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Antal løse aviser a\' 0,1 Kr.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Antal bundter a\' 7 Kr.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Underline);
            this.label8.Location = new System.Drawing.Point(221, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Genbrugsaviser";
            // 
            // labDato
            // 
            this.labDato.AutoSize = true;
            this.labDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDato.Location = new System.Drawing.Point(472, 9);
            this.labDato.Name = "labDato";
            this.labDato.Size = new System.Drawing.Size(0, 13);
            this.labDato.TabIndex = 4;
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(128, 63);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.Size = new System.Drawing.Size(100, 20);
            this.txtNavn.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Indtast navn:";
            // 
            // cmbNavne
            // 
            this.cmbNavne.FormattingEnabled = true;
            this.cmbNavne.Location = new System.Drawing.Point(354, 63);
            this.cmbNavne.Name = "cmbNavne";
            this.cmbNavne.Size = new System.Drawing.Size(121, 21);
            this.cmbNavne.TabIndex = 7;
            this.cmbNavne.SelectedIndexChanged += new System.EventHandler(this.cmbNavne_SelectedIndexChanged);
            // 
            // lstAntal
            // 
            this.lstAntal.FormattingEnabled = true;
            this.lstAntal.Location = new System.Drawing.Point(538, -4);
            this.lstAntal.Name = "lstAntal";
            this.lstAntal.Size = new System.Drawing.Size(105, 56);
            this.lstAntal.TabIndex = 8;
            this.lstAntal.Visible = false;
            // 
            // btnSlet
            // 
            this.btnSlet.Location = new System.Drawing.Point(519, 60);
            this.btnSlet.Name = "btnSlet";
            this.btnSlet.Size = new System.Drawing.Size(75, 23);
            this.btnSlet.TabIndex = 9;
            this.btnSlet.Text = "Slet";
            this.btnSlet.UseVisualStyleBackColor = true;
            this.btnSlet.Click += new System.EventHandler(this.btnSlet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(640, 430);
            this.Controls.Add(this.btnSlet);
            this.Controls.Add(this.lstAntal);
            this.Controls.Add(this.cmbNavne);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNavn);
            this.Controls.Add(this.labDato);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBundt;
        private System.Windows.Forms.TextBox txtAntal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLøsAvis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBundter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVægt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUdregn;
        private System.Windows.Forms.Label labPris;
        private System.Windows.Forms.TextBox txtPrisTons;
        private System.Windows.Forms.TextBox txtPrisLøsAvis;
        private System.Windows.Forms.TextBox txtPrisBundter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labDato;
        private System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNavne;
        private System.Windows.Forms.ListBox lstAntal;
        private System.Windows.Forms.Button btnSlet;
    }
}

