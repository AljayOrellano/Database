
namespace Pet_Vaccination
{
    partial class Mainform
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPet = new System.Windows.Forms.Button();
            this.btnInjected = new System.Windows.Forms.Button();
            this.btnVaccine = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pet_Vaccination.Properties.Resources.pet_vaccination_brochure_template_vector_34043696;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(230, -51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 636);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPet
            // 
            this.btnPet.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPet.Location = new System.Drawing.Point(-1, 127);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(232, 46);
            this.btnPet.TabIndex = 1;
            this.btnPet.Text = "PET";
            this.btnPet.UseVisualStyleBackColor = false;
            this.btnPet.Click += new System.EventHandler(this.btnPet_Click);
            // 
            // btnInjected
            // 
            this.btnInjected.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnInjected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInjected.Location = new System.Drawing.Point(-1, 188);
            this.btnInjected.Name = "btnInjected";
            this.btnInjected.Size = new System.Drawing.Size(232, 46);
            this.btnInjected.TabIndex = 2;
            this.btnInjected.Text = "PET INJECTED";
            this.btnInjected.UseVisualStyleBackColor = false;
            this.btnInjected.Click += new System.EventHandler(this.btnInjected_Click);
            // 
            // btnVaccine
            // 
            this.btnVaccine.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnVaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaccine.Location = new System.Drawing.Point(-1, 249);
            this.btnVaccine.Name = "btnVaccine";
            this.btnVaccine.Size = new System.Drawing.Size(232, 46);
            this.btnVaccine.TabIndex = 3;
            this.btnVaccine.Text = "VACCINE";
            this.btnVaccine.UseVisualStyleBackColor = false;
            this.btnVaccine.Click += new System.EventHandler(this.btnVaccine_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(-1, 408);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(232, 46);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "PET VACCINATION INFORMATION SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome!";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(933, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnVaccine);
            this.Controls.Add(this.btnInjected);
            this.Controls.Add(this.btnPet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPet;
        private System.Windows.Forms.Button btnInjected;
        private System.Windows.Forms.Button btnVaccine;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}