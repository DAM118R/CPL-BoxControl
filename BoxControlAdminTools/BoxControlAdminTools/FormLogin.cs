using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using static System.Windows.Forms.DataFormats;

namespace BoxControlAdminTools
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_demo_Click(object sender, EventArgs e)
        {
            Shared.demo = !Shared.demo;
            lbl_Demo.Visible = Shared.demo;
            if (Shared.demo)
            {
                Shared.Load_Users();
            }
            else
            {
                Shared.Clean_Users();
            }
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
           if(!Shared.demo)
            {
                loginviaApi();
            }
            else
            {
                Shared.InitDemo_user();
                string roles = GetUserRoles(Shared.Demo_user);
                MessageBox.Show($"Bienvenido usuario de demostracion, {Shared.Demo_user.Username}!\nRoles: {roles}", "Login Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                FormHub frm = new FormHub(Shared.Demo_user);
                frm.Show();
                this.Hide();
            }
        }

        private async void loginviaApi()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validar las credenciales llamando a la API local
            User user = await ValidateCredentials(username, password);

            if (user != null)
            {
                // Credenciales correctas, mostrar mensaje de bienvenida
                string roles = GetUserRoles(user);
                MessageBox.Show($"Bienvenido, {user.Username}!\nRoles: {roles}", "Login Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                FormHub frm = new FormHub(user);
                frm.Show();
                this.Hide();

            }
            else
            {
                // Credenciales incorrectas, mostrar mensaje de error.
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetUserRoles(User user)
        {
            // Construir una cadena con los roles del usuario
            string roles = "";
            if (user.Admin)
                roles += "Administrador, ";
            if (user.Delivery)
                roles += "Encargado de Logistica, ";
            if (user.Client)
                roles += "Soporte Tecnico, ";
            if (user.Hr)
                roles += "Recursos Humanos, ";

            // Eliminar la última coma y espacio si existen
            if (!string.IsNullOrEmpty(roles))
                roles = roles.TrimEnd(',', ' ');

            return roles;
        }
        private async Task<User> ValidateCredentials(string username, string password)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"http://localhost:8080/api/users/search?username={username}&password={password}";

                    // Realizar la solicitud GET a la API
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer la respuesta como texto
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Deserializar el JSON a un objeto User
                        User user = JsonConvert.DeserializeObject<User>(responseBody);
                        return user;
                    }
                    else
                    {
                        // Si la solicitud no fue exitosa, devuelve null
                        ;
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Algo no a salido bien \n Contacta con el equipo de BoxControl y cuentales lo que ha pasado y este codigo:  {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
