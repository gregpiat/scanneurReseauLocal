namespace scanneurReseauLocal
{
    partial class scanneurReseauLocal
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbIp = new System.Windows.Forms.TextBox();
            this.btnLancerLeScan = new System.Windows.Forms.Button();
            this.lblVotreIp = new System.Windows.Forms.Label();
            this.lblPasserelle = new System.Windows.Forms.Label();
            this.dgvInfosMachines = new System.Windows.Forms.DataGridView();
            this.btnRechargerInfosDeSaConfig = new System.Windows.Forms.Button();
            this.txbPasserelle = new System.Windows.Forms.TextBox();
            this.ldgvIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ldgvNomMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomMachine = new System.Windows.Forms.Label();
            this.txbNomMachine = new System.Windows.Forms.TextBox();
            this.lblAdresseTestee = new System.Windows.Forms.Label();
            this.lblAvancement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfosMachines)).BeginInit();
            this.SuspendLayout();
            // 
            // txbIp
            // 
            this.txbIp.Location = new System.Drawing.Point(126, 62);
            this.txbIp.Name = "txbIp";
            this.txbIp.Size = new System.Drawing.Size(100, 20);
            this.txbIp.TabIndex = 0;
            // 
            // btnLancerLeScan
            // 
            this.btnLancerLeScan.Location = new System.Drawing.Point(126, 149);
            this.btnLancerLeScan.Name = "btnLancerLeScan";
            this.btnLancerLeScan.Size = new System.Drawing.Size(143, 76);
            this.btnLancerLeScan.TabIndex = 1;
            this.btnLancerLeScan.Text = "Lancer le scan du réseau local";
            this.btnLancerLeScan.UseVisualStyleBackColor = true;
            this.btnLancerLeScan.Click += new System.EventHandler(this.btnLancerLeScan_Click);
            // 
            // lblVotreIp
            // 
            this.lblVotreIp.AutoSize = true;
            this.lblVotreIp.Location = new System.Drawing.Point(69, 65);
            this.lblVotreIp.Name = "lblVotreIp";
            this.lblVotreIp.Size = new System.Drawing.Size(51, 13);
            this.lblVotreIp.TabIndex = 3;
            this.lblVotreIp.Text = "Votre IP :";
            // 
            // lblPasserelle
            // 
            this.lblPasserelle.AutoSize = true;
            this.lblPasserelle.Location = new System.Drawing.Point(250, 66);
            this.lblPasserelle.Name = "lblPasserelle";
            this.lblPasserelle.Size = new System.Drawing.Size(139, 13);
            this.lblPasserelle.TabIndex = 4;
            this.lblPasserelle.Text = "Votre passerelle par défaut :";
            // 
            // dgvInfosMachines
            // 
            this.dgvInfosMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfosMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ldgvIp,
            this.ldgvNomMachine});
            this.dgvInfosMachines.Location = new System.Drawing.Point(126, 277);
            this.dgvInfosMachines.Name = "dgvInfosMachines";
            this.dgvInfosMachines.Size = new System.Drawing.Size(304, 253);
            this.dgvInfosMachines.TabIndex = 5;
            this.dgvInfosMachines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRechargerInfosDeSaConfig
            // 
            this.btnRechargerInfosDeSaConfig.Location = new System.Drawing.Point(299, 149);
            this.btnRechargerInfosDeSaConfig.Name = "btnRechargerInfosDeSaConfig";
            this.btnRechargerInfosDeSaConfig.Size = new System.Drawing.Size(143, 76);
            this.btnRechargerInfosDeSaConfig.TabIndex = 6;
            this.btnRechargerInfosDeSaConfig.Text = "Recharger les informations de sa connexion";
            this.btnRechargerInfosDeSaConfig.UseVisualStyleBackColor = true;
            // 
            // txbPasserelle
            // 
            this.txbPasserelle.Location = new System.Drawing.Point(406, 65);
            this.txbPasserelle.Name = "txbPasserelle";
            this.txbPasserelle.Size = new System.Drawing.Size(100, 20);
            this.txbPasserelle.TabIndex = 7;
            // 
            // ldgvIp
            // 
            this.ldgvIp.HeaderText = "Ip de la machine";
            this.ldgvIp.Name = "ldgvIp";
            // 
            // ldgvNomMachine
            // 
            this.ldgvNomMachine.HeaderText = "Nom de la machine";
            this.ldgvNomMachine.Name = "ldgvNomMachine";
            // 
            // lblNomMachine
            // 
            this.lblNomMachine.AutoSize = true;
            this.lblNomMachine.Location = new System.Drawing.Point(16, 91);
            this.lblNomMachine.Name = "lblNomMachine";
            this.lblNomMachine.Size = new System.Drawing.Size(104, 13);
            this.lblNomMachine.TabIndex = 9;
            this.lblNomMachine.Text = "Nom de la machine :";
            // 
            // txbNomMachine
            // 
            this.txbNomMachine.Location = new System.Drawing.Point(126, 88);
            this.txbNomMachine.Name = "txbNomMachine";
            this.txbNomMachine.Size = new System.Drawing.Size(100, 20);
            this.txbNomMachine.TabIndex = 8;
            // 
            // lblAdresseTestee
            // 
            this.lblAdresseTestee.AutoSize = true;
            this.lblAdresseTestee.Location = new System.Drawing.Point(163, 252);
            this.lblAdresseTestee.Name = "lblAdresseTestee";
            this.lblAdresseTestee.Size = new System.Drawing.Size(0, 13);
            this.lblAdresseTestee.TabIndex = 10;
            // 
            // lblAvancement
            // 
            this.lblAvancement.AutoSize = true;
            this.lblAvancement.Location = new System.Drawing.Point(309, 252);
            this.lblAvancement.Name = "lblAvancement";
            this.lblAvancement.Size = new System.Drawing.Size(0, 13);
            this.lblAvancement.TabIndex = 11;
            // 
            // scanneurReseauLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 542);
            this.Controls.Add(this.lblAvancement);
            this.Controls.Add(this.lblAdresseTestee);
            this.Controls.Add(this.lblNomMachine);
            this.Controls.Add(this.txbNomMachine);
            this.Controls.Add(this.txbPasserelle);
            this.Controls.Add(this.btnRechargerInfosDeSaConfig);
            this.Controls.Add(this.dgvInfosMachines);
            this.Controls.Add(this.lblPasserelle);
            this.Controls.Add(this.lblVotreIp);
            this.Controls.Add(this.btnLancerLeScan);
            this.Controls.Add(this.txbIp);
            this.Name = "scanneurReseauLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanneur de réseau local pour détecter les machines connectées";
            this.Load += new System.EventHandler(this.scanneurReseauLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfosMachines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIp;
        private System.Windows.Forms.Button btnLancerLeScan;
        private System.Windows.Forms.Label lblVotreIp;
        private System.Windows.Forms.Label lblPasserelle;
        private System.Windows.Forms.DataGridView dgvInfosMachines;
        private System.Windows.Forms.Button btnRechargerInfosDeSaConfig;
        private System.Windows.Forms.TextBox txbPasserelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldgvIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldgvNomMachine;
        private System.Windows.Forms.Label lblNomMachine;
        private System.Windows.Forms.TextBox txbNomMachine;
        private System.Windows.Forms.Label lblAdresseTestee;
        private System.Windows.Forms.Label lblAvancement;
    }
}

