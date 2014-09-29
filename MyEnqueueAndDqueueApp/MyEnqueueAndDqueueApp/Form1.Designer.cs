namespace MyEnqueueAndDqueueApp
{
    partial class EnqueueDequeAppUI
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
            this.complainColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.waitingQueueListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.waitingQueueGroupBox = new System.Windows.Forms.GroupBox();
            this.deQueueButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameEnqueueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.complainDequeueTextBox = new System.Windows.Forms.TextBox();
            this.nameDequeueTextBox = new System.Windows.Forms.TextBox();
            this.serialNoDequeueTextBox = new System.Windows.Forms.TextBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.enQueueGroupBox = new System.Windows.Forms.GroupBox();
            this.complainEnqueueTextBox = new System.Windows.Forms.TextBox();
            this.deQueueGroupBox = new System.Windows.Forms.GroupBox();
            this.waitingQueueGroupBox.SuspendLayout();
            this.enQueueGroupBox.SuspendLayout();
            this.deQueueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // complainColumnHeader
            // 
            this.complainColumnHeader.Text = "Complain";
            this.complainColumnHeader.Width = 450;
            // 
            // serialNoColumnHeader
            // 
            this.serialNoColumnHeader.Text = "Serial No";
            this.serialNoColumnHeader.Width = 80;
            // 
            // waitingQueueListView
            // 
            this.waitingQueueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNoColumnHeader,
            this.nameColumnHeader,
            this.complainColumnHeader});
            this.waitingQueueListView.Location = new System.Drawing.Point(50, 40);
            this.waitingQueueListView.Name = "waitingQueueListView";
            this.waitingQueueListView.Size = new System.Drawing.Size(674, 160);
            this.waitingQueueListView.TabIndex = 0;
            this.waitingQueueListView.UseCompatibleStateImageBehavior = false;
            this.waitingQueueListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 100;
            // 
            // waitingQueueGroupBox
            // 
            this.waitingQueueGroupBox.Controls.Add(this.waitingQueueListView);
            this.waitingQueueGroupBox.Location = new System.Drawing.Point(0, 203);
            this.waitingQueueGroupBox.Name = "waitingQueueGroupBox";
            this.waitingQueueGroupBox.Size = new System.Drawing.Size(680, 179);
            this.waitingQueueGroupBox.TabIndex = 1;
            this.waitingQueueGroupBox.TabStop = false;
            this.waitingQueueGroupBox.Text = "Waiting Queue";
            // 
            // deQueueButton
            // 
            this.deQueueButton.Location = new System.Drawing.Point(260, 27);
            this.deQueueButton.Name = "deQueueButton";
            this.deQueueButton.Size = new System.Drawing.Size(71, 22);
            this.deQueueButton.TabIndex = 2;
            this.deQueueButton.Text = "Dequeue";
            this.deQueueButton.UseVisualStyleBackColor = true;
            this.deQueueButton.Click += new System.EventHandler(this.deQueueButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Complain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complain";
            // 
            // nameEnqueueTextBox
            // 
            this.nameEnqueueTextBox.Location = new System.Drawing.Point(94, 27);
            this.nameEnqueueTextBox.Name = "nameEnqueueTextBox";
            this.nameEnqueueTextBox.Size = new System.Drawing.Size(77, 20);
            this.nameEnqueueTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Serial No";
            // 
            // complainDequeueTextBox
            // 
            this.complainDequeueTextBox.Location = new System.Drawing.Point(110, 103);
            this.complainDequeueTextBox.Name = "complainDequeueTextBox";
            this.complainDequeueTextBox.Size = new System.Drawing.Size(179, 20);
            this.complainDequeueTextBox.TabIndex = 0;
            // 
            // nameDequeueTextBox
            // 
            this.nameDequeueTextBox.Location = new System.Drawing.Point(110, 63);
            this.nameDequeueTextBox.Name = "nameDequeueTextBox";
            this.nameDequeueTextBox.Size = new System.Drawing.Size(77, 20);
            this.nameDequeueTextBox.TabIndex = 0;
            // 
            // serialNoDequeueTextBox
            // 
            this.serialNoDequeueTextBox.Location = new System.Drawing.Point(110, 26);
            this.serialNoDequeueTextBox.Name = "serialNoDequeueTextBox";
            this.serialNoDequeueTextBox.Size = new System.Drawing.Size(77, 20);
            this.serialNoDequeueTextBox.TabIndex = 0;
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(94, 111);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(93, 22);
            this.enqueueButton.TabIndex = 2;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // enQueueGroupBox
            // 
            this.enQueueGroupBox.Controls.Add(this.enqueueButton);
            this.enQueueGroupBox.Controls.Add(this.label2);
            this.enQueueGroupBox.Controls.Add(this.label1);
            this.enQueueGroupBox.Controls.Add(this.nameEnqueueTextBox);
            this.enQueueGroupBox.Controls.Add(this.complainEnqueueTextBox);
            this.enQueueGroupBox.Location = new System.Drawing.Point(0, 15);
            this.enQueueGroupBox.Name = "enQueueGroupBox";
            this.enQueueGroupBox.Size = new System.Drawing.Size(295, 155);
            this.enQueueGroupBox.TabIndex = 2;
            this.enQueueGroupBox.TabStop = false;
            this.enQueueGroupBox.Text = "Enqueue Customer";
            // 
            // complainEnqueueTextBox
            // 
            this.complainEnqueueTextBox.Location = new System.Drawing.Point(94, 70);
            this.complainEnqueueTextBox.Name = "complainEnqueueTextBox";
            this.complainEnqueueTextBox.Size = new System.Drawing.Size(127, 20);
            this.complainEnqueueTextBox.TabIndex = 0;
            // 
            // deQueueGroupBox
            // 
            this.deQueueGroupBox.Controls.Add(this.deQueueButton);
            this.deQueueGroupBox.Controls.Add(this.label5);
            this.deQueueGroupBox.Controls.Add(this.label4);
            this.deQueueGroupBox.Controls.Add(this.label3);
            this.deQueueGroupBox.Controls.Add(this.complainDequeueTextBox);
            this.deQueueGroupBox.Controls.Add(this.nameDequeueTextBox);
            this.deQueueGroupBox.Controls.Add(this.serialNoDequeueTextBox);
            this.deQueueGroupBox.Location = new System.Drawing.Point(337, 15);
            this.deQueueGroupBox.Name = "deQueueGroupBox";
            this.deQueueGroupBox.Size = new System.Drawing.Size(343, 170);
            this.deQueueGroupBox.TabIndex = 3;
            this.deQueueGroupBox.TabStop = false;
            this.deQueueGroupBox.Text = "Dequeue Customer";
            // 
            // EnqueueDequeAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 414);
            this.Controls.Add(this.waitingQueueGroupBox);
            this.Controls.Add(this.enQueueGroupBox);
            this.Controls.Add(this.deQueueGroupBox);
            this.Name = "EnqueueDequeAppUI";
            this.Text = "CoustmerEnqueDeque";
            this.waitingQueueGroupBox.ResumeLayout(false);
            this.enQueueGroupBox.ResumeLayout(false);
            this.enQueueGroupBox.PerformLayout();
            this.deQueueGroupBox.ResumeLayout(false);
            this.deQueueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader complainColumnHeader;
        private System.Windows.Forms.ColumnHeader serialNoColumnHeader;
        private System.Windows.Forms.ListView waitingQueueListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.GroupBox waitingQueueGroupBox;
        private System.Windows.Forms.Button deQueueButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameEnqueueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox complainDequeueTextBox;
        private System.Windows.Forms.TextBox nameDequeueTextBox;
        private System.Windows.Forms.TextBox serialNoDequeueTextBox;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox enQueueGroupBox;
        private System.Windows.Forms.TextBox complainEnqueueTextBox;
        private System.Windows.Forms.GroupBox deQueueGroupBox;
    }
}

