namespace PartyPlanner
{
    partial class MainForm
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
            this.grpNewParty = new System.Windows.Forms.GroupBox();
            this.txtFeeAmount = new System.Windows.Forms.TextBox();
            this.lblFeePerPerson = new System.Windows.Forms.Label();
            this.btnCreateParty = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtMaxNum = new System.Windows.Forms.TextBox();
            this.lblCostPerPerson = new System.Windows.Forms.Label();
            this.lblTotalGuests = new System.Windows.Forms.Label();
            this.grpAddGuests = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lstGuestList = new System.Windows.Forms.ListBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblNumberofGuests = new System.Windows.Forms.Label();
            this.lblTotalCostOutput = new System.Windows.Forms.Label();
            this.lblTotalGuestsOutput = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblGuestList = new System.Windows.Forms.Label();
            this.lblTotalFeeOutput = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblTotalSurplus = new System.Windows.Forms.Label();
            this.lblTotalSurplusOutput = new System.Windows.Forms.Label();
            this.grpNewParty.SuspendLayout();
            this.grpAddGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewParty
            // 
            this.grpNewParty.Controls.Add(this.txtFeeAmount);
            this.grpNewParty.Controls.Add(this.lblFeePerPerson);
            this.grpNewParty.Controls.Add(this.btnCreateParty);
            this.grpNewParty.Controls.Add(this.txtAmount);
            this.grpNewParty.Controls.Add(this.txtMaxNum);
            this.grpNewParty.Controls.Add(this.lblCostPerPerson);
            this.grpNewParty.Controls.Add(this.lblTotalGuests);
            this.grpNewParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewParty.Location = new System.Drawing.Point(10, 30);
            this.grpNewParty.Margin = new System.Windows.Forms.Padding(1);
            this.grpNewParty.Name = "grpNewParty";
            this.grpNewParty.Padding = new System.Windows.Forms.Padding(1);
            this.grpNewParty.Size = new System.Drawing.Size(273, 150);
            this.grpNewParty.TabIndex = 0;
            this.grpNewParty.TabStop = false;
            this.grpNewParty.Text = "New Party";
            // 
            // txtFeeAmount
            // 
            this.txtFeeAmount.Location = new System.Drawing.Point(155, 88);
            this.txtFeeAmount.Name = "txtFeeAmount";
            this.txtFeeAmount.Size = new System.Drawing.Size(89, 22);
            this.txtFeeAmount.TabIndex = 6;
            // 
            // lblFeePerPerson
            // 
            this.lblFeePerPerson.AutoSize = true;
            this.lblFeePerPerson.Location = new System.Drawing.Point(13, 93);
            this.lblFeePerPerson.Name = "lblFeePerPerson";
            this.lblFeePerPerson.Size = new System.Drawing.Size(104, 16);
            this.lblFeePerPerson.TabIndex = 5;
            this.lblFeePerPerson.Text = "Fee Per Person:";
            // 
            // btnCreateParty
            // 
            this.btnCreateParty.Location = new System.Drawing.Point(89, 115);
            this.btnCreateParty.Margin = new System.Windows.Forms.Padding(1);
            this.btnCreateParty.Name = "btnCreateParty";
            this.btnCreateParty.Size = new System.Drawing.Size(78, 24);
            this.btnCreateParty.TabIndex = 4;
            this.btnCreateParty.Text = "Create List";
            this.btnCreateParty.UseVisualStyleBackColor = true;
            this.btnCreateParty.Click += new System.EventHandler(this.btnCreateParty_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(155, 59);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(1);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(89, 22);
            this.txtAmount.TabIndex = 3;
            // 
            // txtMaxNum
            // 
            this.txtMaxNum.Location = new System.Drawing.Point(155, 24);
            this.txtMaxNum.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaxNum.Name = "txtMaxNum";
            this.txtMaxNum.Size = new System.Drawing.Size(89, 22);
            this.txtMaxNum.TabIndex = 2;
            // 
            // lblCostPerPerson
            // 
            this.lblCostPerPerson.AutoSize = true;
            this.lblCostPerPerson.Location = new System.Drawing.Point(10, 62);
            this.lblCostPerPerson.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCostPerPerson.Name = "lblCostPerPerson";
            this.lblCostPerPerson.Size = new System.Drawing.Size(107, 16);
            this.lblCostPerPerson.TabIndex = 1;
            this.lblCostPerPerson.Text = "Cost Per Person:";
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.AutoSize = true;
            this.lblTotalGuests.Location = new System.Drawing.Point(2, 27);
            this.lblTotalGuests.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalGuests.Name = "lblTotalGuests";
            this.lblTotalGuests.Size = new System.Drawing.Size(132, 16);
            this.lblTotalGuests.TabIndex = 0;
            this.lblTotalGuests.Text = "Max Amount of Guest";
            // 
            // grpAddGuests
            // 
            this.grpAddGuests.Controls.Add(this.btnAdd);
            this.grpAddGuests.Controls.Add(this.txtLastName);
            this.grpAddGuests.Controls.Add(this.txtFirstName);
            this.grpAddGuests.Controls.Add(this.lblLastName);
            this.grpAddGuests.Controls.Add(this.lblFirstName);
            this.grpAddGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddGuests.Location = new System.Drawing.Point(10, 199);
            this.grpAddGuests.Margin = new System.Windows.Forms.Padding(1);
            this.grpAddGuests.Name = "grpAddGuests";
            this.grpAddGuests.Padding = new System.Windows.Forms.Padding(1);
            this.grpAddGuests.Size = new System.Drawing.Size(273, 160);
            this.grpAddGuests.TabIndex = 1;
            this.grpAddGuests.TabStop = false;
            this.grpAddGuests.Text = "Invite Guest";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 120);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(105, 66);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(1);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(117, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(105, 27);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(117, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 66);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 16);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 27);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lstGuestList
            // 
            this.lstGuestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGuestList.FormattingEnabled = true;
            this.lstGuestList.ItemHeight = 16;
            this.lstGuestList.Location = new System.Drawing.Point(310, 30);
            this.lstGuestList.Margin = new System.Windows.Forms.Padding(1);
            this.lstGuestList.Name = "lstGuestList";
            this.lstGuestList.Size = new System.Drawing.Size(299, 372);
            this.lstGuestList.TabIndex = 2;
            this.lstGuestList.SelectedIndexChanged += new System.EventHandler(this.lstGuestList_SelectedIndexChanged);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(20, 396);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(71, 16);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lblNumberofGuests
            // 
            this.lblNumberofGuests.AutoSize = true;
            this.lblNumberofGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofGuests.Location = new System.Drawing.Point(20, 369);
            this.lblNumberofGuests.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNumberofGuests.Name = "lblNumberofGuests";
            this.lblNumberofGuests.Size = new System.Drawing.Size(117, 16);
            this.lblNumberofGuests.TabIndex = 4;
            this.lblNumberofGuests.Text = "Number of Guests:";
            // 
            // lblTotalCostOutput
            // 
            this.lblTotalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCostOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostOutput.Location = new System.Drawing.Point(158, 395);
            this.lblTotalCostOutput.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalCostOutput.Name = "lblTotalCostOutput";
            this.lblTotalCostOutput.Size = new System.Drawing.Size(125, 25);
            this.lblTotalCostOutput.TabIndex = 5;
            this.lblTotalCostOutput.Text = "Output";
            // 
            // lblTotalGuestsOutput
            // 
            this.lblTotalGuestsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalGuestsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGuestsOutput.Location = new System.Drawing.Point(158, 368);
            this.lblTotalGuestsOutput.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalGuestsOutput.Name = "lblTotalGuestsOutput";
            this.lblTotalGuestsOutput.Size = new System.Drawing.Size(125, 23);
            this.lblTotalGuestsOutput.TabIndex = 6;
            this.lblTotalGuestsOutput.Text = "Output";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(340, 411);
            this.btnChange.Margin = new System.Windows.Forms.Padding(1);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(70, 26);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(511, 411);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 26);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblGuestList
            // 
            this.lblGuestList.AutoSize = true;
            this.lblGuestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestList.Location = new System.Drawing.Point(433, 9);
            this.lblGuestList.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGuestList.Name = "lblGuestList";
            this.lblGuestList.Size = new System.Drawing.Size(65, 16);
            this.lblGuestList.TabIndex = 9;
            this.lblGuestList.Text = "Guest List";
            this.lblGuestList.Click += new System.EventHandler(this.lblGuestList_Click);
            // 
            // lblTotalFeeOutput
            // 
            this.lblTotalFeeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalFeeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeeOutput.Location = new System.Drawing.Point(158, 422);
            this.lblTotalFeeOutput.Name = "lblTotalFeeOutput";
            this.lblTotalFeeOutput.Size = new System.Drawing.Size(125, 23);
            this.lblTotalFeeOutput.TabIndex = 10;
            this.lblTotalFeeOutput.Text = "ootPut";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.Location = new System.Drawing.Point(20, 423);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(68, 16);
            this.lblTotalFee.TabIndex = 11;
            this.lblTotalFee.Text = "Total Fee:";
            // 
            // lblTotalSurplus
            // 
            this.lblTotalSurplus.AutoSize = true;
            this.lblTotalSurplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSurplus.Location = new System.Drawing.Point(23, 451);
            this.lblTotalSurplus.Name = "lblTotalSurplus";
            this.lblTotalSurplus.Size = new System.Drawing.Size(93, 16);
            this.lblTotalSurplus.TabIndex = 12;
            this.lblTotalSurplus.Text = "Surplus/Deficit";
            // 
            // lblTotalSurplusOutput
            // 
            this.lblTotalSurplusOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSurplusOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSurplusOutput.Location = new System.Drawing.Point(158, 451);
            this.lblTotalSurplusOutput.Name = "lblTotalSurplusOutput";
            this.lblTotalSurplusOutput.Size = new System.Drawing.Size(125, 21);
            this.lblTotalSurplusOutput.TabIndex = 13;
            this.lblTotalSurplusOutput.Text = "label3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(653, 503);
            this.Controls.Add(this.lblTotalSurplusOutput);
            this.Controls.Add(this.lblTotalSurplus);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.lblTotalFeeOutput);
            this.Controls.Add(this.lblGuestList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblTotalGuestsOutput);
            this.Controls.Add(this.lblTotalCostOutput);
            this.Controls.Add(this.lblNumberofGuests);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lstGuestList);
            this.Controls.Add(this.grpAddGuests);
            this.Controls.Add(this.grpNewParty);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Text = "Party Organizer by Linus Lnid";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpNewParty.ResumeLayout(false);
            this.grpNewParty.PerformLayout();
            this.grpAddGuests.ResumeLayout(false);
            this.grpAddGuests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewParty;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtMaxNum;
        private System.Windows.Forms.Label lblCostPerPerson;
        private System.Windows.Forms.Label lblTotalGuests;
        private System.Windows.Forms.GroupBox grpAddGuests;
        private System.Windows.Forms.ListBox lstGuestList;
        private System.Windows.Forms.Button btnCreateParty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblNumberofGuests;
        private System.Windows.Forms.Label lblTotalCostOutput;
        private System.Windows.Forms.Label lblTotalGuestsOutput;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblGuestList;
        private System.Windows.Forms.TextBox txtFeeAmount;
        private System.Windows.Forms.Label lblFeePerPerson;
        private System.Windows.Forms.Label lblTotalFeeOutput;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label lblTotalSurplus;
        private System.Windows.Forms.Label lblTotalSurplusOutput;
    }
}

