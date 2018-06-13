using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softLockTask
{

    public partial class Form1 : Form

    {
        private String _file;
        private CBC cBC;
        private Byte[] enFile;


        public Form1()
        {
            InitializeComponent();
            cBC = new CBC();
        }
        

        private void _ofbd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fbd = new OpenFileDialog()) {
                fbd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fbd.FilterIndex = 2;
                fbd.RestoreDirectory = true;
                FileInfo c;
                if (fbd.ShowDialog() == DialogResult.OK) {
                    _file = fbd.FileName;
                    c = new FileInfo(_file);
                    directory.Text = c.DirectoryName;
                    Fname.Text = c.Name;
                    size.Text = (((float)c.Length / (float)1024.00)).ToString()+"KB";
                    ext.Text = c.Extension;
                }
            }
          
        }
        private void act(int action)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "unknown.txt";
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (savefile.ShowDialog() == DialogResult.OK) {
                byte[] f2 = File.ReadAllBytes(_file);
                cBC.clear_buffout();
                cBC.set_buffIN(f2);
                if (action == 1) {
                    cBC.encrypt();
                }
                else {
                    cBC.decrypt();
                }
                enFile = cBC.get_buffout().ToArray();
                File.WriteAllBytes(savefile.FileName, enFile);
                MessageBox.Show("The file was saved in this path:" + savefile.FileName);
            }
        }

        private void _enc_Click(object sender, EventArgs e)
        {


            this.act(1);
           
        }

        private void _dec_Click(object sender, EventArgs e)
        {

            this.act(2);
        }


    }
}
