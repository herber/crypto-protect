namespace CryptoProtect
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.chk_BadRabbit = new System.Windows.Forms.CheckBox();
            this.chk_Petya = new System.Windows.Forms.CheckBox();
            this.btn_Install = new System.Windows.Forms.Button();
            this.btn_Uninstall = new System.Windows.Forms.Button();
            this.stat_main = new System.Windows.Forms.StatusStrip();
            this.stat_lbl_main = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lnk_GitHub = new System.Windows.Forms.LinkLabel();
            this.lnk_Web = new System.Windows.Forms.LinkLabel();
            this.stat_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_BadRabbit
            // 
            this.chk_BadRabbit.AutoSize = true;
            this.chk_BadRabbit.Location = new System.Drawing.Point(12, 12);
            this.chk_BadRabbit.Name = "chk_BadRabbit";
            this.chk_BadRabbit.Size = new System.Drawing.Size(76, 17);
            this.chk_BadRabbit.TabIndex = 0;
            this.chk_BadRabbit.Text = "BadRabbit";
            this.chk_BadRabbit.UseVisualStyleBackColor = true;
            // 
            // chk_Petya
            // 
            this.chk_Petya.AutoSize = true;
            this.chk_Petya.Location = new System.Drawing.Point(12, 35);
            this.chk_Petya.Name = "chk_Petya";
            this.chk_Petya.Size = new System.Drawing.Size(108, 17);
            this.chk_Petya.TabIndex = 1;
            this.chk_Petya.Text = "Petya / NotPetya";
            this.chk_Petya.UseVisualStyleBackColor = true;
            // 
            // btn_Install
            // 
            this.btn_Install.Location = new System.Drawing.Point(197, 12);
            this.btn_Install.Name = "btn_Install";
            this.btn_Install.Size = new System.Drawing.Size(75, 23);
            this.btn_Install.TabIndex = 2;
            this.btn_Install.Text = "Install";
            this.btn_Install.UseVisualStyleBackColor = true;
            this.btn_Install.Click += new System.EventHandler(this.btn_Install_Click);
            // 
            // btn_Uninstall
            // 
            this.btn_Uninstall.Location = new System.Drawing.Point(197, 42);
            this.btn_Uninstall.Name = "btn_Uninstall";
            this.btn_Uninstall.Size = new System.Drawing.Size(75, 23);
            this.btn_Uninstall.TabIndex = 3;
            this.btn_Uninstall.Text = "Uninstall";
            this.btn_Uninstall.UseVisualStyleBackColor = true;
            this.btn_Uninstall.Click += new System.EventHandler(this.btn_Uninstall_Click);
            // 
            // stat_main
            // 
            this.stat_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stat_lbl_main});
            this.stat_main.Location = new System.Drawing.Point(0, 90);
            this.stat_main.Name = "stat_main";
            this.stat_main.Size = new System.Drawing.Size(284, 22);
            this.stat_main.SizingGrip = false;
            this.stat_main.TabIndex = 0;
            // 
            // stat_lbl_main
            // 
            this.stat_lbl_main.Name = "stat_lbl_main";
            this.stat_lbl_main.Size = new System.Drawing.Size(96, 17);
            this.stat_lbl_main.Text = "by Tobias Herber";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lnk_GitHub
            // 
            this.lnk_GitHub.AutoSize = true;
            this.lnk_GitHub.LinkColor = System.Drawing.Color.Blue;
            this.lnk_GitHub.Location = new System.Drawing.Point(11, 66);
            this.lnk_GitHub.Name = "lnk_GitHub";
            this.lnk_GitHub.Size = new System.Drawing.Size(40, 13);
            this.lnk_GitHub.TabIndex = 5;
            this.lnk_GitHub.TabStop = true;
            this.lnk_GitHub.Text = "GitHub";
            this.lnk_GitHub.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnk_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_GitHub_LinkClicked);
            // 
            // lnk_Web
            // 
            this.lnk_Web.AutoSize = true;
            this.lnk_Web.LinkColor = System.Drawing.Color.Blue;
            this.lnk_Web.Location = new System.Drawing.Point(57, 66);
            this.lnk_Web.Name = "lnk_Web";
            this.lnk_Web.Size = new System.Drawing.Size(46, 13);
            this.lnk_Web.TabIndex = 7;
            this.lnk_Web.TabStop = true;
            this.lnk_Web.Text = "Website";
            this.lnk_Web.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnk_Web.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_Web_LinkClicked);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(this.lnk_Web);
            this.Controls.Add(this.lnk_GitHub);
            this.Controls.Add(this.stat_main);
            this.Controls.Add(this.btn_Uninstall);
            this.Controls.Add(this.btn_Install);
            this.Controls.Add(this.chk_Petya);
            this.Controls.Add(this.chk_BadRabbit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.Text = "CryptoProtect";
            this.stat_main.ResumeLayout(false);
            this.stat_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_BadRabbit;
        private System.Windows.Forms.CheckBox chk_Petya;
        private System.Windows.Forms.Button btn_Install;
        private System.Windows.Forms.Button btn_Uninstall;
        private System.Windows.Forms.StatusStrip stat_main;
        private System.Windows.Forms.ToolStripStatusLabel stat_lbl_main;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.LinkLabel lnk_GitHub;
        private System.Windows.Forms.LinkLabel lnk_Web;
    }
}

