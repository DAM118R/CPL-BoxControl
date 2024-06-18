using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxControlAdminTools
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lbl_Demo.Visible = Shared.demo;
            InitializeUserTable();
        }
        private async void InitializeUserTable()
        {
            List<User> users = !Shared.demo ? await GetUsersFromApi() : Shared.Demo_users;
            if (users != null)
            {
                dgv_users.DataSource = users;
            }
        }

        private async Task<List<User>> GetUsersFromApi()
        {
            try
            {
                using (HttpClient oClient = new HttpClient())
                {
                    HttpResponseMessage oResponse = await oClient.GetAsync("http://localhost:8080/api/users");

                    if (oResponse.IsSuccessStatusCode)
                    {
                        string sResponseBody = await oResponse.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<User>>(sResponseBody);
                    }
                    else
                    {
                        MessageBox.Show($"Error: {oResponse.StatusCode} - {oResponse.ReasonPhrase}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show($"Error: {oEx.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void lbl_Demo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            FormHub hub = new FormHub();
            hub.Show();
            this.Hide();
        }
    }
}
