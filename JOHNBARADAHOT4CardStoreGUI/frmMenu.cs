using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace JOHNBARADAHOT4CardStoreGUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        const decimal ENVELOPE = .25m;
        const decimal STAMP = .5m;
        const decimal CUSTOMMSG = .30m;
        const decimal CARDPRICE = 1.00m;
        decimal total = 0m;
        string[] occasion =
        {
            "C:\\Users\\13146\\Desktop\\Testproject\\HOT-2\\JOHNBARADAHOT4CardStoreGUI\\JOHNBARADAHOT4CardStoreGUI\\Images\\Thankyou1.JPG",
            "C:\\Users\\13146\\Desktop\\Testproject\\HOT-2\\JOHNBARADAHOT4CardStoreGUI\\JOHNBARADAHOT4CardStoreGUI\\Images\\grad2.JPG",
            "C:\\Users\\13146\\Desktop\\Testproject\\HOT-2\\JOHNBARADAHOT4CardStoreGUI\\JOHNBARADAHOT4CardStoreGUI\\Images\\condolences.PNG"
        };
        decimal[] stylePrices =
        {
            1.00m, 1.25m, 1.50m
        };
        string[] style =
        {
            "C:\\Users\\13146\\Desktop\\Testproject\\HOT-2\\JOHNBARADAHOT4CardStoreGUI\\JOHNBARADAHOT4CardStoreGUI\\Images\\tree.png",
            "C:\\Users\\13146\\Desktop\\Testproject\\HOT-2\\JOHNBARADAHOT4CardStoreGUI\\JOHNBARADAHOT4CardStoreGUI\\Images\\flowers.png",
            "C:\\Users\\13146\\Desktop\\Testproject\\HOT-2\\JOHNBARADAHOT4CardStoreGUI\\JOHNBARADAHOT4CardStoreGUI\\Images\\graduation.jpg"
        };


        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int si = cbxOccasion.SelectedIndex;
            SetOccasion(si);
            //UpdateTotal();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int si = cbxOccasion.SelectedIndex;
            //UpdateTotal();
        }
        private void cbxEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEnvelope();
            UpdateTotal();
        }


        private void UpdateEnvelope()
        {
            if (cbxEnvelope.Checked)
            {
                total += ENVELOPE;
            }
            else
            {
            }
        }

        private void cbxStamp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStamp();
            UpdateTotal();
        }
        private void UpdateStamp()
        {
            if (cbxStamp.Checked)
            {
                total += STAMP;
            }
            else
            {
            }
        }
        private void UpdateTotal()
        {
            total = 0;
            UpdateStamp();
            UpdateEnvelope();
            UpdateCustomMsg();
            UpdateStylePrices();
            total += CARDPRICE;
            lblCost.Text = "COST: " + total.ToString("c");
        }
        private void UpdateStylePrices()
        {
            int sty = cbxStyle.SelectedIndex;
            decimal price = 0m;
            if (sty >= 0)
            { 
                price = stylePrices[sty];
                total += price;
            }
        }

        private void cbxCustomMsg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCustomMsg();
            UpdateTotal();
        }
        private void UpdateCustomMsg()
        {
            if (cbxCustomMsg.Checked)
            {
                txtCustomMsg.ReadOnly = false;

                total += CUSTOMMSG;

                txtCardText.Visible = true;
            }
            else
            {
                txtCustomMsg.ReadOnly = true;
                txtCardText.Visible = false;

                txtCustomMsg.Text = "";
            }
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ErrorCheck();
            FillCardBox();
            UpdateTotal();
        }
        private void ErrorCheck()
        {
            if (cbxOccasion.SelectedIndex < 0 ||
                cbxStyle.SelectedIndex < 0)
            {
                DialogResult dialog = MessageBox.Show(

            "ERROR",

            "Please Enter a Value in both boxes",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
                if (dialog == DialogResult.OK)

                {
                    return;
                }
            }
        }
        private void FillCardBox()
        {
            AddSelectedItems();
            txtCardText.Text = txtCustomMsg.Text;
        }



        private void AddSelectedItems()
        {
            int si = cbxOccasion.SelectedIndex;

            switch(si)
            {
                case 0:
                    SetOccasion(si); break;
                case 1: 
                    SetOccasion(si); break;
                case 2: 
                    SetOccasion(si); break;

            }
            si = cbxStyle.SelectedIndex;
            switch (si)
            {
                case 0:
                    SetStyle(si); break;
                case 1:
                    SetStyle(si); break;
                case 2:
                    SetStyle(si); break;

            }
        }
        private void SetOccasion(int si)
        {
            pbxCardOccasion.Image = System.Drawing.Image.FromFile(occasion[si]);
        }
        private void  SetStyle(int si)
        {
            pbxCardStyle.Image = System.Drawing.Image.FromFile(style[si]);
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadHome();
        }
        private void LoadHome()
        {
            frmHome menuForm = new frmHome();
            menuForm.Show();
            this.Hide();
        }

        private void txtCustomMsg_TextChanged(object sender, EventArgs e)
        {
            //UpdateCustomMsg();
        }
    }
    
}
