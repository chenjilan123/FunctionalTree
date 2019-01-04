namespace FunctionalTree
{
    partial class VehicleOrganization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleOrganization));
            this.ioTView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.spC = new System.Windows.Forms.SplitContainer();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spC)).BeginInit();
            this.spC.Panel1.SuspendLayout();
            this.spC.Panel2.SuspendLayout();
            this.spC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // ioTView
            // 
            this.ioTView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ioTView.CheckBoxes = true;
            this.ioTView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ioTView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ioTView.HotTracking = true;
            this.ioTView.ImageIndex = 6;
            this.ioTView.ImageList = this.imageList;
            this.ioTView.Indent = 19;
            this.ioTView.LineColor = System.Drawing.Color.Gray;
            this.ioTView.Location = new System.Drawing.Point(0, 0);
            this.ioTView.Name = "ioTView";
            this.ioTView.SelectedImageIndex = 6;
            this.ioTView.Size = new System.Drawing.Size(220, 532);
            this.ioTView.TabIndex = 0;
            this.ioTView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.ioTView_AfterCollapse);
            this.ioTView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.ioTView_AfterExpand);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "奔驰off.png");
            this.imageList.Images.SetKeyName(1, "奔驰on.png");
            this.imageList.Images.SetKeyName(2, "本田off.png");
            this.imageList.Images.SetKeyName(3, "本田on.png");
            this.imageList.Images.SetKeyName(4, "法拉利off.png");
            this.imageList.Images.SetKeyName(5, "法拉利on.png");
            this.imageList.Images.SetKeyName(6, "文件夹.png");
            this.imageList.Images.SetKeyName(7, "文件夹 (1).png");
            // 
            // spC
            // 
            this.spC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spC.Location = new System.Drawing.Point(0, 0);
            this.spC.Name = "spC";
            // 
            // spC.Panel1
            // 
            this.spC.Panel1.Controls.Add(this.refresh);
            this.spC.Panel1.Controls.Add(this.ioTView);
            // 
            // spC.Panel2
            // 
            this.spC.Panel2.Controls.Add(this.Cancel);
            this.spC.Panel2.Controls.Add(this.OK);
            this.spC.Size = new System.Drawing.Size(660, 532);
            this.spC.SplitterDistance = 220;
            this.spC.TabIndex = 1;
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.BackColor = System.Drawing.Color.White;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = global::FunctionalTree.Properties.Resources.刷新gray;
            this.refresh.Location = new System.Drawing.Point(198, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(19, 19);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 0;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(350, 497);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(269, 497);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // VehicleOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 532);
            this.Controls.Add(this.spC);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VehicleOrganization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.spC.Panel1.ResumeLayout(false);
            this.spC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spC)).EndInit();
            this.spC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ioTView;
        private System.Windows.Forms.SplitContainer spC;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
    }
}

