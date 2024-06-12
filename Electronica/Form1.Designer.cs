namespace Electronica
{
    partial class F
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
            btnAddToKart = new Button();
            CBoptions = new ComboBox();
            listView1 = new ListView();
            lbOptions = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            kart = new ListView();
            label11 = new Label();
            lblTotalPrice = new Label();
            btnRemoveFromKart = new Button();
            btnBuy = new Button();
            SalesHistory = new ListView();
            lbSaleshistory = new Label();
            btnExportToExcel = new Button();
            btnExportToWord = new Button();
            btnExportToPDF = new Button();
            label12 = new Label();
            btnExportToXML = new Button();
            btnExportToJson = new Button();
            btnExportToTXT = new Button();
            lblWarrenty = new Label();
            SuspendLayout();
            // 
            // btnAddToKart
            // 
            btnAddToKart.BackColor = Color.LightSeaGreen;
            btnAddToKart.FlatAppearance.BorderColor = Color.White;
            btnAddToKart.FlatStyle = FlatStyle.Popup;
            btnAddToKart.Location = new Point(53, 381);
            btnAddToKart.Name = "btnAddToKart";
            btnAddToKart.Size = new Size(199, 35);
            btnAddToKart.TabIndex = 0;
            btnAddToKart.Text = "Add To Kart";
            btnAddToKart.UseVisualStyleBackColor = false;
            btnAddToKart.Click += BtnAddToKart_Click;
            // 
            // CBoptions
            // 
            CBoptions.BackColor = Color.LightSeaGreen;
            CBoptions.FlatStyle = FlatStyle.Popup;
            CBoptions.FormattingEnabled = true;
            CBoptions.Items.AddRange(new object[] { "Cell Phones", "Computers", "Tablets" });
            CBoptions.Location = new Point(53, 77);
            CBoptions.Name = "CBoptions";
            CBoptions.Size = new Size(199, 28);
            CBoptions.TabIndex = 1;
            CBoptions.SelectedIndexChanged += CBoptions_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Aquamarine;
            listView1.Location = new Point(53, 111);
            listView1.Name = "listView1";
            listView1.Size = new Size(199, 264);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            // 
            // lbOptions
            // 
            lbOptions.AutoSize = true;
            lbOptions.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbOptions.Location = new Point(90, 28);
            lbOptions.Name = "lbOptions";
            lbOptions.Size = new Size(108, 35);
            lbOptions.TabIndex = 4;
            lbOptions.Text = "Options";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(273, 85);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 5;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(273, 111);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 6;
            label2.Text = "Brand and Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(273, 141);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 7;
            label3.Text = "Screen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(276, 171);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 8;
            label4.Text = "Processor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label5.Location = new Point(276, 200);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 9;
            label5.Text = "RAM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label6.Location = new Point(276, 232);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 10;
            label6.Text = "Storage";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label7.Location = new Point(276, 263);
            label7.Name = "label7";
            label7.Size = new Size(121, 25);
            label7.TabIndex = 11;
            label7.Text = "Main Camera";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label8.Location = new Point(276, 292);
            label8.Name = "label8";
            label8.Size = new Size(124, 25);
            label8.TabIndex = 12;
            label8.Text = "Front Camera";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label9.Location = new Point(276, 324);
            label9.Name = "label9";
            label9.Size = new Size(73, 25);
            label9.TabIndex = 13;
            label9.Text = "Battery";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label10.Location = new Point(276, 355);
            label10.Name = "label10";
            label10.Size = new Size(53, 25);
            label10.TabIndex = 14;
            label10.Text = "Price";
            // 
            // kart
            // 
            kart.BackColor = Color.Aquamarine;
            kart.Location = new Point(633, 85);
            kart.Name = "kart";
            kart.Size = new Size(456, 243);
            kart.TabIndex = 15;
            kart.UseCompatibleStateImageBehavior = false;
            kart.View = View.Details;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label11.Location = new Point(844, 38);
            label11.Name = "label11";
            label11.Size = new Size(65, 35);
            label11.TabIndex = 16;
            label11.Text = "Kart";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTotalPrice.Location = new Point(1113, 85);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(57, 25);
            lblTotalPrice.TabIndex = 17;
            lblTotalPrice.Text = "Price:";
            // 
            // btnRemoveFromKart
            // 
            btnRemoveFromKart.BackColor = Color.LightSeaGreen;
            btnRemoveFromKart.FlatStyle = FlatStyle.Popup;
            btnRemoveFromKart.Location = new Point(1095, 146);
            btnRemoveFromKart.Name = "btnRemoveFromKart";
            btnRemoveFromKart.Size = new Size(199, 29);
            btnRemoveFromKart.TabIndex = 18;
            btnRemoveFromKart.Text = "Remove from kart";
            btnRemoveFromKart.UseVisualStyleBackColor = false;
            btnRemoveFromKart.Click += BtnRemoveFromKart_Click;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.LightSeaGreen;
            btnBuy.FlatStyle = FlatStyle.Popup;
            btnBuy.Location = new Point(1095, 111);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(199, 29);
            btnBuy.TabIndex = 19;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += BtnBuy_Click;
            // 
            // SalesHistory
            // 
            SalesHistory.BackColor = Color.Aquamarine;
            SalesHistory.Location = new Point(53, 446);
            SalesHistory.Name = "SalesHistory";
            SalesHistory.Size = new Size(1018, 259);
            SalesHistory.TabIndex = 20;
            SalesHistory.UseCompatibleStateImageBehavior = false;
            SalesHistory.View = View.Details;
            // 
            // lbSaleshistory
            // 
            lbSaleshistory.AutoSize = true;
            lbSaleshistory.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbSaleshistory.Location = new Point(482, 407);
            lbSaleshistory.Name = "lbSaleshistory";
            lbSaleshistory.Size = new Size(163, 35);
            lbSaleshistory.TabIndex = 21;
            lbSaleshistory.Text = "Sales history";
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.BackColor = Color.LightSeaGreen;
            btnExportToExcel.FlatStyle = FlatStyle.Popup;
            btnExportToExcel.Location = new Point(1087, 460);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(261, 29);
            btnExportToExcel.TabIndex = 22;
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.UseVisualStyleBackColor = false;
            btnExportToExcel.Click += BtnExportToExcel_Click;
            // 
            // btnExportToWord
            // 
            btnExportToWord.BackColor = Color.LightSeaGreen;
            btnExportToWord.FlatStyle = FlatStyle.Popup;
            btnExportToWord.Location = new Point(1087, 495);
            btnExportToWord.Name = "btnExportToWord";
            btnExportToWord.Size = new Size(261, 29);
            btnExportToWord.TabIndex = 23;
            btnExportToWord.Text = "Export to Word";
            btnExportToWord.UseVisualStyleBackColor = false;
            btnExportToWord.Click += BtnExportToWord_Click;
            // 
            // btnExportToPDF
            // 
            btnExportToPDF.BackColor = Color.LightSeaGreen;
            btnExportToPDF.FlatStyle = FlatStyle.Popup;
            btnExportToPDF.Location = new Point(1087, 530);
            btnExportToPDF.Name = "btnExportToPDF";
            btnExportToPDF.Size = new Size(261, 29);
            btnExportToPDF.TabIndex = 24;
            btnExportToPDF.Text = "Export to PDF";
            btnExportToPDF.UseVisualStyleBackColor = false;
            btnExportToPDF.Click += BtnExportToPDF_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label12.Location = new Point(1135, 407);
            label12.Name = "label12";
            label12.Size = new Size(159, 35);
            label12.TabIndex = 25;
            label12.Text = "Save history";
            // 
            // btnExportToXML
            // 
            btnExportToXML.BackColor = Color.LightSeaGreen;
            btnExportToXML.FlatStyle = FlatStyle.Popup;
            btnExportToXML.Location = new Point(1087, 565);
            btnExportToXML.Name = "btnExportToXML";
            btnExportToXML.Size = new Size(261, 29);
            btnExportToXML.TabIndex = 26;
            btnExportToXML.Text = "Export to XML";
            btnExportToXML.UseVisualStyleBackColor = false;
            btnExportToXML.Click += BtnExportToXML_Click;
            // 
            // btnExportToJson
            // 
            btnExportToJson.BackColor = Color.LightSeaGreen;
            btnExportToJson.FlatStyle = FlatStyle.Popup;
            btnExportToJson.Location = new Point(1087, 600);
            btnExportToJson.Name = "btnExportToJson";
            btnExportToJson.Size = new Size(261, 29);
            btnExportToJson.TabIndex = 27;
            btnExportToJson.Text = "Export to Json";
            btnExportToJson.UseVisualStyleBackColor = false;
            btnExportToJson.Click += BtnExportToJson_Click;
            // 
            // btnExportToTXT
            // 
            btnExportToTXT.BackColor = Color.LightSeaGreen;
            btnExportToTXT.FlatStyle = FlatStyle.Popup;
            btnExportToTXT.Location = new Point(1087, 635);
            btnExportToTXT.Name = "btnExportToTXT";
            btnExportToTXT.Size = new Size(261, 29);
            btnExportToTXT.TabIndex = 28;
            btnExportToTXT.Text = "Export to TXT";
            btnExportToTXT.UseVisualStyleBackColor = false;
            btnExportToTXT.Click += BtnExportToTXT_Click;
            // 
            // lblWarrenty
            // 
            lblWarrenty.AutoSize = true;
            lblWarrenty.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblWarrenty.Location = new Point(276, 384);
            lblWarrenty.Name = "lblWarrenty";
            lblWarrenty.Size = new Size(88, 25);
            lblWarrenty.TabIndex = 29;
            lblWarrenty.Text = "Warrenty";
            // 
            // F
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1412, 717);
            Controls.Add(lblWarrenty);
            Controls.Add(btnExportToTXT);
            Controls.Add(btnExportToJson);
            Controls.Add(btnExportToXML);
            Controls.Add(label12);
            Controls.Add(btnExportToPDF);
            Controls.Add(btnExportToWord);
            Controls.Add(btnExportToExcel);
            Controls.Add(lbSaleshistory);
            Controls.Add(SalesHistory);
            Controls.Add(btnBuy);
            Controls.Add(btnRemoveFromKart);
            Controls.Add(lblTotalPrice);
            Controls.Add(label11);
            Controls.Add(kart);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbOptions);
            Controls.Add(listView1);
            Controls.Add(CBoptions);
            Controls.Add(btnAddToKart);
            Name = "F";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddToKart;
        private ComboBox CBoptions;
        private ListView listView1;
        private Label lbOptions;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListView kart;
        private Label label11;
        private Label lblTotalPrice;
        private Button btnRemoveFromKart;
        private Button btnBuy;
        private ListView SalesHistory;
        private Label lbSaleshistory;
        private Button btnExportToExcel;
        private Button btnExportToWord;
        private Button btnExportToPDF;
        private Label label12;
        private Button btnExportToXML;
        private Button btnExportToJson;
        private Button btnExportToTXT;
        private Label lblWarrenty;
    }
}
