// Tcp Application:: receiving process
//
//+++++++1+++++++++2+++++++++3+++++++++4+++++++++5+++++++++6+++++++++7+++++++++8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

using golf_net;
using PGN;


public partial class TcpApp
{
	public static void OnIoEvent(int ev, int hr, object socket, int rcn, object data)
	{
		if     (NTC.EV_CLOSE == ev)
		{
			PGLog.LOGI("OnRecv: gracefully closed");
		}
		else if(NTC.EV_ACCEPT == ev)
		{
			PGLog.LOGI("OnRecv: Accept");
		}
		else if(NTC.EV_CONNECT == ev)
		{
			PGLog.LOGI("OnRecv: Connect");

			if(NTC.OK != hr)
			{
			}
		}
		else if(NTC.EV_SEND == ev)
		{
			PGLog.LOGI("OnRecv: Send");
		}
		else if(NTC.EV_RECV == ev)
		{
			PGLog.LOGI("OnRecv: Receive");

			byte[] rcv = null;
			ushort len = 0;
			ushort opp = 0;
			int    idx_bgn= NTC.PCK_HEAD;
			int    i   = 0;

			if(0>hr)
			{
			    PGLog.LOGI("OnRecv: disconnected");
			    TcpCln	pCln = (TcpCln)data;

			    pCln.CloseSocket();
			    return;
			}
			
			rcv = (byte[])data;
			len = Packet.LenFromBuf(rcv);
			opp = Packet.OppFromBuf(rcv);

			if(NTC.SC_ANS_LOGIN == opp)
			{
				byte  user_count = 0;

				app_user_lst.Clear();
				app_pmap_lst.Clear();

				// setup the user id, and character name
				Packet.ValueFromBuf(ref app_user_id  , rcv, idx_bgn + 0);
				Packet.ValueFromBuf(ref app_char_name, rcv, idx_bgn + 4, 40);


				PGLog.LOGI("OnRecv:user id/name::" + app_user_id + ", " + app_char_name);


				Packet.ValueFromBuf(ref user_count   , rcv, idx_bgn + 48);


				idx_bgn = NTC.PCK_HEAD + 49;
				for(i=0; i<user_count; ++i)
				{
					uint	id   = 0;
					string	name = null;
					byte	owner= 0;
					byte	ready= 0;

					Packet.ValueFromBuf(ref id   , rcv, idx_bgn + 46 *i +  0    );
					Packet.ValueFromBuf(ref name , rcv, idx_bgn + 46 *i +  4, 40);
					Packet.ValueFromBuf(ref owner, rcv, idx_bgn + 46 *i + 44    );
					Packet.ValueFromBuf(ref ready, rcv, idx_bgn + 46 *i + 45    );

					TuserInfo usr = new TuserInfo(id, name, owner, ready);
					app_user_lst.Add(usr);
					PGLog.LOGI("OnRecv:NTC.SC_ANS_LOGIN:: id/name::" + id + ", " + name);
				}


				for(i=0; i<3; ++i)
				{
					uint	id   = (uint)i;
					string	name = "map " + i;

					TplayMap map = new TplayMap(id, name);
					app_pmap_lst.Add(map);
				}


				// change the phase of the application
				Program.ChageForm(APC.PHASE_LOBBY);
			}

			else if(NTC.SC_BROADCAST_USERLIST == opp)
			{
				byte  user_count = 0;

				idx_bgn = NTC.PCK_HEAD;

				app_user_lst.Clear();


				Packet.ValueFromBuf(ref user_count   , rcv, idx_bgn + 0);


				idx_bgn = NTC.PCK_HEAD + 1;
				for(i=0; i<user_count; ++i)
				{
					uint	id   = 0;
					string	name = null;
					byte	owner= 0;
					byte	ready= 0;

					Packet.ValueFromBuf(ref id   , rcv, idx_bgn + 46 *i +  0    );
					Packet.ValueFromBuf(ref name , rcv, idx_bgn + 46 *i +  4, 40);
					Packet.ValueFromBuf(ref owner, rcv, idx_bgn + 46 *i + 44    );
					Packet.ValueFromBuf(ref ready, rcv, idx_bgn + 46 *i + 45    );

					TuserInfo usr = new TuserInfo(id, name, owner, ready);
					app_user_lst.Add(usr);
					PGLog.LOGI("OnRecv:NTC.SC_ANS_LOGIN:: id/name::" + id + ", " + name);
				}


				Program.ChageUserList(0);
			}

			else if(NTC.SC_BROADCAST_LOGOUT == opp)
			{
				uint	id   = 0;
				string	name = null;

				idx_bgn = NTC.PCK_HEAD;

				Packet.ValueFromBuf(ref id, rcv, idx_bgn + 0);
				name = TcpApp.FindUser(id).name;

				for(i=0; i<app_user_lst.Count; ++i)
				{
					if(app_user_lst[i].id == id)
					{
						app_user_lst.RemoveAt(i);
						break;
					}
				}

				Program.ChageUserList(0);
				PGLog.LOGI("OnRecv:NTC.SC_BROADCAST_LOGOUT::" + name);
			}
			
			else if(NTC.CS_REQ_BROADCAST == opp)
			{
				//
				// GAME PLAY PACKET: gpp + send id + {dest id} + data
				//


				idx_bgn= NTC.PCK_HEAD;
				ushort	gpp     = 0;
				uint	sendId	= 0;
				uint	destId	= 0;

				Packet.ValueFromBuf(ref gpp, rcv, idx_bgn + 0);


				// 초대 받음
				if     (NTC.GP_RQ_INVITE   == gpp)
				{
					uint idx_map = 0;

					Packet.ValueFromBuf(ref sendId, rcv, idx_bgn + 2);
					Packet.ValueFromBuf(ref destId, rcv, idx_bgn + 2 + 4);
					Packet.ValueFromBuf(ref idx_map, rcv, idx_bgn + 2 + 4 + 4);

					if(TcpApp.app_user_id == destId)
					{
						string name = TcpApp.FindUser(sendId).name;

						int inviteRps = NTC.RST_OK;
						string log = "OnRecv:NTC.GP_INVITE:: sender:" + name + ", dest id::" + destId + ", map id::" + idx_map ;
						PGLog.LOGI(log);
						DialogResult r =
						MessageBox.Show("From " + name + " 한판 뜰래? ", "Inviting", MessageBoxButtons.YesNo);

						if(DialogResult.No == r)
							inviteRps = NTC.RST_NO;

						TcpApp.SendRsInvite(sendId, (byte)inviteRps);

						if(NTC.RST_OK == inviteRps)
						{
							app_advr_id = sendId;

							TcpApp.FindUser(app_user_id).ready = NTC.RST_READY_TRUE;
							TcpApp.SendReady(NTC.RST_READY_TRUE);
						}
					}
				}

				// 초대 응답
				else if(NTC.GP_RS_INVITE   == gpp)
				{
					byte rq = 0;
					Packet.ValueFromBuf(ref sendId, rcv, idx_bgn + 2);
					Packet.ValueFromBuf(ref destId, rcv, idx_bgn + 2 + 4);
					Packet.ValueFromBuf(ref     rq, rcv, idx_bgn + 2 + 4 + 4);

					if(TcpApp.app_user_id == destId)
					{
						string name = TcpApp.FindUser(sendId).name;
						string log = "OnRecv:NTC.GP_RS_INVITE::" + name + "::"+rq;
						PGLog.LOGI(log);

						// Send Ready
						if(rq == NTC.RST_OK)
						{
							app_advr_id = sendId;

							MessageBox.Show("Inviting success","Msg",MessageBoxButtons.OK);
							TcpApp.SendReady(NTC.RST_READY_TRUE);
							return;
						}


						MessageBox.Show("Inviting failed","Msg",MessageBoxButtons.OK);
					}
				}

				else if(NTC.GP_SHOT     == gpp)
				{
				}
				else if(NTC.GP_PUTT     == gpp)
				{
				}
				else if(NTC.GP_MOVESTOP == gpp)
				{
				}
				else if(NTC.GP_END      == gpp)
				{
				}
				else if(NTC.GP_RESULT   == gpp)
				{
				}
			}

			else if(NTC.SC_BROADCAST_READY == opp)
			{
				TuserInfo usr = null;
				uint	id    = 0;
				byte	ready = 0;
	
				idx_bgn= NTC.PCK_HEAD;

				Packet.ValueFromBuf(ref id  , rcv, idx_bgn + 0);
				Packet.ValueFromBuf(ref ready, rcv, idx_bgn + 4);


				usr = TcpApp.FindUser(id);
				usr.ready = ready;

				PGLog.LOGI("OnRecv:NTC.SC_BROADCAST_READY::" + usr.name + ", " + ready);

				
				if( NTC.RST_READY_TRUE == TcpApp.FindUser(app_user_id).ready &&
					NTC.RST_READY_TRUE == TcpApp.FindUser(app_advr_id).ready)
				{
					TcpApp.SendGo();
					Program.ChageForm(APC.PHASE_PLAY);
				}
			}

			else if(NTC.SC_BROADCAST_START == opp)
			{
				Program.ChageForm(APC.PHASE_PLAY);
			}
		}
		else
		{
			PGLog.LOGI("OnRecv: Not defined");
		}
	}
}

