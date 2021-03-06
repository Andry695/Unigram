// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLAuthCodeTypeSms : TLAuthCodeTypeBase 
	{
		public TLAuthCodeTypeSms() { }
		public TLAuthCodeTypeSms(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.AuthCodeTypeSms; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x72A3158C);
			if (cache) WriteToCache(to);
		}
	}
}