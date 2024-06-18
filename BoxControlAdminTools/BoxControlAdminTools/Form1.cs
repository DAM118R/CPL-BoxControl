using System.Drawing.Text;

namespace BoxControlAdminTools
{
    public partial class FormHub : Form
    {



        public FormHub(User Active_user)
        {
            Shared.Active_user = Active_user;
            InitializeComponent();
        }
        public FormHub()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void FormHub_Load(object sender, EventArgs e)
        {
            lbl_Demo.Visible = Shared.demo;
            ShowGroup(Shared.Active_user);
            //http://localhost:8080/api/tasks/assigned?idAssign=2
        }
        private void ShowGroup(User user)
        {
            btn_EmployeeTools.Visible = true;
            btn_ClientTools.Visible = false;
            btn_ProviderTool.Visible = false;
            btn_TaskTool.Visible = true;
            btn_AdminTools.Visible = false;
            //Estructura del bool[ admin , task ,  logi , client ]
            //Si admin tiene acceso a todo
            if (user.Admin)
            {
                btn_AdminTools.Visible = true;
                btn_ClientTools.Visible = true;
                btn_ProviderTool.Visible = true;
                btn_TaskTool.Visible = true;
            }
            else
            {
                if (user.Delivery)
                {
                    btn_ProviderTool.Visible = true;
                }
                if (user.Client)
                {
                    btn_ClientTools.Visible = true;
                }
            }
            AdjustButtonPositions();

        }

        private void AdjustButtonPositions()
        {
            int yOffset = 12;
            foreach (Control ctrl in pan_left.Controls)
            {
                if (ctrl is Button btn && btn.Visible)
                {
                    btn.Location = new System.Drawing.Point(12, yOffset);
                    yOffset += btn.Height + 6; // 6 is the gap between buttons
                }
            }
        }

        private void btn_ClientTools_Click(object sender, EventArgs e)
        {

        }

        private void btn_AdminTools_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Shared.Active_user = null;
            FormLogin formLogin = new FormLogin();
            formLogin.Show();   
            this.Hide();
        }
    }
}
