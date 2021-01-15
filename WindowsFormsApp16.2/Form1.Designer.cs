
namespace WindowsFormsApp16._2
{
    partial class Form1
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
            this.btnInlezen = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnWissen = new System.Windows.Forms.Button();
            this.btnSorteren = new System.Windows.Forms.Button();
            this.lbOverzicht = new System.Windows.Forms.ListBox();
            this.labelDier = new System.Windows.Forms.Label();
            this.txtDierToevoegen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInlezen
            // 
            this.btnInlezen.Location = new System.Drawing.Point(583, 25);
            this.btnInlezen.Name = "btnInlezen";
            this.btnInlezen.Size = new System.Drawing.Size(150, 94);
            this.btnInlezen.TabIndex = 0;
            this.btnInlezen.Text = "Inlezen +Overzicht";
            this.btnInlezen.UseVisualStyleBackColor = true;
            this.btnInlezen.Click += new System.EventHandler(this.btnInlezen_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(583, 246);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(150, 94);
            this.btnToevoegen.TabIndex = 1;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(583, 374);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(150, 94);
            this.btnWissen.TabIndex = 2;
            this.btnWissen.Text = "Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // btnSorteren
            // 
            this.btnSorteren.Location = new System.Drawing.Point(583, 517);
            this.btnSorteren.Name = "btnSorteren";
            this.btnSorteren.Size = new System.Drawing.Size(150, 94);
            this.btnSorteren.TabIndex = 3;
            this.btnSorteren.Text = "Sorteren";
            this.btnSorteren.UseVisualStyleBackColor = true;
            this.btnSorteren.Click += new System.EventHandler(this.btnSorteren_Click);
            // 
            // lbOverzicht
            // 
            this.lbOverzicht.FormattingEnabled = true;
            this.lbOverzicht.ItemHeight = 16;
            this.lbOverzicht.Location = new System.Drawing.Point(22, 25);
            this.lbOverzicht.Name = "lbOverzicht";
            this.lbOverzicht.Size = new System.Drawing.Size(490, 596);
            this.lbOverzicht.TabIndex = 4;
            // 
            // labelDier
            // 
            this.labelDier.AutoSize = true;
            this.labelDier.Location = new System.Drawing.Point(583, 145);
            this.labelDier.Name = "labelDier";
            this.labelDier.Size = new System.Drawing.Size(38, 17);
            this.labelDier.TabIndex = 5;
            this.labelDier.Text = "Dier:";
            // 
            // txtDierToevoegen
            // 
            this.txtDierToevoegen.Location = new System.Drawing.Point(583, 185);
            this.txtDierToevoegen.Name = "txtDierToevoegen";
            this.txtDierToevoegen.Size = new System.Drawing.Size(150, 22);
            this.txtDierToevoegen.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.txtDierToevoegen);
            this.Controls.Add(this.labelDier);
            this.Controls.Add(this.lbOverzicht);
            this.Controls.Add(this.btnSorteren);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnInlezen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInlezen;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.Button btnSorteren;
        private System.Windows.Forms.ListBox lbOverzicht;
        private System.Windows.Forms.Label labelDier;
        private System.Windows.Forms.TextBox txtDierToevoegen;
    }
}

