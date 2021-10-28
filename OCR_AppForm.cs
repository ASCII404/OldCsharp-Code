using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using IronOcr;
using System.Runtime.InteropServices;

namespace OCR
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainForm(object sender, EventArgs e)
        {
            //Setting the OCR license
            IronOcr.License.LicenseKey = "IRON2CR-MYLICENSE-KEY-1EF02";
            bool result = IronOcr.License.IsValidLicense("IRONOCR-MYLICENSE-KEY-1EF01");
            //Checking the OCR license
            System.Console.WriteLine("{0}:{1}", IronOcr.License.LicenseKey, result);

            //I DON'T OWN AN OCR LICENSE
        }

        private void LoadImage_button_Click(object sender, EventArgs e)
        {
            string[] files;
            FolderBrowserDialog newBrowser = new FolderBrowserDialog();
            List<System.IO.FileInfo> theFiles = new List<System.IO.FileInfo>();
            BindingSource bind_source = new BindingSource();

            //Check to see if the browser is open
            if (newBrowser.ShowDialog() == DialogResult.OK)
            {
                listbox_LoadedItems.Items.Clear();
                files = Directory.GetFiles(newBrowser.SelectedPath);

                //Going trough all the files in the directory we've selected
                foreach (string file in files)
                {
                    //Take only the files with the correct exstension
                    System.IO.FileInfo f = new System.IO.FileInfo(file);
                    string correct_format = System.IO.Path.GetExtension(file);
                    if (correct_format == ".jpeg" || correct_format == ".png" || correct_format == ".jpg")
                    {
                        theFiles.Add(f);
                    }
                }

                //Bind data so we can display only the name and not the entire path of the file
                bind_source.DataSource = theFiles;
                listbox_LoadedItems.DataSource = bind_source;
                listbox_LoadedItems.DisplayMember = "Name";
            }

            //Checking if the listbox is empty to handle the load button
            if(listbox_LoadedItems.Items.Count != 0)
            {
                button_LoadImages.Enabled = false;
                label_statusCheck.ForeColor = System.Drawing.Color.Green;
                button_ClearList.Enabled = true;
            }
        }

        private void ClearText_Click(object sender, EventArgs e)
        {
            //See the picturebox image to the default image
            pictureBox_main.Image = Properties.Resources.empty_image;
            //Clearing the text after we've cleared the image
            textBox_Ocr.Text = "";
        }

        private void ListBox_LoadedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If the listbox is not empty
            if (listbox_LoadedItems.Enabled == true)
                label_statusCheck.Text = "Ok";
            try
            {
                //Trying to select an item if he has the wrong extension
                string curent_item = listbox_LoadedItems.SelectedItem.ToString();
                pictureBox_main.Image = Image.FromFile(curent_item);
            }
            catch(Exception except)
            {
                //We handle the exceptions thrown from the try block
                if (except is NullReferenceException)
                    label_statusCheck.Text = "Nothing selected";
                if (except is OutOfMemoryException)
                    label_statusCheck.Text = "Invalid Format";
            }

            //If the label is empty(==set to null)
            if (label_statusCheck.Text == "Nothing selected")
                label_statusCheck.ForeColor = System.Drawing.Color.Red;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void StatusCheckLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClearList_Box_Click(object sender, EventArgs e)
        {
            //Handling the buttons accesibility
            button_ClearList.Enabled = false;
            button_LoadImages.Enabled = true;

            //Setting all data to null to clear the listbox
            listbox_LoadedItems.DataSource = null;
            pictureBox_main.Image = Properties.Resources.empty_image;
        }

        private void ApplyOcr_Click(object sender, EventArgs e)
        {
            AutoOcr Ocr = new AutoOcr() { ReadBarCodes = false };
            try
            {
                var result = Ocr.Read(listbox_LoadedItems.SelectedItem.ToString());
                textBox_Ocr.Text = result.Text;
            }

            catch(NullReferenceException)
            {
                label_statusCheck.Text = "OCR Error, nothing selected!";
                label_statusCheck.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Button_Help_Click(object sender, EventArgs e)
        {
            string instructions = " Instructions\n ---------------- \n" +
                                  "1.Press on load images\n" +
                                  "2.Select the folder where you have the images\n" +
                                  "3.Select one of your images\n" +
                                  "4.Press on Apply_Ocr\n";

            string Info = "\n\n\n" +
                          " Info\n ---------------- \n" +
                          "1.Load images = Get your images in the listbox\n" +
                          "2.Clear text = Clear the resulted text from the OCR process\n" +
                          "3.Apply_OCR = Apply the ocr process\n" +
                          "4.Clear list = Empty the listbox\n";

            string help = instructions + Info;
            MessageBox.Show(help);
        }

        private void label_resultedText_Click(object sender, EventArgs e)
        {

        }
    }
}