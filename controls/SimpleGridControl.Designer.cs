﻿namespace xwcs.core.ui.controls
{
	partial class SimpleGridControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;



		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleGridControl));
			DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
			DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
			DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.simpleButton_DELETE = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton_ADD = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl
			// 
			this.gridControl.Location = new System.Drawing.Point(2, 2);
			this.gridControl.MainView = this.gridView;
			this.gridControl.Name = "gridControl";
			this.gridControl.Size = new System.Drawing.Size(373, 189);
			this.gridControl.TabIndex = 0;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// gridView
			// 
			this.gridView.GridControl = this.gridControl;
			this.gridView.Name = "gridView";
			this.gridView.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.False;
			this.gridView.OptionsBehavior.ReadOnly = true;
			this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView.OptionsView.RowAutoHeight = true;
			this.gridView.OptionsView.ShowGroupPanel = false;
			this.gridView.EditFormPrepared += new DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventHandler(this.gridView_EditFormPrepared);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.simpleButton_DELETE, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.simpleButton_ADD, 0, 1);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(379, 2);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(28, 189);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// simpleButton_DELETE
			// 
			this.simpleButton_DELETE.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButton_DELETE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.simpleButton_DELETE.Enabled = false;
			this.simpleButton_DELETE.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_DELETE.Image")));
			this.simpleButton_DELETE.Location = new System.Drawing.Point(4, 97);
			this.simpleButton_DELETE.Name = "simpleButton_DELETE";
			this.simpleButton_DELETE.Size = new System.Drawing.Size(20, 17);
			this.simpleButton_DELETE.TabIndex = 3;
			// 
			// simpleButton_ADD
			// 
			this.simpleButton_ADD.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.simpleButton_ADD.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.simpleButton_ADD.Enabled = false;
			this.simpleButton_ADD.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_ADD.Image")));
			this.simpleButton_ADD.Location = new System.Drawing.Point(4, 74);
			this.simpleButton_ADD.Name = "simpleButton_ADD";
			this.simpleButton_ADD.Size = new System.Drawing.Size(20, 17);
			this.simpleButton_ADD.TabIndex = 2;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.gridControl);
			this.layoutControl1.Controls.Add(this.tableLayoutPanel4);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1075, 195, 450, 400);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(409, 193);
			this.layoutControl1.TabIndex = 4;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
			this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
			columnDefinition1.Width = 100D;
			columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
			columnDefinition2.Width = 32D;
			this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
			rowDefinition1.Height = 100D;
			rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
			this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Size = new System.Drawing.Size(409, 193);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.tableLayoutPanel4;
			this.layoutControlItem1.Location = new System.Drawing.Point(377, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
			this.layoutControlItem1.Size = new System.Drawing.Size(32, 193);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.gridControl;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(377, 193);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// SimpleGridControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.layoutControl1);
			this.EditValue = 6;
			this.MinimumSize = new System.Drawing.Size(0, 100);
			this.Name = "SimpleGridControl";
			this.Size = new System.Drawing.Size(409, 193);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		public DevExpress.XtraGrid.GridControl gridControl;
		public DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private DevExpress.XtraEditors.SimpleButton simpleButton_ADD;
		private DevExpress.XtraEditors.SimpleButton simpleButton_DELETE;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
