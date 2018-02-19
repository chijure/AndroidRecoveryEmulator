using AndroidRecoveryEmulator.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AndroidRecoveryEmulator
{
    public partial class frmMain : Form
    {
        public static string zip;
        public static bool error;
        public static int lineno;
        public static int progress;       
        public frmMain()
        {
            InitializeComponent();
            WipeData.Parent = ptbBackgroundImage;
            WipeData.BackColor = Color.Transparent;
            InstallZipPanel.Parent = ptbBackgroundImage;
            InstallZipPanel.BackColor = Color.Transparent;
            InstallZipConfirm.Parent = ptbBackgroundImage;
            InstallZipConfirm.BackColor = Color.Transparent;
            WipeCache.Parent = ptbBackgroundImage;
            WipeCache.BackColor = Color.Transparent;
            MainMenu.Parent = ptbBackgroundImage;
            MainMenu.BackColor = Color.Transparent;
            Output.Parent = ptbBackgroundImage;
            Output.BackColor = Color.Transparent;
            Title.Parent = ptbBackgroundImage;
            Title.BackColor = Color.Transparent;
        }
        private void cacheMenu_Click(object sender, EventArgs e)
        {
            WipeCache.Visible = true;
            WipeCache.Dock = DockStyle.Fill;
        }
        private void factoryReset_Click(object sender, EventArgs e)
        {
            WipeData.Visible = true;
            WipeData.Dock = DockStyle.Fill;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice")))
            {
                Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice"));
            }
            if (!Directory.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\system")))
            {
                Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\system"));
            }
            if (!Directory.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\data")))
            {
                Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\data"));
            }
            if (!Directory.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\cache")))
            {
                Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\cache"));
            }
            if (!Directory.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\tmp")))
            {
                Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\tmp"));
            }
            if (!Directory.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\dev")))
            {
                Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\dev"));
            }
            MessageBox.Show("This is free software, please take the time of day to thank\nthe developer - Ricky Divjakovski.\n\nA paid version will be available to remove this message\nand exclusive features will be availabe to paid users.", "A message from the developer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void goBack_Click(object sender, EventArgs e)
        {
            ((Label)sender).Parent.Visible = false;
        }
        private void installZip_Click(object sender, EventArgs e)
        {
            InstallZipPanel.Visible = true;
            InstallZipPanel.Dock = DockStyle.Fill;
        }
        private void Menu_Above(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.DodgerBlue;
            ((Label)sender).ForeColor = Color.White;
        }
        private void Menu_NotAbove(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
            ((Label)sender).ForeColor = Color.DodgerBlue;
        }
        private void OutputToFront_Tick(object sender, EventArgs e)
        {
            Output.BringToFront();
            Title.BringToFront();
        }
        private void rebootExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SelectZip_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Zip Files|*.zip;",
                Multiselect = false
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                ((Label)sender).Parent.Visible = false;
                return;
            }
            frmMain.zip = openFileDialog.FileName;
            ((Label)sender).Parent.Visible = false;
            YesInstallZip.Text = string.Concat(YesInstallZip.Text, Path.GetFileName(frmMain.zip), "                                                        ");
            InstallZipConfirm.Visible = true;
            InstallZipConfirm.Dock = DockStyle.Fill;
        }
        private void YesInstallZip_Click(object sender, EventArgs e)
        {
            int i;
            if (!File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\unzip.exe")))
            {
                File.WriteAllBytes(string.Concat(Directory.GetCurrentDirectory(), "\\unzip.exe"), Resources.unzip);
            }
            frmMain.lineno = 0;
            frmMain.progress = 0;
            frmMain.error = false;
            try
            {
                Directory.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualZip"), true);
            }
            catch
            {
            }
            Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualZip"));
            ((Label)sender).Parent.Visible = false;
            MainMenu.Visible = false;
            Output.Text = string.Concat(Output.Text, "\n");
            Output.Text = string.Concat(Output.Text, "\n-- Installing: ", Path.GetFileName(frmMain.zip));
            Output.Text = string.Concat(Output.Text, "\nFinding update package...");
            Output.Text = string.Concat(Output.Text, "\nOpening update package...");
            Process process = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = false,
                FileName = string.Concat(Directory.GetCurrentDirectory(), "\\unzip.exe"),
                Arguments = string.Concat(new string[] { " \"", frmMain.zip, "\" -d \"", Directory.GetCurrentDirectory(), "\\VirtualZip\"" })
            };
            process.StartInfo = processStartInfo;
            process.Start();
            process.WaitForExit();
            if (File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\unzip.exe")))
            {
                File.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\unzip.exe"));
            }
            if (!File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualZip\\META-INF\\com\\google\\android\\updater-script")))
            {
                Output.Text = string.Concat(Output.Text, "\n{0}ERROR: No upater-script");
                frmMain.error = true;
            }
            else
            {
                Output.Text = string.Concat(Output.Text, "\nInstalling update...");
                foreach (string str in File.ReadLines(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualZip\\META-INF\\com\\google\\android\\updater-script")))
                {
                    frmMain.lineno++;
                    str.StartsWith("#");
                    if (str.StartsWith("ui_print("))
                    {
                        Output.Text = string.Concat(Output.Text, "\n", str.Split(new char[] { '\"' })[1]);
                    }
                    if (str.StartsWith("package_extract_file("))
                    {
                        string str1 = str.Split(new char[] { '\"' })[1];
                        string str2 = str.Split(new char[] { '\"' })[3];
                        str1 = str1.Replace("/", "\\");
                        str2 = str2.Replace("/", "\\");
                        if (str1 == "boot.img")
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str2)));
                        }
                        if (File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str2)))
                        {
                            File.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str2));
                        }
                        if (!Directory.Exists(Path.GetDirectoryName(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str2))))
                        {
                            Label output = Output;
                            object[] text = new object[] { Output.Text, "\n{", frmMain.lineno, "}ERROR: Directory does not exist - ", null };
                            text[4] = str.Split(new char[] { '\"' })[3];
                            output.Text = string.Concat(text);
                        }
                        else
                        {
                            File.Copy(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualZip\\", str1), string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str2));
                        }
                    }
                    if (str.StartsWith("package_extract_dir("))
                    {
                        string str3 = str.Split(new char[] { '\"' })[1];
                        string str4 = str.Split(new char[] { '\"' })[3];
                        str3 = str3.Replace("/", "\\");
                        str4 = str4.Replace("/", "\\");
                        if (!Directory.Exists(Path.GetDirectoryName(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\", str4))))
                        {
                            Label label = Output;
                            object[] objArray = new object[] { Output.Text, "\n{", frmMain.lineno, "}ERROR: directory not found in zip - ", null };
                            objArray[4] = str.Split(new char[] { '\"' })[1];
                            label.Text = string.Concat(objArray);
                            frmMain.error = true;
                        }
                        else
                        {
                            string[] directories = Directory.GetDirectories(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualZip\\", str3), "*", SearchOption.AllDirectories);
                            for (i = 0; i < (int)directories.Length; i++)
                            {
                                Directory.CreateDirectory(directories[i].Replace(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualZip\\", str3), string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str4)));
                            }
                            directories = Directory.GetFiles(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualZip\\", str3), "*.*", SearchOption.AllDirectories);
                            for (i = 0; i < (int)directories.Length; i++)
                            {
                                string str5 = directories[i];
                                File.Copy(str5, str5.Replace(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualZip\\", str3), string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str4)), true);
                            }
                            Directory.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualZip\\", str3), true);
                        }
                    }
                    if (str.StartsWith("block_image_update("))
                    {
                        string str6 = str.Split(new char[] { '\"' })[1];
                        str6 = str6.Replace("/", "\\");
                        Output.Text = string.Concat(Output.Text, "\nApplying block update to - ", Path.GetFileName(str6));
                    }
                    if (str.StartsWith("run_program("))
                    {
                        string str7 = str.Split(new char[] { '\"' })[1];
                        str7 = str7.Replace("/", "\\");
                        if (!str.StartsWith("run_program(\"/system") && !str.StartsWith("run_program(\"/tmp"))
                        {
                            Label output1 = Output;
                            object[] text1 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: file not found - ", null };
                            text1[4] = str.Split(new char[] { '\"' })[1];
                            output1.Text = string.Concat(text1);
                            frmMain.error = true;
                        }
                        else if (!File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str7)))
                        {
                            Label label1 = Output;
                            object[] objArray1 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: file not found - ", null };
                            objArray1[4] = str.Split(new char[] { '\"' })[1];
                            label1.Text = string.Concat(objArray1);
                            frmMain.error = true;
                        }
                    }
                    if (str.StartsWith("delete("))
                    {
                        string str8 = str.Split(new char[] { '\"' })[1];
                        str8 = str8.Replace("/", "\\");
                        if (!str.StartsWith("delete(\"/system"))
                        {
                            Label output2 = Output;
                            object[] text2 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: file not found - ", null };
                            text2[4] = str.Split(new char[] { '\"' })[1];
                            output2.Text = string.Concat(text2);
                            frmMain.error = true;
                        }
                        else if (!File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str8)))
                        {
                            Label label2 = Output;
                            object[] objArray2 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: file not found - ", null };
                            objArray2[4] = str.Split(new char[] { '\"' })[1];
                            label2.Text = string.Concat(objArray2);
                            frmMain.error = true;
                        }
                        else
                        {
                            File.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str8));
                        }
                    }
                    if (str.StartsWith("delete_recursive("))
                    {
                        string str9 = str.Split(new char[] { '\"' })[1];
                        str9 = str9.Replace("/", "\\");
                        if (!str.StartsWith("delete_recursive(\"/system"))
                        {
                            Label output3 = Output;
                            object[] text3 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: directory not found - ", null };
                            text3[4] = str.Split(new char[] { '\"' })[1];
                            output3.Text = string.Concat(text3);
                            frmMain.error = true;
                        }
                        else if (!File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str9)))
                        {
                            Label label3 = Output;
                            object[] objArray3 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: directory not found - ", null };
                            objArray3[4] = str.Split(new char[] { '\"' })[1];
                            label3.Text = string.Concat(objArray3);
                            frmMain.error = true;
                        }
                        else
                        {
                            Directory.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str9));
                        }
                    }
                    if (!str.StartsWith("abort()"))
                    {
                        if (str.StartsWith("format("))
                        {
                            string str10 = str.Split(new char[] { '\"' })[7];
                            str10 = str10.Replace("/", "\\");
                            if (!str.Split(new char[] { '\"' })[7].StartsWith("/system"))
                            {
                                if (!str.Split(new char[] { '\"' })[7].StartsWith("/data"))
                                {
                                    if (!str.Split(new char[] { '\"' })[7].StartsWith("/cache"))
                                    {
                                        goto Label1;
                                    }
                                }
                            }
                            Directory.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str10), true);
                            Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str10));
                        }
                    Label1:
                        if (str.StartsWith("set_perm("))
                        {
                            string str11 = str.Split(new char[] { '\"' })[1];
                            str11 = str11.Replace("/", "\\");
                            if (!File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str11)))
                            {
                                Label output4 = Output;
                                object[] text4 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: file not found - ", null };
                                text4[4] = str.Split(new char[] { '\"' })[1];
                                output4.Text = string.Concat(text4);
                                frmMain.error = true;
                            }
                        }
                        if (str.StartsWith("set_perm_recursive("))
                        {
                            string str12 = str.Split(new char[] { '\"' })[1];
                            str12 = str12.Replace("/", "\\");
                            if (!Directory.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str12)))
                            {
                                Label label4 = Output;
                                object[] objArray4 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: directory not found - ", null };
                                objArray4[4] = str.Split(new char[] { '\"' })[1];
                                label4.Text = string.Concat(objArray4);
                                frmMain.error = true;
                            }
                        }
                        if (str.StartsWith("set_metadata("))
                        {
                            string str13 = str.Split(new char[] { '\"' })[1];
                            str13 = str13.Replace("/", "\\");
                            if (!File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str13)))
                            {
                                Label output5 = Output;
                                object[] text5 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: file not found - ", null };
                                text5[4] = str.Split(new char[] { '\"' })[1];
                                output5.Text = string.Concat(text5);
                                frmMain.error = true;
                            }
                        }
                        if (str.StartsWith("set_metadata_recursive("))
                        {
                            string str14 = str.Split(new char[] { '\"' })[1];
                            str14 = str14.Replace("/", "\\");
                            if (!Directory.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str14)))
                            {
                                Label label5 = Output;
                                object[] objArray5 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: directory not found - ", null };
                                objArray5[4] = str.Split(new char[] { '\"' })[1];
                                label5.Text = string.Concat(objArray5);
                                frmMain.error = true;
                            }
                        }
                        if (str.StartsWith("set_metadata_recursive("))
                        {
                            string str15 = str.Split(new char[] { '\"' })[1];
                            str15 = str15.Replace("/", "\\");
                            if (!Directory.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str15)))
                            {
                                Label output6 = Output;
                                object[] text6 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: directory not found - ", null };
                                text6[4] = str.Split(new char[] { '\"' })[1];
                                output6.Text = string.Concat(text6);
                                frmMain.error = true;
                            }
                        }
                        if (str.StartsWith("symlink("))
                        {
                            string str16 = str.Split(new char[] { '\"' })[1];
                            if (str16.StartsWith("/"))
                            {
                                str16 = str16.Replace("/", "\\");
                                if (!File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str16)))
                                {
                                    Label label6 = Output;
                                    object[] objArray6 = new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: file not found - ", null };
                                    objArray6[4] = str.Split(new char[] { '\"' })[1];
                                    label6.Text = string.Concat(objArray6);
                                    frmMain.error = true;
                                }
                                else if (!File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str.Split(new char[] { '\"' })[3].Replace("/", "\\"))))
                                {
                                    File.Create(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str.Split(new char[] { '\"' })[3].Replace("/", "\\")));
                                }
                            }
                            else if (!File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\system\\bin\\", str16)))
                            {
                                Output.Text = string.Concat(new object[] { Output.Text, "\n{", frmMain.lineno, "}POSSIBLE ERROR: file not found - /system/bin/", str16 });
                                frmMain.error = true;
                            }
                            else if (!File.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str.Split(new char[] { '\"' })[3].Replace("/", "\\"))))
                            {
                                File.Create(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice", str.Split(new char[] { '\"' })[3].Replace("/", "\\")));
                            }
                        }
                        if (!str.StartsWith("show_progress("))
                        {
                            continue;
                        }
                        string str17 = str.Split(new char[] { '(' })[1];
                        str17 = str17.Split(new char[] { ',' })[0];
                        frmMain.progress = frmMain.progress + int.Parse(str17.Split(new char[] { '.' })[1]) * 10;
                        if (frmMain.progress > 100)
                        {
                            Output.Text = string.Concat(Output.Text, "\nProgress - 100%");
                        }
                        else if (!str17.StartsWith("1.0"))
                        {
                            Output.Text = string.Concat(Output.Text, "\nProgress - ", frmMain.progress.ToString(), "%");
                        }
                        else
                        {
                            Output.Text = string.Concat(Output.Text, "\nProgress - 100%");
                        }
                    }
                    else
                    {
                        Output.Text = string.Concat(new object[] { Output.Text, "\n{", frmMain.lineno, "}INSTALL ABORTED" });
                        frmMain.error = true;
                        goto Label0;
                    }
                }
            Label0:
                Directory.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\tmp"), true);
                Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\tmp"));
                try
                {
                    Directory.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualZip"), true);
                }
                catch
                {
                }
                if (Directory.Exists(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\dev")))
                {
                    Directory.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\dev"), true);
                }
                Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\dev"));
            }
            if (frmMain.error)
            {
                Output.Text = string.Concat(Output.Text, "\nInstall from local storage FAILED with POSSIBLE errors.");
            }
            else
            {
                Output.Text = string.Concat(Output.Text, "\nInstall from local storage SUCCEEDED.");
            }
            frmMain.error = false;
            frmMain.lineno = 0;
            MainMenu.Visible = true;
        }
        private void yesWipeCache_Click(object sender, EventArgs e)
        {
            Directory.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\cache"), true);
            Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\cache"));
            Output.Text = string.Concat(Output.Text, "\nWiped cache");
            ((Label)sender).Parent.Visible = false;
        }
        private void yesWipeData_Click(object sender, EventArgs e)
        {
            Directory.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\system"), true);
            Directory.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\data"), true);
            Directory.Delete(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\cache"), true);
            Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\system"));
            Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\data"));
            Directory.CreateDirectory(string.Concat(Directory.GetCurrentDirectory(), "\\VirtualDevice\\cache"));
            Output.Text = string.Concat(Output.Text, "\nWiped system, data and cache");
            ((Label)sender).Parent.Visible = false;
        }
    }
}
