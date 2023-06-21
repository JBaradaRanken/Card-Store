using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace JOHNBARADAHOT4CardStoreGUI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitPrompt();
        }
        private void LoadMenu()
        {
            frmMenu menuForm = new frmMenu(); 
            menuForm.Show();                     
            this.Hide();
        }
        private void ExitPrompt()
        {
            
                DialogResult dialog = MessageBox.Show(

            "Do You Really Want To Exit The Program?",

            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)

                {
                    System.Windows.Forms.Application.Exit();
                }
            
        }
    }
}
