﻿
namespace _33_Layout
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucCMenu = new _33_Layout.ucColorMenu();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ucPanelCenter1 = new _33_Layout.ucPanel();
            this.ucPanelRight = new _33_Layout.ucPanel();
            this.ucPanelCenter2 = new _33_Layout.ucPanel();
            this.ucPanelTop = new _33_Layout.ucPanel();
            this.lboxLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucCMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(617, 406);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // ucCMenu
            // 
            this.ucCMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCMenu.Location = new System.Drawing.Point(0, 0);
            this.ucCMenu.Name = "ucCMenu";
            this.ucCMenu.Size = new System.Drawing.Size(125, 406);
            this.ucCMenu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucPanelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lboxLog, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ucPanelCenter1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucPanelRight, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucPanelCenter2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(490, 236);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ucPanelCenter1
            // 
            this.ucPanelCenter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucPanelCenter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelCenter1.Location = new System.Drawing.Point(0, 0);
            this.ucPanelCenter1.Margin = new System.Windows.Forms.Padding(0);
            this.ucPanelCenter1.Name = "ucPanelCenter1";
            this.ucPanelCenter1.Size = new System.Drawing.Size(245, 160);
            this.ucPanelCenter1.TabIndex = 0;
            // 
            // ucPanelRight
            // 
            this.ucPanelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelRight.Location = new System.Drawing.Point(245, 0);
            this.ucPanelRight.Margin = new System.Windows.Forms.Padding(0);
            this.ucPanelRight.Name = "ucPanelRight";
            this.tableLayoutPanel2.SetRowSpan(this.ucPanelRight, 2);
            this.ucPanelRight.Size = new System.Drawing.Size(245, 236);
            this.ucPanelRight.TabIndex = 1;
            // 
            // ucPanelCenter2
            // 
            this.ucPanelCenter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucPanelCenter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelCenter2.Location = new System.Drawing.Point(0, 160);
            this.ucPanelCenter2.Margin = new System.Windows.Forms.Padding(0);
            this.ucPanelCenter2.Name = "ucPanelCenter2";
            this.ucPanelCenter2.Size = new System.Drawing.Size(245, 76);
            this.ucPanelCenter2.TabIndex = 2;
            // 
            // ucPanelTop
            // 
            this.ucPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelTop.Location = new System.Drawing.Point(0, 0);
            this.ucPanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.ucPanelTop.Name = "ucPanelTop";
            this.ucPanelTop.Size = new System.Drawing.Size(490, 90);
            this.ucPanelTop.TabIndex = 2;
            // 
            // lboxLog
            // 
            this.lboxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 15;
            this.lboxLog.Location = new System.Drawing.Point(0, 326);
            this.lboxLog.Margin = new System.Windows.Forms.Padding(0);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(490, 80);
            this.lboxLog.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 406);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ucPanel ucPanelCenter1;
        private ucPanel ucPanelRight;
        private ucPanel ucPanelCenter2;
        private ucPanel ucPanelTop;
        private ucColorMenu ucCMenu;
        private System.Windows.Forms.ListBox lboxLog;
    }
}

