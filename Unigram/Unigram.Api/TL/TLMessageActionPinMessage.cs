// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionPinMessage : TLMessageActionBase 
	{
		public TLMessageActionPinMessage() { }
		public TLMessageActionPinMessage(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessageActionPinMessage; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x94BD38ED);
			if (cache) WriteToCache(to);
		}
	}
}