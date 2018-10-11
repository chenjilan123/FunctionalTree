namespace FunctionalTree
{
    partial class TreeFakeMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeFakeMainForm));
            this.ioTView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.spC = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.spC)).BeginInit();
            this.spC.Panel1.SuspendLayout();
            this.spC.SuspendLayout();
            this.SuspendLayout();
            // 
            // ioTView
            // 
            this.ioTView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ioTView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ioTView.HotTracking = true;
            this.ioTView.ImageIndex = 0;
            this.ioTView.ImageList = this.imageList;
            this.ioTView.Location = new System.Drawing.Point(0, 0);
            this.ioTView.Name = "ioTView";
            this.ioTView.SelectedImageIndex = 0;
            this.ioTView.Size = new System.Drawing.Size(217, 532);
            this.ioTView.StateImageList = this.imageList;
            this.ioTView.TabIndex = 0;
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
            // 
            // spC
            // 
            this.spC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spC.Location = new System.Drawing.Point(0, 0);
            this.spC.Name = "spC";
            // 
            // spC.Panel1
            // 
            this.spC.Panel1.Controls.Add(this.ioTView);
            this.spC.Size = new System.Drawing.Size(651, 532);
            this.spC.SplitterDistance = 217;
            this.spC.TabIndex = 1;
            // 
            // TreeFakeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 532);
            this.Controls.Add(this.spC);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TreeFakeMainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.spC.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spC)).EndInit();
            this.spC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ioTView;
        private System.Windows.Forms.SplitContainer spC;
        private System.Windows.Forms.ImageList imageList;
    }
}

