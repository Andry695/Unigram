// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLEncryptedFile : TLEncryptedFileBase 
	{
		public Int64 Id { get; set; }
		public Int64 AccessHash { get; set; }
		public Int32 Size { get; set; }
		public Int32 DCId { get; set; }
		public Int32 KeyFingerprint { get; set; }

		public TLEncryptedFile() { }
		public TLEncryptedFile(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.EncryptedFile; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
			Size = from.ReadInt32();
			DCId = from.ReadInt32();
			KeyFingerprint = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x4A70994C);
			to.Write(Id);
			to.Write(AccessHash);
			to.Write(Size);
			to.Write(DCId);
			to.Write(KeyFingerprint);
			if (cache) WriteToCache(to);
		}
	}
}