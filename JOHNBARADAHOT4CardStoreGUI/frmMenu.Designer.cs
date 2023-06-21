namespace JOHNBARADAHOT4CardStoreGUI
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxOccasion = new System.Windows.Forms.ComboBox();
            this.lblOccasion = new System.Windows.Forms.Label();
            this.cbxEnvelope = new System.Windows.Forms.CheckBox();
            this.txtCustomMsg = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblStyle = new System.Windows.Forms.Label();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.cbxStamp = new System.Windows.Forms.CheckBox();
            this.cbxCustomMsg = new System.Windows.Forms.CheckBox();
            this.pbxCardStyle = new System.Windows.Forms.PictureBox();
            this.pbxCardOccasion = new System.Windows.Forms.PictureBox();
            this.txtCardText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardOccasion)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxOccasion
            // 
            this.cbxOccasion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOccasion.FormattingEnabled = true;
            this.cbxOccasion.Items.AddRange(new object[] {
            "Thank You",
            "Graduation",
            "Condolence"});
            this.cbxOccasion.Location = new System.Drawing.Point(137, 20);
            this.cbxOccasion.Name = "cbxOccasion";
            this.cbxOccasion.Size = new System.Drawing.Size(145, 30);
            this.cbxOccasion.TabIndex = 0;
            this.cbxOccasion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblOccasion
            // 
            this.lblOccasion.AutoSize = true;
            this.lblOccasion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccasion.Location = new System.Drawing.Point(33, 20);
            this.lblOccasion.Name = "lblOccasion";
            this.lblOccasion.Size = new System.Drawing.Size(98, 22);
            this.lblOccasion.TabIndex = 8;
            this.lblOccasion.Text = "Occasion";
            // 
            // cbxEnvelope
            // 
            this.cbxEnvelope.AutoSize = true;
            this.cbxEnvelope.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEnvelope.Location = new System.Drawing.Point(12, 79);
            this.cbxEnvelope.Name = "cbxEnvelope";
            this.cbxEnvelope.Size = new System.Drawing.Size(116, 26);
            this.cbxEnvelope.TabIndex = 2;
            this.cbxEnvelope.Text = "Envelope";
            this.cbxEnvelope.UseVisualStyleBackColor = true;
            this.cbxEnvelope.CheckedChanged += new System.EventHandler(this.cbxEnvelope_CheckedChanged);
            // 
            // txtCustomMsg
            // 
            this.txtCustomMsg.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomMsg.Location = new System.Drawing.Point(36, 158);
            this.txtCustomMsg.Multiline = true;
            this.txtCustomMsg.Name = "txtCustomMsg";
            this.txtCustomMsg.ReadOnly = true;
            this.txtCustomMsg.Size = new System.Drawing.Size(323, 201);
            this.txtCustomMsg.TabIndex = 5;
            this.txtCustomMsg.TextChanged += new System.EventHandler(this.txtCustomMsg_TextChanged);
            // 
            // lblCost
            // 
            this.lblCost.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(4, 379);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(148, 31);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "COST:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(149, 361);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(109, 58);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnHome
            // 
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(264, 361);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(95, 58);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Back to Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.Location = new System.Drawing.Point(33, 53);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(56, 22);
            this.lblStyle.TabIndex = 9;
            this.lblStyle.Text = "Style";
            // 
            // cbxStyle
            // 
            this.cbxStyle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Items.AddRange(new object[] {
            "Tree",
            "Flowers",
            "Graduation"});
            this.cbxStyle.Location = new System.Drawing.Point(137, 48);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(145, 30);
            this.cbxStyle.TabIndex = 1;
            this.cbxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbxStamp
            // 
            this.cbxStamp.AutoSize = true;
            this.cbxStamp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStamp.Location = new System.Drawing.Point(12, 102);
            this.cbxStamp.Name = "cbxStamp";
            this.cbxStamp.Size = new System.Drawing.Size(88, 26);
            this.cbxStamp.TabIndex = 3;
            this.cbxStamp.Text = "Stamp";
            this.cbxStamp.UseVisualStyleBackColor = true;
            this.cbxStamp.CheckedChanged += new System.EventHandler(this.cbxStamp_CheckedChanged);
            // 
            // cbxCustomMsg
            // 
            this.cbxCustomMsg.AutoSize = true;
            this.cbxCustomMsg.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCustomMsg.Location = new System.Drawing.Point(12, 125);
            this.cbxCustomMsg.Name = "cbxCustomMsg";
            this.cbxCustomMsg.Size = new System.Drawing.Size(190, 26);
            this.cbxCustomMsg.TabIndex = 4;
            this.cbxCustomMsg.Text = "Custom Message";
            this.cbxCustomMsg.UseVisualStyleBackColor = true;
            this.cbxCustomMsg.CheckedChanged += new System.EventHandler(this.cbxCustomMsg_CheckedChanged);
            // 
            // pbxCardStyle
            // 
            this.pbxCardStyle.Location = new System.Drawing.Point(365, 12);
            this.pbxCardStyle.Name = "pbxCardStyle";
            this.pbxCardStyle.Size = new System.Drawing.Size(423, 174);
            this.pbxCardStyle.TabIndex = 11;
            this.pbxCardStyle.TabStop = false;
            // 
            // pbxCardOccasion
            // 
            this.pbxCardOccasion.Location = new System.Drawing.Point(365, 180);
            this.pbxCardOccasion.Name = "pbxCardOccasion";
            this.pbxCardOccasion.Size = new System.Drawing.Size(423, 258);
            this.pbxCardOccasion.TabIndex = 12;
            this.pbxCardOccasion.TabStop = false;
            // 
            // txtCardText
            // 
            this.txtCardText.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardText.ForeColor = System.Drawing.Color.Transparent;
            this.txtCardText.Location = new System.Drawing.Point(365, 361);
            this.txtCardText.Multiline = true;
            this.txtCardText.Name = "txtCardText";
            this.txtCardText.ReadOnly = true;
            this.txtCardText.Size = new System.Drawing.Size(423, 77);
            this.txtCardText.TabIndex = 13;
            this.txtCardText.Visible = false;
            // 
            // frmMenu
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnHome;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCardText);
            this.Controls.Add(this.pbxCardOccasion);
            this.Controls.Add(this.pbxCardStyle);
            this.Controls.Add(this.cbxCustomMsg);
            this.Controls.Add(this.cbxStamp);
            this.Controls.Add(this.cbxStyle);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCustomMsg);
            this.Controls.Add(this.cbxEnvelope);
            this.Controls.Add(this.lblOccasion);
            this.Controls.Add(this.cbxOccasion);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Designer";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCardOccasion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxOccasion;
        private System.Windows.Forms.Label lblOccasion;
        private System.Windows.Forms.CheckBox cbxEnvelope;
        private System.Windows.Forms.TextBox txtCustomMsg;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.CheckBox cbxStamp;
        private System.Windows.Forms.CheckBox cbxCustomMsg;
        private System.Windows.Forms.PictureBox pbxCardStyle;
        private System.Windows.Forms.PictureBox pbxCardOccasion;
        private System.Windows.Forms.TextBox txtCardText;
    }
}

