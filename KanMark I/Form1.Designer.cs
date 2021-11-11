namespace KanMark_I
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newKanbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todoBox = new System.Windows.Forms.GroupBox();
            this.rmCardBtn = new System.Windows.Forms.Button();
            this.doingBox = new System.Windows.Forms.GroupBox();
            this.doneBox = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCardBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newKanbanToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newKanbanToolStripMenuItem
            // 
            this.newKanbanToolStripMenuItem.Name = "newKanbanToolStripMenuItem";
            this.newKanbanToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.newKanbanToolStripMenuItem.Text = "New Kanban";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // todoBox
            // 
            this.todoBox.Location = new System.Drawing.Point(26, 36);
            this.todoBox.Name = "todoBox";
            this.todoBox.Size = new System.Drawing.Size(365, 631);
            this.todoBox.TabIndex = 1;
            this.todoBox.TabStop = false;
            this.todoBox.Text = "To do";
            // 
            // rmCardBtn
            // 
            this.rmCardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rmCardBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rmCardBtn.Location = new System.Drawing.Point(190, 673);
            this.rmCardBtn.Name = "rmCardBtn";
            this.rmCardBtn.Size = new System.Drawing.Size(158, 34);
            this.rmCardBtn.TabIndex = 5;
            this.rmCardBtn.Text = "Remove Card";
            this.rmCardBtn.UseVisualStyleBackColor = true;
            // 
            // doingBox
            // 
            this.doingBox.Location = new System.Drawing.Point(397, 36);
            this.doingBox.Name = "doingBox";
            this.doingBox.Size = new System.Drawing.Size(365, 631);
            this.doingBox.TabIndex = 2;
            this.doingBox.TabStop = false;
            this.doingBox.Text = "Doing";
            // 
            // doneBox
            // 
            this.doneBox.Location = new System.Drawing.Point(768, 36);
            this.doneBox.Name = "doneBox";
            this.doneBox.Size = new System.Drawing.Size(365, 631);
            this.doneBox.TabIndex = 3;
            this.doneBox.TabStop = false;
            this.doneBox.Text = "Done";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 36);
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(157, 32);
            this.newTaskToolStripMenuItem.Text = "New Task";
            // 
            // newCardBtn
            // 
            this.newCardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newCardBtn.Location = new System.Drawing.Point(26, 673);
            this.newCardBtn.Name = "newCardBtn";
            this.newCardBtn.Size = new System.Drawing.Size(158, 34);
            this.newCardBtn.TabIndex = 4;
            this.newCardBtn.Text = "New Card";
            this.newCardBtn.UseVisualStyleBackColor = true;
            this.newCardBtn.Click += new System.EventHandler(this.newCardBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1158, 719);
            this.Controls.Add(this.rmCardBtn);
            this.Controls.Add(this.newCardBtn);
            this.Controls.Add(this.doneBox);
            this.Controls.Add(this.doingBox);
            this.Controls.Add(this.todoBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KanMark I";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newKanbanToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private GroupBox todoBox;
        private GroupBox doingBox;
        private GroupBox doneBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newTaskToolStripMenuItem;
        private Button newCardBtn;
        private Button rmCardBtn;
    }
}