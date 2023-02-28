﻿namespace TriviaQuiz
{
    partial class Joker
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
            this.btnGeography = new System.Windows.Forms.Button();
            this.btnNSTU = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnPopCulture = new System.Windows.Forms.Button();
            this.btnSport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeography
            // 
            this.btnGeography.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeography.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGeography.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnGeography.Location = new System.Drawing.Point(7, 74);
            this.btnGeography.Name = "btnGeography";
            this.btnGeography.Size = new System.Drawing.Size(233, 72);
            this.btnGeography.TabIndex = 0;
            this.btnGeography.Text = "География";
            this.btnGeography.UseVisualStyleBackColor = true;
            this.btnGeography.Click += new System.EventHandler(this.BtnGeography_Click);
            this.btnGeography.MouseEnter += new System.EventHandler(this.BtnGeography_MouseEnter);
            this.btnGeography.MouseLeave += new System.EventHandler(this.BtnGeography_MouseLeave);
            // 
            // btnNSTU
            // 
            this.btnNSTU.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNSTU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNSTU.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnNSTU.Location = new System.Drawing.Point(265, 74);
            this.btnNSTU.Name = "btnNSTU";
            this.btnNSTU.Size = new System.Drawing.Size(233, 72);
            this.btnNSTU.TabIndex = 1;
            this.btnNSTU.Text = "НГТУ";
            this.btnNSTU.UseVisualStyleBackColor = true;
            this.btnNSTU.Click += new System.EventHandler(this.btnNSTU_Click);
            this.btnNSTU.MouseEnter += new System.EventHandler(this.BtnGeography_MouseEnter);
            this.btnNSTU.MouseLeave += new System.EventHandler(this.BtnGeography_MouseLeave);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHistory.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnHistory.Location = new System.Drawing.Point(389, 169);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(233, 72);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "Computer Science";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            this.btnHistory.MouseEnter += new System.EventHandler(this.BtnGeography_MouseEnter);
            this.btnHistory.MouseLeave += new System.EventHandler(this.BtnGeography_MouseLeave);
            // 
            // btnPopCulture
            // 
            this.btnPopCulture.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopCulture.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPopCulture.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnPopCulture.Location = new System.Drawing.Point(135, 169);
            this.btnPopCulture.Name = "btnPopCulture";
            this.btnPopCulture.Size = new System.Drawing.Size(233, 72);
            this.btnPopCulture.TabIndex = 3;
            this.btnPopCulture.Text = "Поп-культура";
            this.btnPopCulture.UseVisualStyleBackColor = true;
            this.btnPopCulture.Click += new System.EventHandler(this.BtnPopCulture_Click);
            this.btnPopCulture.MouseEnter += new System.EventHandler(this.BtnGeography_MouseEnter);
            this.btnPopCulture.MouseLeave += new System.EventHandler(this.BtnGeography_MouseLeave);
            // 
            // btnSport
            // 
            this.btnSport.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSport.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnSport.Location = new System.Drawing.Point(518, 74);
            this.btnSport.Name = "btnSport";
            this.btnSport.Size = new System.Drawing.Size(233, 72);
            this.btnSport.TabIndex = 4;
            this.btnSport.Text = "Спорт";
            this.btnSport.UseVisualStyleBackColor = true;
            this.btnSport.Click += new System.EventHandler(this.BtnSport_Click);
            this.btnSport.MouseEnter += new System.EventHandler(this.BtnGeography_MouseEnter);
            this.btnSport.MouseLeave += new System.EventHandler(this.BtnGeography_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "ВЫБЕРЕТЕ ТЕМУ";
            // 
            // Joker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriviaQuiz.Properties.Resources.Site_Background;
            this.ClientSize = new System.Drawing.Size(763, 253);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSport);
            this.Controls.Add(this.btnPopCulture);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnNSTU);
            this.Controls.Add(this.btnGeography);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Joker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Джокер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeography;
        private System.Windows.Forms.Button btnNSTU;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnPopCulture;
        private System.Windows.Forms.Button btnSport;
        private System.Windows.Forms.Label label1;
    }
}