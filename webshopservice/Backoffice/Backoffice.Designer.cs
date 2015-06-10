namespace Backoffice
{
    partial class Backoffice
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
            this.lblShipped = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.ListBox();
            this.btnShip = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShipped
            // 
            this.lblShipped.AutoSize = true;
            this.lblShipped.Location = new System.Drawing.Point(21, 23);
            this.lblShipped.Name = "lblShipped";
            this.lblShipped.Size = new System.Drawing.Size(78, 13);
            this.lblShipped.TabIndex = 0;
            this.lblShipped.Text = "no shipping yet";
            // 
            // lbTime
            // 
            this.lbTime.FormattingEnabled = true;
            this.lbTime.Location = new System.Drawing.Point(130, 87);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(120, 95);
            this.lbTime.TabIndex = 1;
            // 
            // btnShip
            // 
            this.btnShip.Location = new System.Drawing.Point(4, 188);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(120, 23);
            this.btnShip.TabIndex = 2;
            this.btnShip.Text = "ship order";
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(21, 71);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(93, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "id ordered product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "time ordered";
            // 
            // lbId
            // 
            this.lbId.FormattingEnabled = true;
            this.lbId.Location = new System.Drawing.Point(4, 87);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(120, 95);
            this.lbId.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "update orders";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Backoffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 221);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnShip);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lblShipped);
            this.Name = "Backoffice";
            this.Text = "Backend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShipped;
        private System.Windows.Forms.ListBox lbTime;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbId;
        private System.Windows.Forms.Button btnUpdate;
    }
}

