namespace GUI
{
    partial class Meny
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
            this.btnlärare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlärare
            // 
            this.btnlärare.Location = new System.Drawing.Point(40, 41);
            this.btnlärare.Name = "btnlärare";
            this.btnlärare.Size = new System.Drawing.Size(274, 159);
            this.btnlärare.TabIndex = 0;
            this.btnlärare.Text = "Lärare";
            this.btnlärare.UseVisualStyleBackColor = true;
            this.btnlärare.Click += new System.EventHandler(this.btnlärare_Click);
            // 
            // Meny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlärare);
            this.Name = "Meny";
            this.Text = "Meny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlärare;
    }
}