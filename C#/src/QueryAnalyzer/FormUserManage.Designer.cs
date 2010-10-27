﻿namespace QueryAnalyzer
{
    partial class FormUserManage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.tabPageSystem = new System.Windows.Forms.TabPage();
            this.groupBoxSystemRight = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControlRight = new System.Windows.Forms.TabControl();
            this.tabPageDatabase = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDatabase = new System.Windows.Forms.ListBox();
            this.groupBoxDatabaseRight = new System.Windows.Forms.GroupBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabPageSystem.SuspendLayout();
            this.groupBoxSystemRight.SuspendLayout();
            this.tabControlRight.SuspendLayout();
            this.tabPageDatabase.SuspendLayout();
            this.groupBoxDatabaseRight.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(0, 0);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(190, 537);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // tabPageSystem
            // 
            this.tabPageSystem.Controls.Add(this.groupBoxSystemRight);
            this.tabPageSystem.Location = new System.Drawing.Point(4, 22);
            this.tabPageSystem.Name = "tabPageSystem";
            this.tabPageSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSystem.Size = new System.Drawing.Size(591, 482);
            this.tabPageSystem.TabIndex = 0;
            this.tabPageSystem.Text = "Global Right";
            this.tabPageSystem.UseVisualStyleBackColor = true;
            // 
            // groupBoxSystemRight
            // 
            this.groupBoxSystemRight.Controls.Add(this.checkBox9);
            this.groupBoxSystemRight.Controls.Add(this.checkBox5);
            this.groupBoxSystemRight.Controls.Add(this.checkBox6);
            this.groupBoxSystemRight.Controls.Add(this.checkBox7);
            this.groupBoxSystemRight.Controls.Add(this.checkBox8);
            this.groupBoxSystemRight.Controls.Add(this.checkBox4);
            this.groupBoxSystemRight.Controls.Add(this.checkBox3);
            this.groupBoxSystemRight.Controls.Add(this.checkBox2);
            this.groupBoxSystemRight.Controls.Add(this.checkBox1);
            this.groupBoxSystemRight.Location = new System.Drawing.Point(117, 43);
            this.groupBoxSystemRight.Name = "groupBoxSystemRight";
            this.groupBoxSystemRight.Size = new System.Drawing.Size(351, 320);
            this.groupBoxSystemRight.TabIndex = 0;
            this.groupBoxSystemRight.TabStop = false;
            this.groupBoxSystemRight.Text = "Right";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(32, 189);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(57, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Tag = "0x00000200";
            this.checkBox9.Text = "Delete";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(159, 152);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(61, 17);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Tag = "0x00000100";
            this.checkBox5.Text = "Update";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(32, 152);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(56, 17);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Tag = "0x00000080";
            this.checkBox6.Text = "Select";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(159, 112);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(84, 17);
            this.checkBox7.TabIndex = 5;
            this.checkBox7.Tag = "0x00000020";
            this.checkBox7.Text = "CreateTable";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(32, 112);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(66, 17);
            this.checkBox8.TabIndex = 4;
            this.checkBox8.Tag = "0x00000010";
            this.checkBox8.Text = "Optimize";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(159, 74);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(133, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Tag = "0x00000008";
            this.checkBox4.Text = "ExcuteStoreProcedure";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(32, 74);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Tag = "0x00000004";
            this.checkBox3.Text = "WriteDatabase";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(159, 34);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Tag = "0x00000002";
            this.checkBox2.Text = "ManageDB";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "0x00000001";
            this.checkBox1.Text = "ManageUser";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabControlRight
            // 
            this.tabControlRight.Controls.Add(this.tabPageSystem);
            this.tabControlRight.Controls.Add(this.tabPageDatabase);
            this.tabControlRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlRight.Location = new System.Drawing.Point(0, 0);
            this.tabControlRight.Name = "tabControlRight";
            this.tabControlRight.SelectedIndex = 0;
            this.tabControlRight.Size = new System.Drawing.Size(599, 508);
            this.tabControlRight.TabIndex = 0;
            this.tabControlRight.SelectedIndexChanged += new System.EventHandler(this.tabControlRight_SelectedIndexChanged);
            // 
            // tabPageDatabase
            // 
            this.tabPageDatabase.Controls.Add(this.buttonDelete);
            this.tabPageDatabase.Controls.Add(this.buttonAdd);
            this.tabPageDatabase.Controls.Add(this.label1);
            this.tabPageDatabase.Controls.Add(this.listBoxDatabase);
            this.tabPageDatabase.Controls.Add(this.groupBoxDatabaseRight);
            this.tabPageDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabPageDatabase.Name = "tabPageDatabase";
            this.tabPageDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatabase.Size = new System.Drawing.Size(591, 482);
            this.tabPageDatabase.TabIndex = 1;
            this.tabPageDatabase.Text = "Database Right";
            this.tabPageDatabase.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(222, 389);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(189, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete Database Right";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(222, 360);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(189, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add Database Right";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Databases";
            // 
            // listBoxDatabase
            // 
            this.listBoxDatabase.FormattingEnabled = true;
            this.listBoxDatabase.Location = new System.Drawing.Point(6, 27);
            this.listBoxDatabase.Name = "listBoxDatabase";
            this.listBoxDatabase.Size = new System.Drawing.Size(196, 420);
            this.listBoxDatabase.TabIndex = 2;
            this.listBoxDatabase.SelectedIndexChanged += new System.EventHandler(this.listBoxDatabase_SelectedIndexChanged);
            // 
            // groupBoxDatabaseRight
            // 
            this.groupBoxDatabaseRight.Controls.Add(this.checkBox10);
            this.groupBoxDatabaseRight.Controls.Add(this.checkBox11);
            this.groupBoxDatabaseRight.Controls.Add(this.checkBox12);
            this.groupBoxDatabaseRight.Controls.Add(this.checkBox13);
            this.groupBoxDatabaseRight.Controls.Add(this.checkBox14);
            this.groupBoxDatabaseRight.Controls.Add(this.checkBox15);
            this.groupBoxDatabaseRight.Controls.Add(this.checkBox16);
            this.groupBoxDatabaseRight.Controls.Add(this.checkBox17);
            this.groupBoxDatabaseRight.Controls.Add(this.checkBox18);
            this.groupBoxDatabaseRight.Location = new System.Drawing.Point(222, 20);
            this.groupBoxDatabaseRight.Name = "groupBoxDatabaseRight";
            this.groupBoxDatabaseRight.Size = new System.Drawing.Size(351, 320);
            this.groupBoxDatabaseRight.TabIndex = 1;
            this.groupBoxDatabaseRight.TabStop = false;
            this.groupBoxDatabaseRight.Text = "Right";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(32, 189);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(57, 17);
            this.checkBox10.TabIndex = 8;
            this.checkBox10.Tag = "0x00000200";
            this.checkBox10.Text = "Delete";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBoxDatabase_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(159, 152);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(61, 17);
            this.checkBox11.TabIndex = 7;
            this.checkBox11.Tag = "0x00000100";
            this.checkBox11.Text = "Update";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBoxDatabase_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(32, 152);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(56, 17);
            this.checkBox12.TabIndex = 6;
            this.checkBox12.Tag = "0x00000080";
            this.checkBox12.Text = "Select";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBoxDatabase_CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(159, 112);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(84, 17);
            this.checkBox13.TabIndex = 5;
            this.checkBox13.Tag = "0x00000020";
            this.checkBox13.Text = "CreateTable";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBoxDatabase_CheckedChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(32, 112);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(66, 17);
            this.checkBox14.TabIndex = 4;
            this.checkBox14.Tag = "0x00000010";
            this.checkBox14.Text = "Optimize";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBoxDatabase_CheckedChanged);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(159, 74);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(133, 17);
            this.checkBox15.TabIndex = 3;
            this.checkBox15.Tag = "0x00000008";
            this.checkBox15.Text = "ExcuteStoreProcedure";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBoxDatabase_CheckedChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(32, 74);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(97, 17);
            this.checkBox16.TabIndex = 2;
            this.checkBox16.Tag = "0x00000004";
            this.checkBox16.Text = "WriteDatabase";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBoxDatabase_CheckedChanged);
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(159, 34);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(80, 17);
            this.checkBox17.TabIndex = 1;
            this.checkBox17.Tag = "0x00000002";
            this.checkBox17.Text = "ManageDB";
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.checkBoxDatabase_CheckedChanged);
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(32, 34);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(87, 17);
            this.checkBox18.TabIndex = 0;
            this.checkBox18.Tag = "0x00000001";
            this.checkBox18.Text = "ManageUser";
            this.checkBox18.UseVisualStyleBackColor = true;
            this.checkBox18.CheckedChanged += new System.EventHandler(this.checkBoxDatabase_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.tabControlRight);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(193, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 542);
            this.panel2.TabIndex = 5;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(95, 514);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(3, 514);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(190, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 542);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 542);
            this.panel1.TabIndex = 3;
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete user";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // FormUserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUserManage";
            this.Text = "User Manage";
            this.Load += new System.EventHandler(this.FormUserManage_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUserManage_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageSystem.ResumeLayout(false);
            this.groupBoxSystemRight.ResumeLayout(false);
            this.groupBoxSystemRight.PerformLayout();
            this.tabControlRight.ResumeLayout(false);
            this.tabPageDatabase.ResumeLayout(false);
            this.tabPageDatabase.PerformLayout();
            this.groupBoxDatabaseRight.ResumeLayout(false);
            this.groupBoxDatabaseRight.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TabPage tabPageSystem;
        private System.Windows.Forms.TabControl tabControlRight;
        private System.Windows.Forms.TabPage tabPageDatabase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxSystemRight;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.GroupBox groupBoxDatabaseRight;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.ListBox listBoxDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;

    }
}