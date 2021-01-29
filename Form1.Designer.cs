namespace CheckBoxes
{
    partial class FormCheckBox
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
            this.chkStarTrek = new System.Windows.Forms.CheckBox();
            this.chkStarWars = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkStarTrek
            // 
            this.chkStarTrek.AutoSize = true;
            this.chkStarTrek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStarTrek.Location = new System.Drawing.Point(12, 49);
            this.chkStarTrek.Name = "chkStarTrek";
            this.chkStarTrek.Size = new System.Drawing.Size(146, 28);
            this.chkStarTrek.TabIndex = 0;
            this.chkStarTrek.Text = "I like Star Trek";
            this.chkStarTrek.UseVisualStyleBackColor = true;          
            // 
            // chkStarWars
            // 
            this.chkStarWars.AutoSize = true;
            this.chkStarWars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStarWars.Location = new System.Drawing.Point(180, 49);
            this.chkStarWars.Name = "chkStarWars";
            this.chkStarWars.Size = new System.Drawing.Size(151, 28);
            this.chkStarWars.TabIndex = 1;
            this.chkStarWars.Text = "I like Star Wars";
            this.chkStarWars.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 92);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(319, 43);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(12, 9);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(218, 24);
            this.lblInstruction.TabIndex = 3;
            this.lblInstruction.Text = "Please make a selection:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(12, 153);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(76, 24);
            this.lblResults.TabIndex = 4;
            this.lblResults.Text = "Results:";
            // 
            // FormCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 207);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkStarWars);
            this.Controls.Add(this.chkStarTrek);
            this.Name = "FormCheckBox";
            this.Text = "CheckBox Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkStarTrek;
        private System.Windows.Forms.CheckBox chkStarWars;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblResults;
    }
}

