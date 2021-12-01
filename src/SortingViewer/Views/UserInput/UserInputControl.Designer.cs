
namespace SortingViewer.Views.UserInput {
    partial class UserInputControl {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInputControl));
            this.btnStartSort = new System.Windows.Forms.Button();
            this.cmbSelectSortAlgorythm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopSort = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetValues = new System.Windows.Forms.Button();
            this.txtSortValues = new System.Windows.Forms.TextBox();
            this.numStepDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartSort
            // 
            this.btnStartSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartSort.Location = new System.Drawing.Point(3, 47);
            this.btnStartSort.Name = "btnStartSort";
            this.btnStartSort.Size = new System.Drawing.Size(154, 24);
            this.btnStartSort.TabIndex = 0;
            this.btnStartSort.Text = "Start Sort";
            this.btnStartSort.UseVisualStyleBackColor = true;
            this.btnStartSort.Click += new System.EventHandler(this.btnStartSort_Click);
            // 
            // cmbSelectSortAlgorythm
            // 
            this.cmbSelectSortAlgorythm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbSelectSortAlgorythm, 2);
            this.cmbSelectSortAlgorythm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectSortAlgorythm.FormattingEnabled = true;
            this.cmbSelectSortAlgorythm.Location = new System.Drawing.Point(3, 17);
            this.cmbSelectSortAlgorythm.Name = "cmbSelectSortAlgorythm";
            this.cmbSelectSortAlgorythm.Size = new System.Drawing.Size(314, 21);
            this.cmbSelectSortAlgorythm.TabIndex = 1;
            this.cmbSelectSortAlgorythm.SelectedIndexChanged += new System.EventHandler(this.cmbSelectSortAlgorythm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Sort Algorythm:";
            // 
            // btnStopSort
            // 
            this.btnStopSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopSort.Location = new System.Drawing.Point(163, 47);
            this.btnStopSort.Name = "btnStopSort";
            this.btnStopSort.Size = new System.Drawing.Size(154, 24);
            this.btnStopSort.TabIndex = 3;
            this.btnStopSort.Text = "Stop Sort";
            this.btnStopSort.UseVisualStyleBackColor = true;
            this.btnStopSort.Click += new System.EventHandler(this.btnStopSort_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStopSort, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbSelectSortAlgorythm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStartSort, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSetValues, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSortValues, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numStepDelay, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 184);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnSetValues
            // 
            this.btnSetValues.Location = new System.Drawing.Point(3, 77);
            this.btnSetValues.Name = "btnSetValues";
            this.btnSetValues.Size = new System.Drawing.Size(154, 24);
            this.btnSetValues.TabIndex = 4;
            this.btnSetValues.Text = "Set Values";
            this.btnSetValues.UseVisualStyleBackColor = true;
            this.btnSetValues.Click += new System.EventHandler(this.btnSetValues_Click);
            // 
            // txtSortValues
            // 
            this.txtSortValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSortValues.Location = new System.Drawing.Point(163, 77);
            this.txtSortValues.Name = "txtSortValues";
            this.txtSortValues.Size = new System.Drawing.Size(154, 20);
            this.txtSortValues.TabIndex = 5;
            this.txtSortValues.Text = resources.GetString("txtSortValues.Text");
            // 
            // numStepDelay
            // 
            this.numStepDelay.Location = new System.Drawing.Point(3, 120);
            this.numStepDelay.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numStepDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStepDelay.Name = "numStepDelay";
            this.numStepDelay.Size = new System.Drawing.Size(75, 20);
            this.numStepDelay.TabIndex = 6;
            this.numStepDelay.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numStepDelay.ValueChanged += new System.EventHandler(this.numStepDelay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Sort Algorythm:";
            // 
            // UserInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserInputControl";
            this.Size = new System.Drawing.Size(320, 184);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartSort;
        private System.Windows.Forms.ComboBox cmbSelectSortAlgorythm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStopSort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSetValues;
        private System.Windows.Forms.TextBox txtSortValues;
        private System.Windows.Forms.NumericUpDown numStepDelay;
        private System.Windows.Forms.Label label2;
    }
}
