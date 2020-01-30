/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if !NO_GAS
using System;
using Iced.Intel.FormatterInternal;

namespace Iced.Intel.GasFormatterInternal {
	static class MemorySizes {
		public static readonly FormatterString[] AllMemorySizes = GetMemorySizes();
		enum BroadcastToKind {
			b1to2,
			b1to4,
			b1to8,
			b1to16,
		}
		static FormatterString[] GetMemorySizes() {
#if HAS_SPAN
			ReadOnlySpan<byte>
#else
			byte[]
#endif
			bcstToData = new byte[IcedConstants.NumberOfMemorySizes - (int)IcedConstants.FirstBroadcastMemorySize] {
				// GENERATOR-BEGIN: BcstTo
				// ⚠️This was generated by GENERATOR!🦹‍♂️
				(byte)BroadcastToKind.b1to2,
				(byte)BroadcastToKind.b1to2,
				(byte)BroadcastToKind.b1to2,
				(byte)BroadcastToKind.b1to4,
				(byte)BroadcastToKind.b1to4,
				(byte)BroadcastToKind.b1to2,
				(byte)BroadcastToKind.b1to2,
				(byte)BroadcastToKind.b1to2,
				(byte)BroadcastToKind.b1to4,
				(byte)BroadcastToKind.b1to2,
				(byte)BroadcastToKind.b1to8,
				(byte)BroadcastToKind.b1to8,
				(byte)BroadcastToKind.b1to4,
				(byte)BroadcastToKind.b1to4,
				(byte)BroadcastToKind.b1to4,
				(byte)BroadcastToKind.b1to8,
				(byte)BroadcastToKind.b1to4,
				(byte)BroadcastToKind.b1to16,
				(byte)BroadcastToKind.b1to16,
				(byte)BroadcastToKind.b1to8,
				(byte)BroadcastToKind.b1to8,
				(byte)BroadcastToKind.b1to8,
				(byte)BroadcastToKind.b1to16,
				(byte)BroadcastToKind.b1to8,
				(byte)BroadcastToKind.b1to4,
				(byte)BroadcastToKind.b1to8,
				(byte)BroadcastToKind.b1to16,
				(byte)BroadcastToKind.b1to2,
				(byte)BroadcastToKind.b1to4,
				(byte)BroadcastToKind.b1to8,
				(byte)BroadcastToKind.b1to2,
				(byte)BroadcastToKind.b1to4,
				(byte)BroadcastToKind.b1to8,
				(byte)BroadcastToKind.b1to4,
				(byte)BroadcastToKind.b1to8,
				(byte)BroadcastToKind.b1to16,
				// GENERATOR-END: BcstTo
			};

			var infos = new FormatterString[IcedConstants.NumberOfMemorySizes];
			var b1to2 = new FormatterString("1to2");
			var b1to4 = new FormatterString("1to4");
			var b1to8 = new FormatterString("1to8");
			var b1to16 = new FormatterString("1to16");
			for (int i = 0; i < infos.Length; i++) {
				FormatterString bcstTo;
				if (i < (int)IcedConstants.FirstBroadcastMemorySize)
					bcstTo = default;
				else {
					bcstTo = (BroadcastToKind)bcstToData[i - (int)IcedConstants.FirstBroadcastMemorySize] switch {
						BroadcastToKind.b1to2 => b1to2,
						BroadcastToKind.b1to4 => b1to4,
						BroadcastToKind.b1to8 => b1to8,
						BroadcastToKind.b1to16 => b1to16,
						_ => throw new InvalidOperationException(),
					};
				}

				infos[i] = bcstTo;
			}

			return infos;
		}
	}
}
#endif