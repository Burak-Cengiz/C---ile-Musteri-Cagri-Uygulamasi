namespace MusteriCagriUygulamasi
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
            this.components = new System.ComponentModel.Container();
            this.cmBxMsteriTip = new System.Windows.Forms.ComboBox();
            this.lblMusteriTip = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblZaman = new System.Windows.Forms.Label();
            this.btnArama = new System.Windows.Forms.Button();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.txtBxMusteriID = new System.Windows.Forms.TextBox();
            this.lstBxCagrilar = new System.Windows.Forms.ListBox();
            this.btnCagriAta = new System.Windows.Forms.Button();
            this.btnBryselCgriBtir = new System.Windows.Forms.Button();
            this.btnTicriCagrBtr = new System.Windows.Forms.Button();
            this.btnCgrID = new System.Windows.Forms.Button();
            this.txtBxOnclkID = new System.Windows.Forms.TextBox();
            this.btnCagrilar = new System.Windows.Forms.Button();
            this.lstBxBtnCagrilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmBxMsteriTip
            // 
            this.cmBxMsteriTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmBxMsteriTip.FormattingEnabled = true;
            this.cmBxMsteriTip.Items.AddRange(new object[] {
            "Ticari",
            "Bireysel"});
            this.cmBxMsteriTip.Location = new System.Drawing.Point(167, 15);
            this.cmBxMsteriTip.Name = "cmBxMsteriTip";
            this.cmBxMsteriTip.Size = new System.Drawing.Size(104, 28);
            this.cmBxMsteriTip.TabIndex = 0;
            // 
            // lblMusteriTip
            // 
            this.lblMusteriTip.AutoSize = true;
            this.lblMusteriTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriTip.Location = new System.Drawing.Point(32, 15);
            this.lblMusteriTip.Name = "lblMusteriTip";
            this.lblMusteriTip.Size = new System.Drawing.Size(129, 25);
            this.lblMusteriTip.TabIndex = 1;
            this.lblMusteriTip.Text = "Müşteri Tipi : ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(297, 15);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(73, 25);
            this.lblZaman.TabIndex = 2;
            this.lblZaman.Text = "Zaman";
            // 
            // btnArama
            // 
            this.btnArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArama.Location = new System.Drawing.Point(352, 53);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(112, 39);
            this.btnArama.TabIndex = 3;
            this.btnArama.Text = "Arama Yap";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriID.Location = new System.Drawing.Point(32, 53);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(111, 25);
            this.lblMusteriID.TabIndex = 4;
            this.lblMusteriID.Text = "Müşteri ID: ";
            // 
            // txtBxMusteriID
            // 
            this.txtBxMusteriID.Location = new System.Drawing.Point(167, 58);
            this.txtBxMusteriID.Name = "txtBxMusteriID";
            this.txtBxMusteriID.Size = new System.Drawing.Size(104, 20);
            this.txtBxMusteriID.TabIndex = 5;
            // 
            // lstBxCagrilar
            // 
            this.lstBxCagrilar.FormattingEnabled = true;
            this.lstBxCagrilar.Items.AddRange(new object[] {
            "Çağrı ID    Müşteri ID       Müşteri Tipi                           Çağrı Başlang" +
                "ıç Zamanı "});
            this.lstBxCagrilar.Location = new System.Drawing.Point(37, 118);
            this.lstBxCagrilar.Name = "lstBxCagrilar";
            this.lstBxCagrilar.Size = new System.Drawing.Size(427, 173);
            this.lstBxCagrilar.TabIndex = 6;
            // 
            // btnCagriAta
            // 
            this.btnCagriAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCagriAta.Location = new System.Drawing.Point(37, 313);
            this.btnCagriAta.Name = "btnCagriAta";
            this.btnCagriAta.Size = new System.Drawing.Size(112, 39);
            this.btnCagriAta.TabIndex = 8;
            this.btnCagriAta.Text = "Çağrıyı Ata";
            this.btnCagriAta.UseVisualStyleBackColor = true;
            this.btnCagriAta.Click += new System.EventHandler(this.btnCagriAta_Click);
            // 
            // btnBryselCgriBtir
            // 
            this.btnBryselCgriBtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBryselCgriBtir.Location = new System.Drawing.Point(222, 306);
            this.btnBryselCgriBtir.Name = "btnBryselCgriBtir";
            this.btnBryselCgriBtir.Size = new System.Drawing.Size(168, 52);
            this.btnBryselCgriBtir.TabIndex = 9;
            this.btnBryselCgriBtir.Text = "Bireysel Müşteri Çağrıyı Bitir";
            this.btnBryselCgriBtir.UseVisualStyleBackColor = true;
            this.btnBryselCgriBtir.Click += new System.EventHandler(this.btnBryselCgriBtir_Click);
            // 
            // btnTicriCagrBtr
            // 
            this.btnTicriCagrBtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTicriCagrBtr.Location = new System.Drawing.Point(222, 364);
            this.btnTicriCagrBtr.Name = "btnTicriCagrBtr";
            this.btnTicriCagrBtr.Size = new System.Drawing.Size(167, 52);
            this.btnTicriCagrBtr.TabIndex = 10;
            this.btnTicriCagrBtr.Text = "Ticari Müşteri Çağrıyı Bitir";
            this.btnTicriCagrBtr.UseVisualStyleBackColor = true;
            this.btnTicriCagrBtr.Click += new System.EventHandler(this.btnTicriCagrBtr_Click);
            // 
            // btnCgrID
            // 
            this.btnCgrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCgrID.Location = new System.Drawing.Point(167, 483);
            this.btnCgrID.Name = "btnCgrID";
            this.btnCgrID.Size = new System.Drawing.Size(181, 56);
            this.btnCgrID.TabIndex = 11;
            this.btnCgrID.Text = "Seçilen Çağrı ID \'yi En öne Koyun";
            this.btnCgrID.UseVisualStyleBackColor = true;
            this.btnCgrID.Click += new System.EventHandler(this.btnCgrID_Click);
            // 
            // txtBxOnclkID
            // 
            this.txtBxOnclkID.Location = new System.Drawing.Point(37, 503);
            this.txtBxOnclkID.Name = "txtBxOnclkID";
            this.txtBxOnclkID.Size = new System.Drawing.Size(104, 20);
            this.txtBxOnclkID.TabIndex = 12;
            // 
            // btnCagrilar
            // 
            this.btnCagrilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCagrilar.Location = new System.Drawing.Point(713, 38);
            this.btnCagrilar.Name = "btnCagrilar";
            this.btnCagrilar.Size = new System.Drawing.Size(155, 52);
            this.btnCagrilar.TabIndex = 13;
            this.btnCagrilar.Text = "Yapılan Çağrıları Gör";
            this.btnCagrilar.UseVisualStyleBackColor = true;
            this.btnCagrilar.Click += new System.EventHandler(this.btnCagrilar_Click);
            // 
            // lstBxBtnCagrilar
            // 
            this.lstBxBtnCagrilar.FormattingEnabled = true;
            this.lstBxBtnCagrilar.Items.AddRange(new object[] {
            "Çağrı ID    Müşteri ID       Müşteri Tipi                      "});
            this.lstBxBtnCagrilar.Location = new System.Drawing.Point(685, 96);
            this.lstBxBtnCagrilar.Name = "lstBxBtnCagrilar";
            this.lstBxBtnCagrilar.Size = new System.Drawing.Size(208, 173);
            this.lstBxBtnCagrilar.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 574);
            this.Controls.Add(this.lstBxBtnCagrilar);
            this.Controls.Add(this.btnCagrilar);
            this.Controls.Add(this.txtBxOnclkID);
            this.Controls.Add(this.btnCgrID);
            this.Controls.Add(this.btnTicriCagrBtr);
            this.Controls.Add(this.btnBryselCgriBtir);
            this.Controls.Add(this.btnCagriAta);
            this.Controls.Add(this.lstBxCagrilar);
            this.Controls.Add(this.txtBxMusteriID);
            this.Controls.Add(this.lblMusteriID);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblMusteriTip);
            this.Controls.Add(this.cmBxMsteriTip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBxMsteriTip;
        private System.Windows.Forms.Label lblMusteriTip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.TextBox txtBxMusteriID;
        private System.Windows.Forms.ListBox lstBxCagrilar;
        private System.Windows.Forms.Button btnCagriAta;
        private System.Windows.Forms.Button btnBryselCgriBtir;
        private System.Windows.Forms.Button btnTicriCagrBtr;
        private System.Windows.Forms.Button btnCgrID;
        private System.Windows.Forms.TextBox txtBxOnclkID;
        private System.Windows.Forms.Button btnCagrilar;
        private System.Windows.Forms.ListBox lstBxBtnCagrilar;
    }
}

