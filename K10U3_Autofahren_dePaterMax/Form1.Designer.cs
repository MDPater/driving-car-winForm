namespace K10U3_Autofahren_dePaterMax
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
            this.panelStrasse = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonFahren = new System.Windows.Forms.Button();
            this.buttonLangsamer = new System.Windows.Forms.Button();
            this.buttonSchneller = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelStrasse
            // 
            this.panelStrasse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelStrasse.Location = new System.Drawing.Point(13, 13);
            this.panelStrasse.Name = "panelStrasse";
            this.panelStrasse.Size = new System.Drawing.Size(775, 83);
            this.panelStrasse.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 126);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 33);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonFahren
            // 
            this.buttonFahren.Location = new System.Drawing.Point(255, 129);
            this.buttonFahren.Name = "buttonFahren";
            this.buttonFahren.Size = new System.Drawing.Size(75, 30);
            this.buttonFahren.TabIndex = 2;
            this.buttonFahren.Text = "Fahren";
            this.buttonFahren.UseVisualStyleBackColor = true;
            this.buttonFahren.Click += new System.EventHandler(this.buttonFahren_Click);
            // 
            // buttonLangsamer
            // 
            this.buttonLangsamer.Location = new System.Drawing.Point(337, 129);
            this.buttonLangsamer.Name = "buttonLangsamer";
            this.buttonLangsamer.Size = new System.Drawing.Size(99, 30);
            this.buttonLangsamer.TabIndex = 3;
            this.buttonLangsamer.Text = " Langsamer";
            this.buttonLangsamer.UseVisualStyleBackColor = true;
            this.buttonLangsamer.Click += new System.EventHandler(this.buttonLangsamer_Click);
            // 
            // buttonSchneller
            // 
            this.buttonSchneller.Location = new System.Drawing.Point(442, 129);
            this.buttonSchneller.Name = "buttonSchneller";
            this.buttonSchneller.Size = new System.Drawing.Size(85, 30);
            this.buttonSchneller.TabIndex = 4;
            this.buttonSchneller.Text = "Schneller";
            this.buttonSchneller.UseVisualStyleBackColor = true;
            this.buttonSchneller.Click += new System.EventHandler(this.buttonSchneller_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(713, 129);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 30);
            this.buttonBeenden.TabIndex = 5;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 171);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonSchneller);
            this.Controls.Add(this.buttonLangsamer);
            this.Controls.Add(this.buttonFahren);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelStrasse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStrasse;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonFahren;
        private System.Windows.Forms.Button buttonLangsamer;
        private System.Windows.Forms.Button buttonSchneller;
        private System.Windows.Forms.Button buttonBeenden;
    }
}

