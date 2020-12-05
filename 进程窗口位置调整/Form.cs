using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using static 进程窗口位置调整.User32;
using static 进程窗口位置调整.Win32;

namespace 进程窗口位置调整
{
    public partial class Form : System.Windows.Forms.Form
    {

        public Process[] Pros;
        public Process[] UserPros;
        public Process ItemPro = null;
        public Screen[] Scrs;
        public Screen ItemScr = null;
        public Rectangle WinScr = Rectangle.Empty;
        public Form()
        {
            InitializeComponent();
            //HighcheckBox.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Process> UserProsList=new List<Process> { };

            Pros = Process.GetProcesses();

            if (HighcheckBox.Checked == true)
            {
                foreach (Process Pro in Pros)
                {
                    ProslistBox.Items.Add(Pro.Id + " : " + Pro.ProcessName + " : " + Pro.MainWindowTitle);
                    ListViewItem ProSubList = new ListViewItem(Pro.Id.ToString());

                    ProSubList.SubItems.Add(Pro.ProcessName);//= ListViewSubItem listView;
                    ProSubList.SubItems.Add(Pro.MainWindowTitle);//= ListViewSubItem listView;

                    try
                    {
                        ProSubList.SubItems.Add(Pro.Handle.ToString());
                    }
                    catch { ProSubList.SubItems.Add("-1"); }

                    ProSubList.SubItems.Add(Pro.MainWindowHandle.ToString());
                    ProcesslistView.Items.Add(ProSubList);
                }
            }
            else
            {
                int k=0;
                foreach (Process Pro in Pros)
                {
                    try
                    {
                        if (Pro.MainWindowHandle.ToInt32() != 0 && Pro.MainWindowHandle.ToInt32() != 0)
                        {
                            ProslistBox.Items.Add(Pro.Id + " : " + Pro.ProcessName + " : " + Pro.MainWindowTitle);
                            ListViewItem ProSubList = new ListViewItem(Pro.Id.ToString());

                            ProSubList.SubItems.Add(Pro.ProcessName);//= ListViewSubItem listView;
                            ProSubList.SubItems.Add(Pro.MainWindowTitle);//= ListViewSubItem listView;

                            try
                            {
                                ProSubList.SubItems.Add(Pro.Handle.ToString());
                            }
                            catch { ProSubList.SubItems.Add("-1"); }

                            ProSubList.SubItems.Add(Pro.MainWindowHandle.ToString());
                            ProcesslistView.Items.Add(ProSubList);

                            UserProsList.Add(Pro);
                            k++;
                        }
                    }
                    catch { }

                }
                UserPros = UserProsList.ToArray();
            }
            


            Scrs = Screen.AllScreens;
            foreach (Screen Scr in Scrs)
            {
                WincomboBox.Items.Add(Scr.DeviceName + " : " + Scr.Primary);
                if (Scr.Primary)
                {
                    WincomboBox.SelectedItem = Scr.DeviceName + " : " + Scr.Primary;
                    ItemScr = Scrs[WincomboBox.SelectedIndex];
                }

            }
        }

        private void ProslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Item = ProslistBox.SelectedIndex;
            Process Pro;

            if (HighcheckBox.Checked == true)
            {
                Pro = Pros[Item];
            }
            else
            {
                Pro = UserPros[Item];
            }
            // 查找程序窗口句柄
            IntPtr handle = FindWindow(null, Pro.ProcessName);
            if (handle == IntPtr.Zero)
            {
                Itemlabel.Text = Pro.ProcessName;
                try
                {
                    Itemlabel.Text = "ProcessName : " + Pro.ProcessName + '\n' +
                    "Id : " + Pro.Id + '\n' +
                    "Handle : " + Pro.Handle + '\n' +
                    "MainWindowHandle : " + Pro.MainWindowHandle;
                    ItemPro = Pro;
                    Mainlabel.Text = "已选中进程：" + ItemPro.ProcessName;
                    
                }
                catch { }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<Process> UserProsList = new List<Process> { };

            UserPros = null;
            
            ProslistBox.Items.Clear();
            WincomboBox.Items.Clear();
            ProcesslistView.Items.Clear();

            Pros = Process.GetProcesses();

            if (HighcheckBox.Checked == true)
            {
                foreach (Process Pro in Pros)
                {
                    ProslistBox.Items.Add(Pro.Id + " : " + Pro.ProcessName + " : " + Pro.MainWindowTitle);

                    ListViewItem ProSubList = new ListViewItem(Pro.Id.ToString());

                    ProSubList.SubItems.Add(Pro.ProcessName);//= ListViewSubItem listView;
                    ProSubList.SubItems.Add(Pro.MainWindowTitle);//= ListViewSubItem listView;

                    try
                    {
                        ProSubList.SubItems.Add(Pro.Handle.ToString());
                    }
                    catch { ProSubList.SubItems.Add("-1"); }

                    ProSubList.SubItems.Add(Pro.MainWindowHandle.ToString());
                    ProcesslistView.Items.Add(ProSubList);
                }
            }
            else
            {
                int k = 0;
                foreach (Process Pro in Pros)
                {
                    try
                    {
                        if (Pro.MainWindowHandle.ToInt32() != 0 && Pro.MainWindowHandle.ToInt32() != 0)
                        {
                            ProslistBox.Items.Add(Pro.Id + " : " + Pro.ProcessName + " : " + Pro.MainWindowTitle);
                            ListViewItem ProSubList = new ListViewItem(Pro.Id.ToString());

                            ProSubList.SubItems.Add(Pro.ProcessName);//= ListViewSubItem listView;
                            ProSubList.SubItems.Add(Pro.MainWindowTitle);//= ListViewSubItem listView;

                            try
                            {
                                ProSubList.SubItems.Add(Pro.Handle.ToString());
                            }
                            catch { ProSubList.SubItems.Add("-1"); }

                            ProSubList.SubItems.Add(Pro.MainWindowHandle.ToString());
                            ProcesslistView.Items.Add(ProSubList);

                            UserProsList.Add(Pro);
                            k++;
                        }
                    }
                    catch { }

                }
                UserPros = UserProsList.ToArray();
            }

            Scrs = Screen.AllScreens;
            foreach (Screen Scr in Scrs)
            {
                WincomboBox.Items.Add(Scr.DeviceName + " : " + Scr.Primary);
                if (Scr.Primary)
                {
                    WincomboBox.SelectedItem = Scr.DeviceName + " : " + Scr.Primary;
                    ItemScr = Scrs[WincomboBox.SelectedIndex];
                }

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Showlabel.Text = "输出结果：";

            if (ItemPro != null) 
            {
                if (ItemPro.MainWindowHandle != IntPtr.Zero && WinScr!=Rectangle.Empty) 
                {
                    //if (IsIconic(ItemPro.MainWindowHandle))
                    //{

                        ShowWindow(ItemPro.MainWindowHandle, 1);

                    //}
                    if (CentercheckBox.Checked==true)
                    {
                        if (MoveWindow(ItemPro.MainWindowHandle, WinScr.Right / 6, WinScr.Bottom / 6, WinScr.Right * 2 / 3, WinScr.Bottom * 2 / 3, true)) 
                        {
                            Showlabel.Text = "调整成功！";
                        }
                        else
                        {
                            Showlabel.Text = "调整失败！";
                        }
                    }
                    else
                    {
                        if (MoveWindow(ItemPro.MainWindowHandle, WinScr.Location.X, WinScr.Location.Y, WinScr.Right, WinScr.Bottom, true))
                        {
                            Showlabel.Text = "调整成功！";
                        }
                        else
                        {
                            Showlabel.Text = "调整失败！";
                        }
                    }
                    
                }
            }
            
        }

        private void WincomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemScr = Scrs[WincomboBox.SelectedIndex];
            WinScr = ItemScr.Bounds;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }
    }
}
