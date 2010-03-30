﻿namespace QueryAnalyzer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.batchInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelReport = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxDatabases = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSql = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.panelResult = new System.Windows.Forms.Panel();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treeViewData = new System.Windows.Forms.TreeView();
            this.contextMenuStripTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troubleshooterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.dropTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.truncateTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListTreeView = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialogSql = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStripServer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.troubleshooterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripDatabase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.troubleshooterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonExcute = new System.Windows.Forms.ToolStripButton();
            this.createTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            this.contextMenuStripTable.SuspendLayout();
            this.contextMenuStripServer.SuspendLayout();
            this.contextMenuStripDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOToolStripMenuItem,
            this.toolStripMenuItem2,
            this.batchInsertToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openOToolStripMenuItem
            // 
            this.openOToolStripMenuItem.Name = "openOToolStripMenuItem";
            this.openOToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openOToolStripMenuItem.Text = "Open(&O)";
            this.openOToolStripMenuItem.Click += new System.EventHandler(this.openOToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 6);
            // 
            // batchInsertToolStripMenuItem
            // 
            this.batchInsertToolStripMenuItem.Name = "batchInsertToolStripMenuItem";
            this.batchInsertToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.batchInsertToolStripMenuItem.Text = "BatchInsert";
            this.batchInsertToolStripMenuItem.Click += new System.EventHandler(this.batchInsertToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performanceToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // performanceToolStripMenuItem
            // 
            this.performanceToolStripMenuItem.Name = "performanceToolStripMenuItem";
            this.performanceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.performanceToolStripMenuItem.Text = "Performance";
            this.performanceToolStripMenuItem.Click += new System.EventHandler(this.performanceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelReport});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelReport
            // 
            this.toolStripStatusLabelReport.Name = "toolStripStatusLabelReport";
            this.toolStripStatusLabelReport.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabelReport.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxDatabases,
            this.toolStripSeparator1,
            this.toolStripButtonExcute});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBoxDatabases
            // 
            this.toolStripComboBoxDatabases.Name = "toolStripComboBoxDatabases";
            this.toolStripComboBoxDatabases.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxDatabases.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxDatabases_SelectedIndexChanged);
            this.toolStripComboBoxDatabases.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripComboBoxDatabases_KeyPress);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.treeViewData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 615);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxSql);
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(132, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 615);
            this.panel2.TabIndex = 20;
            // 
            // textBoxSql
            // 
            this.textBoxSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSql.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSql.Location = new System.Drawing.Point(0, 0);
            this.textBoxSql.MaxLength = 327670;
            this.textBoxSql.Multiline = true;
            this.textBoxSql.Name = "textBoxSql";
            this.textBoxSql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSql.Size = new System.Drawing.Size(884, 473);
            this.textBoxSql.TabIndex = 24;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 473);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(884, 3);
            this.splitter2.TabIndex = 23;
            this.splitter2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageResults);
            this.tabControl1.Controls.Add(this.tabPageMessages);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 476);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 139);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.panelResult);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(876, 113);
            this.tabPageResults.TabIndex = 0;
            this.tabPageResults.Text = "Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // panelResult
            // 
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult.Location = new System.Drawing.Point(3, 3);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(870, 107);
            this.panelResult.TabIndex = 0;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.textBoxMessages);
            this.tabPageMessages.Location = new System.Drawing.Point(4, 22);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(876, 113);
            this.tabPageMessages.TabIndex = 1;
            this.tabPageMessages.Text = "Messages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessages.Location = new System.Drawing.Point(3, 3);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMessages.Size = new System.Drawing.Size(870, 107);
            this.textBoxMessages.TabIndex = 0;
            this.textBoxMessages.WordWrap = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(129, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 615);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // treeViewData
            // 
            this.treeViewData.ContextMenuStrip = this.contextMenuStripTable;
            this.treeViewData.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewData.ImageIndex = 0;
            this.treeViewData.ImageList = this.imageListTreeView;
            this.treeViewData.Location = new System.Drawing.Point(0, 0);
            this.treeViewData.Name = "treeViewData";
            this.treeViewData.SelectedImageIndex = 0;
            this.treeViewData.Size = new System.Drawing.Size(129, 615);
            this.treeViewData.TabIndex = 0;
            this.treeViewData.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewData_AfterSelect);
            this.treeViewData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewData_MouseDown);
            // 
            // contextMenuStripTable
            // 
            this.contextMenuStripTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableInfoToolStripMenuItem,
            this.rebuildTableToolStripMenuItem,
            this.toolStripMenuItem1,
            this.refreshToolStripMenuItem,
            this.troubleshooterToolStripMenuItem,
            this.toolStripMenuItem3,
            this.dropTableToolStripMenuItem,
            this.truncateTableToolStripMenuItem});
            this.contextMenuStripTable.Name = "contextMenuStripTree";
            this.contextMenuStripTable.Size = new System.Drawing.Size(148, 148);
            // 
            // tableInfoToolStripMenuItem
            // 
            this.tableInfoToolStripMenuItem.Name = "tableInfoToolStripMenuItem";
            this.tableInfoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.tableInfoToolStripMenuItem.Text = "Table Info";
            this.tableInfoToolStripMenuItem.Click += new System.EventHandler(this.tableInfoToolStripMenuItem_Click);
            // 
            // rebuildTableToolStripMenuItem
            // 
            this.rebuildTableToolStripMenuItem.Name = "rebuildTableToolStripMenuItem";
            this.rebuildTableToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.rebuildTableToolStripMenuItem.Text = "Rebuild Table";
            this.rebuildTableToolStripMenuItem.Click += new System.EventHandler(this.rebuildTableToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Enabled = false;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // troubleshooterToolStripMenuItem
            // 
            this.troubleshooterToolStripMenuItem.Name = "troubleshooterToolStripMenuItem";
            this.troubleshooterToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.troubleshooterToolStripMenuItem.Text = "Troubleshooter";
            this.troubleshooterToolStripMenuItem.Click += new System.EventHandler(this.troubleshooterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(144, 6);
            // 
            // dropTableToolStripMenuItem
            // 
            this.dropTableToolStripMenuItem.Name = "dropTableToolStripMenuItem";
            this.dropTableToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.dropTableToolStripMenuItem.Text = "Drop Table";
            this.dropTableToolStripMenuItem.Click += new System.EventHandler(this.dropTableToolStripMenuItem_Click);
            // 
            // truncateTableToolStripMenuItem
            // 
            this.truncateTableToolStripMenuItem.Name = "truncateTableToolStripMenuItem";
            this.truncateTableToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.truncateTableToolStripMenuItem.Text = "Truncate Table";
            this.truncateTableToolStripMenuItem.Click += new System.EventHandler(this.truncateTableToolStripMenuItem_Click);
            // 
            // imageListTreeView
            // 
            this.imageListTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeView.ImageStream")));
            this.imageListTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeView.Images.SetKeyName(0, "Database");
            this.imageListTreeView.Images.SetKeyName(1, "Table");
            this.imageListTreeView.Images.SetKeyName(2, "Folder");
            this.imageListTreeView.Images.SetKeyName(3, "DB.PNG");
            this.imageListTreeView.Images.SetKeyName(4, "QDatabase.png");
            this.imageListTreeView.Images.SetKeyName(5, "QTable.png");
            // 
            // openFileDialogSql
            // 
            this.openFileDialogSql.Filter = "SQL|*.sql";
            this.openFileDialogSql.RestoreDirectory = true;
            // 
            // contextMenuStripServer
            // 
            this.contextMenuStripServer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDatabaseToolStripMenuItem,
            this.refreshToolStripMenuItem1,
            this.troubleshooterToolStripMenuItem1});
            this.contextMenuStripServer.Name = "contextMenuStripServer";
            this.contextMenuStripServer.Size = new System.Drawing.Size(154, 70);
            // 
            // createDatabaseToolStripMenuItem
            // 
            this.createDatabaseToolStripMenuItem.Name = "createDatabaseToolStripMenuItem";
            this.createDatabaseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.createDatabaseToolStripMenuItem.Text = "CreateDatabase";
            this.createDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createDatabaseToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // troubleshooterToolStripMenuItem1
            // 
            this.troubleshooterToolStripMenuItem1.Name = "troubleshooterToolStripMenuItem1";
            this.troubleshooterToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.troubleshooterToolStripMenuItem1.Text = "Troubleshooter";
            this.troubleshooterToolStripMenuItem1.Click += new System.EventHandler(this.troubleshooterToolStripMenuItem_Click);
            // 
            // contextMenuStripDatabase
            // 
            this.contextMenuStripDatabase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseInfoToolStripMenuItem,
            this.dropDatabaseToolStripMenuItem,
            this.createTableToolStripMenuItem,
            this.refreshToolStripMenuItem2,
            this.toolStripMenuItem4,
            this.troubleshooterToolStripMenuItem2});
            this.contextMenuStripDatabase.Name = "contextMenuStripDatabase";
            this.contextMenuStripDatabase.Size = new System.Drawing.Size(153, 142);
            // 
            // databaseInfoToolStripMenuItem
            // 
            this.databaseInfoToolStripMenuItem.Name = "databaseInfoToolStripMenuItem";
            this.databaseInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.databaseInfoToolStripMenuItem.Text = "Database Info";
            this.databaseInfoToolStripMenuItem.Click += new System.EventHandler(this.databaseInfoToolStripMenuItem_Click);
            // 
            // dropDatabaseToolStripMenuItem
            // 
            this.dropDatabaseToolStripMenuItem.Name = "dropDatabaseToolStripMenuItem";
            this.dropDatabaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dropDatabaseToolStripMenuItem.Text = "Drop Database";
            this.dropDatabaseToolStripMenuItem.Click += new System.EventHandler(this.dropDatabaseToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem2
            // 
            this.refreshToolStripMenuItem2.Name = "refreshToolStripMenuItem2";
            this.refreshToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem2.Text = "Refresh";
            this.refreshToolStripMenuItem2.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // troubleshooterToolStripMenuItem2
            // 
            this.troubleshooterToolStripMenuItem2.Name = "troubleshooterToolStripMenuItem2";
            this.troubleshooterToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.troubleshooterToolStripMenuItem2.Text = "Troubleshooter";
            this.troubleshooterToolStripMenuItem2.Click += new System.EventHandler(this.troubleshooterToolStripMenuItem_Click);
            // 
            // toolStripButtonExcute
            // 
            this.toolStripButtonExcute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExcute.Image = global::QueryAnalyzer.Properties.Resources.Excute;
            this.toolStripButtonExcute.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExcute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExcute.Name = "toolStripButtonExcute";
            this.toolStripButtonExcute.Size = new System.Drawing.Size(70, 22);
            this.toolStripButtonExcute.Text = "Excute";
            this.toolStripButtonExcute.Click += new System.EventHandler(this.toolStripButtonExcute_Click);
            // 
            // createTableToolStripMenuItem
            // 
            this.createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            this.createTableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createTableToolStripMenuItem.Text = "Create Table";
            this.createTableToolStripMenuItem.Click += new System.EventHandler(this.createTableToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Query Analyzer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageResults.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            this.tabPageMessages.PerformLayout();
            this.contextMenuStripTable.ResumeLayout(false);
            this.contextMenuStripServer.ResumeLayout(false);
            this.contextMenuStripDatabase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView treeViewData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.TextBox textBoxSql;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcute;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelReport;
        private System.Windows.Forms.ImageList imageListTreeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTable;
        private System.Windows.Forms.ToolStripMenuItem tableInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogSql;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem batchInsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxDatabases;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem rebuildTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troubleshooterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripServer;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem troubleshooterToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDatabase;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem troubleshooterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem truncateTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dropTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    }
}

