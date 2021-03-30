using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelCreator
{
    public partial class LabelCreator : Form
    {
        private List<string> temporaryFiles = new List<string>();
        public string pdf;

        public LabelCreator(string[] args)
        {
            InitializeComponent();

            if (args.Length > 0)
            {
                OpenFile(args[0]);
            }
        }

        #region Methods
        private void openZPLfile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "zpl files (*.zpl)|*.zpl";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OpenFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        public void OpenFile(string path)
        {
            ZplTextbox.Text = File.ReadAllText(path);
            //previewButton_Click(null, null);
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void labeleryApi()
        {
            if (ZplTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please input ZPL Code.");
                return;
            }
            if (LabelWidthTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please input LABEL WIDTH.");
                return;
            }

            if (LabelHeightTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please input LABEL HEIGHT.");
                return;
            }
            if (ComboboxUnits.Text == "")
            {
                MessageBox.Show("Please select UNITS.");
                return;
            }

            if (ComboboxDPI.Text == "")
            {
                MessageBox.Show("Please select DPI.");
                return;
            }

            double width = Double.Parse(LabelWidthTextbox.Text);
            double height = Double.Parse(LabelHeightTextbox.Text);
            string unit = ComboboxUnits.Text;
            string dpiValue = ComboboxDPI.Text;
            string dpi;

            if (ComboboxUnits.SelectedItem.Equals("Millimeters"))
            {
                width = width / 25.4;
                height = height / 25.4;
            }

            if (ComboboxDPI.SelectedItem.Equals("152 dpi"))
            {
                dpi = "6dpmm";
            }
            else if (ComboboxDPI.SelectedItem.Equals("203 dpi"))
            {
                dpi = "8dpmm";
            }
            else if (ComboboxDPI.SelectedItem.Equals("300 dpi"))
            {
                dpi = "12dpmm";
            }
            else if (ComboboxDPI.SelectedItem.Equals("600 dpi"))
            {
                dpi = "24dpmm";
            }
            else
            {
                dpi = "8dpmm";
            }

            if (!CheckForInternetConnection())
            {
                MessageBox.Show("You are not connected to internet.");
                return;
            }

            byte[] zplSourceBytes = Encoding.UTF8.GetBytes(ZplTextbox.Text);

            var request = (HttpWebRequest)WebRequest.Create("http://api.labelary.com/v1/printers/" + dpi + "/labels/" + width + "x" + height + "/");
            request.Method = "POST";
            request.Accept = "application/pdf";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = zplSourceBytes.Length;

            var requestStream = request.GetRequestStream();
            requestStream.Write(zplSourceBytes, 0, zplSourceBytes.Length);
            requestStream.Close();

            pdf = "Label_" + Guid.NewGuid().ToString() + ".pdf";

            temporaryFiles.Add(pdf);

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                var responseStream = response.GetResponseStream();
                var fileStream = File.Create(pdf);
                responseStream.CopyTo(fileStream);
                responseStream.Close();
                fileStream.Close();

                LabelViewer.LoadFile(pdf);
                LabelViewer.setZoom(150);
            }
            catch (WebException exception)
            {
                Console.WriteLine("Error: {0}", exception.Status);
            }
        }

        private void print()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.PrinterSettings = new PrinterSettings();

            if (DialogResult.OK == printDialog.ShowDialog(this))
            {
                if (printDialog.PrintToFile)
                {
                    string filePath;
                    string prnFile = "Label_" + DateTime.Now.ToString("yMMdd") + ".prn";

                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    fbd.Description = "Select file destination for PRN File";
                    fbd.ShowDialog();
                    string FilePath = fbd.SelectedPath;
                    filePath = FilePath;

                    try
                    {
                        File.WriteAllText(filePath + "\\" + prnFile, ZplTextbox.Text.ToString());
                        MessageBox.Show("Successfully saved PRN file.");
                    }
                    catch (Exception ex)
                    {          
                        MessageBox.Show("You have no access to Access this drive.");
                        return;
                    }
                }
                else
                {
                    RawPrinterHelper.SendStringToPrinter(printDialog.PrinterSettings.PrinterName, ZplTextbox.Text);
                }            
            }
        }

        private void exportPDF(string pdf)
        {
           
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.ShowDialog();

            savefile.AddExtension = true;

            savefile.CheckPathExists = true;
            savefile.CreatePrompt = false;
            savefile.OverwritePrompt = true;
            savefile.ValidateNames = true;

            savefile.DefaultExt = "pdf";

            savefile.Filter = "PDF files (*.pdf|*.pdf|" + "All files|*.*";
            savefile.FilterIndex = 1;

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(savefile.FileName, pdf);
                //System.IO.File.WriteAllText(sv.FileName, richTextBox1.Text);
            }
        }
        #endregion


        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Impact", 25);
            Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(30, 200);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Label Creator", font, brush, 0, 0);
            //e.Graphics.DrawString("File Creator", font, brush, 0, 0);
        }

        private void ButtonZplOpen_Click(object sender, EventArgs e)
        {
            openZPLfile();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            labeleryApi();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            print();
        }

        private void LabelCreator_Load(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            exportPDF(pdf);
        }
    }      
}