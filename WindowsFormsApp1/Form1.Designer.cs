
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lableTIAInterface = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lableUserPW = new System.Windows.Forms.Label();
            this.lableUserID = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonTiaStart = new System.Windows.Forms.Button();
            this.buttonTiaDispose = new System.Windows.Forms.Button();
            this.labelCompilation = new System.Windows.Forms.Label();
            this.labelAddItems = new System.Windows.Forms.Label();
            this.lableProjectInterface = new System.Windows.Forms.Label();
            this.buttonConnectToOpenTiaProject = new System.Windows.Forms.Button();
            this.buttonCloseProject = new System.Windows.Forms.Button();
            this.buttonSaveProject = new System.Windows.Forms.Button();
            this.buttonOpenProject = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.labelOrderNr = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonAddDevice = new System.Windows.Forms.Button();
            this.buttonCompile = new System.Windows.Forms.Button();
            this.labelDeviceName_ = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lableTIAInterface
            // 
            this.lableTIAInterface.AutoSize = true;
            this.lableTIAInterface.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTIAInterface.Location = new System.Drawing.Point(46, 149);
            this.lableTIAInterface.Name = "lableTIAInterface";
            this.lableTIAInterface.Size = new System.Drawing.Size(68, 15);
            this.lableTIAInterface.TabIndex = 1;
            this.lableTIAInterface.Text = "TIA portal";
            this.lableTIAInterface.Visible = false;
            this.lableTIAInterface.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(390, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(390, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // lableUserPW
            // 
            this.lableUserPW.AutoSize = true;
            this.lableUserPW.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableUserPW.Location = new System.Drawing.Point(293, 58);
            this.lableUserPW.Name = "lableUserPW";
            this.lableUserPW.Size = new System.Drawing.Size(66, 15);
            this.lableUserPW.TabIndex = 4;
            this.lableUserPW.Text = "Password";
            // 
            // lableUserID
            // 
            this.lableUserID.AutoSize = true;
            this.lableUserID.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableUserID.Location = new System.Drawing.Point(293, 32);
            this.lableUserID.Name = "lableUserID";
            this.lableUserID.Size = new System.Drawing.Size(72, 15);
            this.lableUserID.TabIndex = 5;
            this.lableUserID.Text = "UserName";
            this.lableUserID.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(49, 178);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "With User Interface";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(49, 210);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(134, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Without User Interface";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // buttonTiaStart
            // 
            this.buttonTiaStart.Location = new System.Drawing.Point(49, 258);
            this.buttonTiaStart.Name = "buttonTiaStart";
            this.buttonTiaStart.Size = new System.Drawing.Size(134, 50);
            this.buttonTiaStart.TabIndex = 8;
            this.buttonTiaStart.Text = "Start TIA ";
            this.buttonTiaStart.UseVisualStyleBackColor = true;
            this.buttonTiaStart.Visible = false;
            this.buttonTiaStart.Click += new System.EventHandler(this.buttonTiaStart_Click);
            // 
            // buttonTiaDispose
            // 
            this.buttonTiaDispose.Location = new System.Drawing.Point(49, 314);
            this.buttonTiaDispose.Name = "buttonTiaDispose";
            this.buttonTiaDispose.Size = new System.Drawing.Size(134, 50);
            this.buttonTiaDispose.TabIndex = 9;
            this.buttonTiaDispose.Text = "Dispose TIA";
            this.buttonTiaDispose.UseVisualStyleBackColor = true;
            this.buttonTiaDispose.Visible = false;
            this.buttonTiaDispose.Click += new System.EventHandler(this.buttonTiaDispose_Click);
            // 
            // labelCompilation
            // 
            this.labelCompilation.AutoSize = true;
            this.labelCompilation.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompilation.Location = new System.Drawing.Point(642, 149);
            this.labelCompilation.Name = "labelCompilation";
            this.labelCompilation.Size = new System.Drawing.Size(83, 15);
            this.labelCompilation.TabIndex = 10;
            this.labelCompilation.Text = "Compilation";
            this.labelCompilation.Visible = false;
            // 
            // labelAddItems
            // 
            this.labelAddItems.AutoSize = true;
            this.labelAddItems.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddItems.Location = new System.Drawing.Point(447, 149);
            this.labelAddItems.Name = "labelAddItems";
            this.labelAddItems.Size = new System.Drawing.Size(71, 15);
            this.labelAddItems.TabIndex = 11;
            this.labelAddItems.Text = "Add Items";
            this.labelAddItems.Visible = false;
            // 
            // lableProjectInterface
            // 
            this.lableProjectInterface.AutoSize = true;
            this.lableProjectInterface.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableProjectInterface.Location = new System.Drawing.Point(259, 149);
            this.lableProjectInterface.Name = "lableProjectInterface";
            this.lableProjectInterface.Size = new System.Drawing.Size(124, 15);
            this.lableProjectInterface.TabIndex = 12;
            this.lableProjectInterface.Text = "Project Declaration";
            this.lableProjectInterface.Visible = false;
            // 
            // buttonConnectToOpenTiaProject
            // 
            this.buttonConnectToOpenTiaProject.Location = new System.Drawing.Point(262, 235);
            this.buttonConnectToOpenTiaProject.Name = "buttonConnectToOpenTiaProject";
            this.buttonConnectToOpenTiaProject.Size = new System.Drawing.Size(134, 50);
            this.buttonConnectToOpenTiaProject.TabIndex = 13;
            this.buttonConnectToOpenTiaProject.Text = "Connect to open TIA Project";
            this.buttonConnectToOpenTiaProject.UseVisualStyleBackColor = true;
            this.buttonConnectToOpenTiaProject.Visible = false;
            this.buttonConnectToOpenTiaProject.Click += new System.EventHandler(this.buttonConnectToOpenTiaProject_Click);
            // 
            // buttonCloseProject
            // 
            this.buttonCloseProject.Location = new System.Drawing.Point(262, 347);
            this.buttonCloseProject.Name = "buttonCloseProject";
            this.buttonCloseProject.Size = new System.Drawing.Size(134, 50);
            this.buttonCloseProject.TabIndex = 14;
            this.buttonCloseProject.Text = "Close Project";
            this.buttonCloseProject.UseVisualStyleBackColor = true;
            this.buttonCloseProject.Visible = false;
            this.buttonCloseProject.Click += new System.EventHandler(this.buttonCloseProject_Click);
            // 
            // buttonSaveProject
            // 
            this.buttonSaveProject.Location = new System.Drawing.Point(262, 291);
            this.buttonSaveProject.Name = "buttonSaveProject";
            this.buttonSaveProject.Size = new System.Drawing.Size(134, 50);
            this.buttonSaveProject.TabIndex = 15;
            this.buttonSaveProject.Text = "Save Project";
            this.buttonSaveProject.UseVisualStyleBackColor = true;
            this.buttonSaveProject.Visible = false;
            this.buttonSaveProject.Click += new System.EventHandler(this.buttonSaveProject_Click);
            // 
            // buttonOpenProject
            // 
            this.buttonOpenProject.Location = new System.Drawing.Point(262, 178);
            this.buttonOpenProject.Name = "buttonOpenProject";
            this.buttonOpenProject.Size = new System.Drawing.Size(134, 50);
            this.buttonOpenProject.TabIndex = 16;
            this.buttonOpenProject.Text = "Open Project";
            this.buttonOpenProject.UseVisualStyleBackColor = true;
            this.buttonOpenProject.Visible = false;
            this.buttonOpenProject.Click += new System.EventHandler(this.buttonOpenProject_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(447, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.Visible = false;
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceName.Location = new System.Drawing.Point(448, 188);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(67, 12);
            this.labelDeviceName.TabIndex = 18;
            this.labelDeviceName.Text = "Device Name";
            this.labelDeviceName.Visible = false;
            this.labelDeviceName.Click += new System.EventHandler(this.labelDeviceName_Click);
            // 
            // labelOrderNr
            // 
            this.labelOrderNr.AutoSize = true;
            this.labelOrderNr.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderNr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOrderNr.Location = new System.Drawing.Point(448, 247);
            this.labelOrderNr.Name = "labelOrderNr";
            this.labelOrderNr.Size = new System.Drawing.Size(47, 12);
            this.labelOrderNr.TabIndex = 20;
            this.labelOrderNr.Text = "Order Nr";
            this.labelOrderNr.Visible = false;
            this.labelOrderNr.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(447, 265);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 20);
            this.textBox4.TabIndex = 19;
            this.textBox4.Visible = false;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(448, 303);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 12);
            this.labelVersion.TabIndex = 22;
            this.labelVersion.Text = "Version";
            this.labelVersion.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(447, 321);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 20);
            this.textBox5.TabIndex = 21;
            this.textBox5.Visible = false;
            // 
            // buttonAddDevice
            // 
            this.buttonAddDevice.Location = new System.Drawing.Point(447, 347);
            this.buttonAddDevice.Name = "buttonAddDevice";
            this.buttonAddDevice.Size = new System.Drawing.Size(134, 50);
            this.buttonAddDevice.TabIndex = 23;
            this.buttonAddDevice.Text = "Add Device";
            this.buttonAddDevice.UseVisualStyleBackColor = true;
            this.buttonAddDevice.Visible = false;
            // 
            // buttonCompile
            // 
            this.buttonCompile.Location = new System.Drawing.Point(645, 232);
            this.buttonCompile.Name = "buttonCompile";
            this.buttonCompile.Size = new System.Drawing.Size(134, 50);
            this.buttonCompile.TabIndex = 24;
            this.buttonCompile.Text = "Compile";
            this.buttonCompile.UseVisualStyleBackColor = true;
            this.buttonCompile.Visible = false;
            this.buttonCompile.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelDeviceName_
            // 
            this.labelDeviceName_.AutoSize = true;
            this.labelDeviceName_.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceName_.Location = new System.Drawing.Point(646, 188);
            this.labelDeviceName_.Name = "labelDeviceName_";
            this.labelDeviceName_.Size = new System.Drawing.Size(67, 12);
            this.labelDeviceName_.TabIndex = 26;
            this.labelDeviceName_.Text = "Device Name";
            this.labelDeviceName_.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(645, 206);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(143, 20);
            this.textBox6.TabIndex = 25;
            this.textBox6.Visible = false;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(390, 79);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(283, 22);
            this.buttonLogIn.TabIndex = 27;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(30, 407);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(780, 20);
            this.textBox7.TabIndex = 28;
            this.textBox7.Visible = false;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(679, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Show ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(823, 452);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.labelDeviceName_);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.buttonCompile);
            this.Controls.Add(this.buttonAddDevice);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelOrderNr);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelDeviceName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonOpenProject);
            this.Controls.Add(this.buttonSaveProject);
            this.Controls.Add(this.buttonCloseProject);
            this.Controls.Add(this.buttonConnectToOpenTiaProject);
            this.Controls.Add(this.lableProjectInterface);
            this.Controls.Add(this.labelAddItems);
            this.Controls.Add(this.labelCompilation);
            this.Controls.Add(this.buttonTiaDispose);
            this.Controls.Add(this.buttonTiaStart);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lableUserID);
            this.Controls.Add(this.lableUserPW);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lableTIAInterface);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIAOpenness_HLS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lableTIAInterface;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lableUserPW;
        private System.Windows.Forms.Label lableUserID;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button buttonTiaStart;
        private System.Windows.Forms.Button buttonTiaDispose;
        private System.Windows.Forms.Label labelCompilation;
        private System.Windows.Forms.Label labelAddItems;
        private System.Windows.Forms.Label lableProjectInterface;
        private System.Windows.Forms.Button buttonConnectToOpenTiaProject;
        private System.Windows.Forms.Button buttonCloseProject;
        private System.Windows.Forms.Button buttonSaveProject;
        private System.Windows.Forms.Button buttonOpenProject;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.Label labelOrderNr;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonAddDevice;
        private System.Windows.Forms.Button buttonCompile;
        private System.Windows.Forms.Label labelDeviceName_;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

