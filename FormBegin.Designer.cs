﻿namespace golf_net
{
	partial class FormBegin
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtIp = new System.Windows.Forms.TextBox();
			this.txtPt = new System.Windows.Forms.TextBox();
			this.lblIp = new System.Windows.Forms.Label();
			this.lblPt = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtUID = new System.Windows.Forms.TextBox();
			this.txtPWD = new System.Windows.Forms.TextBox();
			this.lblUID = new System.Windows.Forms.Label();
			this.lblPWD = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtIp
			// 
			this.txtIp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtIp.Location = new System.Drawing.Point(86, 25);
			this.txtIp.Margin = new System.Windows.Forms.Padding(4);
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size(129, 24);
			this.txtIp.TabIndex = 0;
			// 
			// txtPt
			// 
			this.txtPt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtPt.Location = new System.Drawing.Point(257, 25);
			this.txtPt.Margin = new System.Windows.Forms.Padding(4);
			this.txtPt.Name = "txtPt";
			this.txtPt.Size = new System.Drawing.Size(58, 24);
			this.txtPt.TabIndex = 1;
			this.txtPt.TextChanged += new System.EventHandler(this.txtPt_TextChanged);
			// 
			// lblIp
			// 
			this.lblIp.AutoSize = true;
			this.lblIp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblIp.Location = new System.Drawing.Point(58, 28);
			this.lblIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIp.Name = "lblIp";
			this.lblIp.Size = new System.Drawing.Size(20, 17);
			this.lblIp.TabIndex = 7;
			this.lblIp.Text = "IP";
			// 
			// lblPt
			// 
			this.lblPt.AutoSize = true;
			this.lblPt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblPt.Location = new System.Drawing.Point(224, 28);
			this.lblPt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPt.Name = "lblPt";
			this.lblPt.Size = new System.Drawing.Size(34, 17);
			this.lblPt.TabIndex = 8;
			this.lblPt.Text = "Port";
			this.lblPt.Click += new System.EventHandler(this.lblPt_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(86, 214);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(229, 54);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtUID
			// 
			this.txtUID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtUID.Location = new System.Drawing.Point(86, 155);
			this.txtUID.Margin = new System.Windows.Forms.Padding(4);
			this.txtUID.Name = "txtUID";
			this.txtUID.Size = new System.Drawing.Size(228, 24);
			this.txtUID.TabIndex = 2;
			// 
			// txtPWD
			// 
			this.txtPWD.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtPWD.Location = new System.Drawing.Point(86, 182);
			this.txtPWD.Margin = new System.Windows.Forms.Padding(4);
			this.txtPWD.Name = "txtPWD";
			this.txtPWD.Size = new System.Drawing.Size(228, 24);
			this.txtPWD.TabIndex = 3;
			// 
			// lblUID
			// 
			this.lblUID.AutoSize = true;
			this.lblUID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblUID.Location = new System.Drawing.Point(47, 162);
			this.lblUID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUID.Name = "lblUID";
			this.lblUID.Size = new System.Drawing.Size(31, 17);
			this.lblUID.TabIndex = 3;
			this.lblUID.Text = "UID";
			// 
			// lblPWD
			// 
			this.lblPWD.AutoSize = true;
			this.lblPWD.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblPWD.Location = new System.Drawing.Point(38, 189);
			this.lblPWD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPWD.Name = "lblPWD";
			this.lblPWD.Size = new System.Drawing.Size(40, 17);
			this.lblPWD.TabIndex = 4;
			this.lblPWD.Text = "PWD";
			// 
			// btnConnect
			// 
			this.btnConnect.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConnect.Location = new System.Drawing.Point(86, 55);
			this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(229, 47);
			this.btnConnect.TabIndex = 9;
			this.btnConnect.Text = "Connection";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// FormBegin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 300);
			this.ControlBox = false;
			this.Controls.Add(this.txtPt);
			this.Controls.Add(this.txtIp);
			this.Controls.Add(this.lblIp);
			this.Controls.Add(this.lblPt);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.lblPWD);
			this.Controls.Add(this.lblUID);
			this.Controls.Add(this.txtPWD);
			this.Controls.Add(this.txtUID);
			this.Controls.Add(this.btnLogin);
			this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormBegin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Begin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtIp;
		private System.Windows.Forms.TextBox txtPt;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Label lblIp;
		private System.Windows.Forms.Label lblPt;

		private System.Windows.Forms.TextBox txtUID;
		private System.Windows.Forms.TextBox txtPWD;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblUID;
		private System.Windows.Forms.Label lblPWD;
	}
}

