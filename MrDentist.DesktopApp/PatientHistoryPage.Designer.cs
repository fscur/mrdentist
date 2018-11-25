namespace MrDentist.DesktopApp
{
    partial class PatientHistoryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientHistoryPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patientInfoPanel = new System.Windows.Forms.Panel();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patientContentPanel = new System.Windows.Forms.Panel();
            this.evolutionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExams = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.canvas = new MrDentist.DesktopApp.OdontogramEntryCanvas();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.patientInfoPanel.SuspendLayout();
            this.patientContentPanel.SuspendLayout();
            this.evolutionLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Controls.Add(this.pictureBox1, 0, 0);
            this.layout.Controls.Add(this.patientInfoPanel, 1, 0);
            this.layout.Controls.Add(this.patientContentPanel, 0, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 2;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Size = new System.Drawing.Size(1106, 744);
            this.layout.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(256, 256);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(128, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // patientInfoPanel
            // 
            this.patientInfoPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.patientInfoPanel.Controls.Add(this.phoneLabel);
            this.patientInfoPanel.Controls.Add(this.addressLabel);
            this.patientInfoPanel.Controls.Add(this.buttonEditPatient);
            this.patientInfoPanel.Controls.Add(this.nameLabel);
            this.patientInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientInfoPanel.Location = new System.Drawing.Point(168, 20);
            this.patientInfoPanel.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.patientInfoPanel.Name = "patientInfoPanel";
            this.patientInfoPanel.Padding = new System.Windows.Forms.Padding(5);
            this.patientInfoPanel.Size = new System.Drawing.Size(918, 128);
            this.patientInfoPanel.TabIndex = 1;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(14, 94);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(53, 13);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "[ phone ]";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(14, 77);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(59, 13);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "[ address ]";
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditPatient.FlatAppearance.BorderSize = 0;
            this.buttonEditPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditPatient.Image = global::MrDentist.DesktopApp.Properties.Resources.pencil_1;
            this.buttonEditPatient.Location = new System.Drawing.Point(886, 8);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(24, 24);
            this.buttonEditPatient.TabIndex = 1;
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(8, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(281, 50);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "[ patient name ]";
            // 
            // patientContentPanel
            // 
            this.patientContentPanel.AutoScroll = true;
            this.patientContentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.layout.SetColumnSpan(this.patientContentPanel, 2);
            this.patientContentPanel.Controls.Add(this.evolutionLayout);
            this.patientContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientContentPanel.Location = new System.Drawing.Point(20, 168);
            this.patientContentPanel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.patientContentPanel.Name = "patientContentPanel";
            this.patientContentPanel.Padding = new System.Windows.Forms.Padding(10);
            this.patientContentPanel.Size = new System.Drawing.Size(1066, 556);
            this.patientContentPanel.TabIndex = 2;
            // 
            // evolutionLayout
            // 
            this.evolutionLayout.ColumnCount = 2;
            this.evolutionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.evolutionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.evolutionLayout.Controls.Add(this.label1, 0, 0);
            this.evolutionLayout.Controls.Add(this.appointmentsDataGridView, 0, 1);
            this.evolutionLayout.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.evolutionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evolutionLayout.Location = new System.Drawing.Point(10, 10);
            this.evolutionLayout.Name = "evolutionLayout";
            this.evolutionLayout.RowCount = 2;
            this.evolutionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.evolutionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.evolutionLayout.Size = new System.Drawing.Size(1046, 536);
            this.evolutionLayout.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.evolutionLayout.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1040, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Evolução";
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.AllowUserToAddRows = false;
            this.appointmentsDataGridView.AllowUserToDeleteRows = false;
            this.appointmentsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.appointmentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDate,
            this.colObservations,
            this.colExams,
            this.colDummy});
            this.appointmentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(3, 28);
            this.appointmentsDataGridView.MultiSelect = false;
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.ReadOnly = true;
            this.appointmentsDataGridView.RowHeadersVisible = false;
            this.appointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(349, 505);
            this.appointmentsDataGridView.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colDate
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDate.HeaderText = "Data";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 50;
            // 
            // colObservations
            // 
            this.colObservations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colObservations.HeaderText = "Observações";
            this.colObservations.MinimumWidth = 200;
            this.colObservations.Name = "colObservations";
            this.colObservations.ReadOnly = true;
            // 
            // colExams
            // 
            this.colExams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colExams.HeaderText = "Exames";
            this.colExams.Name = "colExams";
            this.colExams.ReadOnly = true;
            this.colExams.Width = 50;
            // 
            // colDummy
            // 
            this.colDummy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDummy.FillWeight = 10F;
            this.colDummy.HeaderText = "";
            this.colDummy.Name = "colDummy";
            this.colDummy.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.canvas, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(358, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 505);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(22, 12);
            this.canvas.MaximumSize = new System.Drawing.Size(640, 480);
            this.canvas.MinimumSize = new System.Drawing.Size(640, 480);
            this.canvas.Name = "canvas";
            this.canvas.Shapes = ((System.Collections.Generic.List<MrDentist.Models.IDentalIssueShape>)(resources.GetObject("canvas.Shapes")));
            this.canvas.Size = new System.Drawing.Size(640, 480);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.canvas.TabIndex = 3;
            this.canvas.TabStop = false;
            // 
            // PatientHistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layout);
            this.Name = "PatientHistoryPage";
            this.Size = new System.Drawing.Size(1106, 744);
            this.layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.patientInfoPanel.ResumeLayout(false);
            this.patientInfoPanel.PerformLayout();
            this.patientContentPanel.ResumeLayout(false);
            this.evolutionLayout.ResumeLayout(false);
            this.evolutionLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel patientInfoPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button buttonEditPatient;
        private System.Windows.Forms.Panel patientContentPanel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.TableLayoutPanel evolutionLayout;
        private System.Windows.Forms.Label label1;
        private OdontogramEntryCanvas canvas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservations;
        private System.Windows.Forms.DataGridViewButtonColumn colExams;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDummy;
    }
}
