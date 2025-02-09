﻿using System;
using System.Buffers;

namespace KcpSharp.ThroughputBanchmarks
{
    /// <summary>
    /// Wraps an array in a reusable block of managed memory
    /// </summary>
    internal sealed class MemoryPoolBlock : IMemoryOwner<byte>
    {
        internal MemoryPoolBlock(PinnedBlockMemoryPool pool, int length)
        {
            Pool = pool;

            Memory = GC.AllocateUninitializedArray<byte>(length, pinned: true);
        }

        /// <summary>
        /// Back-reference to the memory pool which this block was allocated from. It may only be returned to this pool.
        /// </summary>
        public PinnedBlockMemoryPool Pool { get; }

        public Memory<byte> Memory { get; }

        public void Dispose()
        {
            Pool.Return(this);
        }
    }
}
