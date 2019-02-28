using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEFClient
{
    public partial class DeleteFile : Form
    {
        public DeleteFile()
        {
            InitializeComponent();
        }

        private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadFile uf = new UploadFile();
            uf.ShowDialog();
        }

        #region Delete file!
        private void Button_delete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBox_deleteId.Text);
            FileDelete(id);
        }

        private async void FileDelete(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64040/");
            
            HttpResponseMessage response = await client.DeleteAsync("api/values/" + id + "/");

            if (response.IsSuccessStatusCode)
            {
                label_Result.Text = " Successfully deleted!";
            }
            else
            {
                response.ToString();
            }
        }
        #endregion
    }
}
