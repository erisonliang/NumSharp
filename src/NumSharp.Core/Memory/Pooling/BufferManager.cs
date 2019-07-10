﻿using System;

namespace NumSharp.Memory.Pooling
{
    public abstract class BufferManager
    {
        public abstract byte[] TakeBuffer(int bufferSize);
        public abstract void ReturnBuffer(byte[] buffer);
        public abstract void Clear();

        public static BufferManager CreateBufferManager(long maxBufferPoolSize, int maxBufferSize)
        {
            if (maxBufferSize < 0) throw new ArgumentOutOfRangeException(nameof(maxBufferSize));
            if (maxBufferPoolSize < 0) throw new ArgumentOutOfRangeException(nameof(maxBufferPoolSize));


            return new WrappingBufferManager(InternalBufferManager.Create(maxBufferPoolSize, maxBufferSize));
        }

        internal static InternalBufferManager GetInternalBufferManager(BufferManager bufferManager)
        {
            if (bufferManager is WrappingBufferManager)
            {
                return ((WrappingBufferManager)bufferManager).InternalBufferManager;
            }
            else
            {
                return new WrappingInternalBufferManager(bufferManager);
            }
        }

        class WrappingBufferManager : BufferManager
        {
            InternalBufferManager innerBufferManager;

            public WrappingBufferManager(InternalBufferManager innerBufferManager)
            {
                this.innerBufferManager = innerBufferManager;
            }

            public InternalBufferManager InternalBufferManager
            {
                get { return this.innerBufferManager; }
            }

            public override byte[] TakeBuffer(int bufferSize)
            {
                if (bufferSize < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(bufferSize), bufferSize, "");
                }

                return this.innerBufferManager.TakeBuffer(bufferSize);
            }

            public override void ReturnBuffer(byte[] buffer)
            {
                if (buffer == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(buffer), buffer, "");
                }

                this.innerBufferManager.ReturnBuffer(buffer);
            }

            public override void Clear()
            {
                this.innerBufferManager.Clear();
            }
        }

        class WrappingInternalBufferManager : InternalBufferManager
        {
            BufferManager innerBufferManager;

            public WrappingInternalBufferManager(BufferManager innerBufferManager)
            {
                this.innerBufferManager = innerBufferManager;
            }

            public override void Clear()
            {
                this.innerBufferManager.Clear();
            }

            public override void ReturnBuffer(byte[] buffer)
            {
                this.innerBufferManager.ReturnBuffer(buffer);
            }

            public override byte[] TakeBuffer(int bufferSize)
            {
                return this.innerBufferManager.TakeBuffer(bufferSize);
            }
        }
    }
}
