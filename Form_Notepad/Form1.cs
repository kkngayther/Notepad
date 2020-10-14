using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Form_Notepad
{
    public partial class Form1 : Form
    {
        string filename = "Untitles - Notepad";
        string temp = "";

        public Form1()
        {
            InitializeComponent();
            this.Text = filename;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNoiDung.Modified)
            {
                string temp = this.Text;
                if (temp[0] == '*')
                {
                    if (MessageBox.Show("Bạn có muốn lưu thay đổi?", "Notepad", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        itemSave_Click(null, null);
                    }
                    filename = "Untitles - Notepad";
                }
            }
            txtNoiDung.Text = "";
            this.Text = "Untitles - Notepad";
        }
        private void itemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtNoiDung.Font = fontDialog1.Font;
            }
        }
        private void itemSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                File.WriteAllText(filename, txtNoiDung.Text);
                this.Text = filename;
            }    
        }

        private void itemSave_Click(object sender, EventArgs e)
        {
            if (filename == "Untitles - Notepad")
            {
                itemSaveAs_Click(null, null);
            }
            else
            {
                File.WriteAllText(filename, txtNoiDung.Text);
                this.Text = filename;
            }
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            if (txtNoiDung.Modified)
            {
                this.Text = "*" + filename;
            }
        }

        private void itemOpen_Click(object sender, EventArgs e)
        {
            if (txtNoiDung.Modified)
            {
                if (MessageBox.Show("Bạn có muốn lưu thay đổi?", "Notepad", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    itemSave_Click(null, null);
                }    
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                txtNoiDung.Text = File.ReadAllText(filename);
                this.Text = filename;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked)
            {
                txtNoiDung.WordWrap = true;
            }    
            else
            {
                txtNoiDung.WordWrap = false;
            }    
        }

        private void itemCut_Click(object sender, EventArgs e)
        {
            temp = txtNoiDung.SelectedText;
            txtNoiDung.SelectedText = "";
        }

        private void itemCopy_Click(object sender, EventArgs e)
        {
            temp = txtNoiDung.SelectedText;
        }

        private void itemPaste_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text += temp;
        }

        private void itemDelete_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = "";
        }

        private void itemSelectAll_Click(object sender, EventArgs e)
        {
            txtNoiDung.SelectAll();
        }

        private void itemTimeDate_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txtNoiDung.Text = now.ToString();
        }

        private void itemZoomIn_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = txtNoiDung.Font.Size;
            currentSize += 2;
            txtNoiDung.Font = new Font(txtNoiDung.Font.Name, currentSize, txtNoiDung.Font.Style, txtNoiDung.Font.Unit);
        }

        private void itemZoomOut_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = txtNoiDung.Font.Size;
            currentSize -= 2;
            txtNoiDung.Font = new Font(txtNoiDung.Font.Name, currentSize, txtNoiDung.Font.Style, txtNoiDung.Font.Unit);
        }

        private void restoreDefaultZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float defaultSize = 12;
            txtNoiDung.Font = new Font(txtNoiDung.Font.Name, defaultSize, txtNoiDung.Font.Style, txtNoiDung.Font.Unit);
        }
    }
}
