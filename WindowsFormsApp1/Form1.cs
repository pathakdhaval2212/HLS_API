using Microsoft.Win32;
using Siemens.Engineering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static TiaPortalProcess _tiaProcess;
        

        public TiaPortal MyTiaPortal
        {
            get; set;
        }
        public Project MyProject
        {
            get; set;
        }

        public Form1()
        {
            InitializeComponent();
            AppDomain CurrentDomain = AppDomain.CurrentDomain;
            CurrentDomain.AssemblyResolve += new ResolveEventHandler(MyResolver);
        }

        private Assembly MyResolver(object sender, ResolveEventArgs args)
        {
            int index = args.Name.IndexOf(',');
            if (index == -1)
            {
                return null;
            }
            string name = args.Name.Substring(0, index);

            RegistryKey filePathReg = Registry.LocalMachine.OpenSubKey(
                "SOFTWARE\\Siemens\\Automation\\Openness\\15.1\\PublicAPI\\15.1.0.0");

            if (filePathReg == null)
                return null;

            object oRegKeyValue = filePathReg.GetValue(name);
            if (oRegKeyValue != null)
            {
                string filePath = oRegKeyValue.ToString();

                string path = filePath;
                string fullPath = Path.GetFullPath(path);
                if (File.Exists(fullPath))
                {
                    return Assembly.LoadFrom(fullPath);
                }
            }

            return null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelDeviceName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTiaStart_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                MyTiaPortal = new TiaPortal(TiaPortalMode.WithoutUserInterface);
                textBox7.Text = "TIA Portal started without user interface";
                _tiaProcess = TiaPortal.GetProcesses()[0];
            }
            else
            {
                MyTiaPortal = new TiaPortal(TiaPortalMode.WithUserInterface);
                textBox7.Text = "TIA Portal started with user interface";
            }

            buttonOpenProject.Enabled = true;
            buttonTiaDispose.Enabled = true;
            buttonTiaStart.Enabled = false;
        }

        private void buttonOpenProject_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileSearch = new OpenFileDialog();

            fileSearch.Filter = "*.ap15_1|*.ap15_1";
            fileSearch.RestoreDirectory = true;
            fileSearch.ShowDialog();

            string ProjectPath = fileSearch.FileName.ToString();

            if (string.IsNullOrEmpty(ProjectPath) == false)
            {
                OpenProject(ProjectPath);
            }
        }

        private void OpenProject(string projectPath)
        {
            throw new NotImplementedException();
        }

        private void buttonSaveProject_Click(object sender, EventArgs e)
        {
            MyProject.Save();
            textBox7.Text = "Project saved";
        }

        private void buttonTiaDispose_Click(object sender, EventArgs e)
        {
            MyTiaPortal.Dispose();
            textBox7.Text = "TIA Portal disposed";

            buttonTiaStart.Enabled = true;
            buttonTiaDispose.Enabled = false;
            buttonCloseProject.Enabled = false;
            buttonOpenProject.Enabled = false;
            buttonCompile.Enabled = false;
            buttonSaveProject.Enabled = false;
        }

        private void buttonConnectToOpenTiaProject_Click(object sender, EventArgs e)
        {
            buttonConnectToOpenTiaProject.Enabled = false;
            IList<TiaPortalProcess> processes = TiaPortal.GetProcesses();
            switch (processes.Count)
            {
                case 1:
                    _tiaProcess = processes[0];
                    MyTiaPortal = _tiaProcess.Attach();
                    if (MyTiaPortal.GetCurrentProcess().Mode == TiaPortalMode.WithUserInterface)
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }


                    if (MyTiaPortal.Projects.Count <= 0)
                    {
                        textBox7.Text = "No TIA Portal Project was found!";
                        buttonConnectToOpenTiaProject.Enabled = true;
                        return;
                    }
                    MyProject = MyTiaPortal.Projects[0];
                    break;
                case 0:
                    textBox7.Text = "No running instance of TIA Portal was found!";
                    buttonConnectToOpenTiaProject.Enabled = true;
                    return;
                default:
                    textBox7.Text = "More than one running instance of TIA Portal was found!";
                    buttonConnectToOpenTiaProject.Enabled = true;
                    return;
            }
            textBox7.Text = _tiaProcess.ProjectPath.ToString();
            buttonTiaStart.Enabled = false;
            buttonConnectToOpenTiaProject.Enabled = true;
            buttonTiaDispose.Enabled = true;
            buttonCompile.Enabled = true;
            buttonCloseProject.Enabled = true;
            buttonOpenProject.Enabled = false;
            buttonSaveProject.Enabled = true;
            buttonAddDevice.Enabled = true;
        }
         
        private void buttonCloseProject_Click(object sender, EventArgs e)
        {
            MyProject.Close();

            textBox7.Text = "Project closed";

            buttonOpenProject.Enabled = true;
            buttonCloseProject.Enabled = false;
            buttonSaveProject.Enabled = false;
            buttonCompile.Enabled = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection con = new SqlConnection(string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\HLS Admin\source\repos\HLS_API\WindowsFormsApp1\Database1.mdf';Integrated Security=True")))
                {
                    SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From LogIn where UserName ='" + textBox1.Text + "' and Password = '" + textBox2.Text + "' ", con.ConnectionString);

                    DataTable dt = new DataTable();

                    sqa.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        lableTIAInterface.Visible = true;
                        radioButton1.Visible = true;
                        radioButton2.Visible = true;
                        buttonTiaStart.Visible = true;
                        buttonTiaDispose.Visible = true;
                        lableProjectInterface.Visible = true;
                        buttonOpenProject.Visible = true;
                        buttonConnectToOpenTiaProject.Visible = true;
                        buttonSaveProject.Visible = true;
                        buttonCloseProject.Visible = true;
                        labelAddItems.Visible = true;
                        labelDeviceName.Visible = true;
                        textBox3.Visible = true;
                        labelOrderNr.Visible = true;
                        textBox4.Visible = true;
                        labelVersion.Visible = true;
                        textBox5.Visible = true;
                        buttonAddDevice.Visible = true;
                        labelCompilation.Visible = true;
                        labelDeviceName_.Visible = true;
                        textBox6.Visible = true;
                        buttonCompile.Visible = true;
                        textBox7.Visible = true;
                    }

                    else
                    {
                        MessageBox.Show("Please enter correct UserName/Password1");
                    }
                }
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;

            switch (check)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private bool isValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty || textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Please enter correct UserName/Password1");
                return false;
            }
            return true;
        }
    }
}
