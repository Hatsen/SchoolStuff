namespace Pacman
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnTilslut = new System.Windows.Forms.Button();
            this.btnAfslut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 47);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start spil";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(13, 78);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(141, 48);
            this.btnServer.TabIndex = 1;
            this.btnServer.Text = "&Opret server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnTilslut
            // 
            this.btnTilslut.Location = new System.Drawing.Point(13, 142);
            this.btnTilslut.Name = "btnTilslut";
            this.btnTilslut.Size = new System.Drawing.Size(141, 49);
            this.btnTilslut.TabIndex = 2;
            this.btnTilslut.Text = "&Tilslut spil";
            this.btnTilslut.UseVisualStyleBackColor = true;
            this.btnTilslut.Click += new System.EventHandler(this.btnTilslut_Click);
            // 
            // btnAfslut
            // 
            this.btnAfslut.Location = new System.Drawing.Point(13, 208);
            this.btnAfslut.Name = "btnAfslut";
            this.btnAfslut.Size = new System.Drawing.Size(141, 42);
            this.btnAfslut.TabIndex = 3;
            this.btnAfslut.Text = "&Afslut";
            this.btnAfslut.UseVisualStyleBackColor = true;
            this.btnAfslut.Click += new System.EventHandler(this.btnAfslut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 264);
            this.Controls.Add(this.btnAfslut);
            this.Controls.Add(this.btnTilslut);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnTilslut;
        private System.Windows.Forms.Button btnAfslut;
    }
}