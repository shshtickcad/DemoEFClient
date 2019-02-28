using System;
using System.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace DemoEFClient
{
    public partial class UploadFile : Form
    {
        public UploadFile()
        {
            InitializeComponent();
        }

        #region Upload file!
        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExp = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "All files|*.*" };
            if (fileExp.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileExp.FileName;
                filePath_label.Text = filePath;

                PostRequest(filePath);
            }
        }
        
        private async void PostRequest(string fileInfo)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64040/");
            var content = new MultipartFormDataContent();
            var fileContent = new ByteArrayContent(File.ReadAllBytes(fileInfo));
            content.Add(fileContent, "file", fileInfo);

            HttpResponseMessage response = await client.PostAsync("api/values/", content);

            if (response.IsSuccessStatusCode)
            {
                result_textBox.Text = Path.GetFileNameWithoutExtension(fileInfo) + " Successfully Uploaded!";
            }
            else
            {
                response.ToString();
            }
        }
        #endregion

        

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteFile df = new DeleteFile();
            df.ShowDialog();
        }
    }
}
