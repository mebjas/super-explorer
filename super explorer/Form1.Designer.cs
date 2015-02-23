namespace super_explorer
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.console = new System.Windows.Forms.RichTextBox();
            this.tree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.quicklinks = new System.Windows.Forms.ListView();
            this.workspace = new System.Windows.Forms.ListView();
            this.workspace_icon = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.ForestGreen;
            this.console.Location = new System.Drawing.Point(0, 587);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(1352, 115);
            this.console.TabIndex = 0;
            this.console.Text = "";
            // 
            // tree
            // 
            this.tree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tree.Location = new System.Drawing.Point(1174, 38);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(164, 231);
            this.tree.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1188, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quick Tree";
            // 
            // quicklinks
            // 
            this.quicklinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quicklinks.FullRowSelect = true;
            this.quicklinks.GridLines = true;
            this.quicklinks.Location = new System.Drawing.Point(1174, 275);
            this.quicklinks.Name = "quicklinks";
            this.quicklinks.Size = new System.Drawing.Size(164, 306);
            this.quicklinks.TabIndex = 3;
            this.quicklinks.UseCompatibleStateImageBehavior = false;
            this.quicklinks.View = System.Windows.Forms.View.List;
            // 
            // workspace
            // 
            this.workspace.LargeImageList = this.workspace_icon;
            this.workspace.Location = new System.Drawing.Point(12, 108);
            this.workspace.Name = "workspace";
            this.workspace.Size = new System.Drawing.Size(1156, 473);
            this.workspace.TabIndex = 4;
            this.workspace.UseCompatibleStateImageBehavior = false;
            // 
            // workspace_icon
            // 
            this.workspace_icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("workspace_icon.ImageStream")));
            this.workspace_icon.TransparentColor = System.Drawing.Color.Transparent;
            this.workspace_icon.Images.SetKeyName(0, "drive");
            // 
            // main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.workspace);
            this.Controls.Add(this.quicklinks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Computer";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView quicklinks;
        private System.Windows.Forms.ListView workspace;
        private System.Windows.Forms.ImageList workspace_icon;


    }
}

