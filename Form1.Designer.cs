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
            lblGiocatore = new Label();
            lblGiocatore1 = new Label();
            lblGiocatore2 = new Label();
            btnAvvia = new Button();
            lstCampo1 = new ListBox();
            lstCampo2 = new ListBox();
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
            lblGiocatore1.Location = new Point(180, 247);
            lblGiocatore1.Name = "lblGiocatore1";
            lblGiocatore1.Size = new Size(50, 20);
            lblGiocatore1.TabIndex = 8;
            lblGiocatore1.Text = "label4";
            // 
            // lblGiocatore2
            // 
            lblGiocatore2.AutoSize = true;
            lblGiocatore2.Location = new Point(710, 247);
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
            btnAvvia.Click += btnAvvia_Click;
            // 
            // lstCampo1
            // 
            lstCampo1.FormattingEnabled = true;
            lstCampo1.Location = new Point(80, 302);
            lstCampo1.Name = "lstCampo1";
            lstCampo1.Size = new Size(349, 184);
            lstCampo1.TabIndex = 13;
            // 
            // lstCampo2
            // 
            lstCampo2.FormattingEnabled = true;
            lstCampo2.Location = new Point(589, 302);
            lstCampo2.Name = "lstCampo2";
            lstCampo2.Size = new Size(329, 184);
            lstCampo2.TabIndex = 14;
            // 
            // Form1
            // 
            ClientSize = new Size(984, 527);
            Controls.Add(lstCampo2);
            Controls.Add(lstCampo1);
            Controls.Add(btnAvvia);
            Controls.Add(lblGiocatore2);
            Controls.Add(lblGiocatore1);
            Controls.Add(lblGiocatore);
            Controls.Add(btnCerca);
            Controls.Add(txtColonne);
            Controls.Add(txtRighe);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private TextBox txtRighe;
        private TextBox txtColonne;
        private Button btnCerca;
        private Label lblGiocatore;
        private Label lblGiocatore1;
        private Label lblGiocatore2;
        private Button btnAvvia;
        private ListBox lstCampo1;
        private ListBox lstCampo2;
    }
}
