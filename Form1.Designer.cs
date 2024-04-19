namespace Battaglia_navale
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

     
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtRighe = new TextBox();
            txtColonne = new TextBox();
            btnCerca = new Button();
            dgwGiocatore1 = new DataGridView();
            dgwGiocatore2 = new DataGridView();
            lblGiocatore = new Label();
            lblGiocatore1 = new Label();
            lblGiocatore2 = new Label();
            btnAvvia = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwGiocatore1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwGiocatore2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 83);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Righe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 143);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Colonne:";
            // 
            // txtRighe
            // 
            txtRighe.Location = new Point(236, 83);
            txtRighe.Name = "txtRighe";
            txtRighe.Size = new Size(125, 27);
            txtRighe.TabIndex = 2;
            // 
            // txtColonne
            // 
            txtColonne.Location = new Point(236, 136);
            txtColonne.Name = "txtColonne";
            txtColonne.Size = new Size(125, 27);
            txtColonne.TabIndex = 3;
            // 
            // btnCerca
            // 
            btnCerca.Location = new Point(601, 124);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(94, 29);
            btnCerca.TabIndex = 4;
            btnCerca.Text = "Cerca";
            btnCerca.UseVisualStyleBackColor = true;
            // 
            // dgwGiocatore1
            // 
            dgwGiocatore1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGiocatore1.Location = new Point(94, 290);
            dgwGiocatore1.Name = "dgwGiocatore1";
            dgwGiocatore1.RowHeadersWidth = 51;
            dgwGiocatore1.Size = new Size(300, 188);
            dgwGiocatore1.TabIndex = 5;
            // 
            // dgwGiocatore2
            // 
            dgwGiocatore2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGiocatore2.Location = new Point(601, 290);
            dgwGiocatore2.Name = "dgwGiocatore2";
            dgwGiocatore2.RowHeadersWidth = 51;
            dgwGiocatore2.Size = new Size(300, 188);
            dgwGiocatore2.TabIndex = 6;
            // 
            // lblGiocatore
            // 
            lblGiocatore.AutoSize = true;
            lblGiocatore.Location = new Point(601, 83);
            lblGiocatore.Name = "lblGiocatore";
            lblGiocatore.Size = new Size(50, 20);
            lblGiocatore.TabIndex = 7;
            lblGiocatore.Text = "label3";
            // 
            // lblGiocatore1
            // 
            lblGiocatore1.AutoSize = true;
            lblGiocatore1.Location = new Point(200, 247);
            lblGiocatore1.Name = "lblGiocatore1";
            lblGiocatore1.Size = new Size(50, 20);
            lblGiocatore1.TabIndex = 8;
            lblGiocatore1.Text = "label4";
            // 
            // lblGiocatore2
            // 
            lblGiocatore2.AutoSize = true;
            lblGiocatore2.Location = new Point(724, 247);
            lblGiocatore2.Name = "lblGiocatore2";
            lblGiocatore2.Size = new Size(50, 20);
            lblGiocatore2.TabIndex = 9;
            lblGiocatore2.Text = "label5";
            // 
            // btnAvvia
            // 
            btnAvvia.Location = new Point(94, 22);
            btnAvvia.Name = "btnAvvia";
            btnAvvia.Size = new Size(94, 29);
            btnAvvia.TabIndex = 12;
            btnAvvia.Text = "Avvia";
            btnAvvia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(984, 527);
            Controls.Add(btnAvvia);
            Controls.Add(lblGiocatore2);
            Controls.Add(lblGiocatore1);
            Controls.Add(lblGiocatore);
            Controls.Add(dgwGiocatore2);
            Controls.Add(dgwGiocatore1);
            Controls.Add(btnCerca);
            Controls.Add(txtColonne);
            Controls.Add(txtRighe);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgwGiocatore1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwGiocatore2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private TextBox txtRighe;
        private TextBox txtColonne;
        private Button btnCerca;
        private DataGridView dgwGiocatore1;
        private DataGridView dgwGiocatore2;
        private Label lblGiocatore;
        private Label lblGiocatore1;
        private Label lblGiocatore2;
        private Button btnAvvia;
    }
}
