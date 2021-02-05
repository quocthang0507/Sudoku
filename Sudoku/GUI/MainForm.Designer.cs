
namespace Sudoku.GUI
{
	partial class MainForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.cbxClues = new System.Windows.Forms.ComboBox();
			this.dgvGrid = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSolution = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Clues (Difficulty):";
			// 
			// cbxClues
			// 
			this.cbxClues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxClues.FormattingEnabled = true;
			this.cbxClues.Items.AddRange(new object[] {
            "Most (Hardest)",
            "Medium",
            "Least (Easiest)"});
			this.cbxClues.Location = new System.Drawing.Point(140, 21);
			this.cbxClues.Name = "cbxClues";
			this.cbxClues.Size = new System.Drawing.Size(150, 25);
			this.cbxClues.TabIndex = 1;
			this.cbxClues.SelectedIndexChanged += new System.EventHandler(this.cbxClues_SelectedIndexChanged);
			// 
			// dgvGrid
			// 
			this.dgvGrid.AllowUserToAddRows = false;
			this.dgvGrid.AllowUserToDeleteRows = false;
			this.dgvGrid.AllowUserToResizeColumns = false;
			this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGrid.ColumnHeadersVisible = false;
			this.dgvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
			this.dgvGrid.Location = new System.Drawing.Point(9, 71);
			this.dgvGrid.MultiSelect = false;
			this.dgvGrid.Name = "dgvGrid";
			this.dgvGrid.RowHeadersVisible = false;
			this.dgvGrid.RowTemplate.Height = 35;
			this.dgvGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvGrid.Size = new System.Drawing.Size(315, 315);
			this.dgvGrid.TabIndex = 2;
			this.dgvGrid.TabStop = false;
			this.dgvGrid.SizeChanged += new System.EventHandler(this.dgvGrid_SizeChanged);
			this.dgvGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvGrid_Paint);
			// 
			// Column1
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column1.HeaderText = "Column1";
			this.Column1.Name = "Column1";
			this.Column1.Width = 35;
			// 
			// Column2
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column2.HeaderText = "Column2";
			this.Column2.Name = "Column2";
			this.Column2.Width = 35;
			// 
			// Column3
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column3.HeaderText = "Column3";
			this.Column3.Name = "Column3";
			this.Column3.Width = 35;
			// 
			// Column4
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
			this.Column4.HeaderText = "Column4";
			this.Column4.Name = "Column4";
			this.Column4.Width = 35;
			// 
			// Column5
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
			this.Column5.HeaderText = "Column5";
			this.Column5.Name = "Column5";
			this.Column5.Width = 35;
			// 
			// Column6
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
			this.Column6.HeaderText = "Column6";
			this.Column6.Name = "Column6";
			this.Column6.Width = 35;
			// 
			// Column7
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column7.DefaultCellStyle = dataGridViewCellStyle7;
			this.Column7.HeaderText = "Column7";
			this.Column7.Name = "Column7";
			this.Column7.Width = 35;
			// 
			// Column8
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column8.DefaultCellStyle = dataGridViewCellStyle8;
			this.Column8.HeaderText = "Column8";
			this.Column8.Name = "Column8";
			this.Column8.Width = 35;
			// 
			// Column9
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Column9.DefaultCellStyle = dataGridViewCellStyle9;
			this.Column9.HeaderText = "Column9";
			this.Column9.Name = "Column9";
			this.Column9.Width = 35;
			// 
			// btnSolution
			// 
			this.btnSolution.Location = new System.Drawing.Point(115, 408);
			this.btnSolution.Name = "btnSolution";
			this.btnSolution.Size = new System.Drawing.Size(75, 30);
			this.btnSolution.TabIndex = 3;
			this.btnSolution.Text = "Solution";
			this.btnSolution.UseVisualStyleBackColor = true;
			this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(24, 408);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 30);
			this.btnNew.TabIndex = 2;
			this.btnNew.Text = "New Game";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(206, 408);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(98, 30);
			this.btnExport.TabIndex = 4;
			this.btnExport.Text = "Export image";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Portable Network Graphics|*.png";
			this.saveFileDialog.Title = "Choose folder to save this image";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 461);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnSolution);
			this.Controls.Add(this.dgvGrid);
			this.Controls.Add(this.cbxClues);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sudoku";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxClues;
		private System.Windows.Forms.DataGridView dgvGrid;
		private System.Windows.Forms.Button btnSolution;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}

