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
            this.lMessage = new System.Windows.Forms.Label();
            this.btn_Comm = new System.Windows.Forms.Button();
            this.Btn_setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Sup
            // 
            this.Btn_Sup.Location = new System.Drawing.Point(111, 11);
            this.Btn_Sup.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Sup.Name = "Btn_Sup";
            this.Btn_Sup.Size = new System.Drawing.Size(79, 54);
            this.Btn_Sup.TabIndex = 0;
            this.Btn_Sup.Text = "供應商";
            this.Btn_Sup.UseVisualStyleBackColor = true;
            this.Btn_Sup.Click += new System.EventHandler(this.Btn_Sup_Click);
            // 
            // Btn_SigleHead
            // 
            this.Btn_SigleHead.Location = new System.Drawing.Point(11, 11);
            this.Btn_SigleHead.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SigleHead.Name = "Btn_SigleHead";
            this.Btn_SigleHead.Size = new System.Drawing.Size(79, 54);
            this.Btn_SigleHead.TabIndex = 1;
            this.Btn_SigleHead.Text = "採購單頭";
            this.Btn_SigleHead.UseVisualStyleBackColor = true;
            this.Btn_SigleHead.Click += new System.EventHandler(this.Btn_SigleHead_Click);
            // 
            // Btn_Details
            // 
            this.Btn_Details.Location = new System.Drawing.Point(11, 78);
            this.Btn_Details.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Details.Name = "Btn_Details";
            this.Btn_Details.Size = new System.Drawing.Size(79, 54);
            this.Btn_Details.TabIndex = 2;
            this.Btn_Details.Text = "採購明細";
            this.Btn_Details.UseVisualStyleBackColor = true;
            this.Btn_Details.Click += new System.EventHandler(this.Btn_Details_Click);
            // 
            // Btn_ProData
            // 
            this.Btn_ProData.Location = new System.Drawing.Point(112, 78);
            this.Btn_ProData.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ProData.Name = "Btn_ProData";
            this.Btn_ProData.Size = new System.Drawing.Size(79, 54);
            this.Btn_ProData.TabIndex = 3;
            this.Btn_ProData.Text = "料件檔";
            this.Btn_ProData.UseVisualStyleBackColor = true;
            this.Btn_ProData.Click += new System.EventHandler(this.Btn_ProData_Click);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Location = new System.Drawing.Point(20, 297);
            this.lMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(0, 12);
            this.lMessage.TabIndex = 4;
            // 
            // btn_Comm
            // 
            this.btn_Comm.Location = new System.Drawing.Point(128, 288);
            this.btn_Comm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Comm.Name = "btn_Comm";
            this.btn_Comm.Size = new System.Drawing.Size(63, 31);
            this.btn_Comm.TabIndex = 5;
            this.btn_Comm.Text = "連線";
            this.btn_Comm.UseVisualStyleBackColor = true;
            this.btn_Comm.Click += new System.EventHandler(this.btn_Comm_Click);
            // 
            // Btn_setting
            // 
            this.Btn_setting.Location = new System.Drawing.Point(127, 253);
            this.Btn_setting.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_setting.Name = "Btn_setting";
            this.Btn_setting.Size = new System.Drawing.Size(63, 31);
            this.Btn_setting.TabIndex = 6;
            this.Btn_setting.Text = "設定";
            this.Btn_setting.UseVisualStyleBackColor = true;
            this.Btn_setting.Click += new System.EventHandler(this.Btn_setting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 330);
            this.Controls.Add(this.Btn_setting);
            this.Controls.Add(this.btn_Comm);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.Btn_ProData);
            this.Controls.Add(this.Btn_Details);
            this.Controls.Add(this.Btn_SigleHead);
            this.Controls.Add(this.Btn_Sup);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Button btn_Comm;
        private System.Windows.Forms.Button Btn_setting;
    }
}

