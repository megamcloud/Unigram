// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateUserTyping : TLUpdateBase 
	{
		public Int32 UserId { get; set; }
		public TLSendMessageActionBase Action { get; set; }

		public TLUpdateUserTyping() { }
		public TLUpdateUserTyping(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateUserTyping; } }

		public override void Read(TLBinaryReader from)
		{
			UserId = from.ReadInt32();
			Action = TLFactory.Read<TLSendMessageActionBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(UserId);
			to.WriteObject(Action);
		}
	}
}