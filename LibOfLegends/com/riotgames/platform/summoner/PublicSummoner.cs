﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner
{
	public class PublicSummoner : AbstractDomainObject
	{
		public string internalName;
		public int acctId;
		public int profileIconId;
		public object summonerAssociatedTalents;
		public DateTime revisionDate;
		public int revisionId;
		public int summonerLevel;
		public int summonerId;

		public PublicSummoner()
		{
		}
	}
}