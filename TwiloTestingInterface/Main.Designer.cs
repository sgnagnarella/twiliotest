namespace TwiloTestingInterface
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.mskAgentNumer = new System.Windows.Forms.MaskedTextBox();
            this.btnTakeCall = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbQueue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefreshCallsInQueue = new System.Windows.Forms.Button();
            this.lblCallsInQueue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCallFrom = new System.Windows.Forms.TextBox();
            this.txtWaitTime = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent Phone Number";
            // 
            // mskAgentNumer
            // 
            this.mskAgentNumer.Location = new System.Drawing.Point(203, 21);
            this.mskAgentNumer.Mask = "999-000-0000";
            this.mskAgentNumer.Name = "mskAgentNumer";
            this.mskAgentNumer.Size = new System.Drawing.Size(77, 20);
            this.mskAgentNumer.TabIndex = 1;
            this.mskAgentNumer.Text = "3033978101";
            // 
            // btnTakeCall
            // 
            this.btnTakeCall.Location = new System.Drawing.Point(93, 170);
            this.btnTakeCall.Name = "btnTakeCall";
            this.btnTakeCall.Size = new System.Drawing.Size(101, 38);
            this.btnTakeCall.TabIndex = 2;
            this.btnTakeCall.Text = "Take Call From Queue";
            this.btnTakeCall.UseVisualStyleBackColor = true;
            this.btnTakeCall.Click += new System.EventHandler(this.btnTakeCall_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCallsInQueue);
            this.groupBox1.Controls.Add(this.btnRefreshCallsInQueue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbQueue);
            this.groupBox1.Location = new System.Drawing.Point(15, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Queue";
            // 
            // cmbQueue
            // 
            this.cmbQueue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQueue.FormattingEnabled = true;
            this.cmbQueue.Location = new System.Drawing.Point(19, 28);
            this.cmbQueue.Name = "cmbQueue";
            this.cmbQueue.Size = new System.Drawing.Size(221, 21);
            this.cmbQueue.TabIndex = 0;
            this.cmbQueue.SelectedIndexChanged += new System.EventHandler(this.cmbQueue_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calls in Queue";
            // 
            // btnRefreshCallsInQueue
            // 
            this.btnRefreshCallsInQueue.Location = new System.Drawing.Point(164, 67);
            this.btnRefreshCallsInQueue.Name = "btnRefreshCallsInQueue";
            this.btnRefreshCallsInQueue.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshCallsInQueue.TabIndex = 2;
            this.btnRefreshCallsInQueue.Text = "Refresh";
            this.btnRefreshCallsInQueue.UseVisualStyleBackColor = true;
            this.btnRefreshCallsInQueue.Click += new System.EventHandler(this.btnRefreshCallsInQueue_Click);
            // 
            // lblCallsInQueue
            // 
            this.lblCallsInQueue.AutoSize = true;
            this.lblCallsInQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallsInQueue.ForeColor = System.Drawing.Color.Red;
            this.lblCallsInQueue.Location = new System.Drawing.Point(107, 66);
            this.lblCallsInQueue.Name = "lblCallsInQueue";
            this.lblCallsInQueue.Size = new System.Drawing.Size(20, 24);
            this.lblCallsInQueue.TabIndex = 3;
            this.lblCallsInQueue.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWaitTime);
            this.groupBox2.Controls.Add(this.txtCallFrom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 82);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Call Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calling From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wait Time";
            // 
            // txtCallFrom
            // 
            this.txtCallFrom.Location = new System.Drawing.Point(78, 23);
            this.txtCallFrom.Name = "txtCallFrom";
            this.txtCallFrom.ReadOnly = true;
            this.txtCallFrom.Size = new System.Drawing.Size(181, 20);
            this.txtCallFrom.TabIndex = 4;
            // 
            // txtWaitTime
            // 
            this.txtWaitTime.Location = new System.Drawing.Point(78, 52);
            this.txtWaitTime.Name = "txtWaitTime";
            this.txtWaitTime.ReadOnly = true;
            this.txtWaitTime.Size = new System.Drawing.Size(69, 20);
            this.txtWaitTime.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTakeCall);
            this.Controls.Add(this.mskAgentNumer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "TeleTech CAT App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskAgentNumer;
        private System.Windows.Forms.Button btnTakeCall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCallsInQueue;
        private System.Windows.Forms.Button btnRefreshCallsInQueue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbQueue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWaitTime;
        private System.Windows.Forms.TextBox txtCallFrom;
        private System.Windows.Forms.Label label4;
    }
}

