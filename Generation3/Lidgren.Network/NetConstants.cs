﻿/* Copyright (c) 2010 Michael Lidgren

Permission is hereby granted, free of charge, to any person obtaining a copy of this software
and associated documentation files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom
the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or
substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE
USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;

namespace Lidgren.Network
{
	public static class NetConstants
	{
		public const int kNetChannelsPerDeliveryMethod = 32;

		public const int kNumSequenceNumbers = ushort.MaxValue + 1; // 0 is a valid sequence number

		/// <summary>
		/// Number of channels which needs a sequence number to work
		/// </summary>
		public const int kNumSequencedChannels = ((int)NetMessageType.UserReliableOrdered + NetConstants.kNetChannelsPerDeliveryMethod) - (int)NetMessageType.UserSequenced;

		/// <summary>
		/// Number of reliable channels
		/// </summary>
		public const int kNumReliableChannels = ((int)NetMessageType.UserReliableOrdered + NetConstants.kNetChannelsPerDeliveryMethod) - (int)NetMessageType.UserReliableUnordered;
	}
}