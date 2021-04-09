using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Steganography
{

    public partial class Form1 : Form
    {
        static int bit = 4;
        double textsize;
        Image loadedImage, loadedTrueImage, DecryptedImage;
        Bitmap loadedTrueBitmap, DecryptedBitmap;
       

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Function responsible for Ciphering the image, displaying it in the app and saving it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CipherButton_Click(object sender, EventArgs e)
        {
            if (pathBox.Text == "")
            {
                MessageBox.Show("Please Select the Image to encode");
            }

            else if (textBox.Text == "")
            {
                MessageBox.Show("Please Enter the Text to be hidden");
            }

            else
            {
                string messagetext = textBox.Text;
                double textlength = System.Text.ASCIIEncoding.ASCII.GetByteCount(messagetext);
                double textlen = textlength / 1024;

                Bitmap img = new Bitmap(loadedTrueBitmap.Width, loadedTrueBitmap.Height);
                int length = 0;
                int used_pixel = 0;
                int value = 0;
                string binary = "";
                int curr_letter = 0;
                for (int i = 0; i < img.Width; i++)
                {

                    for (int j = 0; j < img.Height; j++)
                    {

                        Color pixel = loadedTrueBitmap.GetPixel(i, j);

                        if (curr_letter < textBox.TextLength)
                        {
                            if (used_pixel == 0)
                            {
                                char letter = Convert.ToChar(textBox.Text.Substring(curr_letter, 1));
                                value = Convert.ToInt32(letter);
                                binary = Convert.ToString(value, 2);
                                binary = "00" + binary;
                                if (binary.Length == 8) binary = "0" + binary;
                                int test = Convert.ToInt32(binary, 2);
                                length = binary.Length;
                            }
                            StringBuilder R = new StringBuilder();
                            StringBuilder G = new StringBuilder();
                            StringBuilder B = new StringBuilder();

                            R.Append(Convert.ToString(pixel.R, 2));
                            if (R.Length < bit) for (int n = 0; n <= bit - R.Length; n++) R.Insert(0, "0");
                            R[R.Length - bit] = binary[used_pixel];
                            G.Append(Convert.ToString(pixel.G, 2));
                            if (G.Length < bit) for (int n = 0; n <= bit - G.Length; n++) G.Insert(0, "0");
                            G[G.Length - bit] = binary[used_pixel + 1];
                            B.Append(Convert.ToString(pixel.B, 2));
                            if (B.Length < bit) for (int n = 0; n <= bit - B.Length; n++) B.Insert(0, "0");
                            B[B.Length - bit] = binary[used_pixel + 2];

                            int R_value = Convert.ToInt32(R.ToString(), 2);
                            int G_value = Convert.ToInt32(G.ToString(), 2);
                            int B_value = Convert.ToInt32(B.ToString(), 2);

                            img.SetPixel(i, j, Color.FromArgb(R_value, G_value, B_value));
                            used_pixel += 3;
                            if (used_pixel >= 9) { used_pixel = 0; curr_letter++; }

                        }
                        else { img.SetPixel(i, j, pixel); }

                        if (i == img.Width - 1 && j == img.Height - 1)
                        {
                            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textBox.TextLength));
                        }



                    }
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Image Files (*.png) | *.png";
                saveFile.InitialDirectory = @"C:\Users\Greg\source\repos\Steganography\Steganography";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    DecipherPathbox.Text = saveFile.FileName.ToString();
                    CipherImg.ImageLocation = DecipherPathbox.Text;
                    img.Save(DecipherPathbox.Text);

                }

                MessageBox.Show("Image Saved Successfully");
            }

        }

        /// <summary>
        /// Function responsible for deciphering the image and displaying the hidden text in the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecipherButton_Click(object sender, EventArgs e)
        {
            if (DecipherPathbox.Text == "")
            {
                MessageBox.Show("Please Select the Image to decode");
            }

            else
            {
                Bitmap img = new Bitmap(DecipherPathbox.Text);
                StringBuilder letter_bin = new StringBuilder();
                String msg = "";
                Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
                int msgLength = lastpixel.B;
                int curr_letter = 0;
                int used_pixel = 0;
                for (int i = 0; i < img.Width; i++)
                {

                    for (int j = 0; j < img.Height; j++)
                    {
                        Color pixel = img.GetPixel(i, j);

                        if (curr_letter < msgLength)
                        {
                         
                            StringBuilder R = new StringBuilder();
                            StringBuilder G = new StringBuilder();
                            StringBuilder B = new StringBuilder();

                            R.Append(Convert.ToString(pixel.R, 2));
                            G.Append(Convert.ToString(pixel.G, 2));
                            B.Append(Convert.ToString(pixel.B, 2));
                            
                            letter_bin.Append(R[R.Length - bit]);
                            letter_bin.Append(G[G.Length - bit]);
                            letter_bin.Append(B[B.Length - bit]);

                            used_pixel++;
                           
                            if (used_pixel >= 3)
                            {
                                int binar = Convert.ToInt32(letter_bin.ToString(), 2);
                                String letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(binar) });
                                msg = msg + letter;
                                curr_letter++;
                                letter_bin.Clear();
                                used_pixel = 0;
                            }

                        }
                    }
                }
                DecryptedMsg.Text = msg;

                if (DecryptedMsg.Text == "")
                {
                    MessageBox.Show("No hidden data found");
                }
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Filter = "Image Files(*.png) | *.png;";
            openDialog.InitialDirectory = @"C:\Users\Greg\source\repos\Steganography\Steganography";

            if (openDialog.ShowDialog() == DialogResult.OK)

            {
                pathBox.Text = openDialog.FileName.ToString();

                ClearImg.ImageLocation = pathBox.Text;

                loadedTrueImage = Image.FromFile(pathBox.Text);

                loadedTrueBitmap = new Bitmap(loadedTrueImage);

                //textsize = (8.0 * ((loadedImage.Height * (loadedImage.Width / 3) * 3) / 3 - 1)) / 1024;
            }
        }

        private void OpenFileDecipher_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Filter = "Image Files(*.png) | *.png;";
            openDialog.InitialDirectory = @"C:\Users\Greg\source\repos\Steganography\Steganography";

            if (openDialog.ShowDialog() == DialogResult.OK)

            {
                DecipherPathbox.Text = openDialog.FileName.ToString();

                CipherImg.ImageLocation = DecipherPathbox.Text;
            }
        }
    }
}
