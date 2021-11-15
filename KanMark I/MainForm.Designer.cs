﻿namespace KanMark_I
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.todoBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rmCardBtn = new System.Windows.Forms.Button();
            this.doingBox = new System.Windows.Forms.GroupBox();
            this.doneBox = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCardBtn = new System.Windows.Forms.Button();
            this.todoBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoBox
            // 
            resources.ApplyResources(this.todoBox, "todoBox");
            this.todoBox.Controls.Add(this.groupBox1);
            this.todoBox.Name = "todoBox";
            this.todoBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            // 
            // rmCardBtn
            // 
            resources.ApplyResources(this.rmCardBtn, "rmCardBtn");
            this.rmCardBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rmCardBtn.Name = "rmCardBtn";
            this.rmCardBtn.UseVisualStyleBackColor = true;
            // 
            // doingBox
            // 
            resources.ApplyResources(this.doingBox, "doingBox");
            this.doingBox.Name = "doingBox";
            this.doingBox.TabStop = false;
            // 
            // doneBox
            // 
            resources.ApplyResources(this.doneBox, "doneBox");
            this.doneBox.Name = "doneBox";
            this.doneBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            resources.ApplyResources(this.newTaskToolStripMenuItem, "newTaskToolStripMenuItem");
            // 
            // newCardBtn
            // 
            resources.ApplyResources(this.newCardBtn, "newCardBtn");
            this.newCardBtn.Name = "newCardBtn";
            this.newCardBtn.UseVisualStyleBackColor = true;
            this.newCardBtn.Click += new System.EventHandler(this.newCardBtn_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.rmCardBtn);
            this.Controls.Add(this.newCardBtn);
            this.Controls.Add(this.doneBox);
            this.Controls.Add(this.doingBox);
            this.Controls.Add(this.todoBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.todoBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox todoBox;
        private GroupBox doingBox;
        private GroupBox doneBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newTaskToolStripMenuItem;
        private Button newCardBtn;
        private Button rmCardBtn;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
    }
}