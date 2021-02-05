
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.cbxClues = new System.Windows.Forms.ComboBox();
			this.dgvGrid = new System.Windows.Forms.DataGridView();
			this.btnSolution = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Clues (Difficult):";
			// 
			// cbxClues
			// 
			this.cbxClues.FormattingEnabled = true;
			this.cbxClues.Items.AddRange(new object[] {
            "Most (Hardest)",
            "Medium",
            "Least (Easiest)"});
			this.cbxClues.Location = new System.Drawing.Point(141, 24);
			this.cbxClues.Name = "cbxClues";
			this.cbxClues.Size = new System.Drawing.Size(150, 25);
			this.cbxClues.TabIndex = 1;
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
			this.dgvGrid.Location = new System.Drawing.Point(9, 80);
			this.dgvGrid.MultiSelect = false;
			this.dgvGrid.Name = "dgvGrid";
			this.dgvGrid.RowHeadersVisible = false;
			this.dgvGrid.RowTemplate.Height = 25;
			this.dgvGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvGrid.Size = new System.Drawing.Size(315, 315);
			this.dgvGrid.TabIndex = 2;
			// 
			// btnSolution
			// 
			this.btnSolution.Location = new System.Drawing.Point(88, 408);
			this.btnSolution.Name = "btnSolution";
			this.btnSolution.Size = new System.Drawing.Size(75, 30);
			this.btnSolution.TabIndex = 2;
			this.btnSolution.Text = "Solution";
			this.btnSolution.UseVisualStyleBackColor = true;
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(169, 408);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 30);
			this.btnNew.TabIndex = 3;
			this.btnNew.Text = "New Game";
			this.btnNew.UseVisualStyleBackColor = true;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Column1";
			this.Column1.Name = "Column1";
			this.Column1.Width = 35;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Column2";
			this.Column2.Name = "Column2";
			this.Column2.Width = 35;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Column3";
			this.Column3.Name = "Column3";
			this.Column3.Width = 35;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Column4";
			this.Column4.Name = "Column4";
			this.Column4.Width = 35;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Column5";
			this.Column5.Name = "Column5";
			this.Column5.Width = 35;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Column6";
			this.Column6.Name = "Column6";
			this.Column6.Width = 35;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Column7";
			this.Column7.Name = "Column7";
			this.Column7.Width = 35;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Column8";
			this.Column8.Name = "Column8";
			this.Column8.Width = 35;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Column9";
			this.Column9.Name = "Column9";
			this.Column9.Width = 35;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 461);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnSolution);
			this.Controls.Add(this.dgvGrid);
			this.Controls.Add(this.cbxClues);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Sudoku";
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
	}
}

