namespace C968_attempt_4
{
    partial class AddPartScreen
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
            this.CancelAddPart = new System.Windows.Forms.Button();
            this.SavePart = new System.Windows.Forms.Button();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.partIDText = new System.Windows.Forms.TextBox();
            this.partNameText = new System.Windows.Forms.TextBox();
            this.partPriceText = new System.Windows.Forms.TextBox();
            this.partInventoryText = new System.Windows.Forms.TextBox();
            this.partMinText = new System.Windows.Forms.TextBox();
            this.partMaxText = new System.Windows.Forms.TextBox();
            this.SourceIDLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SourceID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelAddPart
            // 
            this.CancelAddPart.Location = new System.Drawing.Point(561, 528);
            this.CancelAddPart.Name = "CancelAddPart";
            this.CancelAddPart.Size = new System.Drawing.Size(154, 55);
            this.CancelAddPart.TabIndex = 0;
            this.CancelAddPart.Text = "Cancel";
            this.CancelAddPart.UseVisualStyleBackColor = true;
            this.CancelAddPart.Click += new System.EventHandler(this.Make_Go_Away);
            // 
            // SavePart
            // 
            this.SavePart.Location = new System.Drawing.Point(748, 528);
            this.SavePart.Name = "SavePart";
            this.SavePart.Size = new System.Drawing.Size(154, 55);
            this.SavePart.TabIndex = 1;
            this.SavePart.Text = "Save";
            this.SavePart.UseVisualStyleBackColor = true;
            this.SavePart.Click += new System.EventHandler(this.SavePartClick_Click);
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Location = new System.Drawing.Point(323, 31);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadio.TabIndex = 2;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            this.InHouseRadio.CheckedChanged += new System.EventHandler(this.InHouseRadio_CheckedChanged);
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(647, 31);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadio.TabIndex = 3;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadio_CheckedChanged);
            // 
            // partIDText
            // 
            this.partIDText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.partIDText.Location = new System.Drawing.Point(397, 99);
            this.partIDText.Name = "partIDText";
            this.partIDText.ReadOnly = true;
            this.partIDText.Size = new System.Drawing.Size(250, 20);
            this.partIDText.TabIndex = 4;
            // 
            // partNameText
            // 
            this.partNameText.Location = new System.Drawing.Point(397, 135);
            this.partNameText.Name = "partNameText";
            this.partNameText.Size = new System.Drawing.Size(250, 20);
            this.partNameText.TabIndex = 6;
            // 
            // partPriceText
            // 
            this.partPriceText.Location = new System.Drawing.Point(395, 205);
            this.partPriceText.Name = "partPriceText";
            this.partPriceText.Size = new System.Drawing.Size(250, 20);
            this.partPriceText.TabIndex = 7;
            // 
            // partInventoryText
            // 
            this.partInventoryText.Location = new System.Drawing.Point(395, 167);
            this.partInventoryText.Name = "partInventoryText";
            this.partInventoryText.Size = new System.Drawing.Size(250, 20);
            this.partInventoryText.TabIndex = 8;
            // 
            // partMinText
            // 
            this.partMinText.Location = new System.Drawing.Point(397, 257);
            this.partMinText.Name = "partMinText";
            this.partMinText.Size = new System.Drawing.Size(93, 20);
            this.partMinText.TabIndex = 9;
            // 
            // partMaxText
            // 
            this.partMaxText.Location = new System.Drawing.Point(578, 257);
            this.partMaxText.Name = "partMaxText";
            this.partMaxText.Size = new System.Drawing.Size(93, 20);
            this.partMaxText.TabIndex = 10;
            // 
            // SourceIDLabel
            // 
            this.SourceIDLabel.Location = new System.Drawing.Point(397, 309);
            this.SourceIDLabel.Name = "SourceIDLabel";
            this.SourceIDLabel.Size = new System.Drawing.Size(250, 20);
            this.SourceIDLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add Part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "PartID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Inventory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Max";
            // 
            // SourceID
            // 
            this.SourceID.AutoSize = true;
            this.SourceID.Location = new System.Drawing.Point(309, 312);
            this.SourceID.Name = "SourceID";
            this.SourceID.Size = new System.Drawing.Size(82, 13);
            this.SourceID.TabIndex = 26;
            this.SourceID.Text = "Company Name";
            // 
            // AddPartScreen
            // 
            this.ClientSize = new System.Drawing.Size(1079, 622);
            this.Controls.Add(this.SourceID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceIDLabel);
            this.Controls.Add(this.partMaxText);
            this.Controls.Add(this.partMinText);
            this.Controls.Add(this.partInventoryText);
            this.Controls.Add(this.partPriceText);
            this.Controls.Add(this.partNameText);
            this.Controls.Add(this.partIDText);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InHouseRadio);
            this.Controls.Add(this.SavePart);
            this.Controls.Add(this.CancelAddPart);
            this.Name = "AddPartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RadioButton Inhouse;
        private System.Windows.Forms.TextBox addparttitle;
        private System.Windows.Forms.RadioButton outsourced;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox MachineID;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox IDinput;
        private System.Windows.Forms.TextBox IDTitle;
        private System.Windows.Forms.TextBox PriceTitle;
        private System.Windows.Forms.TextBox InventoryTitle;
        private System.Windows.Forms.TextBox NameTitle;
        private System.Windows.Forms.TextBox MachineIDTitle;
        private System.Windows.Forms.TextBox MinID;
        private System.Windows.Forms.TextBox MaxID;
        private System.Windows.Forms.Button SaveAdd;
        private System.Windows.Forms.Button CancelPart;
        private System.Windows.Forms.Button CancelAddPart;
        private System.Windows.Forms.Button SavePart;
        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.TextBox partIDText;
        private System.Windows.Forms.TextBox partNameText;
        private System.Windows.Forms.TextBox partPriceText;
        private System.Windows.Forms.TextBox partInventoryText;
        private System.Windows.Forms.TextBox partMinText;
        private System.Windows.Forms.TextBox partMaxText;
        private System.Windows.Forms.TextBox SourceIDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SourceID;
    }
}