namespace WindowsFormsApplication1
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
            this.Ajustar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.close = new System.Windows.Forms.Button();
            this.setcolor = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.show_image = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ajustar
            // 
            this.Ajustar.AutoSize = true;
            this.Ajustar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ajustar.Location = new System.Drawing.Point(3, 600);
            this.Ajustar.Name = "Ajustar";
            this.Ajustar.Size = new System.Drawing.Size(90, 61);
            this.Ajustar.TabIndex = 1;
            this.Ajustar.Text = "Ajustar";
            this.Ajustar.UseVisualStyleBackColor = true;
            this.Ajustar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 591);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Ajustar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 664);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.close);
            this.flowLayoutPanel1.Controls.Add(this.setcolor);
            this.flowLayoutPanel1.Controls.Add(this.erase);
            this.flowLayoutPanel1.Controls.Add(this.show_image);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(99, 600);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(538, 61);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Location = new System.Drawing.Point(3, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(87, 23);
            this.close.TabIndex = 0;
            this.close.Text = "Cerrar";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // setcolor
            // 
            this.setcolor.AutoSize = true;
            this.setcolor.Location = new System.Drawing.Point(96, 3);
            this.setcolor.Name = "setcolor";
            this.setcolor.Size = new System.Drawing.Size(144, 23);
            this.setcolor.TabIndex = 1;
            this.setcolor.Text = "Establecer Color De Fondo";
            this.setcolor.UseVisualStyleBackColor = true;
            this.setcolor.Click += new System.EventHandler(this.setcolor_Click);
            // 
            // erase
            // 
            this.erase.AutoSize = true;
            this.erase.Location = new System.Drawing.Point(246, 3);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(87, 23);
            this.erase.TabIndex = 2;
            this.erase.Text = "Borrar Image";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // show_image
            // 
            this.show_image.AutoSize = true;
            this.show_image.Location = new System.Drawing.Point(339, 3);
            this.show_image.Name = "show_image";
            this.show_image.Size = new System.Drawing.Size(111, 23);
            this.show_image.TabIndex = 3;
            this.show_image.Text = "Mostrar una Imagen";
            this.show_image.UseVisualStyleBackColor = true;
            this.show_image.Click += new System.EventHandler(this.show_image_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos JPEG (*.jpg)|*.jpg|Archivos PNG (*.png)|*.png|Archivos BMP (*.bmp)|*.bmp" +
    "";
            this.openFileDialog1.Title = "eleccionar Un Archivo de Imagen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 664);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Pictures Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox Ajustar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button setcolor;
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.Button show_image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;

    }
}

