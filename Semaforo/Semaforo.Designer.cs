namespace Semaforo
{
    partial class Semaforo
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndetener = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.btnencender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.peton = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peton)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btndetener);
            this.groupBox1.Controls.Add(this.btnapagar);
            this.groupBox1.Controls.Add(this.btnencender);
            this.groupBox1.Location = new System.Drawing.Point(482, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // btndetener
            // 
            this.btndetener.Location = new System.Drawing.Point(20, 126);
            this.btndetener.Name = "btndetener";
            this.btndetener.Size = new System.Drawing.Size(75, 23);
            this.btndetener.TabIndex = 2;
            this.btndetener.Text = "DETENER";
            this.btndetener.UseVisualStyleBackColor = true;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(20, 86);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(75, 23);
            this.btnapagar.TabIndex = 1;
            this.btnapagar.Text = "APAGAR";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // btnencender
            // 
            this.btnencender.Location = new System.Drawing.Point(20, 47);
            this.btnencender.Name = "btnencender";
            this.btnencender.Size = new System.Drawing.Size(75, 23);
            this.btnencender.TabIndex = 0;
            this.btnencender.Text = "ENCENDER";
            this.btnencender.UseVisualStyleBackColor = true;
            this.btnencender.Click += new System.EventHandler(this.btnencender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Semaforo.Properties.Resources.verde;
            this.pictureBox1.Location = new System.Drawing.Point(16, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // peton
            // 
            this.peton.Image = global::Semaforo.Properties.Resources.peatonal_verde;
            this.peton.Location = new System.Drawing.Point(180, 105);
            this.peton.Name = "peton";
            this.peton.Size = new System.Drawing.Size(218, 278);
            this.peton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.peton.TabIndex = 3;
            this.peton.TabStop = false;
            this.peton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Semaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 568);
            this.Controls.Add(this.peton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Semaforo";
            this.Text = "Semaforo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndetener;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Button btnencender;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox peton;
    }
}

