﻿namespace FCFS
{
    partial class fcfsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnSTART = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbAverage = new System.Windows.Forms.GroupBox();
            this.tbATAT = new System.Windows.Forms.TextBox();
            this.tbAWT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_awt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.inBT = new System.Windows.Forms.TextBox();
            this.lb_AT = new System.Windows.Forms.Label();
            this.lb_process = new System.Windows.Forms.Label();
            this.lbBT = new System.Windows.Forms.Label();
            this.inProcess = new System.Windows.Forms.TextBox();
            this.inAT = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.grpQueue = new System.Windows.Forms.GroupBox();
            this.rbMultiple = new System.Windows.Forms.RadioButton();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSolution = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbAverage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.grpQueue.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 177);
            this.panel1.TabIndex = 3;
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(192)))), ((int)(((byte)(197)))));
            this.btnDELETE.FlatAppearance.BorderSize = 0;
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.Color.White;
            this.btnDELETE.Location = new System.Drawing.Point(859, 14);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(115, 32);
            this.btnDELETE.TabIndex = 0;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnSTART
            // 
            this.btnSTART.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(166)))), ((int)(((byte)(200)))));
            this.btnSTART.FlatAppearance.BorderSize = 0;
            this.btnSTART.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTART.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTART.ForeColor = System.Drawing.Color.White;
            this.btnSTART.Location = new System.Drawing.Point(859, 50);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(115, 32);
            this.btnSTART.TabIndex = 1;
            this.btnSTART.Text = "START";
            this.btnSTART.UseVisualStyleBackColor = false;
            this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnRestart);
            this.panel2.Controls.Add(this.btnSolution);
            this.panel2.Controls.Add(this.gbAverage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnSTART);
            this.panel2.Controls.Add(this.btnDELETE);
            this.panel2.Location = new System.Drawing.Point(1, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 309);
            this.panel2.TabIndex = 4;
            // 
            // gbAverage
            // 
            this.gbAverage.Controls.Add(this.tbATAT);
            this.gbAverage.Controls.Add(this.tbAWT);
            this.gbAverage.Controls.Add(this.label3);
            this.gbAverage.Controls.Add(this.lb_awt);
            this.gbAverage.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAverage.Location = new System.Drawing.Point(834, 87);
            this.gbAverage.Name = "gbAverage";
            this.gbAverage.Size = new System.Drawing.Size(173, 140);
            this.gbAverage.TabIndex = 4;
            this.gbAverage.TabStop = false;
            this.gbAverage.Text = "AVERAGE";
            this.gbAverage.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbATAT
            // 
            this.tbATAT.Enabled = false;
            this.tbATAT.Location = new System.Drawing.Point(10, 103);
            this.tbATAT.Name = "tbATAT";
            this.tbATAT.Size = new System.Drawing.Size(136, 26);
            this.tbATAT.TabIndex = 1;
            // 
            // tbAWT
            // 
            this.tbAWT.Enabled = false;
            this.tbAWT.Location = new System.Drawing.Point(10, 48);
            this.tbAWT.Name = "tbAWT";
            this.tbAWT.Size = new System.Drawing.Size(136, 26);
            this.tbAWT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "TURN-AROUND TIME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_awt
            // 
            this.lb_awt.AutoSize = true;
            this.lb_awt.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_awt.Location = new System.Drawing.Point(6, 25);
            this.lb_awt.Name = "lb_awt";
            this.lb_awt.Size = new System.Drawing.Size(106, 20);
            this.lb_awt.TabIndex = 0;
            this.lb_awt.Text = "WATING TIME";
            this.lb_awt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(192)))), ((int)(((byte)(197)))));
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.MaximumSize = new System.Drawing.Size(795, 35);
            this.label2.MinimumSize = new System.Drawing.Size(795, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(795, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "T A B L E";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(166)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProcess,
            this.colAT,
            this.colBT,
            this.colWT,
            this.colTAT,
            this.colComp});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.dataGridView1.Location = new System.Drawing.Point(26, 54);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(795, 230);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(795, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // colProcess
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colProcess.DefaultCellStyle = dataGridViewCellStyle8;
            this.colProcess.HeaderText = "PROCESS";
            this.colProcess.MinimumWidth = 6;
            this.colProcess.Name = "colProcess";
            this.colProcess.ReadOnly = true;
            this.colProcess.Width = 125;
            // 
            // colAT
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colAT.DefaultCellStyle = dataGridViewCellStyle9;
            this.colAT.HeaderText = "ARRIVAL TIME (AT)";
            this.colAT.MinimumWidth = 6;
            this.colAT.Name = "colAT";
            this.colAT.ReadOnly = true;
            this.colAT.Width = 125;
            // 
            // colBT
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colBT.DefaultCellStyle = dataGridViewCellStyle10;
            this.colBT.HeaderText = "BURST TIME (BT)";
            this.colBT.MinimumWidth = 6;
            this.colBT.Name = "colBT";
            this.colBT.ReadOnly = true;
            this.colBT.Width = 125;
            // 
            // colWT
            // 
            this.colWT.HeaderText = "WAITING TIME";
            this.colWT.MinimumWidth = 6;
            this.colWT.Name = "colWT";
            this.colWT.Width = 125;
            // 
            // colTAT
            // 
            this.colTAT.HeaderText = "TURN-AROUND TIME";
            this.colTAT.MinimumWidth = 6;
            this.colTAT.Name = "colTAT";
            this.colTAT.Width = 125;
            // 
            // colComp
            // 
            this.colComp.HeaderText = "COMPLETION TIME";
            this.colComp.MinimumWidth = 6;
            this.colComp.Name = "colComp";
            this.colComp.Width = 125;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MaximumSize = new System.Drawing.Size(1025, 35);
            this.panel4.MinimumSize = new System.Drawing.Size(1025, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1025, 35);
            this.panel4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Come First Serve";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(959, -3);
            this.button3.MaximumSize = new System.Drawing.Size(60, 40);
            this.button3.MinimumSize = new System.Drawing.Size(60, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "X";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inBT
            // 
            this.inBT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.inBT.Location = new System.Drawing.Point(304, 88);
            this.inBT.Name = "inBT";
            this.inBT.Size = new System.Drawing.Size(100, 25);
            this.inBT.TabIndex = 2;
            // 
            // lb_AT
            // 
            this.lb_AT.AutoSize = true;
            this.lb_AT.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AT.Location = new System.Drawing.Point(190, 60);
            this.lb_AT.Name = "lb_AT";
            this.lb_AT.Size = new System.Drawing.Size(108, 20);
            this.lb_AT.TabIndex = 0;
            this.lb_AT.Text = "ARRIVAL TIME";
            // 
            // lb_process
            // 
            this.lb_process.AutoSize = true;
            this.lb_process.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_process.Location = new System.Drawing.Point(190, 29);
            this.lb_process.Name = "lb_process";
            this.lb_process.Size = new System.Drawing.Size(78, 20);
            this.lb_process.TabIndex = 0;
            this.lb_process.Text = "PROCESS";
            // 
            // lbBT
            // 
            this.lbBT.AutoSize = true;
            this.lbBT.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBT.Location = new System.Drawing.Point(190, 91);
            this.lbBT.Name = "lbBT";
            this.lbBT.Size = new System.Drawing.Size(96, 20);
            this.lbBT.TabIndex = 0;
            this.lbBT.Text = "BURST TIME";
            // 
            // inProcess
            // 
            this.inProcess.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.inProcess.Location = new System.Drawing.Point(304, 26);
            this.inProcess.Name = "inProcess";
            this.inProcess.Size = new System.Drawing.Size(100, 25);
            this.inProcess.TabIndex = 0;
            // 
            // inAT
            // 
            this.inAT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.inAT.Location = new System.Drawing.Point(304, 57);
            this.inAT.Name = "inAT";
            this.inAT.Size = new System.Drawing.Size(100, 25);
            this.inAT.TabIndex = 1;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(192)))), ((int)(((byte)(197)))));
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Location = new System.Drawing.Point(426, 29);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(115, 31);
            this.btnADD.TabIndex = 3;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(166)))), ((int)(((byte)(200)))));
            this.btnCLEAR.FlatAppearance.BorderSize = 0;
            this.btnCLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLEAR.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEAR.ForeColor = System.Drawing.Color.White;
            this.btnCLEAR.Location = new System.Drawing.Point(426, 69);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(115, 31);
            this.btnCLEAR.TabIndex = 4;
            this.btnCLEAR.Text = "CLEAR";
            this.btnCLEAR.UseVisualStyleBackColor = false;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.Controls.Add(this.grpQueue);
            this.inputPanel.Controls.Add(this.btnCLEAR);
            this.inputPanel.Controls.Add(this.btnADD);
            this.inputPanel.Controls.Add(this.inAT);
            this.inputPanel.Controls.Add(this.inProcess);
            this.inputPanel.Controls.Add(this.lbBT);
            this.inputPanel.Controls.Add(this.lb_process);
            this.inputPanel.Controls.Add(this.lb_AT);
            this.inputPanel.Controls.Add(this.inBT);
            this.inputPanel.Location = new System.Drawing.Point(1, 30);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(554, 126);
            this.inputPanel.TabIndex = 5;
            // 
            // grpQueue
            // 
            this.grpQueue.Controls.Add(this.rbMultiple);
            this.grpQueue.Controls.Add(this.rbSingle);
            this.grpQueue.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQueue.Location = new System.Drawing.Point(26, 23);
            this.grpQueue.Name = "grpQueue";
            this.grpQueue.Size = new System.Drawing.Size(128, 85);
            this.grpQueue.TabIndex = 5;
            this.grpQueue.TabStop = false;
            this.grpQueue.Text = "QUEUEING";
            // 
            // rbMultiple
            // 
            this.rbMultiple.AutoSize = true;
            this.rbMultiple.Location = new System.Drawing.Point(14, 51);
            this.rbMultiple.Name = "rbMultiple";
            this.rbMultiple.Size = new System.Drawing.Size(104, 24);
            this.rbMultiple.TabIndex = 0;
            this.rbMultiple.TabStop = true;
            this.rbMultiple.Text = " MULTIPLE";
            this.rbMultiple.UseVisualStyleBackColor = true;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(14, 24);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(82, 24);
            this.rbSingle.TabIndex = 0;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "SINGLE";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(548, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 121);
            this.panel3.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(192)))), ((int)(((byte)(197)))));
            this.groupBox1.Location = new System.Drawing.Point(30, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GANTT CHART";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(166)))), ((int)(((byte)(200)))));
            this.groupBox2.Location = new System.Drawing.Point(13, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "READY QUEUE";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSolution
            // 
            this.btnSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(192)))), ((int)(((byte)(197)))));
            this.btnSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolution.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnSolution.ForeColor = System.Drawing.Color.White;
            this.btnSolution.Location = new System.Drawing.Point(859, 237);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(115, 32);
            this.btnSolution.TabIndex = 5;
            this.btnSolution.Text = "SOLUTION";
            this.btnSolution.UseVisualStyleBackColor = false;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(166)))), ((int)(((byte)(200)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(859, 273);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(115, 30);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // fcfsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 640);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1020, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "fcfsForm";
            this.ShowIcon = false;
            this.Text = "First Come First Serve";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbAverage.ResumeLayout(false);
            this.gbAverage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.grpQueue.ResumeLayout(false);
            this.grpQueue.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox inBT;
        private System.Windows.Forms.Label lb_AT;
        private System.Windows.Forms.Label lb_process;
        private System.Windows.Forms.Label lbBT;
        private System.Windows.Forms.TextBox inProcess;
        private System.Windows.Forms.TextBox inAT;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnCLEAR;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.GroupBox grpQueue;
        private System.Windows.Forms.RadioButton rbMultiple;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_awt;
        private System.Windows.Forms.GroupBox gbAverage;
        private System.Windows.Forms.TextBox tbATAT;
        private System.Windows.Forms.TextBox tbAWT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Button btnRestart;
    }
}
