namespace Dinamica
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
            this.pnMemoria = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnRight = new System.Windows.Forms.Panel();
            this.dtgLibres = new System.Windows.Forms.DataGridView();
            this.dtgTareas = new System.Windows.Forms.DataGridView();
            this.jPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSB = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLiberarTarea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTareas = new System.Windows.Forms.ListBox();
            this.pnTareas = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTarea = new System.Windows.Forms.TextBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnSO = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSO = new System.Windows.Forms.TextBox();
            this.btnAgregarSO = new System.Windows.Forms.Button();
            this.pnSize = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSize = new System.Windows.Forms.Button();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.cbUnidad = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AreaLibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTareas)).BeginInit();
            this.jPanel.SuspendLayout();
            this.pnTareas.SuspendLayout();
            this.pnSO.SuspendLayout();
            this.pnSize.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMemoria
            // 
            this.pnMemoria.BackColor = System.Drawing.Color.White;
            this.pnMemoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMemoria.Location = new System.Drawing.Point(0, 0);
            this.pnMemoria.Margin = new System.Windows.Forms.Padding(2);
            this.pnMemoria.Name = "pnMemoria";
            this.pnMemoria.Size = new System.Drawing.Size(338, 542);
            this.pnMemoria.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // pnRight
            // 
            this.pnRight.AutoScroll = true;
            this.pnRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnRight.Controls.Add(this.dtgLibres);
            this.pnRight.Controls.Add(this.dtgTareas);
            this.pnRight.Controls.Add(this.jPanel);
            this.pnRight.Controls.Add(this.pnTareas);
            this.pnRight.Controls.Add(this.label3);
            this.pnRight.Controls.Add(this.pnSO);
            this.pnRight.Controls.Add(this.pnSize);
            this.pnRight.Controls.Add(this.cbUnidad);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(0, 0);
            this.pnRight.Margin = new System.Windows.Forms.Padding(2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(1005, 749);
            this.pnRight.TabIndex = 1;
            // 
            // dtgLibres
            // 
            this.dtgLibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AreaLibre,
            this.Posicion,
            this.Tamaño});
            this.dtgLibres.Location = new System.Drawing.Point(360, 337);
            this.dtgLibres.Name = "dtgLibres";
            this.dtgLibres.Size = new System.Drawing.Size(338, 183);
            this.dtgLibres.TabIndex = 21;
            // 
            // dtgTareas
            // 
            this.dtgTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dtgTareas.Location = new System.Drawing.Point(13, 337);
            this.dtgTareas.Name = "dtgTareas";
            this.dtgTareas.Size = new System.Drawing.Size(338, 183);
            this.dtgTareas.TabIndex = 20;
            // 
            // jPanel
            // 
            this.jPanel.Controls.Add(this.label7);
            this.jPanel.Controls.Add(this.lbSB);
            this.jPanel.Controls.Add(this.label6);
            this.jPanel.Controls.Add(this.btnLiberarTarea);
            this.jPanel.Controls.Add(this.button1);
            this.jPanel.Controls.Add(this.lbTareas);
            this.jPanel.Location = new System.Drawing.Point(319, 3);
            this.jPanel.Name = "jPanel";
            this.jPanel.Size = new System.Drawing.Size(534, 236);
            this.jPanel.TabIndex = 19;
            this.jPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tareas";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSB
            // 
            this.lbSB.FormattingEnabled = true;
            this.lbSB.Location = new System.Drawing.Point(190, 40);
            this.lbSB.Margin = new System.Windows.Forms.Padding(2);
            this.lbSB.Name = "lbSB";
            this.lbSB.Size = new System.Drawing.Size(150, 121);
            this.lbSB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tareas en stand by";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLiberarTarea
            // 
            this.btnLiberarTarea.Location = new System.Drawing.Point(16, 173);
            this.btnLiberarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnLiberarTarea.Name = "btnLiberarTarea";
            this.btnLiberarTarea.Size = new System.Drawing.Size(149, 27);
            this.btnLiberarTarea.TabIndex = 16;
            this.btnLiberarTarea.Text = "Liberar";
            this.btnLiberarTarea.UseVisualStyleBackColor = true;
            this.btnLiberarTarea.Click += new System.EventHandler(this.btnLiberarTarea_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Liberar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTareas
            // 
            this.lbTareas.FormattingEnabled = true;
            this.lbTareas.Location = new System.Drawing.Point(16, 41);
            this.lbTareas.Margin = new System.Windows.Forms.Padding(2);
            this.lbTareas.Name = "lbTareas";
            this.lbTareas.Size = new System.Drawing.Size(150, 121);
            this.lbTareas.TabIndex = 14;
            // 
            // pnTareas
            // 
            this.pnTareas.Controls.Add(this.label10);
            this.pnTareas.Controls.Add(this.tbTitle);
            this.pnTareas.Controls.Add(this.label5);
            this.pnTareas.Controls.Add(this.tbTarea);
            this.pnTareas.Controls.Add(this.btnAgregarTarea);
            this.pnTareas.Location = new System.Drawing.Point(11, 38);
            this.pnTareas.Margin = new System.Windows.Forms.Padding(2);
            this.pnTareas.Name = "pnTareas";
            this.pnTareas.Size = new System.Drawing.Size(208, 164);
            this.pnTareas.TabIndex = 10;
            this.pnTareas.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Titulo de la tarea";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(23, 86);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(163, 20);
            this.tbTitle.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tamaño de la tarea";
            // 
            // tbTarea
            // 
            this.tbTarea.Location = new System.Drawing.Point(23, 39);
            this.tbTarea.Margin = new System.Windows.Forms.Padding(2);
            this.tbTarea.Name = "tbTarea";
            this.tbTarea.Size = new System.Drawing.Size(163, 20);
            this.tbTarea.TabIndex = 2;
            this.tbTarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTarea_KeyPress);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Location = new System.Drawing.Point(23, 120);
            this.btnAgregarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(161, 27);
            this.btnAgregarTarea.TabIndex = 4;
            this.btnAgregarTarea.Text = "Agregar";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unidades";
            // 
            // pnSO
            // 
            this.pnSO.Controls.Add(this.label2);
            this.pnSO.Controls.Add(this.tbSO);
            this.pnSO.Controls.Add(this.btnAgregarSO);
            this.pnSO.Location = new System.Drawing.Point(13, 36);
            this.pnSO.Margin = new System.Windows.Forms.Padding(2);
            this.pnSO.Name = "pnSO";
            this.pnSO.Size = new System.Drawing.Size(208, 119);
            this.pnSO.TabIndex = 8;
            this.pnSO.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamaño del sistema operativo";
            // 
            // tbSO
            // 
            this.tbSO.Location = new System.Drawing.Point(23, 39);
            this.tbSO.Margin = new System.Windows.Forms.Padding(2);
            this.tbSO.Name = "tbSO";
            this.tbSO.Size = new System.Drawing.Size(163, 20);
            this.tbSO.TabIndex = 2;
            this.tbSO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSO_KeyPress);
            // 
            // btnAgregarSO
            // 
            this.btnAgregarSO.Location = new System.Drawing.Point(23, 69);
            this.btnAgregarSO.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarSO.Name = "btnAgregarSO";
            this.btnAgregarSO.Size = new System.Drawing.Size(161, 27);
            this.btnAgregarSO.TabIndex = 4;
            this.btnAgregarSO.Text = "Agregar SO";
            this.btnAgregarSO.UseVisualStyleBackColor = true;
            this.btnAgregarSO.Click += new System.EventHandler(this.BtnAgregarSO_Click);
            // 
            // pnSize
            // 
            this.pnSize.Controls.Add(this.label1);
            this.pnSize.Controls.Add(this.btnSize);
            this.pnSize.Controls.Add(this.tbSize);
            this.pnSize.Location = new System.Drawing.Point(15, 36);
            this.pnSize.Margin = new System.Windows.Forms.Padding(2);
            this.pnSize.Name = "pnSize";
            this.pnSize.Size = new System.Drawing.Size(208, 124);
            this.pnSize.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tamaño de la memoria";
            // 
            // btnSize
            // 
            this.btnSize.Location = new System.Drawing.Point(9, 64);
            this.btnSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(161, 27);
            this.btnSize.TabIndex = 6;
            this.btnSize.Text = "Establecer tamaño";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.BtnSize_Click);
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(9, 39);
            this.tbSize.Margin = new System.Windows.Forms.Padding(2);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(163, 20);
            this.tbSize.TabIndex = 0;
            this.tbSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSize_KeyPress);
            // 
            // cbUnidad
            // 
            this.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidad.FormattingEnabled = true;
            this.cbUnidad.Location = new System.Drawing.Point(237, 64);
            this.cbUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(77, 21);
            this.cbUnidad.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblSize);
            this.panel2.Controls.Add(this.lblDisponible);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 542);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 207);
            this.panel2.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(45, 166);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 18);
            this.label19.TabIndex = 25;
            this.label19.Text = "Espacio disponible";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(45, 132);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 18);
            this.label18.TabIndex = 24;
            this.label18.Text = "Tarea";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(45, 96);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 18);
            this.label17.TabIndex = 23;
            this.label17.Text = "S.O.";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(11, 166);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 20);
            this.panel5.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(11, 94);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 20);
            this.panel6.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(11, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 19;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(128, 12);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(16, 18);
            this.lblSize.TabIndex = 22;
            this.lblSize.Text = "0";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.Location = new System.Drawing.Point(97, 55);
            this.lblDisponible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(16, 18);
            this.lblDisponible.TabIndex = 21;
            this.lblDisponible.Text = "0";
            this.lblDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 18);
            this.label16.TabIndex = 20;
            this.label16.Text = "Disponible:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 12);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 18);
            this.label15.TabIndex = 19;
            this.label15.Text = "Memoria total:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(300, 844);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 312);
            this.panel3.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Indefinido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Disponible:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(132, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Indefinido";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Memoria total:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnMemoria);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(667, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(338, 749);
            this.panel4.TabIndex = 2;
            // 
            // AreaLibre
            // 
            this.AreaLibre.HeaderText = "Area Libre";
            this.AreaLibre.Name = "AreaLibre";
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.Name = "Posicion";
            // 
            // Tamaño
            // 
            this.Tamaño.HeaderText = "Tamaño";
            this.Tamaño.Name = "Tamaño";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Posicion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tamaño";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 749);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnRight);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTareas)).EndInit();
            this.jPanel.ResumeLayout(false);
            this.jPanel.PerformLayout();
            this.pnTareas.ResumeLayout(false);
            this.pnTareas.PerformLayout();
            this.pnSO.ResumeLayout(false);
            this.pnSO.PerformLayout();
            this.pnSize.ResumeLayout(false);
            this.pnSize.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMemoria;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSO;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button btnAgregarSO;
        private System.Windows.Forms.ComboBox cbUnidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnSO;
        private System.Windows.Forms.Panel pnSize;
        private System.Windows.Forms.Button btnSize;
         private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnTareas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTarea;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnLiberarTarea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbTareas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbSB;
         private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel jPanel;
        private System.Windows.Forms.DataGridView dtgTareas;
        private System.Windows.Forms.DataGridView dtgLibres;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaLibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

