﻿using System;

namespace EventStore.Core.TransactionLog.Chunks
{
    public interface ITFChunkScavengerLog
    {
        string ScavengeId { get; }
        
        void ScavengeStarted();

        void ChunksScavenged(int chunkStartNumber, int chunkEndNumber, TimeSpan elapsed, long spaceSaved);

        void ChunksNotScavenged(int chunkStartNumber, int chunkEndNumber, TimeSpan elapsed, string errorMessage);

        void ScavengeCompleted(ScavengeResult result, string error, TimeSpan elapsed);
    }
    
    public enum ScavengeResult
    {
        Success,
        Failed,
        Stopped
    }
}
