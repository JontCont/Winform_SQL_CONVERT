namespace SCM_Convert
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Sup = new System.Windows.Forms.Button();
            this.Btn_SigleHead = new System.Windows.Forms.Button();
            this.Btn_Details = new System.Windows.Forms.Button();
            this.Btn_ProData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Comm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Sup
            // 
            this.Btn_Sup.Location = new System.Drawing.Point(67, 27);
            this.Btn_Sup.Name = "Btn_Sup";
            this.Btn_Sup.Size = new System.Drawing.Size(105, 67);
            this.Btn_Sup.TabIndex = 0;
            this.Btn_Sup.Text = "供應商";
            this.Btn_Sup.UseVisualStyleBackColor = true;
            this.Btn_Sup.Click += new System.EventHandler(this.Btn_Sup_Click);
            // 
            // Btn_SigleHead
            // 
            this.Btn_SigleHead.Location = new System.Drawing.Point(67, 129);
            this.Btn_SigleHead.Name = "Btn_SigleHead";
            this.Btn_SigleHead.Size = new System.Drawing.Size(105, 67);
            this.Btn_SigleHead.TabIndex = 1;
            this.Btn_SigleHead.Text = "採購單頭";
            this.Btn_SigleHead.UseVisualStyleBackColor = true;
            this.Btn_SigleHead.Click += new System.EventHandler(this.Btn_SigleHead_Click);
            // 
            // Btn_Details
            // 
            this.Btn_Details.Location = new System.Drawing.Point(67, 224);
            this.Btn_Details.Name = "Btn_Details";
            this.Btn_Details.Size = new System.Drawing.Size(105, 67);
            this.Btn_Details.TabIndex = 2;
            this.Btn_Details.Text = "採購明細";
            this.Btn_Details.UseVisualStyleBackColor = true;
            this.Btn_Details.Click += new System.EventHandler(this.Btn_Details_Click);
            // 
            // Btn_ProData
            // 
            this.Btn_ProData.Location = new System.Drawing.Point(67, 312);
            this.Btn_ProData.Name = "Btn_ProData";
            this.Btn_ProData.Size = new System.Drawing.Size(105, 67);
            this.Btn_ProData.TabIndex = 3;
            this.Btn_ProData.Text = "料件檔";
            this.Btn_ProData.UseVisualStyleBackColor = true;
            this.Btn_ProData.Click += new System.EventHandler(this.Btn_ProData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // btn_Comm
            // 
            this.btn_Comm.Location = new System.Drawing.Point(144, 410);
            this.btn_Comm.Name = "btn_Comm";
            this.btn_Comm.Size = new System.Drawing.Size(84, 39);
            this.btn_Comm.TabIndex = 5;
            this.btn_Comm.Text = "連線";
            this.btn_Comm.UseVisualStyleBackColor = true;
            this.btn_Comm.Click += new System.EventHandler(this.btn_Comm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 461);
            this.Controls.Add(this.btn_Comm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ProData);
            this.Controls.Add(this.Btn_Details);
            this.Controls.Add(this.Btn_SigleHead);
            this.Controls.Add(this.Btn_Sup);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sup;
        private System.Windows.Forms.Button Btn_SigleHead;
        private System.Windows.Forms.Button Btn_Details;
        private System.Windows.Forms.Button Btn_ProData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Comm;
    }
}

