// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessagesChats : TLMessagesChatsBase 
	{
		public TLMessagesChats() { }
		public TLMessagesChats(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesChats; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x64FF9FD5);
			to.WriteObject(Chats, cache);
			if (cache) WriteToCache(to);
		}
	}
}