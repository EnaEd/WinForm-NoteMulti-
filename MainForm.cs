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
    public partial class MainForm : Form
    {
        int cnt = 0;
        public MainForm()
        {
            InitializeComponent();
            menuStrip1.MdiWindowListItem = windowToolStripMenuItem;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cnt++;
            ChildForm chF = new ChildForm();
            chF.Text = string.Format("Document {0}",cnt);
            chF.MdiParent = this;
            chF.Show();
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVirticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //понять какая форма активная и вызвать нужный метод
            ChildForm chf = this.ActiveMdiChild as ChildForm;
            chf.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm chf = this.ActiveMdiChild as ChildForm;
            chf.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
