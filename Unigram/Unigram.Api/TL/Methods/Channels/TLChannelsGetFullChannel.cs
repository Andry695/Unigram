// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.getFullChannel
	/// </summary>
	public partial class TLChannelsGetFullChannel : TLObject
	{
		public TLInputChannelBase Channel { get; set; }

		public TLChannelsGetFullChannel() { }
		public TLChannelsGetFullChannel(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.ChannelsGetFullChannel; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x8736A09);
			to.WriteObject(Channel, cache);
			if (cache) WriteToCache(to);
		}
	}
}