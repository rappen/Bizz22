namespace Bizz22
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.xrmView = new Rappen.XTB.Helpers.Controls.XRMColumnLookup();
            this.chkManaged = new System.Windows.Forms.CheckBox();
            this.xrmTable = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSave = new System.Windows.Forms.Button();
            this.xrmPrimaryName = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.xrmRecordHost1 = new Rappen.XTB.Helpers.Controls.XRMRecordHost();
            this.chkFriendly = new System.Windows.Forms.CheckBox();
            this.xrmData = new Rappen.XTB.Helpers.Controls.XRMDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xrmData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xrmView);
            this.panel1.Controls.Add(this.chkManaged);
            this.panel1.Controls.Add(this.xrmTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 100);
            this.panel1.TabIndex = 0;
            // 
            // xrmView
            // 
            this.xrmView.AddNullRecord = true;
            this.xrmView.Column = null;
            this.xrmView.DisplayFormat = "";
            this.xrmView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmView.Filter = null;
            this.xrmView.FormattingEnabled = true;
            this.xrmView.Location = new System.Drawing.Point(558, 46);
            this.xrmView.Name = "xrmView";
            this.xrmView.RecordHost = null;
            this.xrmView.Service = null;
            this.xrmView.Size = new System.Drawing.Size(509, 39);
            this.xrmView.TabIndex = 2;
            this.xrmView.SelectedIndexChanged += new System.EventHandler(this.xrmView_SelectedIndexChanged);
            // 
            // chkManaged
            // 
            this.chkManaged.AutoSize = true;
            this.chkManaged.Location = new System.Drawing.Point(36, 4);
            this.chkManaged.Name = "chkManaged";
            this.chkManaged.Size = new System.Drawing.Size(171, 36);
            this.chkManaged.TabIndex = 1;
            this.chkManaged.Text = "Managed";
            this.chkManaged.UseVisualStyleBackColor = true;
            this.chkManaged.CheckedChanged += new System.EventHandler(this.chkManaged_CheckedChanged);
            // 
            // xrmTable
            // 
            this.xrmTable.AddNullOption = true;
            this.xrmTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmTable.FormattingEnabled = true;
            this.xrmTable.Location = new System.Drawing.Point(23, 46);
            this.xrmTable.Name = "xrmTable";
            this.xrmTable.Size = new System.Drawing.Size(496, 39);
            this.xrmTable.TabIndex = 0;
            this.xrmTable.SelectedIndexChanged += new System.EventHandler(this.xrmTable_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.xrmPrimaryName);
            this.splitContainer1.Panel1.Controls.Add(this.chkFriendly);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xrmData);
            this.splitContainer1.Size = new System.Drawing.Size(1492, 616);
            this.splitContainer1.SplitterDistance = 497;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(397, 196);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xrmPrimaryName
            // 
            this.xrmPrimaryName.Column = null;
            this.xrmPrimaryName.DisplayFormat = "";
            this.xrmPrimaryName.Location = new System.Drawing.Point(54, 169);
            this.xrmPrimaryName.Name = "xrmPrimaryName";
            this.xrmPrimaryName.RecordHost = this.xrmRecordHost1;
            this.xrmPrimaryName.Size = new System.Drawing.Size(377, 38);
            this.xrmPrimaryName.TabIndex = 1;
            // 
            // xrmRecordHost1
            // 
            this.xrmRecordHost1.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.xrmRecordHost1.LogicalName = null;
            this.xrmRecordHost1.Record = null;
            this.xrmRecordHost1.Service = null;
            // 
            // chkFriendly
            // 
            this.chkFriendly.AutoSize = true;
            this.chkFriendly.Checked = true;
            this.chkFriendly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFriendly.Location = new System.Drawing.Point(89, 71);
            this.chkFriendly.Name = "chkFriendly";
            this.chkFriendly.Size = new System.Drawing.Size(154, 36);
            this.chkFriendly.TabIndex = 0;
            this.chkFriendly.Text = "Friendly";
            this.chkFriendly.UseVisualStyleBackColor = true;
            this.chkFriendly.CheckedChanged += new System.EventHandler(this.chkFriendly_CheckedChanged);
            // 
            // xrmData
            // 
            this.xrmData.AllowUserToAddRows = false;
            this.xrmData.AllowUserToDeleteRows = false;
            this.xrmData.AllowUserToOrderColumns = true;
            this.xrmData.AllowUserToResizeRows = false;
            this.xrmData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xrmData.ColumnOrder = "";
            this.xrmData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xrmData.FilterColumns = "";
            this.xrmData.Location = new System.Drawing.Point(0, 0);
            this.xrmData.Name = "xrmData";
            this.xrmData.ReadOnly = true;
            this.xrmData.RowHeadersWidth = 102;
            this.xrmData.RowTemplate.Height = 40;
            this.xrmData.Service = null;
            this.xrmData.ShowFriendlyNames = true;
            this.xrmData.ShowIdColumn = false;
            this.xrmData.ShowIndexColumn = false;
            this.xrmData.Size = new System.Drawing.Size(991, 616);
            this.xrmData.TabIndex = 0;
            this.xrmData.RecordClick += new Rappen.XTB.Helpers.Controls.XRMRecordEventHandler(this.xrmData_RecordClick);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1492, 716);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.MyPluginControl_ConnectionUpdated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xrmData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Rappen.XTB.Helpers.Controls.XRMEntityComboBox xrmTable;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkManaged;
        private Rappen.XTB.Helpers.Controls.XRMColumnLookup xrmView;
        private Rappen.XTB.Helpers.Controls.XRMDataGridView xrmData;
        private System.Windows.Forms.CheckBox chkFriendly;
        private Rappen.XTB.Helpers.Controls.XRMRecordHost xrmRecordHost1;
        private Rappen.XTB.Helpers.Controls.XRMColumnText xrmPrimaryName;
        private System.Windows.Forms.Button btnSave;
    }
}
