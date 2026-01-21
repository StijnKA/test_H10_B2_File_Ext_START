namespace H10_B2_File_Ext_START
{
    partial class FormLoadLog
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
            this.textBoxPad = new System.Windows.Forms.TextBox();
            this.buttonKiesMap = new System.Windows.Forms.Button();
            this.listBoxBestanden = new System.Windows.Forms.ListBox();
            this.buttonAnalyseer = new System.Windows.Forms.Button();
            this.textBoxResultaat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPad
            // 
            this.textBoxPad.Location = new System.Drawing.Point(58, 17);
            this.textBoxPad.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPad.Name = "textBoxPad";
            this.textBoxPad.ReadOnly = true;
            this.textBoxPad.Size = new System.Drawing.Size(440, 20);
            this.textBoxPad.TabIndex = 0;
            // 
            // buttonKiesMap
            // 
            this.buttonKiesMap.Location = new System.Drawing.Point(24, 240);
            this.buttonKiesMap.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKiesMap.Name = "buttonKiesMap";
            this.buttonKiesMap.Size = new System.Drawing.Size(106, 31);
            this.buttonKiesMap.TabIndex = 1;
            this.buttonKiesMap.Text = "Kies map";
            this.buttonKiesMap.UseVisualStyleBackColor = true;
            // 
            // listBoxBestanden
            // 
            this.listBoxBestanden.FormattingEnabled = true;
            this.listBoxBestanden.Location = new System.Drawing.Point(24, 44);
            this.listBoxBestanden.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBestanden.Name = "listBoxBestanden";
            this.listBoxBestanden.Size = new System.Drawing.Size(220, 186);
            this.listBoxBestanden.TabIndex = 3;
            // 
            // buttonAnalyseer
            // 
            this.buttonAnalyseer.Enabled = false;
            this.buttonAnalyseer.Location = new System.Drawing.Point(138, 240);
            this.buttonAnalyseer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnalyseer.Name = "buttonAnalyseer";
            this.buttonAnalyseer.Size = new System.Drawing.Size(106, 31);
            this.buttonAnalyseer.TabIndex = 4;
            this.buttonAnalyseer.Text = "Analyseer";
            this.buttonAnalyseer.UseVisualStyleBackColor = true;
            // 
            // textBoxResultaat
            // 
            this.textBoxResultaat.Location = new System.Drawing.Point(268, 44);
            this.textBoxResultaat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResultaat.Multiline = true;
            this.textBoxResultaat.Name = "textBoxResultaat";
            this.textBoxResultaat.Size = new System.Drawing.Size(230, 186);
            this.textBoxResultaat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pad:";
            // 
            // FormLoadLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResultaat);
            this.Controls.Add(this.buttonAnalyseer);
            this.Controls.Add(this.listBoxBestanden);
            this.Controls.Add(this.buttonKiesMap);
            this.Controls.Add(this.textBoxPad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLoadLog";
            this.Text = "Bestanden verkennen & loggen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPad;
        private System.Windows.Forms.Button buttonKiesMap;
        private System.Windows.Forms.ListBox listBoxBestanden;
        private System.Windows.Forms.Button buttonAnalyseer;
        private System.Windows.Forms.TextBox textBoxResultaat;
        private System.Windows.Forms.Label label1;
    }
}

