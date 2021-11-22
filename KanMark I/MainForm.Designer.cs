namespace KanMark_I
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todoGrp = new System.Windows.Forms.GroupBox();
            this.doingGrp = new System.Windows.Forms.GroupBox();
            this.doneGrp = new System.Windows.Forms.GroupBox();
            this.NewCardBtn = new System.Windows.Forms.Button();
            this.RmCardBtn = new System.Windows.Forms.Button();
            this.manageBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // todoGrp
            // 
            resources.ApplyResources(this.todoGrp, "todoGrp");
            this.todoGrp.Name = "todoGrp";
            this.todoGrp.TabStop = false;
            // 
            // doingGrp
            // 
            resources.ApplyResources(this.doingGrp, "doingGrp");
            this.doingGrp.Name = "doingGrp";
            this.doingGrp.TabStop = false;
            // 
            // doneGrp
            // 
            resources.ApplyResources(this.doneGrp, "doneGrp");
            this.doneGrp.Name = "doneGrp";
            this.doneGrp.TabStop = false;
            // 
            // NewCardBtn
            // 
            resources.ApplyResources(this.NewCardBtn, "NewCardBtn");
            this.NewCardBtn.Name = "NewCardBtn";
            this.NewCardBtn.UseVisualStyleBackColor = true;
            this.NewCardBtn.Click += new System.EventHandler(this.NewCardBtn_Click);
            // 
            // RmCardBtn
            // 
            this.RmCardBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.RmCardBtn, "RmCardBtn");
            this.RmCardBtn.Name = "RmCardBtn";
            this.RmCardBtn.UseVisualStyleBackColor = true;
            this.RmCardBtn.Click += new System.EventHandler(this.RmCardBtn_Click);
            // 
            // manageBtn
            // 
            resources.ApplyResources(this.manageBtn, "manageBtn");
            this.manageBtn.Name = "manageBtn";
            this.manageBtn.UseVisualStyleBackColor = true;
            this.manageBtn.Click += new System.EventHandler(this.manageBtn_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.manageBtn);
            this.Controls.Add(this.NewCardBtn);
            this.Controls.Add(this.RmCardBtn);
            this.Controls.Add(this.doneGrp);
            this.Controls.Add(this.doingGrp);
            this.Controls.Add(this.todoGrp);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newTaskToolStripMenuItem;
        private GroupBox todoGrp;
        private GroupBox doingGrp;
        private GroupBox doneGrp;
        private Button NewCardBtn;
        private Button RmCardBtn;
        private Button manageBtn;
    }
}