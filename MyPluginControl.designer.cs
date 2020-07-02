using System.Collections.Specialized;
using System.Drawing;

namespace MyXrmToolBoxPlugin1
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadSolution = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SolutionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolutionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SolutionName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolutionId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compare = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.exportToExcel = new System.Windows.Forms.Button();
            this.sourceConnection = new System.Windows.Forms.Label();
            this.targetConnection = new System.Windows.Forms.Label();
            this.sourceSolutionCount = new System.Windows.Forms.Label();
            this.targetSolutionCo = new System.Windows.Forms.Label();
            this.compareCount = new System.Windows.Forms.Label();
            this.SolutionName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Match = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetSolutionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(928, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // loadSolution
            // 
            this.loadSolution.Location = new System.Drawing.Point(102, -2);
            this.loadSolution.Name = "loadSolution";
            this.loadSolution.Size = new System.Drawing.Size(107, 27);
            this.loadSolution.TabIndex = 5;
            this.loadSolution.Text = "Load Solution";
            this.loadSolution.UseVisualStyleBackColor = true;
            this.loadSolution.Click += new System.EventHandler(this.loadSolution_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SolutionName,
            this.VersionNumber,
            this.CreatedOn,
            this.Description,
            this.SolutionId});
            this.dataGridView1.Location = new System.Drawing.Point(23, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 269);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SolutionName
            // 
            this.SolutionName.HeaderText = "Solution Name";
            this.SolutionName.Name = "SolutionName";
          //  this.SolutionName.DefaultCellStyle.BackColor = Color.Red;
            // 
            // VersionNumber
            // 
            this.VersionNumber.HeaderText = "Version Number";
            this.VersionNumber.Name = "VersionNumber";
            // 
            // CreatedOn
            // 
            this.CreatedOn.HeaderText = "CreatedOn";
            this.CreatedOn.Name = "CreatedOn";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // SolutionId
            // 
            this.SolutionId.HeaderText = "SolutionId";
            this.SolutionId.Name = "SolutionId";
            this.SolutionId.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Connect Target";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SolutionName2,
            this.VersionNumber2,
            this.CreatedOn2,
            this.Description2,
            this.SolutionId2});
            this.dataGridView2.Location = new System.Drawing.Point(472, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(429, 269);
            this.dataGridView2.TabIndex = 8;
            // 
            // SolutionName2
            // 
            this.SolutionName2.HeaderText = "Solution Name";
            this.SolutionName2.Name = "SolutionName2";
            // 
            // VersionNumber2
            // 
            this.VersionNumber2.HeaderText = "Version Number";
            this.VersionNumber2.Name = "VersionNumber2";
            // 
            // CreatedOn2
            // 
            this.CreatedOn2.HeaderText = "Created On";
            this.CreatedOn2.Name = "CreatedOn2";
            // 
            // Description2
            // 
            this.Description2.HeaderText = "Description";
            this.Description2.Name = "Description2";
            // 
            // SolutionId2
            // 
            this.SolutionId2.HeaderText = "SolutionId";
            this.SolutionId2.Name = "SolutionId2";
            this.SolutionId2.Visible = false;
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(592, 352);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(111, 24);
            this.Compare.TabIndex = 9;
            this.Compare.Text = "Compare Solution";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SolutionName3,
            this.Version3,
            this.CreatedOn3,
            this.Match,
            this.TargetSolutionName});
            this.dataGridView3.Location = new System.Drawing.Point(23, 382);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(878, 263);
            this.dataGridView3.TabIndex = 10;
            // 
            // exportToExcel
            // 
            this.exportToExcel.Location = new System.Drawing.Point(726, 353);
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.Size = new System.Drawing.Size(114, 23);
            this.exportToExcel.TabIndex = 11;
            this.exportToExcel.Text = "Export to Excel";
            this.exportToExcel.UseVisualStyleBackColor = true;
            this.exportToExcel.Visible = false;
            this.exportToExcel.Click += new System.EventHandler(this.exportToExcel_Click);
            // 
            // sourceConnection
            // 
            this.sourceConnection.AutoSize = true;
            this.sourceConnection.Location = new System.Drawing.Point(23, 29);
            this.sourceConnection.Name = "sourceConnection";
            this.sourceConnection.Size = new System.Drawing.Size(0, 13);
            this.sourceConnection.TabIndex = 12;
            // 
            // targetConnection
            // 
            this.targetConnection.AutoSize = true;
            this.targetConnection.Location = new System.Drawing.Point(472, 34);
            this.targetConnection.Name = "targetConnection";
            this.targetConnection.Size = new System.Drawing.Size(0, 13);
            this.targetConnection.TabIndex = 13;
            // 
            // sourceSolutionCount
            // 
            this.sourceSolutionCount.AutoSize = true;
            this.sourceSolutionCount.Location = new System.Drawing.Point(363, 46);
            this.sourceSolutionCount.Name = "sourceSolutionCount";
            this.sourceSolutionCount.Size = new System.Drawing.Size(0, 13);
            this.sourceSolutionCount.TabIndex = 14;
            // 
            // targetSolutionCo
            // 
            this.targetSolutionCo.AutoSize = true;
            this.targetSolutionCo.Location = new System.Drawing.Point(812, 46);
            this.targetSolutionCo.Name = "targetSolutionCo";
            this.targetSolutionCo.Size = new System.Drawing.Size(0, 13);
            this.targetSolutionCo.TabIndex = 15;
            // 
            // compareCount
            // 
            this.compareCount.AutoSize = true;
            this.compareCount.Location = new System.Drawing.Point(23, 366);
            this.compareCount.Name = "compareCount";
            this.compareCount.Size = new System.Drawing.Size(0, 13);
            this.compareCount.TabIndex = 16;
            // 
            // SolutionName3
            // 
            this.SolutionName3.HeaderText = "Solution Name";
            this.SolutionName3.Name = "SolutionName3";
            this.SolutionName3.Width = 200;
            // 
            // Version3
            // 
            this.Version3.HeaderText = "Version";
            this.Version3.Name = "Version3";
            this.Version3.ReadOnly = true;
            this.Version3.Width = 200;
            // 
            // CreatedOn3
            // 
            this.CreatedOn3.HeaderText = "Created On";
            this.CreatedOn3.Name = "CreatedOn3";
            this.CreatedOn3.ReadOnly = true;
            this.CreatedOn3.Width = 200;
            // 
            // Match
            // 
            this.Match.HeaderText = "Match";
            this.Match.Name = "Match";
            this.Match.ReadOnly = true;
            this.Match.Width = 200;
            // 
            // TargetSolutionName
            // 
            this.TargetSolutionName.HeaderText = "Target Solution Name";
            this.TargetSolutionName.Name = "TargetSolutionName";
            this.TargetSolutionName.Visible = false;
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.compareCount);
            this.Controls.Add(this.targetSolutionCo);
            this.Controls.Add(this.sourceSolutionCount);
            this.Controls.Add(this.targetConnection);
            this.Controls.Add(this.sourceConnection);
            this.Controls.Add(this.exportToExcel);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadSolution);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(928, 636);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void ConnectionDetailsUpdated(NotifyCollectionChangedEventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.Button loadSolution;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button exportToExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionNumber2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionId2;
        private System.Windows.Forms.Label sourceConnection;
        private System.Windows.Forms.Label targetConnection;
        private System.Windows.Forms.Label sourceSolutionCount;
        private System.Windows.Forms.Label targetSolutionCo;
        private System.Windows.Forms.Label compareCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Match;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetSolutionName;
    }
}
