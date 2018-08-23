namespace RLReplayDashboard
{
    partial class Form1
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode5 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode6 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode7 = new DevExpress.XtraGrid.GridLevelNode();
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBoxReplayPath = new System.Windows.Forms.TextBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageRaw = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPageGraphs = new DevExpress.XtraTab.XtraTabPage();
            this.comboBoxEditDateRange = new DevExpress.XtraEditors.ComboBoxEdit();
            this.colClassIndexLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassNetCacheLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassNetCaches = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebugStringLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEngineVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyFrameLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevelLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicenseeVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamesLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjectLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjects = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackagesLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPart1Crc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPart1Length = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPart2Crc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPart2Length = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProperties = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAGame_Replay_Soccar_TA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTickMarkLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xtraTabPageGames = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageRaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPageGraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDateRange.Properties)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(12, 27);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // textBoxReplayPath
            // 
            this.textBoxReplayPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReplayPath.Location = new System.Drawing.Point(93, 27);
            this.textBoxReplayPath.Name = "textBoxReplayPath";
            this.textBoxReplayPath.Size = new System.Drawing.Size(301, 23);
            this.textBoxReplayPath.TabIndex = 1;
            this.textBoxReplayPath.Text = "C:\\Users\\paul.ikeda\\OneDrive\\RL Replays";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 60);
            this.xtraTabControl1.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.xtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageRaw;
            this.xtraTabControl1.Size = new System.Drawing.Size(1067, 563);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageRaw,
            this.xtraTabPageGraphs,
            this.xtraTabPageGames});
            // 
            // xtraTabPageRaw
            // 
            this.xtraTabPageRaw.Controls.Add(this.gridControl1);
            this.xtraTabPageRaw.Name = "xtraTabPageRaw";
            this.xtraTabPageRaw.Size = new System.Drawing.Size(1065, 538);
            this.xtraTabPageRaw.Text = "Raw";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(RocketLeagueReplayParser.Replay);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Levels";
            gridLevelNode2.RelationName = "KeyFrames";
            gridLevelNode3.RelationName = "Frames";
            gridLevelNode4.RelationName = "DebugStrings";
            gridLevelNode5.RelationName = "TickMarks";
            gridLevelNode6.RelationName = "Packages";
            gridLevelNode7.RelationName = "ClassIndexes";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3,
            gridLevelNode4,
            gridLevelNode5,
            gridLevelNode6,
            gridLevelNode7});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1065, 538);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClassIndexLength,
            this.colClassNetCacheLength,
            this.colClassNetCaches,
            this.colDebugStringLength,
            this.colEngineVersion,
            this.colKeyFrameLength,
            this.colLevelLength,
            this.colLicenseeVersion,
            this.colNames,
            this.colNamesLength,
            this.colNetVersion,
            this.colObjectLength,
            this.colObjects,
            this.colPackagesLength,
            this.colPart1Crc,
            this.colPart1Length,
            this.colPart2Crc,
            this.colPart2Length,
            this.colProperties,
            this.colTAGame_Replay_Soccar_TA,
            this.colTickMarkLength});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // xtraTabPageGraphs
            // 
            this.xtraTabPageGraphs.Controls.Add(this.comboBoxEditDateRange);
            this.xtraTabPageGraphs.Name = "xtraTabPageGraphs";
            this.xtraTabPageGraphs.Size = new System.Drawing.Size(1065, 557);
            this.xtraTabPageGraphs.Text = "Graphs";
            // 
            // comboBoxEditDateRange
            // 
            this.comboBoxEditDateRange.EditValue = "All";
            this.comboBoxEditDateRange.Location = new System.Drawing.Point(12, 13);
            this.comboBoxEditDateRange.Name = "comboBoxEditDateRange";
            this.comboBoxEditDateRange.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditDateRange.Properties.Items.AddRange(new object[] {
            "All",
            "Last Week",
            "Last Month",
            "Last Year"});
            this.comboBoxEditDateRange.Size = new System.Drawing.Size(154, 20);
            this.comboBoxEditDateRange.TabIndex = 0;
            // 
            // colClassIndexLength
            // 
            this.colClassIndexLength.FieldName = "ClassIndexLength";
            this.colClassIndexLength.Name = "colClassIndexLength";
            this.colClassIndexLength.Visible = true;
            this.colClassIndexLength.VisibleIndex = 0;
            // 
            // colClassNetCacheLength
            // 
            this.colClassNetCacheLength.FieldName = "ClassNetCacheLength";
            this.colClassNetCacheLength.Name = "colClassNetCacheLength";
            this.colClassNetCacheLength.Visible = true;
            this.colClassNetCacheLength.VisibleIndex = 1;
            // 
            // colClassNetCaches
            // 
            this.colClassNetCaches.FieldName = "ClassNetCaches";
            this.colClassNetCaches.Name = "colClassNetCaches";
            this.colClassNetCaches.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.colClassNetCaches.Visible = true;
            this.colClassNetCaches.VisibleIndex = 2;
            // 
            // colDebugStringLength
            // 
            this.colDebugStringLength.FieldName = "DebugStringLength";
            this.colDebugStringLength.Name = "colDebugStringLength";
            this.colDebugStringLength.Visible = true;
            this.colDebugStringLength.VisibleIndex = 3;
            // 
            // colEngineVersion
            // 
            this.colEngineVersion.FieldName = "EngineVersion";
            this.colEngineVersion.Name = "colEngineVersion";
            this.colEngineVersion.Visible = true;
            this.colEngineVersion.VisibleIndex = 4;
            // 
            // colKeyFrameLength
            // 
            this.colKeyFrameLength.FieldName = "KeyFrameLength";
            this.colKeyFrameLength.Name = "colKeyFrameLength";
            this.colKeyFrameLength.Visible = true;
            this.colKeyFrameLength.VisibleIndex = 5;
            // 
            // colLevelLength
            // 
            this.colLevelLength.FieldName = "LevelLength";
            this.colLevelLength.Name = "colLevelLength";
            this.colLevelLength.Visible = true;
            this.colLevelLength.VisibleIndex = 6;
            // 
            // colLicenseeVersion
            // 
            this.colLicenseeVersion.FieldName = "LicenseeVersion";
            this.colLicenseeVersion.Name = "colLicenseeVersion";
            this.colLicenseeVersion.Visible = true;
            this.colLicenseeVersion.VisibleIndex = 7;
            // 
            // colNames
            // 
            this.colNames.FieldName = "Names";
            this.colNames.Name = "colNames";
            this.colNames.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.colNames.Visible = true;
            this.colNames.VisibleIndex = 8;
            // 
            // colNamesLength
            // 
            this.colNamesLength.FieldName = "NamesLength";
            this.colNamesLength.Name = "colNamesLength";
            this.colNamesLength.Visible = true;
            this.colNamesLength.VisibleIndex = 9;
            // 
            // colNetVersion
            // 
            this.colNetVersion.FieldName = "NetVersion";
            this.colNetVersion.Name = "colNetVersion";
            this.colNetVersion.Visible = true;
            this.colNetVersion.VisibleIndex = 10;
            // 
            // colObjectLength
            // 
            this.colObjectLength.FieldName = "ObjectLength";
            this.colObjectLength.Name = "colObjectLength";
            this.colObjectLength.Visible = true;
            this.colObjectLength.VisibleIndex = 11;
            // 
            // colObjects
            // 
            this.colObjects.FieldName = "Objects";
            this.colObjects.Name = "colObjects";
            this.colObjects.Visible = true;
            this.colObjects.VisibleIndex = 12;
            // 
            // colPackagesLength
            // 
            this.colPackagesLength.FieldName = "PackagesLength";
            this.colPackagesLength.Name = "colPackagesLength";
            this.colPackagesLength.Visible = true;
            this.colPackagesLength.VisibleIndex = 13;
            // 
            // colPart1Crc
            // 
            this.colPart1Crc.FieldName = "Part1Crc";
            this.colPart1Crc.Name = "colPart1Crc";
            this.colPart1Crc.Visible = true;
            this.colPart1Crc.VisibleIndex = 17;
            // 
            // colPart1Length
            // 
            this.colPart1Length.FieldName = "Part1Length";
            this.colPart1Length.Name = "colPart1Length";
            this.colPart1Length.Visible = true;
            this.colPart1Length.VisibleIndex = 14;
            // 
            // colPart2Crc
            // 
            this.colPart2Crc.FieldName = "Part2Crc";
            this.colPart2Crc.Name = "colPart2Crc";
            this.colPart2Crc.Visible = true;
            this.colPart2Crc.VisibleIndex = 15;
            // 
            // colPart2Length
            // 
            this.colPart2Length.FieldName = "Part2Length";
            this.colPart2Length.Name = "colPart2Length";
            this.colPart2Length.Visible = true;
            this.colPart2Length.VisibleIndex = 16;
            // 
            // colProperties
            // 
            this.colProperties.FieldName = "Properties";
            this.colProperties.Name = "colProperties";
            this.colProperties.Visible = true;
            this.colProperties.VisibleIndex = 18;
            // 
            // colTAGame_Replay_Soccar_TA
            // 
            this.colTAGame_Replay_Soccar_TA.FieldName = "TAGame_Replay_Soccar_TA";
            this.colTAGame_Replay_Soccar_TA.Name = "colTAGame_Replay_Soccar_TA";
            this.colTAGame_Replay_Soccar_TA.Visible = true;
            this.colTAGame_Replay_Soccar_TA.VisibleIndex = 19;
            // 
            // colTickMarkLength
            // 
            this.colTickMarkLength.FieldName = "TickMarkLength";
            this.colTickMarkLength.Name = "colTickMarkLength";
            this.colTickMarkLength.Visible = true;
            this.colTickMarkLength.VisibleIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToJSONToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToJSONToolStripMenuItem
            // 
            this.exportToJSONToolStripMenuItem.Name = "exportToJSONToolStripMenuItem";
            this.exportToJSONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToJSONToolStripMenuItem.Text = "Export to JSON";
            this.exportToJSONToolStripMenuItem.Click += new System.EventHandler(this.exportToJSONToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // xtraTabPageGames
            // 
            this.xtraTabPageGames.Name = "xtraTabPageGames";
            this.xtraTabPageGames.Size = new System.Drawing.Size(1065, 538);
            this.xtraTabPageGames.Text = "xtraTabPage1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 635);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.textBoxReplayPath);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rocket League Replay Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageRaw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPageGraphs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDateRange.Properties)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBoxReplayPath;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageRaw;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGraphs;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditDateRange;
        private DevExpress.XtraGrid.Columns.GridColumn colClassIndexLength;
        private DevExpress.XtraGrid.Columns.GridColumn colClassNetCacheLength;
        private DevExpress.XtraGrid.Columns.GridColumn colClassNetCaches;
        private DevExpress.XtraGrid.Columns.GridColumn colDebugStringLength;
        private DevExpress.XtraGrid.Columns.GridColumn colEngineVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyFrameLength;
        private DevExpress.XtraGrid.Columns.GridColumn colLevelLength;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseeVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colNames;
        private DevExpress.XtraGrid.Columns.GridColumn colNamesLength;
        private DevExpress.XtraGrid.Columns.GridColumn colNetVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colObjectLength;
        private DevExpress.XtraGrid.Columns.GridColumn colObjects;
        private DevExpress.XtraGrid.Columns.GridColumn colPackagesLength;
        private DevExpress.XtraGrid.Columns.GridColumn colPart1Crc;
        private DevExpress.XtraGrid.Columns.GridColumn colPart1Length;
        private DevExpress.XtraGrid.Columns.GridColumn colPart2Crc;
        private DevExpress.XtraGrid.Columns.GridColumn colPart2Length;
        private DevExpress.XtraGrid.Columns.GridColumn colProperties;
        private DevExpress.XtraGrid.Columns.GridColumn colTAGame_Replay_Soccar_TA;
        private DevExpress.XtraGrid.Columns.GridColumn colTickMarkLength;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGames;
    }
}

