using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.Barcode;

namespace Barcode2
{
    public partial class Form2 : Form

 {
        string filename;
        List<MyPicture> list;

        public Form2()
        {
            InitializeComponent();
        }
        BarcodeEncoder Generator;

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generator = new BarcodeEncoder();
            Generator.IncludeLabel = true;
            Generator.CustomLabel = textBox5.Text;
            if (textBox5.Text != "")
                pictureBox1.Image = new Bitmap(Generator.Encode(BarcodeFormat.Code39, textBox5.Text));


        }


        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using (picEntities db = new picEntities())
            {
                MyPicture pic = new MyPicture() { FileName = filename, Data = ConvertImageToBinary(pictureBox1.Image) };

                db.MyPictures.Add(pic);
                await db.SaveChangesAsync();
                MessageBox.Show("you have been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Generator = new BarcodeEncoder();
            Generator.IncludeLabel = true;
            Generator.CustomLabel = textBox5.Text;
            Generator.CustomLabel = textBox4.Text;
            if (textBox5.Text != "" )
                pictureBox1.Image = new Bitmap(Generator.Encode(BarcodeFormat.Code39, textBox5.Text ));
                



        }
    }
}
