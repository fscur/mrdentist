namespace MrDentist.DesktopApp
{
    partial class AppointmentsPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._layout = new System.Windows.Forms.TableLayoutPanel();
            this._calendar = new System.Windows.Forms.MonthCalendar();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _layout
            // 
            this._layout.ColumnCount = 2;
            this._layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._layout.Controls.Add(this._calendar, 0, 0);
            this._layout.Controls.Add(this.appointmentsDataGridView, 1, 0);
            this._layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._layout.Location = new System.Drawing.Point(0, 0);
            this._layout.Name = "_layout";
            this._layout.RowCount = 1;
            this._layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._layout.Size = new System.Drawing.Size(753, 391);
            this._layout.TabIndex = 0;
            // 
            // _calendar
            // 
            this._calendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this._calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._calendar.Location = new System.Drawing.Point(9, 9);
            this._calendar.Name = "_calendar";
            this._calendar.TabIndex = 1;
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.AllowUserToAddRows = false;
            this.appointmentsDataGridView.AllowUserToDeleteRows = false;
            this.appointmentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTime,
            this.colPatient,
            this.colDummy});
            this.appointmentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(245, 0);
            this.appointmentsDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.ReadOnly = true;
            this.appointmentsDataGridView.RowHeadersVisible = false;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(508, 391);
            this.appointmentsDataGridView.TabIndex = 2;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Horário";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colPatient
            // 
            this.colPatient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPatient.FillWeight = 104.3299F;
            this.colPatient.HeaderText = "Paciente";
            this.colPatient.Name = "colPatient";
            this.colPatient.ReadOnly = true;
            // 
            // colDummy
            // 
            this.colDummy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDummy.FillWeight = 5.670105F;
            this.colDummy.HeaderText = "";
            this.colDummy.Name = "colDummy";
            this.colDummy.ReadOnly = true;
            // 
            // AppointmentsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._layout);
            this.Name = "AppointmentsPage";
            this.Size = new System.Drawing.Size(753, 391);
            this._layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _layout;
        private System.Windows.Forms.MonthCalendar _calendar;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDummy;
    }
}
