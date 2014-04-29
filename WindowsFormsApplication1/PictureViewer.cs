using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  /// <summary>
  /// constructor de la clase pictures,inicializa componentes.
  /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            int number;
            number = 10;
            number = number - 5;
            number = number * 3;
            InitializeComponent();
            //this.Text = number.ToString() ;
          

            
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">recarga </param>
        /// <param name="e"></param>

        private void show_image_Click(object sender, EventArgs e)
        {
           

        
          if ( openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
              // carga la imagen al picture box

            }
           
            {

            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setcolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void erase_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Ajustar.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
