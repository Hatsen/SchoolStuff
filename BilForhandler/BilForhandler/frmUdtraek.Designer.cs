namespace BilForhandler
{
    partial class frmUdtraek
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTilbage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 212);
            this.listBox1.TabIndex = 0;
            // 
            // btnTilbage
            // 
            this.btnTilbage.Location = new System.Drawing.Point(197, 221);
            this.btnTilbage.Name = "btnTilbage";
            this.btnTilbage.Size = new System.Drawing.Size(75, 23);
            this.btnTilbage.TabIndex = 1;
            this.btnTilbage.Text = "&Tilbage";
            this.btnTilbage.UseVisualStyleBackColor = true;
            this.btnTilbage.Click += new System.EventHandler(this.btnTilbage_Click);
            // 
            // frmUdtraek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnTilbage);
            this.Controls.Add(this.listBox1);
            this.Name = "frmUdtraek";
            this.Text = "frmUdtraek";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTilbage;
    }
}