using System.ComponentModel;

namespace AndroidRecoveryEmulator
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.installZip = new System.Windows.Forms.Label();
            this.rebootExit = new System.Windows.Forms.Label();
            this.factoryresetMenu = new System.Windows.Forms.Label();
            this.WipeData = new System.Windows.Forms.Panel();
            this.FactorResetLabel = new System.Windows.Forms.Label();
            this.goBackWipeData = new System.Windows.Forms.Label();
            this.yesWipeData = new System.Windows.Forms.Label();
            this.noWipeData = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.Output = new System.Windows.Forms.Label();
            this.InstallZipConfirm = new System.Windows.Forms.Label();
            this.InstallZipConfirmLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YesInstallZip = new System.Windows.Forms.Label();
            this.noInstallZip = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.InstallZipPanel = new System.Windows.Forms.Panel();
            this.IntallZipLabel = new System.Windows.Forms.Label();
            this.installZipGoBack = new System.Windows.Forms.Label();
            this.SelectZip = new System.Windows.Forms.Label();
            this.AdvancedMenu = new System.Windows.Forms.Label();
            this.WipeCache = new System.Windows.Forms.Panel();
            this.WipeCacheLabel = new System.Windows.Forms.Label();
            this.goBackWipeCache = new System.Windows.Forms.Label();
            this.yesWipeCache = new System.Windows.Forms.Label();
            this.noWipeCache = new System.Windows.Forms.Label();
            this.cacheMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OutputToFront = new System.Windows.Forms.Timer(this.components);
            this.ptbBackgroundImage = new System.Windows.Forms.PictureBox();
            this.WipeData.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.InstallZipConfirm.SuspendLayout();
            this.InstallZipPanel.SuspendLayout();
            this.WipeCache.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // installZip
            // 
            this.installZip.AutoSize = true;
            this.installZip.BackColor = System.Drawing.Color.Transparent;
            this.installZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.installZip.ForeColor = System.Drawing.Color.DodgerBlue;
            this.installZip.Location = new System.Drawing.Point(3, 54);
            this.installZip.Name = "installZip";
            this.installZip.Size = new System.Drawing.Size(307, 17);
            this.installZip.TabIndex = 5;
            this.installZip.Text = " - Install zip                                                         ";
            this.installZip.Click += new System.EventHandler(this.installZip_Click);
            this.installZip.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.installZip.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // rebootExit
            // 
            this.rebootExit.AutoSize = true;
            this.rebootExit.BackColor = System.Drawing.Color.Transparent;
            this.rebootExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rebootExit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rebootExit.Location = new System.Drawing.Point(3, 37);
            this.rebootExit.Name = "rebootExit";
            this.rebootExit.Size = new System.Drawing.Size(395, 17);
            this.rebootExit.TabIndex = 6;
            this.rebootExit.Text = " - Reboot system now(exit)                                                       " +
    "";
            this.rebootExit.Click += new System.EventHandler(this.rebootExit_Click);
            this.rebootExit.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.rebootExit.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // factoryresetMenu
            // 
            this.factoryresetMenu.AutoSize = true;
            this.factoryresetMenu.BackColor = System.Drawing.Color.Transparent;
            this.factoryresetMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.factoryresetMenu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.factoryresetMenu.Location = new System.Drawing.Point(3, 71);
            this.factoryresetMenu.Name = "factoryresetMenu";
            this.factoryresetMenu.Size = new System.Drawing.Size(400, 17);
            this.factoryresetMenu.TabIndex = 7;
            this.factoryresetMenu.Text = " - Wipe data/Factory reset                                                       " +
    "  ";
            this.factoryresetMenu.Click += new System.EventHandler(this.factoryReset_Click);
            this.factoryresetMenu.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.factoryresetMenu.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // WipeData
            // 
            this.WipeData.Controls.Add(this.FactorResetLabel);
            this.WipeData.Controls.Add(this.goBackWipeData);
            this.WipeData.Controls.Add(this.yesWipeData);
            this.WipeData.Controls.Add(this.noWipeData);
            this.WipeData.Location = new System.Drawing.Point(3, 235);
            this.WipeData.Name = "WipeData";
            this.WipeData.Size = new System.Drawing.Size(48, 135);
            this.WipeData.TabIndex = 8;
            this.WipeData.Visible = false;
            // 
            // FactorResetLabel
            // 
            this.FactorResetLabel.AutoSize = true;
            this.FactorResetLabel.BackColor = System.Drawing.Color.Transparent;
            this.FactorResetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FactorResetLabel.ForeColor = System.Drawing.Color.White;
            this.FactorResetLabel.Location = new System.Drawing.Point(0, 37);
            this.FactorResetLabel.Name = "FactorResetLabel";
            this.FactorResetLabel.Size = new System.Drawing.Size(191, 34);
            this.FactorResetLabel.TabIndex = 10;
            this.FactorResetLabel.Text = "Confirm wipe of all userdata?\r\nTHIS CANNOT BE UNDONE.";
            // 
            // goBackWipeData
            // 
            this.goBackWipeData.AutoSize = true;
            this.goBackWipeData.BackColor = System.Drawing.Color.Transparent;
            this.goBackWipeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.goBackWipeData.ForeColor = System.Drawing.Color.DodgerBlue;
            this.goBackWipeData.Location = new System.Drawing.Point(0, 109);
            this.goBackWipeData.Name = "goBackWipeData";
            this.goBackWipeData.Size = new System.Drawing.Size(479, 17);
            this.goBackWipeData.TabIndex = 9;
            this.goBackWipeData.Text = " - +++++Go Back+++++                                                             " +
    "                    ";
            this.goBackWipeData.Click += new System.EventHandler(this.goBack_Click);
            this.goBackWipeData.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.goBackWipeData.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // yesWipeData
            // 
            this.yesWipeData.AutoSize = true;
            this.yesWipeData.BackColor = System.Drawing.Color.Transparent;
            this.yesWipeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yesWipeData.ForeColor = System.Drawing.Color.DodgerBlue;
            this.yesWipeData.Location = new System.Drawing.Point(0, 92);
            this.yesWipeData.Name = "yesWipeData";
            this.yesWipeData.Size = new System.Drawing.Size(451, 17);
            this.yesWipeData.TabIndex = 8;
            this.yesWipeData.Text = " - Yes -- Wipe data                                                              " +
    "                   ";
            this.yesWipeData.Click += new System.EventHandler(this.yesWipeData_Click);
            this.yesWipeData.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.yesWipeData.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // noWipeData
            // 
            this.noWipeData.AutoSize = true;
            this.noWipeData.BackColor = System.Drawing.Color.Transparent;
            this.noWipeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.noWipeData.ForeColor = System.Drawing.Color.DodgerBlue;
            this.noWipeData.Location = new System.Drawing.Point(0, 75);
            this.noWipeData.Name = "noWipeData";
            this.noWipeData.Size = new System.Drawing.Size(363, 17);
            this.noWipeData.TabIndex = 7;
            this.noWipeData.Text = " - No                                                                            " +
    "     ";
            this.noWipeData.Click += new System.EventHandler(this.goBack_Click);
            this.noWipeData.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.noWipeData.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // MainMenu
            // 
            this.MainMenu.Controls.Add(this.Output);
            this.MainMenu.Controls.Add(this.InstallZipConfirm);
            this.MainMenu.Controls.Add(this.Title);
            this.MainMenu.Controls.Add(this.InstallZipPanel);
            this.MainMenu.Controls.Add(this.AdvancedMenu);
            this.MainMenu.Controls.Add(this.WipeCache);
            this.MainMenu.Controls.Add(this.cacheMenu);
            this.MainMenu.Controls.Add(this.WipeData);
            this.MainMenu.Controls.Add(this.factoryresetMenu);
            this.MainMenu.Controls.Add(this.rebootExit);
            this.MainMenu.Controls.Add(this.installZip);
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(303, 536);
            this.MainMenu.TabIndex = 10;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(0, 523);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(89, 13);
            this.Output.TabIndex = 9;
            this.Output.Text = "Recovery booted";
            // 
            // InstallZipConfirm
            // 
            this.InstallZipConfirm.Controls.Add(this.InstallZipConfirmLabel);
            this.InstallZipConfirm.Controls.Add(this.label2);
            this.InstallZipConfirm.Controls.Add(this.YesInstallZip);
            this.InstallZipConfirm.Controls.Add(this.noInstallZip);
            this.InstallZipConfirm.Location = new System.Drawing.Point(165, 235);
            this.InstallZipConfirm.Name = "InstallZipConfirm";
            this.InstallZipConfirm.Size = new System.Drawing.Size(48, 135);
            this.InstallZipConfirm.TabIndex = 12;
            this.InstallZipConfirm.Visible = false;
            // 
            // InstallZipConfirmLabel
            // 
            this.InstallZipConfirmLabel.AutoSize = true;
            this.InstallZipConfirmLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstallZipConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InstallZipConfirmLabel.ForeColor = System.Drawing.Color.White;
            this.InstallZipConfirmLabel.Location = new System.Drawing.Point(0, 37);
            this.InstallZipConfirmLabel.Name = "InstallZipConfirmLabel";
            this.InstallZipConfirmLabel.Size = new System.Drawing.Size(221, 17);
            this.InstallZipConfirmLabel.TabIndex = 10;
            this.InstallZipConfirmLabel.Text = "Confirm install from local storage?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(0, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = " - +++++Go Back+++++                                                             " +
    "                    ";
            this.label2.Click += new System.EventHandler(this.goBack_Click);
            this.label2.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.label2.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // YesInstallZip
            // 
            this.YesInstallZip.AutoSize = true;
            this.YesInstallZip.BackColor = System.Drawing.Color.Transparent;
            this.YesInstallZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.YesInstallZip.ForeColor = System.Drawing.Color.DodgerBlue;
            this.YesInstallZip.Location = new System.Drawing.Point(0, 92);
            this.YesInstallZip.Name = "YesInstallZip";
            this.YesInstallZip.Size = new System.Drawing.Size(103, 17);
            this.YesInstallZip.TabIndex = 8;
            this.YesInstallZip.Text = " - Yes -- Install ";
            this.YesInstallZip.Click += new System.EventHandler(this.YesInstallZip_Click);
            this.YesInstallZip.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.YesInstallZip.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // noInstallZip
            // 
            this.noInstallZip.AutoSize = true;
            this.noInstallZip.BackColor = System.Drawing.Color.Transparent;
            this.noInstallZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.noInstallZip.ForeColor = System.Drawing.Color.DodgerBlue;
            this.noInstallZip.Location = new System.Drawing.Point(0, 75);
            this.noInstallZip.Name = "noInstallZip";
            this.noInstallZip.Size = new System.Drawing.Size(363, 17);
            this.noInstallZip.TabIndex = 7;
            this.noInstallZip.Text = " - No                                                                            " +
    "     ";
            this.noInstallZip.Click += new System.EventHandler(this.goBack_Click);
            this.noInstallZip.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.noInstallZip.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(274, 18);
            this.Title.TabIndex = 13;
            this.Title.Text = "CWM-Based emulated recovery v1.0.0.0";
            // 
            // InstallZipPanel
            // 
            this.InstallZipPanel.Controls.Add(this.IntallZipLabel);
            this.InstallZipPanel.Controls.Add(this.installZipGoBack);
            this.InstallZipPanel.Controls.Add(this.SelectZip);
            this.InstallZipPanel.Location = new System.Drawing.Point(111, 235);
            this.InstallZipPanel.Name = "InstallZipPanel";
            this.InstallZipPanel.Size = new System.Drawing.Size(48, 135);
            this.InstallZipPanel.TabIndex = 12;
            this.InstallZipPanel.Visible = false;
            // 
            // IntallZipLabel
            // 
            this.IntallZipLabel.AutoSize = true;
            this.IntallZipLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntallZipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IntallZipLabel.ForeColor = System.Drawing.Color.White;
            this.IntallZipLabel.Location = new System.Drawing.Point(0, 37);
            this.IntallZipLabel.Name = "IntallZipLabel";
            this.IntallZipLabel.Size = new System.Drawing.Size(168, 17);
            this.IntallZipLabel.TabIndex = 10;
            this.IntallZipLabel.Text = "Install update from zip file";
            // 
            // installZipGoBack
            // 
            this.installZipGoBack.AutoSize = true;
            this.installZipGoBack.BackColor = System.Drawing.Color.Transparent;
            this.installZipGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.installZipGoBack.ForeColor = System.Drawing.Color.DodgerBlue;
            this.installZipGoBack.Location = new System.Drawing.Point(0, 78);
            this.installZipGoBack.Name = "installZipGoBack";
            this.installZipGoBack.Size = new System.Drawing.Size(479, 17);
            this.installZipGoBack.TabIndex = 9;
            this.installZipGoBack.Text = " - +++++Go Back+++++                                                             " +
    "                    ";
            this.installZipGoBack.Click += new System.EventHandler(this.goBack_Click);
            this.installZipGoBack.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.installZipGoBack.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // SelectZip
            // 
            this.SelectZip.AutoSize = true;
            this.SelectZip.BackColor = System.Drawing.Color.Transparent;
            this.SelectZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SelectZip.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SelectZip.Location = new System.Drawing.Point(0, 61);
            this.SelectZip.Name = "SelectZip";
            this.SelectZip.Size = new System.Drawing.Size(503, 17);
            this.SelectZip.TabIndex = 7;
            this.SelectZip.Text = " - Select zip from local storage                                                 " +
    "                           ";
            this.SelectZip.Click += new System.EventHandler(this.SelectZip_Click);
            this.SelectZip.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.SelectZip.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // AdvancedMenu
            // 
            this.AdvancedMenu.AutoSize = true;
            this.AdvancedMenu.BackColor = System.Drawing.Color.Transparent;
            this.AdvancedMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AdvancedMenu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AdvancedMenu.Location = new System.Drawing.Point(3, 105);
            this.AdvancedMenu.Name = "AdvancedMenu";
            this.AdvancedMenu.Size = new System.Drawing.Size(396, 17);
            this.AdvancedMenu.TabIndex = 12;
            this.AdvancedMenu.Text = " - Advanced                                                                      " +
    "        ";
            this.AdvancedMenu.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.AdvancedMenu.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // WipeCache
            // 
            this.WipeCache.Controls.Add(this.WipeCacheLabel);
            this.WipeCache.Controls.Add(this.goBackWipeCache);
            this.WipeCache.Controls.Add(this.yesWipeCache);
            this.WipeCache.Controls.Add(this.noWipeCache);
            this.WipeCache.Location = new System.Drawing.Point(57, 235);
            this.WipeCache.Name = "WipeCache";
            this.WipeCache.Size = new System.Drawing.Size(48, 135);
            this.WipeCache.TabIndex = 11;
            this.WipeCache.Visible = false;
            // 
            // WipeCacheLabel
            // 
            this.WipeCacheLabel.AutoSize = true;
            this.WipeCacheLabel.BackColor = System.Drawing.Color.Transparent;
            this.WipeCacheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WipeCacheLabel.ForeColor = System.Drawing.Color.White;
            this.WipeCacheLabel.Location = new System.Drawing.Point(0, 37);
            this.WipeCacheLabel.Name = "WipeCacheLabel";
            this.WipeCacheLabel.Size = new System.Drawing.Size(191, 34);
            this.WipeCacheLabel.TabIndex = 10;
            this.WipeCacheLabel.Text = "Confirm wipe of cache?\r\nTHIS CANNOT BE UNDONE.";
            // 
            // goBackWipeCache
            // 
            this.goBackWipeCache.AutoSize = true;
            this.goBackWipeCache.BackColor = System.Drawing.Color.Transparent;
            this.goBackWipeCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.goBackWipeCache.ForeColor = System.Drawing.Color.DodgerBlue;
            this.goBackWipeCache.Location = new System.Drawing.Point(0, 109);
            this.goBackWipeCache.Name = "goBackWipeCache";
            this.goBackWipeCache.Size = new System.Drawing.Size(479, 17);
            this.goBackWipeCache.TabIndex = 9;
            this.goBackWipeCache.Text = " - +++++Go Back+++++                                                             " +
    "                    ";
            this.goBackWipeCache.Click += new System.EventHandler(this.goBack_Click);
            this.goBackWipeCache.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.goBackWipeCache.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // yesWipeCache
            // 
            this.yesWipeCache.AutoSize = true;
            this.yesWipeCache.BackColor = System.Drawing.Color.Transparent;
            this.yesWipeCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yesWipeCache.ForeColor = System.Drawing.Color.DodgerBlue;
            this.yesWipeCache.Location = new System.Drawing.Point(0, 92);
            this.yesWipeCache.Name = "yesWipeCache";
            this.yesWipeCache.Size = new System.Drawing.Size(461, 17);
            this.yesWipeCache.TabIndex = 8;
            this.yesWipeCache.Text = " - Yes -- Wipe cache                                                             " +
    "                    ";
            this.yesWipeCache.Click += new System.EventHandler(this.yesWipeCache_Click);
            this.yesWipeCache.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.yesWipeCache.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // noWipeCache
            // 
            this.noWipeCache.AutoSize = true;
            this.noWipeCache.BackColor = System.Drawing.Color.Transparent;
            this.noWipeCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.noWipeCache.ForeColor = System.Drawing.Color.DodgerBlue;
            this.noWipeCache.Location = new System.Drawing.Point(0, 75);
            this.noWipeCache.Name = "noWipeCache";
            this.noWipeCache.Size = new System.Drawing.Size(363, 17);
            this.noWipeCache.TabIndex = 7;
            this.noWipeCache.Text = " - No                                                                            " +
    "     ";
            this.noWipeCache.Click += new System.EventHandler(this.goBack_Click);
            this.noWipeCache.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.noWipeCache.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // cacheMenu
            // 
            this.cacheMenu.AutoSize = true;
            this.cacheMenu.BackColor = System.Drawing.Color.Transparent;
            this.cacheMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cacheMenu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cacheMenu.Location = new System.Drawing.Point(3, 88);
            this.cacheMenu.Name = "cacheMenu";
            this.cacheMenu.Size = new System.Drawing.Size(407, 17);
            this.cacheMenu.TabIndex = 10;
            this.cacheMenu.Text = " - Wipe cache                                                                    " +
    "          ";
            this.cacheMenu.Click += new System.EventHandler(this.cacheMenu_Click);
            this.cacheMenu.MouseEnter += new System.EventHandler(this.Menu_Above);
            this.cacheMenu.MouseLeave += new System.EventHandler(this.Menu_NotAbove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(99, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // OutputToFront
            // 
            this.OutputToFront.Enabled = true;
            this.OutputToFront.Tick += new System.EventHandler(this.OutputToFront_Tick);
            // 
            // ptbBackgroundImage
            // 
            this.ptbBackgroundImage.BackColor = System.Drawing.Color.Transparent;
            this.ptbBackgroundImage.BackgroundImage = global::AndroidRecoveryEmulator.Properties.Resources.CWM;
            this.ptbBackgroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.ptbBackgroundImage.Name = "ptbBackgroundImage";
            this.ptbBackgroundImage.Size = new System.Drawing.Size(303, 536);
            this.ptbBackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBackgroundImage.TabIndex = 0;
            this.ptbBackgroundImage.TabStop = false;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(303, 536);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.ptbBackgroundImage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Android Recovery Emulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.WipeData.ResumeLayout(false);
            this.WipeData.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.InstallZipConfirm.ResumeLayout(false);
            this.InstallZipConfirm.PerformLayout();
            this.InstallZipPanel.ResumeLayout(false);
            this.InstallZipPanel.PerformLayout();
            this.WipeCache.ResumeLayout(false);
            this.WipeCache.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackgroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbBackgroundImage;
        private System.Windows.Forms.Label installZip;
        private System.Windows.Forms.Label rebootExit;
        private System.Windows.Forms.Label factoryresetMenu;
        private System.Windows.Forms.Panel WipeData;
        private System.Windows.Forms.Label goBackWipeData;
        private System.Windows.Forms.Label yesWipeData;
        private System.Windows.Forms.Label noWipeData;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Label FactorResetLabel;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Timer OutputToFront;
        private System.Windows.Forms.Panel WipeCache;
        private System.Windows.Forms.Label AdvancedMenu;
        private System.Windows.Forms.Label cacheMenu;
        private System.Windows.Forms.Label noWipeCache;
        private System.Windows.Forms.Label yesWipeCache;
        private System.Windows.Forms.Label goBackWipeCache;
        private System.Windows.Forms.Label WipeCacheLabel;
        private System.Windows.Forms.Panel InstallZipPanel;
        private System.Windows.Forms.Label noInstallZip;
        private System.Windows.Forms.Label YesInstallZip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InstallZipConfirmLabel;
        private System.Windows.Forms.Label InstallZipConfirm;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SelectZip;
        private System.Windows.Forms.Label installZipGoBack;
        private System.Windows.Forms.Label IntallZipLabel;
    }
}

