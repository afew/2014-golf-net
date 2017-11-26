using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using golf_net;
using PGN;

namespace golf_net
{
	public partial class FormPlay:Form
	{
		public FormPlay()
		{
			InitializeComponent();
		}

		private void Shot_Click(object sender,EventArgs e)
		{
			TplayInfo this_play = TcpApp.UserThis().play;

			this_play.x     = Convert.ToSingle(textThisPosX.Text);
			this_play.y     = Convert.ToSingle(textThisPosY.Text);
			this_play.z     = Convert.ToSingle(textThisPosZ.Text);

			this_play.d     = Convert.ToSingle(textThisDir .Text);
			this_play.ct_x  = Convert.ToSingle(textThisCtX .Text);
			this_play.ct_y  = Convert.ToSingle(textThisCtY .Text);
			this_play.club  = Convert.ToUInt32(textThisClub.Text);
			this_play.pow   = Convert.ToSingle(textThisPow .Text);
			this_play.best  = Convert.ToSingle(textThisBest.Text);
			this_play.stroke= Convert.ToByte(textThisStroke.Text);

			TcpApp.SendGpShot(this_play);
		}

		private void Putt_Click(object sender,EventArgs e)
		{
			TplayInfo this_play = TcpApp.UserThis().play;

			this_play.x    = Convert.ToSingle(textThisPosX.Text);
			this_play.y    = Convert.ToSingle(textThisPosY.Text);
			this_play.z    = Convert.ToSingle(textThisPosZ.Text);

			this_play.d    = Convert.ToSingle(textThisDir .Text);
			this_play.ct_y = Convert.ToSingle(textThisCtY .Text);
			this_play.club = Convert.ToUInt32(textThisClub.Text);
			this_play.pow  = Convert.ToSingle(textThisPow .Text);

			TcpApp.SendGpPutt(this_play);
		}

		private void Result_Click(object sender,EventArgs e)
		{
			TplayInfo this_play = TcpApp.UserThis().play;

			this_play.x     = Convert.ToSingle(textThisPosX.Text);
			this_play.y     = Convert.ToSingle(textThisPosY.Text);
			this_play.z     = Convert.ToSingle(textThisPosZ.Text);

			this_play.stroke= Convert.ToByte  (textThisStroke.Text);
			this_play.bonus = Convert.ToUInt32(textThisBonus .Text);

			TcpApp.SendGpEnd(this_play);
			Program.ChageForm(APC.PHASE_RST);
		}

		public void ChangePlayPlayerInfo(int n)
		{
			TplayInfo this_play = TcpApp.UserThis() .play;
			TplayInfo other_play= TcpApp.UserOther().play;

			textThisPosX.Text = this_play.x   .ToString();
			textThisPosY.Text = this_play.y   .ToString();
			textThisPosZ.Text = this_play.z   .ToString();

			textThisDir .Text = this_play.d   .ToString();
			textThisCtX .Text = this_play.ct_x.ToString();
			textThisCtY .Text = this_play.ct_y.ToString();
			textThisClub.Text = this_play.club.ToString();
			textThisPow .Text = this_play.pow .ToString();
			textThisBest.Text = this_play.best.ToString();

			textOtherPosX.Text = other_play.x   .ToString();
			textOtherPosY.Text = other_play.y   .ToString();
			textOtherPosZ.Text = other_play.z   .ToString();

			textOtherDir .Text = other_play.d   .ToString();
			textOtherCtX .Text = other_play.ct_x.ToString();
			textOtherCtY .Text = other_play.ct_y.ToString();
			textOtherClub.Text = other_play.club.ToString();
			textOtherPow .Text = other_play.pow .ToString();
			textOtherBest.Text = other_play.best.ToString();
		}
	}
}
