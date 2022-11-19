namespace Trigger_Bot
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.vacHavarija = new MaterialSkin.Controls.MaterialButton();
            this.simplemode = new MaterialSkin.Controls.MaterialSwitch();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.sasaMaticEfekat = new MaterialSkin.Controls.MaterialSwitch();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.vacHavarija);
            this.panel1.Controls.Add(this.simplemode);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.sasaMaticEfekat);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 161);
            this.panel1.TabIndex = 0;
            // 
            // vacHavarija
            // 
            this.vacHavarija.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vacHavarija.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.vacHavarija.Depth = 0;
            this.vacHavarija.HighEmphasis = true;
            this.vacHavarija.Icon = null;
            this.vacHavarija.Location = new System.Drawing.Point(115, 111);
            this.vacHavarija.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.vacHavarija.MouseState = MaterialSkin.MouseState.HOVER;
            this.vacHavarija.Name = "vacHavarija";
            this.vacHavarija.NoAccentTextColor = System.Drawing.Color.Empty;
            this.vacHavarija.Size = new System.Drawing.Size(124, 36);
            this.vacHavarija.TabIndex = 3;
            this.vacHavarija.Text = "VAC HAVARIJA";
            this.vacHavarija.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.vacHavarija.UseAccentColor = false;
            this.vacHavarija.UseVisualStyleBackColor = true;
            this.vacHavarija.Click += new System.EventHandler(this.vacHavarija_Click);
            // 
            // simplemode
            // 
            this.simplemode.AutoSize = true;
            this.simplemode.Depth = 0;
            this.simplemode.Location = new System.Drawing.Point(15, 68);
            this.simplemode.Margin = new System.Windows.Forms.Padding(0);
            this.simplemode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.simplemode.MouseState = MaterialSkin.MouseState.HOVER;
            this.simplemode.Name = "simplemode";
            this.simplemode.Ripple = true;
            this.simplemode.Size = new System.Drawing.Size(162, 37);
            this.simplemode.TabIndex = 2;
            this.simplemode.Text = "s1mple dimple";
            this.simplemode.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(15, 111);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(92, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Sakrij se";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // sasaMaticEfekat
            // 
            this.sasaMaticEfekat.AutoSize = true;
            this.sasaMaticEfekat.Depth = 0;
            this.sasaMaticEfekat.Location = new System.Drawing.Point(15, 18);
            this.sasaMaticEfekat.Margin = new System.Windows.Forms.Padding(0);
            this.sasaMaticEfekat.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sasaMaticEfekat.MouseState = MaterialSkin.MouseState.HOVER;
            this.sasaMaticEfekat.Name = "sasaMaticEfekat";
            this.sasaMaticEfekat.Ripple = true;
            this.sasaMaticEfekat.Size = new System.Drawing.Size(138, 37);
            this.sasaMaticEfekat.TabIndex = 0;
            this.sasaMaticEfekat.Text = "Sasa Matic";
            this.sasaMaticEfekat.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 180);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialSwitch sasaMaticEfekat;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialSwitch simplemode;
        private MaterialSkin.Controls.MaterialButton vacHavarija;
    }
}