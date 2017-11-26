namespace golf_net
{
	partial class FormPlay
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
			if(disposing && (components != null))
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
			this.btnShot = new System.Windows.Forms.Button();
			this.btnPutt = new System.Windows.Forms.Button();
			this.btnResult = new System.Windows.Forms.Button();
			this.textThisPosX = new System.Windows.Forms.TextBox();
			this.textThisPosY = new System.Windows.Forms.TextBox();
			this.textThisPosZ = new System.Windows.Forms.TextBox();
			this.textThisDir = new System.Windows.Forms.TextBox();
			this.textThisCtX = new System.Windows.Forms.TextBox();
			this.textThisCtY = new System.Windows.Forms.TextBox();
			this.textThisClub = new System.Windows.Forms.TextBox();
			this.textThisPow = new System.Windows.Forms.TextBox();
			this.textThisBest = new System.Windows.Forms.TextBox();
			this.textThisStroke = new System.Windows.Forms.TextBox();
			this.textThisBonus = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textOtherBonus = new System.Windows.Forms.TextBox();
			this.textOtherStroke = new System.Windows.Forms.TextBox();
			this.textOtherBest = new System.Windows.Forms.TextBox();
			this.textOtherPow = new System.Windows.Forms.TextBox();
			this.textOtherClub = new System.Windows.Forms.TextBox();
			this.textOtherCtY = new System.Windows.Forms.TextBox();
			this.textOtherCtX = new System.Windows.Forms.TextBox();
			this.textOtherDir = new System.Windows.Forms.TextBox();
			this.textOtherPosZ = new System.Windows.Forms.TextBox();
			this.textOtherPosY = new System.Windows.Forms.TextBox();
			this.textOtherPosX = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// btnShot
			// 
			this.btnShot.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnShot.Location = new System.Drawing.Point(29, 250);
			this.btnShot.Name = "btnShot";
			this.btnShot.Size = new System.Drawing.Size(90, 40);
			this.btnShot.TabIndex = 11;
			this.btnShot.Text = "Shot";
			this.btnShot.UseVisualStyleBackColor = true;
			this.btnShot.Click += new System.EventHandler(this.Shot_Click);
			// 
			// btnPutt
			// 
			this.btnPutt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnPutt.Location = new System.Drawing.Point(145, 250);
			this.btnPutt.Name = "btnPutt";
			this.btnPutt.Size = new System.Drawing.Size(90, 40);
			this.btnPutt.TabIndex = 12;
			this.btnPutt.Text = "Putting";
			this.btnPutt.UseVisualStyleBackColor = true;
			this.btnPutt.Click += new System.EventHandler(this.Putt_Click);
			// 
			// btnResult
			// 
			this.btnResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnResult.Location = new System.Drawing.Point(261, 250);
			this.btnResult.Name = "btnResult";
			this.btnResult.Size = new System.Drawing.Size(90, 40);
			this.btnResult.TabIndex = 13;
			this.btnResult.Text = "Result";
			this.btnResult.UseVisualStyleBackColor = true;
			this.btnResult.Click += new System.EventHandler(this.Result_Click);
			// 
			// textThisPosX
			// 
			this.textThisPosX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textThisPosX.Location = new System.Drawing.Point(69, 57);
			this.textThisPosX.Name = "textThisPosX";
			this.textThisPosX.Size = new System.Drawing.Size(50, 22);
			this.textThisPosX.TabIndex = 1;
			this.textThisPosX.Text = "0";
			// 
			// textThisPosY
			// 
			this.textThisPosY.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textThisPosY.Location = new System.Drawing.Point(119, 57);
			this.textThisPosY.Name = "textThisPosY";
			this.textThisPosY.Size = new System.Drawing.Size(50, 22);
			this.textThisPosY.TabIndex = 2;
			this.textThisPosY.Text = "0";
			// 
			// textThisPosZ
			// 
			this.textThisPosZ.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textThisPosZ.Location = new System.Drawing.Point(169, 57);
			this.textThisPosZ.Name = "textThisPosZ";
			this.textThisPosZ.Size = new System.Drawing.Size(50, 22);
			this.textThisPosZ.TabIndex = 3;
			this.textThisPosZ.Text = "0";
			// 
			// textThisDir
			// 
			this.textThisDir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textThisDir.Location = new System.Drawing.Point(69, 80);
			this.textThisDir.Name = "textThisDir";
			this.textThisDir.Size = new System.Drawing.Size(50, 22);
			this.textThisDir.TabIndex = 4;
			this.textThisDir.Text = "0";
			// 
			// textThisCtX
			// 
			this.textThisCtX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textThisCtX.Location = new System.Drawing.Point(69, 103);
			this.textThisCtX.Name = "textThisCtX";
			this.textThisCtX.Size = new System.Drawing.Size(50, 22);
			this.textThisCtX.TabIndex = 5;
			this.textThisCtX.Text = "0";
			// 
			// textThisCtY
			// 
			this.textThisCtY.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textThisCtY.Location = new System.Drawing.Point(119, 103);
			this.textThisCtY.Name = "textThisCtY";
			this.textThisCtY.Size = new System.Drawing.Size(50, 22);
			this.textThisCtY.TabIndex = 6;
			this.textThisCtY.Text = "0";
			// 
			// textThisClub
			// 
			this.textThisClub.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textThisClub.Location = new System.Drawing.Point(69, 34);
			this.textThisClub.Name = "textThisClub";
			this.textThisClub.Size = new System.Drawing.Size(50, 22);
			this.textThisClub.TabIndex = 0;
			this.textThisClub.Text = "7";
			// 
			// textThisPow
			// 
			this.textThisPow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textThisPow.Location = new System.Drawing.Point(69, 126);
			this.textThisPow.Name = "textThisPow";
			this.textThisPow.Size = new System.Drawing.Size(50, 22);
			this.textThisPow.TabIndex = 7;
			this.textThisPow.Text = "30";
			// 
			// textThisBest
			// 
			this.textThisBest.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textThisBest.Location = new System.Drawing.Point(69, 149);
			this.textThisBest.Name = "textThisBest";
			this.textThisBest.Size = new System.Drawing.Size(50, 22);
			this.textThisBest.TabIndex = 8;
			this.textThisBest.Text = "100";
			// 
			// textThisStroke
			// 
			this.textThisStroke.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textThisStroke.Location = new System.Drawing.Point(69, 174);
			this.textThisStroke.Name = "textThisStroke";
			this.textThisStroke.ReadOnly = true;
			this.textThisStroke.Size = new System.Drawing.Size(50, 22);
			this.textThisStroke.TabIndex = 9;
			this.textThisStroke.Text = "0";
			// 
			// textThisBonus
			// 
			this.textThisBonus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textThisBonus.Location = new System.Drawing.Point(69, 198);
			this.textThisBonus.Name = "textThisBonus";
			this.textThisBonus.Size = new System.Drawing.Size(50, 22);
			this.textThisBonus.TabIndex = 10;
			this.textThisBonus.Text = "100";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(29, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 14);
			this.label1.TabIndex = 28;
			this.label1.Text = "위치";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(29, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 14);
			this.label2.TabIndex = 29;
			this.label2.Text = "방향";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(34, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 14);
			this.label3.TabIndex = 30;
			this.label3.Text = "CtP";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(30, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 14);
			this.label4.TabIndex = 27;
			this.label4.Text = "Club";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(18, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 14);
			this.label5.TabIndex = 31;
			this.label5.Text = "Power";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(29, 154);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 14);
			this.label6.TabIndex = 32;
			this.label6.Text = "Best";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(17, 177);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 14);
			this.label7.TabIndex = 33;
			this.label7.Text = "Stroke";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.Location = new System.Drawing.Point(20, 201);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 14);
			this.label8.TabIndex = 34;
			this.label8.Text = "Bonus";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(62, 11);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(161, 214);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "This Player";
			// 
			// textOtherBonus
			// 
			this.textOtherBonus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textOtherBonus.Location = new System.Drawing.Point(230, 198);
			this.textOtherBonus.Name = "textOtherBonus";
			this.textOtherBonus.ReadOnly = true;
			this.textOtherBonus.Size = new System.Drawing.Size(50, 22);
			this.textOtherBonus.TabIndex = 24;
			this.textOtherBonus.Text = "100";
			// 
			// textOtherStroke
			// 
			this.textOtherStroke.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textOtherStroke.Location = new System.Drawing.Point(230, 174);
			this.textOtherStroke.Name = "textOtherStroke";
			this.textOtherStroke.ReadOnly = true;
			this.textOtherStroke.Size = new System.Drawing.Size(50, 22);
			this.textOtherStroke.TabIndex = 23;
			this.textOtherStroke.Text = "0";
			// 
			// textOtherBest
			// 
			this.textOtherBest.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textOtherBest.Location = new System.Drawing.Point(230, 149);
			this.textOtherBest.Name = "textOtherBest";
			this.textOtherBest.ReadOnly = true;
			this.textOtherBest.Size = new System.Drawing.Size(50, 22);
			this.textOtherBest.TabIndex = 22;
			this.textOtherBest.Text = "100";
			// 
			// textOtherPow
			// 
			this.textOtherPow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textOtherPow.Location = new System.Drawing.Point(230, 126);
			this.textOtherPow.Name = "textOtherPow";
			this.textOtherPow.ReadOnly = true;
			this.textOtherPow.Size = new System.Drawing.Size(50, 22);
			this.textOtherPow.TabIndex = 21;
			this.textOtherPow.Text = "30";
			// 
			// textOtherClub
			// 
			this.textOtherClub.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textOtherClub.Location = new System.Drawing.Point(230, 34);
			this.textOtherClub.Name = "textOtherClub";
			this.textOtherClub.ReadOnly = true;
			this.textOtherClub.Size = new System.Drawing.Size(50, 22);
			this.textOtherClub.TabIndex = 14;
			this.textOtherClub.Text = "6";
			// 
			// textOtherCtY
			// 
			this.textOtherCtY.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textOtherCtY.Location = new System.Drawing.Point(280, 103);
			this.textOtherCtY.Name = "textOtherCtY";
			this.textOtherCtY.ReadOnly = true;
			this.textOtherCtY.Size = new System.Drawing.Size(50, 22);
			this.textOtherCtY.TabIndex = 20;
			this.textOtherCtY.Text = "0";
			// 
			// textOtherCtX
			// 
			this.textOtherCtX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textOtherCtX.Location = new System.Drawing.Point(230, 103);
			this.textOtherCtX.Name = "textOtherCtX";
			this.textOtherCtX.ReadOnly = true;
			this.textOtherCtX.Size = new System.Drawing.Size(50, 22);
			this.textOtherCtX.TabIndex = 19;
			this.textOtherCtX.Text = "0";
			// 
			// textOtherDir
			// 
			this.textOtherDir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textOtherDir.Location = new System.Drawing.Point(230, 80);
			this.textOtherDir.Name = "textOtherDir";
			this.textOtherDir.ReadOnly = true;
			this.textOtherDir.Size = new System.Drawing.Size(50, 22);
			this.textOtherDir.TabIndex = 18;
			this.textOtherDir.Text = "0";
			// 
			// textOtherPosZ
			// 
			this.textOtherPosZ.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textOtherPosZ.Location = new System.Drawing.Point(330, 57);
			this.textOtherPosZ.Name = "textOtherPosZ";
			this.textOtherPosZ.ReadOnly = true;
			this.textOtherPosZ.Size = new System.Drawing.Size(50, 22);
			this.textOtherPosZ.TabIndex = 17;
			this.textOtherPosZ.Text = "0";
			// 
			// textOtherPosY
			// 
			this.textOtherPosY.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textOtherPosY.Location = new System.Drawing.Point(280, 57);
			this.textOtherPosY.Name = "textOtherPosY";
			this.textOtherPosY.ReadOnly = true;
			this.textOtherPosY.Size = new System.Drawing.Size(50, 22);
			this.textOtherPosY.TabIndex = 16;
			this.textOtherPosY.Text = "0";
			// 
			// textOtherPosX
			// 
			this.textOtherPosX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textOtherPosX.Location = new System.Drawing.Point(230, 57);
			this.textOtherPosX.Name = "textOtherPosX";
			this.textOtherPosX.ReadOnly = true;
			this.textOtherPosX.Size = new System.Drawing.Size(50, 22);
			this.textOtherPosX.TabIndex = 15;
			this.textOtherPosX.Text = "0";
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(225, 11);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(158, 214);
			this.groupBox2.TabIndex = 26;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Other Player";
			// 
			// FormPlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 300);
			this.ControlBox = false;
			this.Controls.Add(this.textOtherBonus);
			this.Controls.Add(this.textOtherStroke);
			this.Controls.Add(this.textOtherBest);
			this.Controls.Add(this.textOtherPow);
			this.Controls.Add(this.textOtherClub);
			this.Controls.Add(this.textOtherCtY);
			this.Controls.Add(this.textOtherCtX);
			this.Controls.Add(this.textOtherDir);
			this.Controls.Add(this.textOtherPosZ);
			this.Controls.Add(this.textOtherPosY);
			this.Controls.Add(this.textOtherPosX);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textThisBonus);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textThisStroke);
			this.Controls.Add(this.btnResult);
			this.Controls.Add(this.btnPutt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textThisBest);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textThisPow);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textThisClub);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textThisCtY);
			this.Controls.Add(this.textThisCtX);
			this.Controls.Add(this.textThisDir);
			this.Controls.Add(this.textThisPosZ);
			this.Controls.Add(this.textThisPosY);
			this.Controls.Add(this.textThisPosX);
			this.Controls.Add(this.btnShot);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "FormPlay";
			this.Text = "Play";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textThisPosX;
		private System.Windows.Forms.TextBox textThisPosY;
		private System.Windows.Forms.TextBox textThisPosZ;
		private System.Windows.Forms.TextBox textThisDir;
		private System.Windows.Forms.TextBox textThisCtX;
		private System.Windows.Forms.TextBox textThisCtY;
		private System.Windows.Forms.TextBox textThisClub;
		private System.Windows.Forms.TextBox textThisPow;
		private System.Windows.Forms.TextBox textThisBest;
		private System.Windows.Forms.TextBox textThisStroke;
		private System.Windows.Forms.TextBox textThisBonus;

		private System.Windows.Forms.TextBox textOtherPosX;
		private System.Windows.Forms.TextBox textOtherPosY;
		private System.Windows.Forms.TextBox textOtherPosZ;
		private System.Windows.Forms.TextBox textOtherDir;
		private System.Windows.Forms.TextBox textOtherCtX;
		private System.Windows.Forms.TextBox textOtherCtY;
		private System.Windows.Forms.TextBox textOtherClub;
		private System.Windows.Forms.TextBox textOtherPow;
		private System.Windows.Forms.TextBox textOtherBest;
		private System.Windows.Forms.TextBox textOtherStroke;
		private System.Windows.Forms.TextBox textOtherBonus;

		private System.Windows.Forms.Button btnShot;
		private System.Windows.Forms.Button btnPutt;
		private System.Windows.Forms.Button btnResult;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}