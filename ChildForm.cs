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
    public partial class ChildForm : Form
    {
        ToolStripMenuItem currentItem;
        public ChildForm()
        {
            InitializeComponent();
            //привязали контекстное меню к нужной форме
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            currentItem = bigToolStripMenuItem;
        }
        public void Copy()
        {
            richTextBox1.Copy();
        }
        public void Paste()
        {
            richTextBox1.Paste();
        }
        public void Cut()
        {
            richTextBox1.Cut();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChildForm_Load(object sender, EventArgs e)
        {

        }

       
            private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //сбрасывание предыдущего выбранного пункта

            if (currentItem != null) currentItem.Checked = false;
            currentItem = (sender as ToolStripMenuItem);
            //установление нового выбранного пункта

            currentItem.Checked = true;
            //в Tag хранится значение размера
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily,
            int.Parse(currentItem.Tag.ToString()));
        
    }

        //private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, int.Parse(bigToolStripMenuItem.Tag.ToString()));
        //    bigToolStripMenuItem.Checked = true;
        //    smalToolStripMenuItem.Checked = false;
        //}

        //private void smalToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, int.Parse(smalToolStripMenuItem.Tag.ToString()));
        //    bigToolStripMenuItem.Checked = false;
        //    smalToolStripMenuItem.Checked = true;

        //}
    }
}
