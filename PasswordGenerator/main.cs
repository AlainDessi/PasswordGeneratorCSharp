using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            initCombo();

        }

        private void generatePswd_Click(object sender, EventArgs e)
        {
            // get the value of comboBox
            int nbCharToGenerate = Int32.Parse(nbChar.SelectedItem.ToString());

            // generate password
            PswdGenerator pswdGen = new PswdGenerator(nbCharToGenerate);
            pswdText.Text = pswdGen.generatePaswd();
        }

        // click on button for exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // initialisation combo box
        private void initCombo()
        {
            nbChar.Items.Insert(0, "8");
            nbChar.Items.Insert(1, "16");
            nbChar.Items.Insert(2, "32");
            nbChar.Items.Insert(3, "64");
            nbChar.Items.Insert(4, "128");

            nbChar.SelectedIndex = 0;
        }

        private void btnCopyClip_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pswdText.Text);
        }
    }

}
