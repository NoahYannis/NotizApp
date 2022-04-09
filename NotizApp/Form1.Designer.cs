
namespace NotizApp
{
    partial class Form1
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblNachricht = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.txtNachricht = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnLesen = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitel.Location = new System.Drawing.Point(147, 105);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(80, 58);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Titel:";
            // 
            // lblNachricht
            // 
            this.lblNachricht.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNachricht.Location = new System.Drawing.Point(85, 181);
            this.lblNachricht.Name = "lblNachricht";
            this.lblNachricht.Size = new System.Drawing.Size(142, 49);
            this.lblNachricht.TabIndex = 1;
            this.lblNachricht.Text = "Nachricht:";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(256, 114);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(222, 27);
            this.txtTitel.TabIndex = 2;
            // 
            // txtNachricht
            // 
            this.txtNachricht.Location = new System.Drawing.Point(256, 181);
            this.txtNachricht.Multiline = true;
            this.txtNachricht.Name = "txtNachricht";
            this.txtNachricht.Size = new System.Drawing.Size(222, 185);
            this.txtNachricht.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(641, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 261);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(256, 413);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(129, 51);
            this.btnNeu.TabIndex = 5;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(426, 413);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(130, 51);
            this.btnSpeichern.TabIndex = 6;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnLesen
            // 
            this.btnLesen.Location = new System.Drawing.Point(593, 413);
            this.btnLesen.Name = "btnLesen";
            this.btnLesen.Size = new System.Drawing.Size(118, 51);
            this.btnLesen.TabIndex = 7;
            this.btnLesen.Text = "Lesen";
            this.btnLesen.UseVisualStyleBackColor = true;
            this.btnLesen.Click += new System.EventHandler(this.btnLesen_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.Location = new System.Drawing.Point(750, 413);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(129, 51);
            this.btnLöschen.TabIndex = 8;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 552);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.btnLesen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNachricht);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.lblNachricht);
            this.Controls.Add(this.lblTitel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblNachricht;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.TextBox txtNachricht;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnLesen;
        private System.Windows.Forms.Button btnLöschen;
    }
}

