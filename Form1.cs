using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        MenuStrip menu;


        public Form1()
        {
            InitializeComponent();
            menu = new MenuStrip();//Создали контейнер при загрузке формы
            ToolStripMenuItem mFile = new ToolStripMenuItem("File");
            mFile.Text = @"&File";
            menu.Items.Add(mFile);
            ToolStripMenuItem mExit = new ToolStripMenuItem("Exit");
            mFile.DropDownItems.Add(mExit);
            mExit.Click += MExit_Click;
            menu.Parent = this;//для того чтоб было видно что мы создали нужна эта привязка
        }

        private void MExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           

        }
    }
}
