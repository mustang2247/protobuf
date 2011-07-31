﻿//
//	This is the backend code for reading and writing
//	Report bugs to: https://silentorbit.com/protobuf-csharpgen/
//
//	Generated by ProtocolBuffer
//	- a pure c# code generation implementation of protocol buffers
//

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using ProtocolBuffers;
namespace Personal
{
	public partial class Person
	{
		public static Person Deserialize(Stream stream)
		{
			Person instance = new Person();
			Serializer.Read(stream, instance);
			return instance;
		}
		
		public static Person Deserialize(byte[] buffer)
		{
			using(MemoryStream ms = new MemoryStream(buffer))
				return Deserialize(ms);
		}
		
		public static T Deserialize<T> (Stream stream) where T : Personal.Person, new()
		{
			T instance = new T ();
			Serializer.Read (stream, instance);
			return instance;
		}
		
		public static T Deserialize<T> (byte[] buffer) where T : Personal.Person, new()
		{
			T instance = new T ();
			using (MemoryStream ms = new MemoryStream(buffer))
				Serializer.Read (ms, instance);
			return instance;
		}
		
		public static Personal.Person Deserialize(Stream stream, Personal.Person instance)
		{
			while (true)
			{
				ProtocolBuffers.Key key = null;
				try {
					key = ProtocolParser.ReadKey (stream);
				} catch (InvalidDataException) {
					break;
				}
		
				switch (key.Field) {
				case 0:
					throw new InvalidDataException("Invalid field id: 0, something went wrong in the stream");
				case 1:
					instance.Name = ProtocolParser.ReadString(stream);
					break;
				case 2:
					instance.Id = (int)ProtocolParser.ReadUInt32(stream);
					break;
				case 3:
					instance.Email = ProtocolParser.ReadString(stream);
					break;
				case 4:
					instance.Phone.Add(Personal.Person.PhoneNumber.Deserialize(ProtocolParser.ReadBytes(stream)));
					break;
				default:
					ProtocolParser.SkipKey(stream, key);
					break;
				}
			}
			return instance;
		}
		
		public static Personal.Person Read(byte[] buffer, Personal.Person instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Deserialize (ms, instance);
			return instance;
		}
	
		public static void Serialize(Stream stream, Person instance)
		{
			if(instance.Name == null)
				throw new ArgumentNullException("Name", "Required by proto specification.");
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(1, Wire.LengthDelimited));
			ProtocolParser.WriteString(stream, instance.Name);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(2, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.Id);
			if(instance.Email != null)
			{
				ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(3, Wire.LengthDelimited));
				ProtocolParser.WriteString(stream, instance.Email);
			}
			foreach (Personal.Person.PhoneNumber i4 in instance.Phone)
			{
				ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(4, Wire.LengthDelimited));
				using(MemoryStream ms4 = new MemoryStream())
				{
					Personal.Person.PhoneNumber.Serialize(ms4, i4);
					ProtocolParser.WriteBytes(stream, ms4.ToArray());
				}
			
			}
		}
		
		public static byte[] SerializeToBytes(Person instance)
		{
			using(MemoryStream ms = new MemoryStream())
			{
				Serialize(ms, instance);
				return ms.ToArray();
			}
		}
	
		public partial class PhoneNumber
		{
			public static PhoneNumber Deserialize(Stream stream)
			{
				PhoneNumber instance = new PhoneNumber();
				Serializer.Read(stream, instance);
				return instance;
			}
			
			public static PhoneNumber Deserialize(byte[] buffer)
			{
				using(MemoryStream ms = new MemoryStream(buffer))
					return Deserialize(ms);
			}
			
			public static T Deserialize<T> (Stream stream) where T : Personal.Person.PhoneNumber, new()
			{
				T instance = new T ();
				Serializer.Read (stream, instance);
				return instance;
			}
			
			public static T Deserialize<T> (byte[] buffer) where T : Personal.Person.PhoneNumber, new()
			{
				T instance = new T ();
				using (MemoryStream ms = new MemoryStream(buffer))
					Serializer.Read (ms, instance);
				return instance;
			}
			
			public static Personal.Person.PhoneNumber Deserialize(Stream stream, Personal.Person.PhoneNumber instance)
			{
				while (true)
				{
					ProtocolBuffers.Key key = null;
					try {
						key = ProtocolParser.ReadKey (stream);
					} catch (InvalidDataException) {
						break;
					}
			
					switch (key.Field) {
					case 0:
						throw new InvalidDataException("Invalid field id: 0, something went wrong in the stream");
					case 1:
						instance.Number = ProtocolParser.ReadString(stream);
						break;
					case 2:
						instance.Type = (Personal.Person.PhoneType)ProtocolParser.ReadUInt32(stream);
						break;
					default:
						ProtocolParser.SkipKey(stream, key);
						break;
					}
				}
				return instance;
			}
			
			public static Personal.Person.PhoneNumber Read(byte[] buffer, Personal.Person.PhoneNumber instance)
			{
				using (MemoryStream ms = new MemoryStream(buffer))
					Deserialize (ms, instance);
				return instance;
			}
		
			public static void Serialize(Stream stream, PhoneNumber instance)
			{
				if(instance.Number == null)
					throw new ArgumentNullException("Number", "Required by proto specification.");
				ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(1, Wire.LengthDelimited));
				ProtocolParser.WriteString(stream, instance.Number);
				if(instance.Type != Personal.Person.PhoneType.HOME)
				{
					ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(2, Wire.Varint));
					ProtocolParser.WriteUInt32(stream, (uint)instance.Type);
				}
			}
			
			public static byte[] SerializeToBytes(PhoneNumber instance)
			{
				using(MemoryStream ms = new MemoryStream())
				{
					Serialize(ms, instance);
					return ms.ToArray();
				}
			}
		}
		
	}
	

}
namespace Mine
{
	public partial class MyMessageV1
	{
		public static MyMessageV1 Deserialize(Stream stream)
		{
			MyMessageV1 instance = new MyMessageV1();
			Serializer.Read(stream, instance);
			return instance;
		}
		
		public static MyMessageV1 Deserialize(byte[] buffer)
		{
			using(MemoryStream ms = new MemoryStream(buffer))
				return Deserialize(ms);
		}
		
		public static T Deserialize<T> (Stream stream) where T : Mine.MyMessageV1, new()
		{
			T instance = new T ();
			Serializer.Read (stream, instance);
			return instance;
		}
		
		public static T Deserialize<T> (byte[] buffer) where T : Mine.MyMessageV1, new()
		{
			T instance = new T ();
			using (MemoryStream ms = new MemoryStream(buffer))
				Serializer.Read (ms, instance);
			return instance;
		}
		
		public static Mine.MyMessageV1 Deserialize(Stream stream, Mine.MyMessageV1 instance)
		{
			while (true)
			{
				ProtocolBuffers.Key key = null;
				try {
					key = ProtocolParser.ReadKey (stream);
				} catch (InvalidDataException) {
					break;
				}
		
				switch (key.Field) {
				case 0:
					throw new InvalidDataException("Invalid field id: 0, something went wrong in the stream");
				case 1:
					instance.FieldA = (int)ProtocolParser.ReadUInt32(stream);
					break;
				default:
					ProtocolParser.SkipKey(stream, key);
					break;
				}
			}
			return instance;
		}
		
		public static Mine.MyMessageV1 Read(byte[] buffer, Mine.MyMessageV1 instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Deserialize (ms, instance);
			return instance;
		}
	
		public static void Serialize(Stream stream, MyMessageV1 instance)
		{
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(1, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.FieldA);
		}
		
		public static byte[] SerializeToBytes(MyMessageV1 instance)
		{
			using(MemoryStream ms = new MemoryStream())
			{
				Serialize(ms, instance);
				return ms.ToArray();
			}
		}
	}
	

}
namespace Yours
{
	public partial class MyMessageV2
	{
		public static MyMessageV2 Deserialize(Stream stream)
		{
			MyMessageV2 instance = new MyMessageV2();
			Serializer.Read(stream, instance);
			return instance;
		}
		
		public static MyMessageV2 Deserialize(byte[] buffer)
		{
			using(MemoryStream ms = new MemoryStream(buffer))
				return Deserialize(ms);
		}
		
		public static T Deserialize<T> (Stream stream) where T : Yours.MyMessageV2, new()
		{
			T instance = new T ();
			Serializer.Read (stream, instance);
			return instance;
		}
		
		public static T Deserialize<T> (byte[] buffer) where T : Yours.MyMessageV2, new()
		{
			T instance = new T ();
			using (MemoryStream ms = new MemoryStream(buffer))
				Serializer.Read (ms, instance);
			return instance;
		}
		
		public static Yours.MyMessageV2 Deserialize(Stream stream, Yours.MyMessageV2 instance)
		{
			BinaryReader br = new BinaryReader (stream);	while (true)
			{
				ProtocolBuffers.Key key = null;
				try {
					key = ProtocolParser.ReadKey (stream);
				} catch (InvalidDataException) {
					break;
				}
		
				switch (key.Field) {
				case 0:
					throw new InvalidDataException("Invalid field id: 0, something went wrong in the stream");
				case 1:
					instance.FieldA = (int)ProtocolParser.ReadUInt32(stream);
					break;
				case 2:
					instance.FieldB = br.ReadDouble ();
					break;
				case 3:
					instance.FieldC = br.ReadSingle ();
					break;
				case 4:
					instance.FieldD = (int)ProtocolParser.ReadUInt32(stream);
					break;
				case 5:
					instance.FieldE = (long)ProtocolParser.ReadUInt64(stream);
					break;
				case 6:
					instance.FieldF = ProtocolParser.ReadUInt32(stream);
					break;
				case 7:
					instance.FieldG = ProtocolParser.ReadUInt64(stream);;
					break;
				case 8:
					instance.FieldH = ProtocolParser.ReadSInt32(stream);;
					break;
				case 9:
					instance.FieldI = ProtocolParser.ReadSInt64(stream);;
					break;
				case 10:
					instance.FieldJ = br.ReadUInt32 ();
					break;
				case 11:
					instance.FieldK = br.ReadUInt64 ();
					break;
				case 12:
					instance.FieldL = br.ReadInt32 ();
					break;
				case 13:
					instance.FieldM = br.ReadInt64 ();
					break;
				case 14:
					instance.FieldN = ProtocolParser.ReadBool(stream);
					break;
				case 15:
					instance.FieldO = ProtocolParser.ReadString(stream);
					break;
				case 16:
					instance.FieldP = ProtocolParser.ReadBytes(stream);
					break;
				case 17:
					instance.FieldQ = (Yours.MyMessageV2.MyEnum)ProtocolParser.ReadUInt32(stream);
					break;
				case 18:
					instance.FieldR = (Yours.MyMessageV2.MyEnum)ProtocolParser.ReadUInt32(stream);
					break;
				case 19:
					instance.Dummy = ProtocolParser.ReadString(stream);
					break;
				case 20:
					instance.FieldS.Add(ProtocolParser.ReadUInt32(stream));
					break;
				case 21:
					using(MemoryStream ms21 = new MemoryStream(ProtocolParser.ReadBytes(stream)))
					{
						while(true)
						{
							if(ms21.Position == ms21.Length)
								break;
							instance.FieldT.Add(ProtocolParser.ReadUInt32(ms21));
						}
					}
		
					break;
				case 22:
					if(instance.FieldU == null)
						instance.FieldU = new Theirs.TheirMessage();
					instance.FieldU = Serializer.Read(ProtocolParser.ReadBytes(stream), instance.FieldU);
					break;
				case 23:
					instance.FieldV.Add(Theirs.TheirMessage.Deserialize(ProtocolParser.ReadBytes(stream)));
					break;
				default:
					ProtocolParser.SkipKey(stream, key);
					break;
				}
			}
			return instance;
		}
		
		public static Yours.MyMessageV2 Read(byte[] buffer, Yours.MyMessageV2 instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Deserialize (ms, instance);
			return instance;
		}
	
		public static void Serialize(Stream stream, MyMessageV2 instance)
		{
			BinaryWriter bw = new BinaryWriter(stream);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(1, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.FieldA);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(2, Wire.Fixed64));
			bw.Write(instance.FieldB);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(3, Wire.Fixed32));
			bw.Write(instance.FieldC);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(4, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.FieldD);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(5, Wire.Varint));
			ProtocolParser.WriteUInt64(stream, (ulong)instance.FieldE);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(6, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, instance.FieldF);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(7, Wire.Varint));
			ProtocolParser.WriteUInt64(stream, instance.FieldG);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(8, Wire.Varint));
			ProtocolParser.WriteSInt32(stream, instance.FieldH);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(9, Wire.Varint));
			ProtocolParser.WriteSInt64(stream, instance.FieldI);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(10, Wire.Fixed32));
			bw.Write(instance.FieldJ);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(11, Wire.Fixed64));
			bw.Write(instance.FieldK);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(12, Wire.Fixed32));
			bw.Write(instance.FieldL);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(13, Wire.Fixed64));
			bw.Write(instance.FieldM);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(14, Wire.Varint));
			ProtocolParser.WriteBool(stream, instance.FieldN);
			if(instance.FieldO == null)
				throw new ArgumentNullException("FieldO", "Required by proto specification.");
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(15, Wire.LengthDelimited));
			ProtocolParser.WriteString(stream, instance.FieldO);
			if(instance.FieldP == null)
				throw new ArgumentNullException("FieldP", "Required by proto specification.");
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(16, Wire.LengthDelimited));
			ProtocolParser.WriteBytes(stream, instance.FieldP);
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(17, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.FieldQ);
			if(instance.FieldR != Yours.MyMessageV2.MyEnum.ETest2)
			{
				ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(18, Wire.Varint));
				ProtocolParser.WriteUInt32(stream, (uint)instance.FieldR);
			}
			if(instance.Dummy != null)
			{
				ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(19, Wire.LengthDelimited));
				ProtocolParser.WriteString(stream, instance.Dummy);
			}
			foreach (uint i20 in instance.FieldS)
			{
				ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(20, Wire.Varint));
				ProtocolParser.WriteUInt32(stream, i20);
			
			}
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(21, Wire.LengthDelimited));
			using(MemoryStream ms21 = new MemoryStream())
			{	
				foreach (uint i21 in instance.FieldT)
				{
					ProtocolParser.WriteUInt32(ms21, i21);
			
				}
				ProtocolParser.WriteBytes(stream, ms21.ToArray());
			}
			if(instance.FieldU != null)
			{
				ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(22, Wire.LengthDelimited));
				using(MemoryStream ms22 = new MemoryStream())
				{
					Theirs.TheirMessage.Serialize(ms22, instance.FieldU);
					ProtocolParser.WriteBytes(stream, ms22.ToArray());
				}
			}
			foreach (Theirs.TheirMessage i23 in instance.FieldV)
			{
				ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(23, Wire.LengthDelimited));
				using(MemoryStream ms23 = new MemoryStream())
				{
					Theirs.TheirMessage.Serialize(ms23, i23);
					ProtocolParser.WriteBytes(stream, ms23.ToArray());
				}
			
			}
		}
		
		public static byte[] SerializeToBytes(MyMessageV2 instance)
		{
			using(MemoryStream ms = new MemoryStream())
			{
				Serialize(ms, instance);
				return ms.ToArray();
			}
		}
	}
	

}
namespace Theirs
{
	public partial class TheirMessage
	{
		public static TheirMessage Deserialize(Stream stream)
		{
			TheirMessage instance = new TheirMessage();
			Serializer.Read(stream, instance);
			return instance;
		}
		
		public static TheirMessage Deserialize(byte[] buffer)
		{
			using(MemoryStream ms = new MemoryStream(buffer))
				return Deserialize(ms);
		}
		
		public static T Deserialize<T> (Stream stream) where T : Theirs.TheirMessage, new()
		{
			T instance = new T ();
			Serializer.Read (stream, instance);
			return instance;
		}
		
		public static T Deserialize<T> (byte[] buffer) where T : Theirs.TheirMessage, new()
		{
			T instance = new T ();
			using (MemoryStream ms = new MemoryStream(buffer))
				Serializer.Read (ms, instance);
			return instance;
		}
		
		public static Theirs.TheirMessage Deserialize(Stream stream, Theirs.TheirMessage instance)
		{
			while (true)
			{
				ProtocolBuffers.Key key = null;
				try {
					key = ProtocolParser.ReadKey (stream);
				} catch (InvalidDataException) {
					break;
				}
		
				switch (key.Field) {
				case 0:
					throw new InvalidDataException("Invalid field id: 0, something went wrong in the stream");
				case 1:
					instance.FieldA = (int)ProtocolParser.ReadUInt32(stream);
					break;
				default:
					ProtocolParser.SkipKey(stream, key);
					break;
				}
			}
			return instance;
		}
		
		public static Theirs.TheirMessage Read(byte[] buffer, Theirs.TheirMessage instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Deserialize (ms, instance);
			return instance;
		}
	
		public static void Serialize(Stream stream, TheirMessage instance)
		{
			ProtocolParser.WriteKey(stream, new ProtocolBuffers.Key(1, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.FieldA);
		}
		
		public static byte[] SerializeToBytes(TheirMessage instance)
		{
			using(MemoryStream ms = new MemoryStream())
			{
				Serialize(ms, instance);
				return ms.ToArray();
			}
		}
	}
	

}

namespace ProtocolBuffers
{
	public static partial class Serializer
	{
		
		public static Personal.Person Read (Stream stream, Personal.Person instance)
		{
			return Personal.Person.Deserialize(stream, instance);
		}
		
		public static Personal.Person Read(byte[] buffer, Personal.Person instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Personal.Person.Deserialize (ms, instance);
			return instance;
		}
		
		public static void Write(Stream stream, Personal.Person instance)
		{
			Personal.Person.Serialize(stream, instance);
		}
		
		
		
		public static Personal.Person.PhoneNumber Read (Stream stream, Personal.Person.PhoneNumber instance)
		{
			return Personal.Person.PhoneNumber.Deserialize(stream, instance);
		}
		
		public static Personal.Person.PhoneNumber Read(byte[] buffer, Personal.Person.PhoneNumber instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Personal.Person.PhoneNumber.Deserialize (ms, instance);
			return instance;
		}
		
		public static void Write(Stream stream, Personal.Person.PhoneNumber instance)
		{
			Personal.Person.PhoneNumber.Serialize(stream, instance);
		}
		

		
		public static Mine.MyMessageV1 Read (Stream stream, Mine.MyMessageV1 instance)
		{
			return Mine.MyMessageV1.Deserialize(stream, instance);
		}
		
		public static Mine.MyMessageV1 Read(byte[] buffer, Mine.MyMessageV1 instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Mine.MyMessageV1.Deserialize (ms, instance);
			return instance;
		}
		
		public static void Write(Stream stream, Mine.MyMessageV1 instance)
		{
			Mine.MyMessageV1.Serialize(stream, instance);
		}
		

		
		public static Yours.MyMessageV2 Read (Stream stream, Yours.MyMessageV2 instance)
		{
			return Yours.MyMessageV2.Deserialize(stream, instance);
		}
		
		public static Yours.MyMessageV2 Read(byte[] buffer, Yours.MyMessageV2 instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Yours.MyMessageV2.Deserialize (ms, instance);
			return instance;
		}
		
		public static void Write(Stream stream, Yours.MyMessageV2 instance)
		{
			Yours.MyMessageV2.Serialize(stream, instance);
		}
		

		
		public static Theirs.TheirMessage Read (Stream stream, Theirs.TheirMessage instance)
		{
			return Theirs.TheirMessage.Deserialize(stream, instance);
		}
		
		public static Theirs.TheirMessage Read(byte[] buffer, Theirs.TheirMessage instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Theirs.TheirMessage.Deserialize (ms, instance);
			return instance;
		}
		
		public static void Write(Stream stream, Theirs.TheirMessage instance)
		{
			Theirs.TheirMessage.Serialize(stream, instance);
		}
		


	}
}
