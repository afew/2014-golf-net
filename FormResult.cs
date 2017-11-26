using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace golf_net
{
	public partial class FormResult:Form
	{
		public FormResult()
		{
			InitializeComponent();
		}

		private void btnLobby_Click(object sender,EventArgs e)
		{
			Program.ChageForm(APC.PHASE_LOBBY);
		}

		private void btnReplay_Click(object sender,EventArgs e)
		{
			Program.ChageForm(APC.PHASE_PLAY);
		}

		private void btnQuit_Click(object sender,EventArgs e)
		{
			Program.ChageForm(APC.PHASE_BEGIN);
		}


		public void ChangeResultPlayerInfo(int n)
		{
			TuserInfo this_play = TcpApp.UserThis() ;
			TuserInfo other_play= TcpApp.UserOther();

			textId0   .Text = this_play.name;
			textScore0.Text = this_play.play.stroke.ToString();
			textBonus0.Text = this_play.play.bonus .ToString();
			textWin0  .Text = this_play.play.iswin .ToString();

			textId1   .Text = other_play.name      ;
			textScore1.Text = other_play.play.stroke.ToString();
			textBonus1.Text = other_play.play.bonus .ToString();
			textWin1  .Text = other_play.play.iswin .ToString();
		}
	}
}
