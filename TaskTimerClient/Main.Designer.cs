namespace TaskTimer
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
            this.TaskInstructionGroupbox = new System.Windows.Forms.GroupBox();
            this.TaskInstructionLabel = new System.Windows.Forms.Label();
            this.TasksCheckedBox = new System.Windows.Forms.CheckedListBox();
            this.TasksGroupbox = new System.Windows.Forms.GroupBox();
            this.StartTaskButton = new System.Windows.Forms.Button();
            this.CompleteTaskButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TaskAnswerRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TaskAnswerInput = new System.Windows.Forms.GroupBox();
            this.TaskInstructionGroupbox.SuspendLayout();
            this.TasksGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TaskAnswerInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskInstructionGroupbox
            // 
            this.TaskInstructionGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskInstructionGroupbox.Controls.Add(this.TaskInstructionLabel);
            this.TaskInstructionGroupbox.Location = new System.Drawing.Point(12, 386);
            this.TaskInstructionGroupbox.Name = "TaskInstructionGroupbox";
            this.TaskInstructionGroupbox.Size = new System.Drawing.Size(276, 155);
            this.TaskInstructionGroupbox.TabIndex = 0;
            this.TaskInstructionGroupbox.TabStop = false;
            this.TaskInstructionGroupbox.Text = "Task Instructions";
            // 
            // TaskInstructionLabel
            // 
            this.TaskInstructionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskInstructionLabel.Location = new System.Drawing.Point(7, 16);
            this.TaskInstructionLabel.Name = "TaskInstructionLabel";
            this.TaskInstructionLabel.Size = new System.Drawing.Size(263, 136);
            this.TaskInstructionLabel.TabIndex = 0;
            this.TaskInstructionLabel.Text = resources.GetString("TaskInstructionLabel.Text");
            // 
            // TasksCheckedBox
            // 
            this.TasksCheckedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TasksCheckedBox.Enabled = false;
            this.TasksCheckedBox.FormattingEnabled = true;
            this.TasksCheckedBox.Location = new System.Drawing.Point(6, 23);
            this.TasksCheckedBox.Name = "TasksCheckedBox";
            this.TasksCheckedBox.Size = new System.Drawing.Size(264, 229);
            this.TasksCheckedBox.TabIndex = 1;
            // 
            // TasksGroupbox
            // 
            this.TasksGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TasksGroupbox.Controls.Add(this.TasksCheckedBox);
            this.TasksGroupbox.Location = new System.Drawing.Point(12, 94);
            this.TasksGroupbox.Name = "TasksGroupbox";
            this.TasksGroupbox.Size = new System.Drawing.Size(276, 257);
            this.TasksGroupbox.TabIndex = 2;
            this.TasksGroupbox.TabStop = false;
            this.TasksGroupbox.Text = "Tasks";
            // 
            // StartTaskButton
            // 
            this.StartTaskButton.Location = new System.Drawing.Point(18, 357);
            this.StartTaskButton.Name = "StartTaskButton";
            this.StartTaskButton.Size = new System.Drawing.Size(121, 23);
            this.StartTaskButton.TabIndex = 3;
            this.StartTaskButton.Text = "Start Task";
            this.StartTaskButton.UseVisualStyleBackColor = true;
            this.StartTaskButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartTaskButton_MouseClick);
            // 
            // CompleteTaskButton
            // 
            this.CompleteTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteTaskButton.Location = new System.Drawing.Point(154, 357);
            this.CompleteTaskButton.Name = "CompleteTaskButton";
            this.CompleteTaskButton.Size = new System.Drawing.Size(128, 23);
            this.CompleteTaskButton.TabIndex = 4;
            this.CompleteTaskButton.Text = "Complete Task";
            this.CompleteTaskButton.UseVisualStyleBackColor = true;
            this.CompleteTaskButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CompleteTaskButton_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 67);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TitleLabel.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(22, 23);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(167, 39);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Task Giver";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskAnswerRichTextBox
            // 
            this.TaskAnswerRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskAnswerRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.TaskAnswerRichTextBox.Name = "TaskAnswerRichTextBox";
            this.TaskAnswerRichTextBox.Size = new System.Drawing.Size(264, 145);
            this.TaskAnswerRichTextBox.TabIndex = 7;
            this.TaskAnswerRichTextBox.Text = "";
            // 
            // TaskAnswerInput
            // 
            this.TaskAnswerInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskAnswerInput.Controls.Add(this.TaskAnswerRichTextBox);
            this.TaskAnswerInput.Location = new System.Drawing.Point(12, 548);
            this.TaskAnswerInput.Name = "TaskAnswerInput";
            this.TaskAnswerInput.Size = new System.Drawing.Size(276, 170);
            this.TaskAnswerInput.TabIndex = 8;
            this.TaskAnswerInput.TabStop = false;
            this.TaskAnswerInput.Text = "Task Answer Box";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 730);
            this.ControlBox = false;
            this.Controls.Add(this.TaskAnswerInput);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CompleteTaskButton);
            this.Controls.Add(this.StartTaskButton);
            this.Controls.Add(this.TasksGroupbox);
            this.Controls.Add(this.TaskInstructionGroupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Task Giver";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TaskInstructionGroupbox.ResumeLayout(false);
            this.TasksGroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TaskAnswerInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TaskInstructionGroupbox;
        private System.Windows.Forms.Label TaskInstructionLabel;
        private System.Windows.Forms.CheckedListBox TasksCheckedBox;
        private System.Windows.Forms.GroupBox TasksGroupbox;
        private System.Windows.Forms.Button StartTaskButton;
        private System.Windows.Forms.Button CompleteTaskButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RichTextBox TaskAnswerRichTextBox;
        private System.Windows.Forms.GroupBox TaskAnswerInput;
    }
}