using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace FormatTool
{
    public partial class FormMain : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern SafeFileHandle CreateFileA(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        private SafeFileHandle _DriverHandle;
        private System.IO.FileStream _DriverStream ;

        private const uint GENERIC_READ = 0x80000000;
        private const uint GENERIC_WRITE = 0x40000000;
        private const uint FILE_SHARE_READ = 0x00000001;
        private const uint FILE_SHARE_WRITE = 0x00000002;
        private const uint OPEN_EXISTING = 3;

        System.IO.DriveInfo[] DriverInfo;

        public FormMain()
        {
            InitializeComponent();
        }
        
        void RefreshDrivers()
        {
            try
            {
                cb_disk.Items.Clear();

                DriverInfo = System.IO.DriveInfo.GetDrives();
                foreach (System.IO.DriveInfo Info in DriverInfo)
                {
                    if (Info.DriveType == System.IO.DriveType.Removable)
                    {
                        cb_disk.Items.Add(Info.Name);
                    }
                }

                _DriverHandle = CreateFileA("\\\\.\\H:", GENERIC_READ, FILE_SHARE_READ, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
                _DriverStream = new System.IO.FileStream(_DriverHandle, System.IO.FileAccess.Read);

                byte[] bufferTest = new byte[512];
                _DriverStream.Read(bufferTest, 0, 512);

                _DriverStream.Close();
                _DriverHandle.Close();
            }
            catch (Exception ee)
            {}
        }


        private void cb_agreed_CheckedChanged(object sender, EventArgs e)
        {
            //同意声明后才能使用
            if (cb_agreed.Checked)
            {
                bt_repart.Enabled = true; 
            }
            else
            {
                bt_repart.Enabled = false;
            }

        }

        private void bt_ref_Click(object sender, EventArgs e)
        {
            RefreshDrivers();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            bt_repart.Enabled = false; //默认禁止使用
            RefreshDrivers();
        }

        private void bt_repart_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("1、马上开始格式化磁盘" + cb_agreed.Text + "的分区信息，这将损坏此磁盘上的所有数据！\n\n2、请关闭杀毒软件或在杀毒软件提示拦截时允许此程序执行！", "警告", MessageBoxButtons.OKCancel))
            {
                //用户已确认！
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = @"bin\repartition.exe";//需要启动的程序名       
                p.StartInfo.Arguments = cb_disk.Text.Trim();//启动参数       
                p.Start();//启动       
                while (!p.HasExited)//判断是否运行结束       
                {}
                //p.Kill();

                if (p.ExitCode != 0)
                {
                    MessageBox.Show("重新调整分区已失败！失败退出码：" + p.ExitCode.ToString(), "提示：");
                }
                else
                {
                    MessageBox.Show("重新调整分区已完成，请重新插拔设备后重新将磁盘格式化为FAT32或FAT格式！", "提示：");
                }
            }
            else
            { }


        }

   
    }
}
