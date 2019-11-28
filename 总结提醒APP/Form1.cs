using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace 总结提醒APP
{
    public partial class 该写总结了 : Form
    {
        public 该写总结了()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process m_Process = null;
            m_Process = new Process();
            m_Process.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD";
            m_Process.Start();
            Screen[] screen = Screen.AllScreens;
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Clip = screen[0].Bounds;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void 该写总结了_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            System.Windows.Forms.Cursor.Position = this.Location;
            System.Windows.Forms.Cursor.Clip = new Rectangle(this.Location, this.Size);
            //限定鼠标的活动范围仅在窗口内
        }

        private void 该写总结了_MouseMove(object sender, MouseEventArgs e) => System.Windows.Forms.Cursor.Clip = new Rectangle(this.Location, this.Size);//限定鼠标的活动范围仅在窗口内

        private void 该写总结了_MouseLeave(object sender, EventArgs e) => System.Windows.Forms.Cursor.Clip = new Rectangle(this.Location, this.Size);//限定鼠标的活动范围仅在窗口内

        private void 该写总结了_Shown(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
