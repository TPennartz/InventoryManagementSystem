namespace C968_attempt_4
{
    partial class ModifyPart
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
            this.In_house = new System.Windows.Forms.RadioButton();
            this.outsourced = new System.Windows.Forms.RadioButton();
            this.IDinput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this._Inventory = new System.Windows.Forms.TextBox();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.MachineID = new System.Windows.Forms.TextBox();
            this.SaveModify = new System.Windows.Forms.Button();
            this.CancelModify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MachineIDTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // In_house
            // 
            this.In_house.AutoSize = true;
            this.In_house.Location = new System.Drawing.Point(250, 12);
            this.In_house.Name = "In_house";
            this.In_house.Size = new System.Drawing.Size(68, 17);
            this.In_house.TabIndex = 2;
            this.In_house.TabStop = true;
            this.In_house.Text = "In-House";
            this.In_house.UseVisualStyleBackColor = true;
            this.In_house.Click += new System.EventHandler(this.Inhouse_CheckedChanged);
            // 
            // outsourced
            // 
            this.outsourced.AutoSize = true;
            this.outsourced.Location = new System.Drawing.Point(467, 12);
            this.outsourced.Name = "outsourced";
            this.outsourced.Size = new System.Drawing.Size(80, 17);
            this.outsourced.TabIndex = 3;
            this.outsourced.TabStop = true;
            this.outsourced.Text = "Outsourced";
            this.outsourced.UseVisualStyleBackColor = true;
            this.outsourced.CheckedChanged += new System.EventHandler(this.Outsourced_CheckedChange);
            this.outsourced.Click += new System.EventHandler(this.Outsourced_CheckedChange);
            // 
            // IDinput
            // 
            this.IDinput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.IDinput.Location = new System.Drawing.Point(289, 64);
            this.IDinput.Name = "IDinput";
            this.IDinput.Size = new System.Drawing.Size(223, 20);
            this.IDinput.TabIndex = 4;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(289, 104);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(223, 20);
            this.NameInput.TabIndex = 12;
            // 
            // _Inventory
            // 
            this._Inventory.Location = new System.Drawing.Point(289, 141);
            this._Inventory.Name = "_Inventory";
            this._Inventory.Size = new System.Drawing.Size(223, 20);
            this._Inventory.TabIndex = 14;
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(289, 177);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(223, 20);
            this.PriceInput.TabIndex = 16;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(413, 214);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(99, 20);
            this.Max.TabIndex = 19;
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(281, 214);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(84, 20);
            this.Min.TabIndex = 21;
            // 
            // MachineID
            // 
            this.MachineID.Location = new System.Drawing.Point(289, 253);
            this.MachineID.Name = "MachineID";
            this.MachineID.Size = new System.Drawing.Size(223, 20);
            this.MachineID.TabIndex = 22;
            // 
            // SaveModify
            // 
            this.SaveModify.Location = new System.Drawing.Point(353, 310);
            this.SaveModify.Name = "SaveModify";
            this.SaveModify.Size = new System.Drawing.Size(103, 33);
            this.SaveModify.TabIndex = 24;
            this.SaveModify.Text = "Save";
            this.SaveModify.UseVisualStyleBackColor = true;
            this.SaveModify.Click += new System.EventHandler(this.Save_Modify);
            // 
            // CancelModify
            // 
            this.CancelModify.Location = new System.Drawing.Point(467, 310);
            this.CancelModify.Name = "CancelModify";
            this.CancelModify.Size = new System.Drawing.Size(103, 33);
            this.CancelModify.TabIndex = 25;
            this.CancelModify.Text = "Cancel Modify";
            this.CancelModify.UseVisualStyleBackColor = true;
            this.CancelModify.Click += new System.EventHandler(this.Cancel_Modify);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Modify Part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Min";
            // 
            // MachineIDTitle
            // 
            this.MachineIDTitle.AutoSize = true;
            this.MachineIDTitle.Location = new System.Drawing.Point(196, 256);
            this.MachineIDTitle.Name = "MachineIDTitle";
            this.MachineIDTitle.Size = new System.Drawing.Size(62, 13);
            this.MachineIDTitle.TabIndex = 33;
            this.MachineIDTitle.Text = "Machine ID";
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MachineIDTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelModify);
            this.Controls.Add(this.SaveModify);
            this.Controls.Add(this.MachineID);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this._Inventory);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.IDinput);
            this.Controls.Add(this.outsourced);
            this.Controls.Add(this.In_house);
            this.Name = "ModifyPart";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton In_house;
        private System.Windows.Forms.RadioButton outsourced;
        private System.Windows.Forms.TextBox IDinput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox _Inventory;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox MachineID;
        private System.Windows.Forms.Button SaveModify;
        private System.Windows.Forms.Button CancelModify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label MachineIDTitle;
    }
}