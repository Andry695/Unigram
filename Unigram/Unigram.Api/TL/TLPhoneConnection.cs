// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPhoneConnection : TLObject 
	{
		public Int64 Id { get; set; }
		public String Ip { get; set; }
		public String Ipv6 { get; set; }
		public Int32 Port { get; set; }
		public Byte[] PeerTag { get; set; }

		public TLPhoneConnection() { }
		public TLPhoneConnection(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PhoneConnection; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = from.ReadInt64();
			Ip = from.ReadString();
			Ipv6 = from.ReadString();
			Port = from.ReadInt32();
			PeerTag = from.ReadByteArray();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x9D4C17C0);
			to.Write(Id);
			to.Write(Ip);
			to.Write(Ipv6);
			to.Write(Port);
			to.WriteByteArray(PeerTag);
			if (cache) WriteToCache(to);
		}
	}
}