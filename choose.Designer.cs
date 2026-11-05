namespace lab2
{
    partial class choose
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
            this.btnBicycle = new System.Windows.Forms.Button();
            this.btxMushroom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBicycle
            // 
            this.btnBicycle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBicycle.Location = new System.Drawing.Point(167, 162);
            this.btnBicycle.Name = "btnBicycle";
            this.btnBicycle.Size = new System.Drawing.Size(93, 46);
            this.btnBicycle.TabIndex = 0;
            this.btnBicycle.Text = "Bicycle";
            this.btnBicycle.UseVisualStyleBackColor = false;
            this.btnBicycle.Click += new System.EventHandler(this.btnBicycle_Click);
            // 
            // btxMushroom
            // 
            this.btxMushroom.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btxMushroom.Location = new System.Drawing.Point(476, 162);
            this.btxMushroom.Name = "btxMushroom";
            this.btxMushroom.Size = new System.Drawing.Size(105, 46);
            this.btxMushroom.TabIndex = 1;
            this.btxMushroom.Text = "Mushroom\r\n";
            this.btxMushroom.UseVisualStyleBackColor = false;
            this.btxMushroom.Click += new System.EventHandler(this.btxMushroom_Click);
            // 
            // choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btxMushroom);
            this.Controls.Add(this.btnBicycle);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "choose";
            this.Text = "choose";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBicycle;
        private System.Windows.Forms.Button btxMushroom;
    }
}