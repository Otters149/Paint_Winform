﻿namespace _MyPaint
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmrSize = new System.Windows.Forms.NumericUpDown();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbFill = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbShape = new System.Windows.Forms.GroupBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnBezier = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnUnGroup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGroup = new System.Windows.Forms.Button();
            this.cbbDashStyle = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlToolChild = new System.Windows.Forms.Panel();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSize)).BeginInit();
            this.grbShape.SuspendLayout();
            this.pnlToolChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaint
            // 
            this.pnlPaint.BackColor = System.Drawing.Color.White;
            this.pnlPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaint.Location = new System.Drawing.Point(0, 92);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(984, 419);
            this.pnlPaint.TabIndex = 1;
            this.pnlPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaint_Paint);
            this.pnlPaint.DoubleClick += new System.EventHandler(this.pnlPaint_DoubleClick);
            this.pnlPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseDown);
            this.pnlPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseMove);
            this.pnlPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseUp);
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.Transparent;
            this.pnlTool.BackgroundImage = global::_MyPaint.Properties.Resources.Transfile;
            this.pnlTool.Controls.Add(this.pnlToolChild);
            this.pnlTool.Controls.Add(this.label8);
            this.pnlTool.Controls.Add(this.nmrSize);
            this.pnlTool.Controls.Add(this.label4);
            this.pnlTool.Controls.Add(this.ckbFill);
            this.pnlTool.Controls.Add(this.grbShape);
            this.pnlTool.Controls.Add(this.label3);
            this.pnlTool.Controls.Add(this.label2);
            this.pnlTool.Controls.Add(this.label1);
            this.pnlTool.Controls.Add(this.cbbDashStyle);
            this.pnlTool.Controls.Add(this.btnColor);
            this.pnlTool.Controls.Add(this.btnSelect);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(984, 92);
            this.pnlTool.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Fill";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "UnGrp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Delete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Group";
            // 
            // nmrSize
            // 
            this.nmrSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrSize.Location = new System.Drawing.Point(663, 38);
            this.nmrSize.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nmrSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSize.Name = "nmrSize";
            this.nmrSize.ReadOnly = true;
            this.nmrSize.Size = new System.Drawing.Size(70, 23);
            this.nmrSize.TabIndex = 19;
            this.nmrSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSize.ValueChanged += new System.EventHandler(this.nmrSize_ValueChanged);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZoomOut.BackgroundImage = global::_MyPaint.Properties.Resources.icons8_zoom_out_50;
            this.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZoomOut.Location = new System.Drawing.Point(190, 52);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(45, 33);
            this.btnZoomOut.TabIndex = 18;
            this.btnZoomOut.Tag = "-";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZoomIn.BackgroundImage = global::_MyPaint.Properties.Resources.icons8_zoom_in_50_2;
            this.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZoomIn.Location = new System.Drawing.Point(190, 12);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(45, 33);
            this.btnZoomIn.TabIndex = 17;
            this.btnZoomIn.Tag = "+";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select";
            // 
            // ckbFill
            // 
            this.ckbFill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ckbFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ckbFill.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ckbFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFill.Image = global::_MyPaint.Properties.Resources.icons8_fill_color_50;
            this.ckbFill.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ckbFill.Location = new System.Drawing.Point(349, 23);
            this.ckbFill.Name = "ckbFill";
            this.ckbFill.Size = new System.Drawing.Size(43, 43);
            this.ckbFill.TabIndex = 15;
            this.ckbFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbFill.UseVisualStyleBackColor = false;
            this.ckbFill.CheckedChanged += new System.EventHandler(this.ckbFill_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.BackgroundImage = global::_MyPaint.Properties.Resources.icons8_delete_50;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(128, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 54);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grbShape
            // 
            this.grbShape.Controls.Add(this.btnLine);
            this.grbShape.Controls.Add(this.btnRectangle);
            this.grbShape.Controls.Add(this.btnEllipse);
            this.grbShape.Controls.Add(this.btnBezier);
            this.grbShape.Controls.Add(this.btnPolygon);
            this.grbShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbShape.Location = new System.Drawing.Point(3, 3);
            this.grbShape.Name = "grbShape";
            this.grbShape.Size = new System.Drawing.Size(332, 83);
            this.grbShape.TabIndex = 13;
            this.grbShape.TabStop = false;
            this.grbShape.Text = "Shape";
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLine.BackgroundImage = global::_MyPaint.Properties.Resources.icons8_line_50;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLine.Location = new System.Drawing.Point(4, 22);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(54, 54);
            this.btnLine.TabIndex = 1;
            this.btnLine.Tag = "0";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnShapes_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRectangle.BackgroundImage = global::_MyPaint.Properties.Resources.icons8_rectangle_50_3;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRectangle.Location = new System.Drawing.Point(70, 22);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(54, 54);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Tag = "1";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnShapes_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEllipse.BackgroundImage = global::_MyPaint.Properties.Resources.icons8_round_64;
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEllipse.Location = new System.Drawing.Point(136, 22);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(54, 54);
            this.btnEllipse.TabIndex = 3;
            this.btnEllipse.Tag = "2";
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnShapes_Click);
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBezier.BackgroundImage = global::_MyPaint.Properties.Resources.icons8_dotted_line_50;
            this.btnBezier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBezier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBezier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBezier.Location = new System.Drawing.Point(203, 22);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(54, 54);
            this.btnBezier.TabIndex = 4;
            this.btnBezier.Tag = "3";
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.btnShapes_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPolygon.BackgroundImage = global::_MyPaint.Properties.Resources.icons8_polygon_50_2;
            this.btnPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPolygon.Location = new System.Drawing.Point(270, 22);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(54, 54);
            this.btnPolygon.TabIndex = 6;
            this.btnPolygon.Tag = "4";
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnShapes_Click);
            // 
            // btnUnGroup
            // 
            this.btnUnGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnGroup.BackgroundImage = global::_MyPaint.Properties.Resources.icons8_ungroup_objects_50;
            this.btnUnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnGroup.Location = new System.Drawing.Point(68, 12);
            this.btnUnGroup.Name = "btnUnGroup";
            this.btnUnGroup.Size = new System.Drawing.Size(54, 54);
            this.btnUnGroup.TabIndex = 11;
            this.btnUnGroup.UseVisualStyleBackColor = false;
            this.btnUnGroup.Click += new System.EventHandler(this.btnUnGroup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "DashStyle";
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGroup.BackgroundImage = global::_MyPaint.Properties.Resources.icons8_group_objects_50;
            this.btnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGroup.Location = new System.Drawing.Point(8, 12);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(54, 54);
            this.btnGroup.TabIndex = 10;
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // cbbDashStyle
            // 
            this.cbbDashStyle.BackColor = System.Drawing.Color.White;
            this.cbbDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDashStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDashStyle.FormattingEnabled = true;
            this.cbbDashStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash Dot",
            "Dash Dot Dot"});
            this.cbbDashStyle.Location = new System.Drawing.Point(534, 38);
            this.cbbDashStyle.Name = "cbbDashStyle";
            this.cbbDashStyle.Size = new System.Drawing.Size(115, 24);
            this.cbbDashStyle.TabIndex = 8;
            this.cbbDashStyle.SelectedIndexChanged += new System.EventHandler(this.cbbDashStyle_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor.Location = new System.Drawing.Point(466, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(54, 54);
            this.btnColor.TabIndex = 7;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelect.BackgroundImage = global::_MyPaint.Properties.Resources.icons8_cursor_50_3;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Location = new System.Drawing.Point(403, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(54, 54);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            this.btnSelect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSelect_KeyDown);
            this.btnSelect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSelect_KeyUp);
            // 
            // pnlToolChild
            // 
            this.pnlToolChild.Controls.Add(this.btnGroup);
            this.pnlToolChild.Controls.Add(this.label7);
            this.pnlToolChild.Controls.Add(this.btnUnGroup);
            this.pnlToolChild.Controls.Add(this.label6);
            this.pnlToolChild.Controls.Add(this.btnDelete);
            this.pnlToolChild.Controls.Add(this.label5);
            this.pnlToolChild.Controls.Add(this.btnZoomIn);
            this.pnlToolChild.Controls.Add(this.btnZoomOut);
            this.pnlToolChild.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlToolChild.Location = new System.Drawing.Point(742, 0);
            this.pnlToolChild.Name = "pnlToolChild";
            this.pnlToolChild.Size = new System.Drawing.Size(242, 92);
            this.pnlToolChild.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.pnlPaint);
            this.Controls.Add(this.pnlTool);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My_Paint";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSize)).EndInit();
            this.grbShape.ResumeLayout(false);
            this.pnlToolChild.ResumeLayout(false);
            this.pnlToolChild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbFill;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grbShape;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnUnGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.ComboBox cbbDashStyle;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.NumericUpDown nmrSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlToolChild;
    }
}

