namespace webshopclient
{
    partial class WebshopClient
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
            this.btnGetName = new System.Windows.Forms.Button();
            this.btnGetList = new System.Windows.Forms.Button();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.btnBuyProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.ListBox();
            this.lbPrice = new System.Windows.Forms.ListBox();
            this.lbStock = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetName
            // 
            this.btnGetName.Location = new System.Drawing.Point(12, 12);
            this.btnGetName.Name = "btnGetName";
            this.btnGetName.Size = new System.Drawing.Size(260, 50);
            this.btnGetName.TabIndex = 0;
            this.btnGetName.Text = "Get Webshop Name";
            this.btnGetName.UseVisualStyleBackColor = true;
            this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(12, 68);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(260, 50);
            this.btnGetList.TabIndex = 1;
            this.btnGetList.Text = "Get Product List";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(12, 124);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(260, 50);
            this.btnGetInfo.TabIndex = 2;
            this.btnGetInfo.Text = "Get Product Info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // btnBuyProduct
            // 
            this.btnBuyProduct.Location = new System.Drawing.Point(15, 180);
            this.btnBuyProduct.Name = "btnBuyProduct";
            this.btnBuyProduct.Size = new System.Drawing.Size(257, 50);
            this.btnBuyProduct.TabIndex = 3;
            this.btnBuyProduct.Text = "Buy Product";
            this.btnBuyProduct.UseVisualStyleBackColor = true;
            this.btnBuyProduct.Click += new System.EventHandler(this.btnBuyProduct_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(298, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(495, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "stock";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(438, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(298, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(253, 50);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "no name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbId
            // 
            this.lbId.FormattingEnabled = true;
            this.lbId.Location = new System.Drawing.Point(298, 124);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(134, 108);
            this.lbId.TabIndex = 8;
            // 
            // lbPrice
            // 
            this.lbPrice.FormattingEnabled = true;
            this.lbPrice.Location = new System.Drawing.Point(438, 124);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(51, 108);
            this.lbPrice.TabIndex = 9;
            // 
            // lbStock
            // 
            this.lbStock.FormattingEnabled = true;
            this.lbStock.Location = new System.Drawing.Point(495, 124);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(56, 108);
            this.lbStock.TabIndex = 10;
            // 
            // WebshopClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 248);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuyProduct);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.btnGetName);
            this.Name = "WebshopClient";
            this.Text = "WebshopClient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetName;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Button btnBuyProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbId;
        private System.Windows.Forms.ListBox lbPrice;
        private System.Windows.Forms.ListBox lbStock;
    }
}

