namespace WindowsFormsApp1
{
    partial class Gebruiker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gebruiker));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBan = new System.Windows.Forms.Button();
            this.BtnUnban = new System.Windows.Forms.Button();
            this.LblBeschrijving1LblBeschrijving1 = new System.Windows.Forms.Label();
            this.LblGebruiker = new System.Windows.Forms.Label();
            this.LblSelect = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LblBeschrijvingen2 = new System.Windows.Forms.Label();
            this.BtnUnban2 = new System.Windows.Forms.Button();
            this.BtnBan2 = new System.Windows.Forms.Button();
            this.BtnEdit2 = new System.Windows.Forms.Button();
            this.BtnAdd2 = new System.Windows.Forms.Button();
            this.BtnDelete2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(905, 229);
            this.dataGridView1.TabIndex = 3;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(758, 12);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 11;
            this.BtnEdit.Text = "Bewerken";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(671, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Toevoegen";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(842, 12);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Verwijderen";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selecteer ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "gebruiker:";
            // 
            // BtnBan
            // 
            this.BtnBan.Location = new System.Drawing.Point(494, 12);
            this.BtnBan.Name = "BtnBan";
            this.BtnBan.Size = new System.Drawing.Size(88, 23);
            this.BtnBan.TabIndex = 14;
            this.BtnBan.Text = "Uitschakelen";
            this.BtnBan.UseVisualStyleBackColor = true;
            this.BtnBan.Click += new System.EventHandler(this.BtnBan_Click);
            // 
            // BtnUnban
            // 
            this.BtnUnban.Location = new System.Drawing.Point(413, 12);
            this.BtnUnban.Name = "BtnUnban";
            this.BtnUnban.Size = new System.Drawing.Size(75, 23);
            this.BtnUnban.TabIndex = 15;
            this.BtnUnban.Text = "Inschakelen";
            this.BtnUnban.UseVisualStyleBackColor = true;
            this.BtnUnban.Click += new System.EventHandler(this.BtnUnban_Click);
            // 
            // LblBeschrijving1LblBeschrijving1
            // 
            this.LblBeschrijving1LblBeschrijving1.AutoSize = true;
            this.LblBeschrijving1LblBeschrijving1.BackColor = System.Drawing.Color.OrangeRed;
            this.LblBeschrijving1LblBeschrijving1.Location = new System.Drawing.Point(197, 17);
            this.LblBeschrijving1LblBeschrijving1.Name = "LblBeschrijving1LblBeschrijving1";
            this.LblBeschrijving1LblBeschrijving1.Size = new System.Drawing.Size(96, 13);
            this.LblBeschrijving1LblBeschrijving1.TabIndex = 16;
            this.LblBeschrijving1LblBeschrijving1.Text = "Mail min, max temp";
            // 
            // LblGebruiker
            // 
            this.LblGebruiker.AutoSize = true;
            this.LblGebruiker.Location = new System.Drawing.Point(13, 301);
            this.LblGebruiker.Name = "LblGebruiker";
            this.LblGebruiker.Size = new System.Drawing.Size(54, 13);
            this.LblGebruiker.TabIndex = 18;
            this.LblGebruiker.Text = "gebruiker:";
            // 
            // LblSelect
            // 
            this.LblSelect.AutoSize = true;
            this.LblSelect.Location = new System.Drawing.Point(13, 284);
            this.LblSelect.Name = "LblSelect";
            this.LblSelect.Size = new System.Drawing.Size(55, 13);
            this.LblSelect.TabIndex = 17;
            this.LblSelect.Text = "Selecteer ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.Location = new System.Drawing.Point(12, 320);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(905, 229);
            this.dataGridView2.TabIndex = 19;
            // 
            // LblBeschrijvingen2
            // 
            this.LblBeschrijvingen2.AutoSize = true;
            this.LblBeschrijvingen2.BackColor = System.Drawing.Color.OrangeRed;
            this.LblBeschrijvingen2.Location = new System.Drawing.Point(197, 284);
            this.LblBeschrijvingen2.Name = "LblBeschrijvingen2";
            this.LblBeschrijvingen2.Size = new System.Drawing.Size(87, 13);
            this.LblBeschrijvingen2.TabIndex = 20;
            this.LblBeschrijvingen2.Text = "Mail service error";
            // 
            // BtnUnban2
            // 
            this.BtnUnban2.Location = new System.Drawing.Point(413, 291);
            this.BtnUnban2.Name = "BtnUnban2";
            this.BtnUnban2.Size = new System.Drawing.Size(75, 23);
            this.BtnUnban2.TabIndex = 22;
            this.BtnUnban2.Text = "Inschakelen";
            this.BtnUnban2.UseVisualStyleBackColor = true;
            this.BtnUnban2.Click += new System.EventHandler(this.BtnUnban2_Click);
            // 
            // BtnBan2
            // 
            this.BtnBan2.Location = new System.Drawing.Point(494, 291);
            this.BtnBan2.Name = "BtnBan2";
            this.BtnBan2.Size = new System.Drawing.Size(88, 23);
            this.BtnBan2.TabIndex = 21;
            this.BtnBan2.Text = "Uitschakelen";
            this.BtnBan2.UseVisualStyleBackColor = true;
            this.BtnBan2.Click += new System.EventHandler(this.BtnBan2_Click);
            // 
            // BtnEdit2
            // 
            this.BtnEdit2.Location = new System.Drawing.Point(758, 291);
            this.BtnEdit2.Name = "BtnEdit2";
            this.BtnEdit2.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit2.TabIndex = 25;
            this.BtnEdit2.Text = "Bewerken";
            this.BtnEdit2.UseVisualStyleBackColor = true;
            this.BtnEdit2.Click += new System.EventHandler(this.BtnEdit2_Click);
            // 
            // BtnAdd2
            // 
            this.BtnAdd2.Location = new System.Drawing.Point(671, 291);
            this.BtnAdd2.Name = "BtnAdd2";
            this.BtnAdd2.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd2.TabIndex = 24;
            this.BtnAdd2.Text = "Toevoegen";
            this.BtnAdd2.UseVisualStyleBackColor = true;
            this.BtnAdd2.Click += new System.EventHandler(this.BtnAdd2_Click);
            // 
            // BtnDelete2
            // 
            this.BtnDelete2.Location = new System.Drawing.Point(842, 291);
            this.BtnDelete2.Name = "BtnDelete2";
            this.BtnDelete2.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete2.TabIndex = 23;
            this.BtnDelete2.Text = "Verwijderen";
            this.BtnDelete2.UseVisualStyleBackColor = true;
            this.BtnDelete2.Click += new System.EventHandler(this.BtnDelete2_Click);
            // 
            // Gebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 593);
            this.Controls.Add(this.BtnEdit2);
            this.Controls.Add(this.BtnAdd2);
            this.Controls.Add(this.BtnDelete2);
            this.Controls.Add(this.BtnUnban2);
            this.Controls.Add(this.BtnBan2);
            this.Controls.Add(this.LblBeschrijvingen2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.LblGebruiker);
            this.Controls.Add(this.LblSelect);
            this.Controls.Add(this.LblBeschrijving1LblBeschrijving1);
            this.Controls.Add(this.BtnUnban);
            this.Controls.Add(this.BtnBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gebruiker";
            this.Text = "Gebruikers beheren";
            this.Load += new System.EventHandler(this.AddMailUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBan;
        private System.Windows.Forms.Button BtnUnban;
        private System.Windows.Forms.Label LblBeschrijving1LblBeschrijving1;
        private System.Windows.Forms.Label LblGebruiker;
        private System.Windows.Forms.Label LblSelect;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label LblBeschrijvingen2;
        private System.Windows.Forms.Button BtnUnban2;
        private System.Windows.Forms.Button BtnBan2;
        private System.Windows.Forms.Button BtnEdit2;
        private System.Windows.Forms.Button BtnAdd2;
        private System.Windows.Forms.Button BtnDelete2;
    }
}