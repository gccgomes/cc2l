﻿#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using System.Globalization;
using System.Linq;
using System.Reflection;
#if UNIT_TESTS
using System;
using NUnit.Framework;

namespace ClearCanvas.Dicom.Tests
{
	[TestFixture]
	internal class DicomUidTests
	{
		[Test]
		public void TestGuidConversion()
		{
            var uidPairs = new[]
		    {
                // This is the reference sample for 2.25 style UIDs given on 
                // David Clunie's website (http://www.dclunie.com/medical-image-faq/html/part2.html)
		        new[] {"f81d4fae-7dec-11d0-a765-00a0c91e6bf6", "329800735698586629295641978511506172918"},

                //These were generated by http://www.itu.int/en/ITU-T/asn1/Pages/UUID/generate_uuid.aspx
		        new[] {"caee1380-7593-11e4-a963-0002a5d5c51b", "269740217344259109252606731820088018203"},
		        new[] {"f5a37f60-7594-11e4-9390-0002a5d5c51b", "326509786863557582563524645431476077851"},
		        new[] {"ff12f6c0-7594-11e4-8f6b-0002a5d5c51b", "339051604989565627204284007819374871835"},
		        new[] {"12180b20-7595-11e4-aece-0002a5d5c51b", "24050944726930122795090541006869087515"},
		        new[] {"212f91a0-7595-11e4-9147-0002a5d5c51b", "44111515475541853071648199882988438811"},
		        new[] {"2b3f40a0-7595-11e4-b63b-0002a5d5c51b", "57485229307949673260101171979388044571"},
		        new[] {"3d31ac80-7595-11e4-b088-0002a5d5c51b", "81340829040994665309106583434536797467"},
		        new[] {"45bc4220-7595-11e4-85ea-0002a5d5c51b", "92694224729288744883190539521772340507"},
		        new[] {"4e8e8f20-7595-11e4-95e8-0002a5d5c51b", "104419992781399866848187402726153766171"},
		        new[] {"74063be0-7595-11e4-aa2b-0002a5d5c51b", "154222815737866429460949140611561538843"},
		        
                //Special cases.
                new[] {Guid.Empty.ToString(), "0"},

                //I used this generator to get the expected value for these. It uses functionality
                //built into Python to convert a GUID to a decimal value.
                //http://guid-convert.appspot.com/
                //Basically, in Python, the UUID class has a .int property that returns the 128-bit
                //integer representation of the UUID, which is what we want.
                new []{"00000000-0000-0000-0000-000000000001", "1"},
                new []{"00000000-0000-0000-0001-000000000000", "281474976710656"},
                new []{"00000000-0000-0001-0000-000000000000", "18446744073709551616"},
                new []{"00000000-0001-0000-0000-000000000000", "1208925819614629174706176"},
                new []{"00000001-0000-0000-0000-000000000000", "79228162514264337593543950336"},

                new []{"00000000-0000-0000-0000-F00000000000", "263882790666240"},
                new []{"00000000-0000-0000-F000-000000000000", "17293822569102704640"},
                new []{"00000000-0000-F000-0000-000000000000", "1133367955888714851287040"},
                new []{"00000000-F000-0000-0000-000000000000", "74276402357122816493947453440"},
                new []{"F0000000-0000-0000-0000-000000000000", "319014718988379809496913694467282698240"},
                new []{"FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", "340282366920938463463374607431768211455"},

                //These UIDs were generated by Visual Studio, and converted to decimal with the Python
                //converter mentioned above.
                new []{"33A4D06F-5B4A-420C-8778-12764A03B4E2", "68646392033606928191667069969500452066"},
                new []{"534918E5-534E-4918-8DB1-5C3E698C141C", "110705466267682660489308928177165046812"},
                new []{"DFDC8525-1F47-4E32-91A1-CAD58D3224F5", "297562848870513438750843654525464749301"},
                new []{"B71DDAB0-8242-4E0C-9DAB-88574866AF42", "243403735387300522275477254959389912898"},
                new []{"CBFD1BFE-28DE-44DC-BE4A-7F4757DE23B0", "271147502011207917925458937881779119024"},
                new []{"5633F579-429C-42DA-BBCD-789CC81C0CBA", "114583393574863518951200517614724713658"},
                new []{"19A8A9E3-3DA2-47E9-B877-B75F4883641D", "34106451497947426915778147192985052189"},
                new []{"DAF7AD50-F7ED-48DA-889A-A8E78EAEF297", "291057715677013852484148561513041293975"},
                new []{"C8CBF162-D1F5-4716-8238-E3208CF77F7B", "266904531309319040621529214696040136571"}
		    };

            foreach (var uidPair in uidPairs)
            {
                Console.WriteLine("Test value: {0}", uidPair[0]);
                Console.WriteLine(" Expected: {0}", uidPair[1]);

                var guidString = uidPair[0];
                var decimalString = uidPair[1];

                var guid = new Guid(guidString);
                var guidDecimalString = DicomUid.ConvertGuid(guid);
                Assert.AreEqual(decimalString, guidDecimalString);
                Console.WriteLine(" ConvertGuid: {0}", guidDecimalString);
#if !__MonoCS__
                var bigIntString = FromBigInt(guid);
                Console.WriteLine(" BigInteger:  {0}", bigIntString);
                Assert.AreEqual(decimalString, bigIntString);
#endif
                Console.WriteLine();
            }
		}

	    private string FromBigInt(Guid guid)
	    {
            var assembly = Assembly.Load("System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
            var bigInteger = assembly.GetType("System.Numerics.BigInteger");
            var parseMethod = bigInteger.GetMethods(BindingFlags.Static | BindingFlags.Public).First(m =>
            {
                if (m.Name != "Parse") return false;
                var parameters = m.GetParameters();
                if (parameters.Length != 2) return false;
                if (parameters[0].ParameterType != typeof(string)) return false;
                if (parameters[1].ParameterType != typeof(NumberStyles)) return false;
                return true;
            });

            //This is how we used to do it, but BigInteger doesn't work on Mono on Windows (yet).
            //Besides, the new way doesn't require referencing System.Numerics just for this.
            var guidBytes = string.Format("0{0:N}", guid);
            var bigInt = parseMethod.Invoke(null, new object[] { guidBytes, NumberStyles.HexNumber });
            return String.Format("{0}", bigInt);
	    }
	}
}

#endif