﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sub_db
{
	internal class c_Common_
	{
		internal const string	m_k_PROGRAM_NAME	= "Subtitles Database";
		internal const string	m_k_VERSION			= "v0.01";

		/*==============================================================
		 * 退出程序
		 *==============================================================*/
		internal static void	quit_program()
		{
			c_Mainform.m_s_mainform.notifyIcon_Main.Visible = false;

			Environment.Exit(0);
		}
	};
}	// namespace sub_db
