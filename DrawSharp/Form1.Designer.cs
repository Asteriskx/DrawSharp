namespace DrawSharp
{
	partial class DrawSharp
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.newSave = new System.Windows.Forms.ToolStripMenuItem();
			this.closeApp = new System.Windows.Forms.ToolStripMenuItem();
			this.tools = new System.Windows.Forms.ToolStripMenuItem();
			this.drawInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.pencil = new System.Windows.Forms.ToolStripMenuItem();
			this.eraser = new System.Windows.Forms.ToolStripMenuItem();
			this.fill = new System.Windows.Forms.ToolStripMenuItem();
			this.rect = new System.Windows.Forms.ToolStripMenuItem();
			this.none = new System.Windows.Forms.ToolStripMenuItem();
			this.colorInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.Stroke = new System.Windows.Forms.ToolStripMenuItem();
			this.Default = new System.Windows.Forms.ToolStripMenuItem();
			this.L1 = new System.Windows.Forms.ToolStripMenuItem();
			this.L2 = new System.Windows.Forms.ToolStripMenuItem();
			this.L3 = new System.Windows.Forms.ToolStripMenuItem();
			this.L4 = new System.Windows.Forms.ToolStripMenuItem();
			this.L5 = new System.Windows.Forms.ToolStripMenuItem();
			this.L6 = new System.Windows.Forms.ToolStripMenuItem();
			this.allErase = new System.Windows.Forms.ToolStripMenuItem();
			this.drawArea = new System.Windows.Forms.PictureBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileInfo,
            this.tools});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(484, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileInfo
			// 
			this.fileInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSave,
            this.closeApp});
			this.fileInfo.Name = "fileInfo";
			this.fileInfo.Size = new System.Drawing.Size(67, 20);
			this.fileInfo.Text = "ファイル(&F)";
			// 
			// newSave
			// 
			this.newSave.Name = "newSave";
			this.newSave.Size = new System.Drawing.Size(175, 22);
			this.newSave.Text = "名前を付けて保存(&S)";
			// 
			// closeApp
			// 
			this.closeApp.Name = "closeApp";
			this.closeApp.Size = new System.Drawing.Size(175, 22);
			this.closeApp.Text = "閉じる(&E)";
			// 
			// tools
			// 
			this.tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawInfo,
            this.colorInfo,
            this.Stroke,
            this.allErase});
			this.tools.Name = "tools";
			this.tools.Size = new System.Drawing.Size(60, 20);
			this.tools.Text = "ツール(&T)";
			// 
			// drawInfo
			// 
			this.drawInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencil,
            this.eraser,
            this.fill,
            this.rect,
            this.none});
			this.drawInfo.Name = "drawInfo";
			this.drawInfo.Size = new System.Drawing.Size(152, 22);
			this.drawInfo.Text = "描画線(&D)";
			// 
			// pencil
			// 
			this.pencil.Name = "pencil";
			this.pencil.Size = new System.Drawing.Size(121, 22);
			this.pencil.Text = "ペン";
			// 
			// eraser
			// 
			this.eraser.Name = "eraser";
			this.eraser.Size = new System.Drawing.Size(121, 22);
			this.eraser.Text = "消しゴム";
			// 
			// fill
			// 
			this.fill.Name = "fill";
			this.fill.Size = new System.Drawing.Size(121, 22);
			this.fill.Text = "塗りつぶし";
			// 
			// rect
			// 
			this.rect.Name = "rect";
			this.rect.Size = new System.Drawing.Size(121, 22);
			this.rect.Text = "四角形";
			// 
			// none
			// 
			this.none.Name = "none";
			this.none.Size = new System.Drawing.Size(121, 22);
			this.none.Text = "なし";
			// 
			// colorInfo
			// 
			this.colorInfo.Name = "colorInfo";
			this.colorInfo.Size = new System.Drawing.Size(152, 22);
			this.colorInfo.Text = "色(&C)";
			// 
			// Stroke
			// 
			this.Stroke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Default,
            this.L1,
            this.L2,
            this.L3,
            this.L4,
            this.L5,
            this.L6});
			this.Stroke.Name = "Stroke";
			this.Stroke.Size = new System.Drawing.Size(152, 22);
			this.Stroke.Text = "太さ(&S)";
			// 
			// Default
			// 
			this.Default.Name = "Default";
			this.Default.Size = new System.Drawing.Size(152, 22);
			this.Default.Text = "default";
			// 
			// L1
			// 
			this.L1.Name = "L1";
			this.L1.Size = new System.Drawing.Size(152, 22);
			this.L1.Text = "レベル1";
			// 
			// L2
			// 
			this.L2.Name = "L2";
			this.L2.Size = new System.Drawing.Size(152, 22);
			this.L2.Text = "レベル2";
			// 
			// L3
			// 
			this.L3.Name = "L3";
			this.L3.Size = new System.Drawing.Size(152, 22);
			this.L3.Text = "レベル3";
			// 
			// L4
			// 
			this.L4.Name = "L4";
			this.L4.Size = new System.Drawing.Size(152, 22);
			this.L4.Text = "レベル4";
			// 
			// L5
			// 
			this.L5.Name = "L5";
			this.L5.Size = new System.Drawing.Size(152, 22);
			this.L5.Text = "レベル5";
			// 
			// L6
			// 
			this.L6.Name = "L6";
			this.L6.Size = new System.Drawing.Size(152, 22);
			this.L6.Text = "レベル6";
			// 
			// allErase
			// 
			this.allErase.Name = "allErase";
			this.allErase.Size = new System.Drawing.Size(152, 22);
			this.allErase.Text = "全消し(&A)";
			// 
			// drawArea
			// 
			this.drawArea.BackColor = System.Drawing.Color.White;
			this.drawArea.Location = new System.Drawing.Point(2, 28);
			this.drawArea.Name = "drawArea";
			this.drawArea.Size = new System.Drawing.Size(480, 430);
			this.drawArea.TabIndex = 1;
			this.drawArea.TabStop = false;
			this.drawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseDown);
			this.drawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseMove);
			this.drawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseUp);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 458);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(484, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status
			// 
			this.status.ForeColor = System.Drawing.Color.White;
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(55, 17);
			this.status.Text = "準備完了";
			// 
			// DrawSharp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 480);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.drawArea);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "DrawSharp";
			this.Text = "SymmetrySharp";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileInfo;
		private System.Windows.Forms.ToolStripMenuItem newSave;
		private System.Windows.Forms.ToolStripMenuItem closeApp;
		private System.Windows.Forms.ToolStripMenuItem tools;
		private System.Windows.Forms.ToolStripMenuItem drawInfo;
		private System.Windows.Forms.ToolStripMenuItem pencil;
		private System.Windows.Forms.ToolStripMenuItem eraser;
		private System.Windows.Forms.ToolStripMenuItem fill;
		private System.Windows.Forms.ToolStripMenuItem rect;
		private System.Windows.Forms.ToolStripMenuItem none;
		private System.Windows.Forms.ToolStripMenuItem colorInfo;
		private System.Windows.Forms.PictureBox drawArea;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel status;
		private System.Windows.Forms.ToolStripMenuItem allErase;
		private System.Windows.Forms.ToolStripMenuItem Stroke;
		private System.Windows.Forms.ToolStripMenuItem Default;
		private System.Windows.Forms.ToolStripMenuItem L1;
		private System.Windows.Forms.ToolStripMenuItem L2;
		private System.Windows.Forms.ToolStripMenuItem L3;
		private System.Windows.Forms.ToolStripMenuItem L4;
		private System.Windows.Forms.ToolStripMenuItem L5;
		private System.Windows.Forms.ToolStripMenuItem L6;
	}
}

