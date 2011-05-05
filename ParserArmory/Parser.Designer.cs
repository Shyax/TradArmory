﻿namespace ParserArmory
{
    partial class Parser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parser));
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxAvancement = new System.Windows.Forms.GroupBox();
            this.textBoxAvancement = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.radioButtonRu = new System.Windows.Forms.RadioButton();
            this.radioButtonES = new System.Windows.Forms.RadioButton();
            this.radioButtonDE = new System.Windows.Forms.RadioButton();
            this.radioButtonFR = new System.Windows.Forms.RadioButton();
            this.buttonLancer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdFin = new System.Windows.Forms.TextBox();
            this.textBoxIdDebut = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBoxAvancement.SuspendLayout();
            this.groupBoxTop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Développé par Shyax";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxAvancement);
            this.tabPage1.Controls.Add(this.groupBoxTop);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Traduction Objets";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxAvancement
            // 
            this.groupBoxAvancement.Controls.Add(this.textBoxAvancement);
            this.groupBoxAvancement.Controls.Add(this.progressBar1);
            this.groupBoxAvancement.Location = new System.Drawing.Point(7, 197);
            this.groupBoxAvancement.Name = "groupBoxAvancement";
            this.groupBoxAvancement.Size = new System.Drawing.Size(401, 215);
            this.groupBoxAvancement.TabIndex = 1;
            this.groupBoxAvancement.TabStop = false;
            this.groupBoxAvancement.Text = "Avancement";
            // 
            // textBoxAvancement
            // 
            this.textBoxAvancement.AcceptsReturn = true;
            this.textBoxAvancement.Location = new System.Drawing.Point(7, 20);
            this.textBoxAvancement.Multiline = true;
            this.textBoxAvancement.Name = "textBoxAvancement";
            this.textBoxAvancement.ReadOnly = true;
            this.textBoxAvancement.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxAvancement.Size = new System.Drawing.Size(381, 157);
            this.textBoxAvancement.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 183);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(382, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.radioButtonRu);
            this.groupBoxTop.Controls.Add(this.radioButtonES);
            this.groupBoxTop.Controls.Add(this.radioButtonDE);
            this.groupBoxTop.Controls.Add(this.radioButtonFR);
            this.groupBoxTop.Controls.Add(this.buttonLancer);
            this.groupBoxTop.Controls.Add(this.label2);
            this.groupBoxTop.Controls.Add(this.label1);
            this.groupBoxTop.Controls.Add(this.textBoxIdFin);
            this.groupBoxTop.Controls.Add(this.textBoxIdDebut);
            this.groupBoxTop.Location = new System.Drawing.Point(6, 6);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Size = new System.Drawing.Size(402, 185);
            this.groupBoxTop.TabIndex = 0;
            this.groupBoxTop.TabStop = false;
            // 
            // radioButtonRu
            // 
            this.radioButtonRu.AutoSize = true;
            this.radioButtonRu.Location = new System.Drawing.Point(9, 156);
            this.radioButtonRu.Name = "radioButtonRu";
            this.radioButtonRu.Size = new System.Drawing.Size(85, 17);
            this.radioButtonRu.TabIndex = 8;
            this.radioButtonRu.TabStop = true;
            this.radioButtonRu.Text = "Locale ruRU";
            this.radioButtonRu.UseVisualStyleBackColor = true;
            // 
            // radioButtonES
            // 
            this.radioButtonES.AutoSize = true;
            this.radioButtonES.Location = new System.Drawing.Point(9, 133);
            this.radioButtonES.Name = "radioButtonES";
            this.radioButtonES.Size = new System.Drawing.Size(85, 17);
            this.radioButtonES.TabIndex = 7;
            this.radioButtonES.Text = "Locale esES";
            this.radioButtonES.UseVisualStyleBackColor = true;
            // 
            // radioButtonDE
            // 
            this.radioButtonDE.AutoSize = true;
            this.radioButtonDE.Location = new System.Drawing.Point(9, 109);
            this.radioButtonDE.Name = "radioButtonDE";
            this.radioButtonDE.Size = new System.Drawing.Size(87, 17);
            this.radioButtonDE.TabIndex = 6;
            this.radioButtonDE.Text = "Locale deDE";
            this.radioButtonDE.UseVisualStyleBackColor = true;
            // 
            // radioButtonFR
            // 
            this.radioButtonFR.AutoSize = true;
            this.radioButtonFR.Checked = true;
            this.radioButtonFR.Location = new System.Drawing.Point(9, 87);
            this.radioButtonFR.Name = "radioButtonFR";
            this.radioButtonFR.Size = new System.Drawing.Size(80, 17);
            this.radioButtonFR.TabIndex = 5;
            this.radioButtonFR.TabStop = true;
            this.radioButtonFR.Text = "Locale frFR";
            this.radioButtonFR.UseVisualStyleBackColor = true;
            // 
            // buttonLancer
            // 
            this.buttonLancer.Location = new System.Drawing.Point(186, 109);
            this.buttonLancer.Name = "buttonLancer";
            this.buttonLancer.Size = new System.Drawing.Size(125, 41);
            this.buttonLancer.TabIndex = 4;
            this.buttonLancer.Text = "Lancer !";
            this.buttonLancer.UseVisualStyleBackColor = true;
            this.buttonLancer.Click += new System.EventHandler(this.buttonLancer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID de fin :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID de début :";
            // 
            // textBoxIdFin
            // 
            this.textBoxIdFin.Location = new System.Drawing.Point(94, 41);
            this.textBoxIdFin.Name = "textBoxIdFin";
            this.textBoxIdFin.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdFin.TabIndex = 1;
            // 
            // textBoxIdDebut
            // 
            this.textBoxIdDebut.Location = new System.Drawing.Point(94, 13);
            this.textBoxIdDebut.Name = "textBoxIdDebut";
            this.textBoxIdDebut.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdDebut.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 441);
            this.tabControl1.TabIndex = 1;
            // 
            // Parser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Parser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TradArmory";
            this.tabPage1.ResumeLayout(false);
            this.groupBoxAvancement.ResumeLayout(false);
            this.groupBoxAvancement.PerformLayout();
            this.groupBoxTop.ResumeLayout(false);
            this.groupBoxTop.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxAvancement;
        private System.Windows.Forms.TextBox textBoxAvancement;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.RadioButton radioButtonRu;
        private System.Windows.Forms.RadioButton radioButtonES;
        private System.Windows.Forms.RadioButton radioButtonDE;
        private System.Windows.Forms.RadioButton radioButtonFR;
        private System.Windows.Forms.Button buttonLancer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdFin;
        private System.Windows.Forms.TextBox textBoxIdDebut;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
