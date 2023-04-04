
namespace WebLine
{
    partial class SEL
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
            this.lstSearchEngines = new System.Windows.Forms.ListBox();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lstSearchEngines
            // 
            this.lstSearchEngines.FormattingEnabled = true;
            this.lstSearchEngines.ItemHeight = 16;
            this.lstSearchEngines.Items.AddRange(new object[] {
            "https://www.google.com/search?q=",
            "https://www.bing.com/search?q=",
            "https://en.wikipedia.org/wiki/Special:Search?search="});
            this.lstSearchEngines.Location = new System.Drawing.Point(111, 47);
            this.lstSearchEngines.Name = "lstSearchEngines";
            this.lstSearchEngines.Size = new System.Drawing.Size(120, 84);
            this.lstSearchEngines.TabIndex = 1;
            this.lstSearchEngines.Visible = false;
            // 
            // flp
            // 
            this.flp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp.Location = new System.Drawing.Point(0, 0);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(296, 240);
            this.flp.TabIndex = 2;
            this.flp.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_Paint);
            // 
            // SEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 240);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.lstSearchEngines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SEL";
            this.Text = "SEL";
            this.Load += new System.EventHandler(this.SEL_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flp;
        public System.Windows.Forms.ListBox lstSearchEngines;
    }
}