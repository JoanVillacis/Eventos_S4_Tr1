namespace Eventos_S4_Tr1
{
    partial class frm_Eventos
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lbl_evento = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_Timer = new Button();
            btn_Salir = new Button();
            panel2 = new Panel();
            btn_Parar_Timer = new Button();
            lbl_Resul_Tiemp = new Label();
            label1 = new Label();
            pnl_Evento_DD = new Panel();
            label6 = new Label();
            txt_Evento = new TextBox();
            label2 = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_evento);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 41);
            panel1.TabIndex = 2;
            // 
            // lbl_evento
            // 
            lbl_evento.AutoSize = true;
            lbl_evento.ForeColor = Color.FromArgb(0, 119, 182);
            lbl_evento.Location = new Point(61, 3);
            lbl_evento.Name = "lbl_evento";
            lbl_evento.Size = new Size(546, 32);
            lbl_evento.TabIndex = 0;
            lbl_evento.Text = "LABEL DE EVENTO(CLICK PARA CAMBIAR ESTADO)";
            lbl_evento.Click += lbl_evento_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btn_Timer, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_Salir, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 445);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(653, 68);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_Timer
            // 
            btn_Timer.BackColor = Color.FromArgb(0, 119, 182);
            btn_Timer.Dock = DockStyle.Fill;
            btn_Timer.FlatAppearance.BorderColor = Color.FromArgb(3, 4, 94);
            btn_Timer.FlatAppearance.MouseOverBackColor = Color.FromArgb(144, 224, 239);
            btn_Timer.FlatStyle = FlatStyle.Flat;
            btn_Timer.ForeColor = Color.White;
            btn_Timer.Location = new Point(3, 3);
            btn_Timer.Name = "btn_Timer";
            btn_Timer.Size = new Size(320, 62);
            btn_Timer.TabIndex = 1;
            btn_Timer.Text = "Timer";
            btn_Timer.UseVisualStyleBackColor = false;
            btn_Timer.Click += btn_Timer_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.FromArgb(0, 180, 216);
            btn_Salir.Dock = DockStyle.Fill;
            btn_Salir.FlatAppearance.BorderColor = Color.FromArgb(0, 119, 182);
            btn_Salir.FlatAppearance.MouseOverBackColor = Color.FromArgb(144, 224, 239);
            btn_Salir.FlatStyle = FlatStyle.Flat;
            btn_Salir.ForeColor = Color.White;
            btn_Salir.Location = new Point(329, 3);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(321, 62);
            btn_Salir.TabIndex = 0;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Parar_Timer);
            panel2.Controls.Add(lbl_Resul_Tiemp);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pnl_Evento_DD);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_Evento);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 41);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 404);
            panel2.TabIndex = 5;
            // 
            // btn_Parar_Timer
            // 
            btn_Parar_Timer.BackColor = Color.FromArgb(0, 180, 216);
            btn_Parar_Timer.FlatAppearance.BorderColor = Color.FromArgb(0, 119, 182);
            btn_Parar_Timer.FlatAppearance.MouseOverBackColor = Color.FromArgb(144, 224, 239);
            btn_Parar_Timer.FlatStyle = FlatStyle.Flat;
            btn_Parar_Timer.ForeColor = Color.White;
            btn_Parar_Timer.Location = new Point(473, 346);
            btn_Parar_Timer.Name = "btn_Parar_Timer";
            btn_Parar_Timer.Size = new Size(167, 43);
            btn_Parar_Timer.TabIndex = 12;
            btn_Parar_Timer.Text = "Parar Timer";
            btn_Parar_Timer.UseVisualStyleBackColor = false;
            btn_Parar_Timer.Click += btn_Parar_Timer_Click;
            // 
            // lbl_Resul_Tiemp
            // 
            lbl_Resul_Tiemp.AutoSize = true;
            lbl_Resul_Tiemp.Font = new Font("Segoe UI", 30F);
            lbl_Resul_Tiemp.Location = new Point(159, 334);
            lbl_Resul_Tiemp.Name = "lbl_Resul_Tiemp";
            lbl_Resul_Tiemp.Size = new Size(56, 67);
            lbl_Resul_Tiemp.TabIndex = 11;
            lbl_Resul_Tiemp.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(3, 4, 94);
            label1.Location = new Point(12, 346);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 10;
            label1.Text = "Tiempo:";
            // 
            // pnl_Evento_DD
            // 
            pnl_Evento_DD.BackColor = Color.White;
            pnl_Evento_DD.Location = new Point(285, 66);
            pnl_Evento_DD.Name = "pnl_Evento_DD";
            pnl_Evento_DD.Size = new Size(358, 263);
            pnl_Evento_DD.TabIndex = 9;
            pnl_Evento_DD.DragDrop += pnl_Evento_DD_DragDrop;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(3, 4, 94);
            label6.Location = new Point(12, 66);
            label6.Name = "label6";
            label6.Size = new Size(267, 32);
            label6.TabIndex = 8;
            label6.Text = "DragDrog de imágenes:";
            // 
            // txt_Evento
            // 
            txt_Evento.ForeColor = Color.FromArgb(3, 4, 94);
            txt_Evento.Location = new Point(232, 13);
            txt_Evento.Name = "txt_Evento";
            txt_Evento.Size = new Size(395, 39);
            txt_Evento.TabIndex = 1;
            txt_Evento.KeyPress += txt_Evento_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(3, 4, 94);
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(222, 32);
            label2.TabIndex = 0;
            label2.Text = "Text Box de Evento:";
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // frm_Eventos
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 240, 248);
            ClientSize = new Size(653, 513);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_Eventos";
            Text = "Panel de Eventos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_evento;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_Timer;
        private Button btn_Salir;
        private Panel panel2;
        private Label label6;
        private TextBox txt_Evento;
        private Label label2;
        private Panel pnl_Evento_DD;
        private System.Windows.Forms.Timer Timer;
        private Label lbl_Resul_Tiemp;
        private Label label1;
        private Button btn_Parar_Timer;
    }
}
