using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace JsonToClass
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]//COM+组件可见
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 550;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            webBrowser_JsonToClass.IsWebBrowserContextMenuEnabled = false;
            webBrowser_JsonToClass.Navigate(new Uri(path + "/JsonToClass.html"));

            //this.BackColor = Color.White;
            //this.TransparencyKey = Color.White;
            //this.Opacity = 0.5;
            
        }
    }
}
