namespace BudgetView
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlInput = new System.Windows.Forms.TabControl();
            this.tabPageInput = new System.Windows.Forms.TabPage();
            this.grpOut = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelOut = new System.Windows.Forms.TableLayoutPanel();
            this.lblSonstiges = new System.Windows.Forms.Label();
            this.txtHaushalt = new System.Windows.Forms.TextBox();
            this.txtBuecher = new System.Windows.Forms.TextBox();
            this.lblBuecher = new System.Windows.Forms.Label();
            this.lblLuxus = new System.Windows.Forms.Label();
            this.txtHardware = new System.Windows.Forms.TextBox();
            this.txtMonatlich = new System.Windows.Forms.TextBox();
            this.txtGames = new System.Windows.Forms.TextBox();
            this.lblEssen = new System.Windows.Forms.Label();
            this.lblHardware = new System.Windows.Forms.Label();
            this.lblGames = new System.Windows.Forms.Label();
            this.lblMonatlich = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLuxus = new System.Windows.Forms.TextBox();
            this.lblHaushalt = new System.Windows.Forms.Label();
            this.txtSonstiges = new System.Windows.Forms.TextBox();
            this.btnSubmitOut = new System.Windows.Forms.Button();
            this.grpIn = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelIn = new System.Windows.Forms.TableLayoutPanel();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnSubmitIn = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControlInput.SuspendLayout();
            this.tabPageInput.SuspendLayout();
            this.grpOut.SuspendLayout();
            this.tableLayoutPanelOut.SuspendLayout();
            this.grpIn.SuspendLayout();
            this.tableLayoutPanelIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControlInput);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 605);
            this.panel1.TabIndex = 0;
            // 
            // tabControlInput
            // 
            this.tabControlInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlInput.Controls.Add(this.tabPageInput);
            this.tabControlInput.Controls.Add(this.tabPage2);
            this.tabControlInput.Controls.Add(this.tabPage3);
            this.tabControlInput.Controls.Add(this.tabPage4);
            this.tabControlInput.Location = new System.Drawing.Point(4, 4);
            this.tabControlInput.Name = "tabControlInput";
            this.tabControlInput.SelectedIndex = 0;
            this.tabControlInput.Size = new System.Drawing.Size(1005, 598);
            this.tabControlInput.TabIndex = 0;
            // 
            // tabPageInput
            // 
            this.tabPageInput.Controls.Add(this.grpOut);
            this.tabPageInput.Controls.Add(this.grpIn);
            this.tabPageInput.Location = new System.Drawing.Point(4, 22);
            this.tabPageInput.Name = "tabPageInput";
            this.tabPageInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInput.Size = new System.Drawing.Size(997, 572);
            this.tabPageInput.TabIndex = 0;
            this.tabPageInput.Text = "Dateneingabe";
            this.tabPageInput.UseVisualStyleBackColor = true;
            // 
            // grpOut
            // 
            this.grpOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOut.Controls.Add(this.tableLayoutPanelOut);
            this.grpOut.Location = new System.Drawing.Point(480, 3);
            this.grpOut.Name = "grpOut";
            this.grpOut.Size = new System.Drawing.Size(514, 566);
            this.grpOut.TabIndex = 2;
            this.grpOut.TabStop = false;
            this.grpOut.Text = "Ausgaben";
            // 
            // tableLayoutPanelOut
            // 
            this.tableLayoutPanelOut.ColumnCount = 2;
            this.tableLayoutPanelOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.18673F));
            this.tableLayoutPanelOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.81327F));
            this.tableLayoutPanelOut.Controls.Add(this.lblSonstiges, 0, 7);
            this.tableLayoutPanelOut.Controls.Add(this.txtHaushalt, 1, 6);
            this.tableLayoutPanelOut.Controls.Add(this.txtBuecher, 1, 5);
            this.tableLayoutPanelOut.Controls.Add(this.lblBuecher, 0, 5);
            this.tableLayoutPanelOut.Controls.Add(this.lblLuxus, 0, 4);
            this.tableLayoutPanelOut.Controls.Add(this.txtHardware, 1, 3);
            this.tableLayoutPanelOut.Controls.Add(this.txtMonatlich, 1, 2);
            this.tableLayoutPanelOut.Controls.Add(this.txtGames, 1, 1);
            this.tableLayoutPanelOut.Controls.Add(this.lblEssen, 0, 0);
            this.tableLayoutPanelOut.Controls.Add(this.lblHardware, 0, 3);
            this.tableLayoutPanelOut.Controls.Add(this.lblGames, 0, 1);
            this.tableLayoutPanelOut.Controls.Add(this.lblMonatlich, 0, 2);
            this.tableLayoutPanelOut.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanelOut.Controls.Add(this.txtLuxus, 1, 4);
            this.tableLayoutPanelOut.Controls.Add(this.lblHaushalt, 0, 6);
            this.tableLayoutPanelOut.Controls.Add(this.txtSonstiges, 1, 7);
            this.tableLayoutPanelOut.Controls.Add(this.btnSubmitOut, 0, 9);
            this.tableLayoutPanelOut.Location = new System.Drawing.Point(16, 55);
            this.tableLayoutPanelOut.Name = "tableLayoutPanelOut";
            this.tableLayoutPanelOut.RowCount = 10;
            this.tableLayoutPanelOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.88163F));
            this.tableLayoutPanelOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.55191F));
            this.tableLayoutPanelOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.13508F));
            this.tableLayoutPanelOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.94742F));
            this.tableLayoutPanelOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.87576F));
            this.tableLayoutPanelOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.77385F));
            this.tableLayoutPanelOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.29456F));
            this.tableLayoutPanelOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.539788F));
            this.tableLayoutPanelOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanelOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelOut.Size = new System.Drawing.Size(407, 460);
            this.tableLayoutPanelOut.TabIndex = 0;
            // 
            // lblSonstiges
            // 
            this.lblSonstiges.AutoSize = true;
            this.lblSonstiges.Location = new System.Drawing.Point(3, 272);
            this.lblSonstiges.Name = "lblSonstiges";
            this.lblSonstiges.Size = new System.Drawing.Size(53, 13);
            this.lblSonstiges.TabIndex = 14;
            this.lblSonstiges.Text = "Sonstiges";
            // 
            // txtHaushalt
            // 
            this.txtHaushalt.Location = new System.Drawing.Point(133, 241);
            this.txtHaushalt.Name = "txtHaushalt";
            this.txtHaushalt.Size = new System.Drawing.Size(100, 20);
            this.txtHaushalt.TabIndex = 13;
            // 
            // txtBuecher
            // 
            this.txtBuecher.Location = new System.Drawing.Point(133, 200);
            this.txtBuecher.Name = "txtBuecher";
            this.txtBuecher.Size = new System.Drawing.Size(100, 20);
            this.txtBuecher.TabIndex = 12;
            // 
            // lblBuecher
            // 
            this.lblBuecher.AutoSize = true;
            this.lblBuecher.Location = new System.Drawing.Point(3, 197);
            this.lblBuecher.Name = "lblBuecher";
            this.lblBuecher.Size = new System.Drawing.Size(41, 13);
            this.lblBuecher.TabIndex = 10;
            this.lblBuecher.Text = "Bücher";
            // 
            // lblLuxus
            // 
            this.lblLuxus.AutoSize = true;
            this.lblLuxus.Location = new System.Drawing.Point(3, 153);
            this.lblLuxus.Name = "lblLuxus";
            this.lblLuxus.Size = new System.Drawing.Size(35, 13);
            this.lblLuxus.TabIndex = 9;
            this.lblLuxus.Text = "Luxus";
            // 
            // txtHardware
            // 
            this.txtHardware.Location = new System.Drawing.Point(133, 117);
            this.txtHardware.Name = "txtHardware";
            this.txtHardware.Size = new System.Drawing.Size(100, 20);
            this.txtHardware.TabIndex = 7;
            // 
            // txtMonatlich
            // 
            this.txtMonatlich.Location = new System.Drawing.Point(133, 75);
            this.txtMonatlich.Name = "txtMonatlich";
            this.txtMonatlich.Size = new System.Drawing.Size(100, 20);
            this.txtMonatlich.TabIndex = 6;
            // 
            // txtGames
            // 
            this.txtGames.Location = new System.Drawing.Point(133, 41);
            this.txtGames.Name = "txtGames";
            this.txtGames.Size = new System.Drawing.Size(100, 20);
            this.txtGames.TabIndex = 5;
            // 
            // lblEssen
            // 
            this.lblEssen.AutoSize = true;
            this.lblEssen.Location = new System.Drawing.Point(3, 0);
            this.lblEssen.Name = "lblEssen";
            this.lblEssen.Size = new System.Drawing.Size(36, 13);
            this.lblEssen.TabIndex = 0;
            this.lblEssen.Text = "Essen";
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Location = new System.Drawing.Point(3, 114);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(104, 13);
            this.lblHardware.TabIndex = 4;
            this.lblHardware.Text = "Hardware / Gadgets";
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Location = new System.Drawing.Point(3, 38);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(40, 13);
            this.lblGames.TabIndex = 2;
            this.lblGames.Text = "Games";
            // 
            // lblMonatlich
            // 
            this.lblMonatlich.AutoSize = true;
            this.lblMonatlich.Location = new System.Drawing.Point(3, 72);
            this.lblMonatlich.Name = "lblMonatlich";
            this.lblMonatlich.Size = new System.Drawing.Size(78, 13);
            this.lblMonatlich.TabIndex = 3;
            this.lblMonatlich.Text = "Monatl. Kosten";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtLuxus
            // 
            this.txtLuxus.Location = new System.Drawing.Point(133, 156);
            this.txtLuxus.Name = "txtLuxus";
            this.txtLuxus.Size = new System.Drawing.Size(100, 20);
            this.txtLuxus.TabIndex = 8;
            // 
            // lblHaushalt
            // 
            this.lblHaushalt.AutoSize = true;
            this.lblHaushalt.Location = new System.Drawing.Point(3, 238);
            this.lblHaushalt.Name = "lblHaushalt";
            this.lblHaushalt.Size = new System.Drawing.Size(49, 13);
            this.lblHaushalt.TabIndex = 11;
            this.lblHaushalt.Text = "Haushalt";
            // 
            // txtSonstiges
            // 
            this.txtSonstiges.Location = new System.Drawing.Point(133, 275);
            this.txtSonstiges.Name = "txtSonstiges";
            this.txtSonstiges.Size = new System.Drawing.Size(100, 20);
            this.txtSonstiges.TabIndex = 13;
            // 
            // btnSubmitOut
            // 
            this.btnSubmitOut.Location = new System.Drawing.Point(3, 408);
            this.btnSubmitOut.Name = "btnSubmitOut";
            this.btnSubmitOut.Size = new System.Drawing.Size(117, 23);
            this.btnSubmitOut.TabIndex = 15;
            this.btnSubmitOut.Text = "Daten übernehmen";
            this.btnSubmitOut.UseVisualStyleBackColor = true;
            this.btnSubmitOut.Click += new System.EventHandler(this.btnSubmitOut_Click);
            // 
            // grpIn
            // 
            this.grpIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpIn.Controls.Add(this.tableLayoutPanelIn);
            this.grpIn.Location = new System.Drawing.Point(7, 7);
            this.grpIn.Name = "grpIn";
            this.grpIn.Size = new System.Drawing.Size(463, 559);
            this.grpIn.TabIndex = 1;
            this.grpIn.TabStop = false;
            this.grpIn.Text = "Einnahmen";
            // 
            // tableLayoutPanelIn
            // 
            this.tableLayoutPanelIn.ColumnCount = 2;
            this.tableLayoutPanelIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.18673F));
            this.tableLayoutPanelIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.81327F));
            this.tableLayoutPanelIn.Controls.Add(this.lblInput, 0, 0);
            this.tableLayoutPanelIn.Controls.Add(this.btnSubmitIn, 0, 2);
            this.tableLayoutPanelIn.Controls.Add(this.textBox7, 1, 0);
            this.tableLayoutPanelIn.Location = new System.Drawing.Point(30, 62);
            this.tableLayoutPanelIn.Name = "tableLayoutPanelIn";
            this.tableLayoutPanelIn.RowCount = 3;
            this.tableLayoutPanelIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.904232F));
            this.tableLayoutPanelIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.84633F));
            this.tableLayoutPanelIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.47216F));
            this.tableLayoutPanelIn.Size = new System.Drawing.Size(407, 449);
            this.tableLayoutPanelIn.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(3, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(60, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Einnahmen";
            // 
            // btnSubmitIn
            // 
            this.btnSubmitIn.Location = new System.Drawing.Point(3, 395);
            this.btnSubmitIn.Name = "btnSubmitIn";
            this.btnSubmitIn.Size = new System.Drawing.Size(117, 23);
            this.btnSubmitIn.TabIndex = 15;
            this.btnSubmitIn.Text = "Daten übernehmen";
            this.btnSubmitIn.UseVisualStyleBackColor = true;
            this.btnSubmitIn.Click += new System.EventHandler(this.btnSubmitIn_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(133, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(997, 572);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(997, 572);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 630);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tabControlInput.ResumeLayout(false);
            this.tabPageInput.ResumeLayout(false);
            this.grpOut.ResumeLayout(false);
            this.tableLayoutPanelOut.ResumeLayout(false);
            this.tableLayoutPanelOut.PerformLayout();
            this.grpIn.ResumeLayout(false);
            this.tableLayoutPanelIn.ResumeLayout(false);
            this.tableLayoutPanelIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlInput;
        private System.Windows.Forms.TabPage tabPageInput;
        private System.Windows.Forms.GroupBox grpOut;
        private System.Windows.Forms.GroupBox grpIn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblEssen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Label lblMonatlich;
        private System.Windows.Forms.Label lblHardware;
        private System.Windows.Forms.TextBox txtGames;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOut;
        private System.Windows.Forms.Label lblLuxus;
        private System.Windows.Forms.TextBox txtHardware;
        private System.Windows.Forms.TextBox txtMonatlich;
        private System.Windows.Forms.TextBox txtLuxus;
        private System.Windows.Forms.TextBox txtHaushalt;
        private System.Windows.Forms.TextBox txtBuecher;
        private System.Windows.Forms.Label lblBuecher;
        private System.Windows.Forms.Label lblHaushalt;
        private System.Windows.Forms.Label lblSonstiges;
        private System.Windows.Forms.TextBox txtSonstiges;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelIn;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnSubmitOut;
        private System.Windows.Forms.Button btnSubmitIn;
    }
}

