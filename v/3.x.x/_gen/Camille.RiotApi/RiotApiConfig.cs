﻿
// This file is automatically generated.
// Do not directly edit.
// Generated on 2020-07-29T03:12:00.488Z
using System;

namespace Camille.RiotApi
{
    public interface IRiotApiConfig
    {
        /// <summary>Riot Games API key.</summary>
        string ApiKey { get; }

        /// <summary>Maximum number of concurrent requests allowed.</summary>
        int MaxConcurrentRequests { get; }

        /// <summary>Multiplier for using concurrent instances. For example, use 0.25 for 4 concurrent instances equally spread.</summary>
        float ConcurrentInstanceFactor { get; }

        /// <summary>Overhead factor to reduce the chance 429s due to network noise.</summary>
        float OverheadFactor { get; }

        /// <summary>Number of times to retry a failed request (zero for no retries).</summary>
        int Retries { get; }

        /// <summary>Factory for creating token buckets.</summary>
        Util.TokenBucketFactory TokenBucketFactory { get; }

        /// <summary>A backoff strategy for 429s with missing Retry-After headers. Returns seconds.</summary>
        Util.BackoffStrategy BackoffStrategy { get; }

    }


    public class RiotApiConfig : IRiotApiConfig
    {
        /// <summary>Riot Games API key.</summary>
        public string ApiKey { get; }

        /// <summary>Maximum number of concurrent requests allowed.</summary>
        public int MaxConcurrentRequests { get; }

        /// <summary>Multiplier for using concurrent instances. For example, use 0.25 for 4 concurrent instances equally spread.</summary>
        public float ConcurrentInstanceFactor { get; }

        /// <summary>Overhead factor to reduce the chance 429s due to network noise.</summary>
        public float OverheadFactor { get; }

        /// <summary>Number of times to retry a failed request (zero for no retries).</summary>
        public int Retries { get; }

        /// <summary>Factory for creating token buckets.</summary>
        public Util.TokenBucketFactory TokenBucketFactory { get; }

        /// <summary>A backoff strategy for 429s with missing Retry-After headers. Returns seconds.</summary>
        public Util.BackoffStrategy BackoffStrategy { get; }

        private RiotApiConfig(string apiKey, int maxConcurrentRequests, float concurrentInstanceFactor, float overheadFactor, int retries, Util.TokenBucketFactory tokenBucketFactory, Util.BackoffStrategy backoffStrategy)
        {
            ApiKey = apiKey;
            MaxConcurrentRequests = maxConcurrentRequests;
            ConcurrentInstanceFactor = concurrentInstanceFactor;
            OverheadFactor = overheadFactor;
            Retries = retries;
            TokenBucketFactory = tokenBucketFactory;
            BackoffStrategy = backoffStrategy;
        }

        public class Builder
        {
            /// <summary>Riot Games API key.</summary>
            public string ApiKey;

            /// <summary>Maximum number of concurrent requests allowed.</summary>
            /// <example>
            /// Default value:
            /// <code>
            /// 1000
            /// </code>
            /// </example>
            public int MaxConcurrentRequests = 1000;

            /// <summary>Multiplier for using concurrent instances. For example, use 0.25 for 4 concurrent instances equally spread.</summary>
            /// <example>
            /// Default value:
            /// <code>
            /// 1f
            /// </code>
            /// </example>
            public float ConcurrentInstanceFactor = 1f;

            /// <summary>Overhead factor to reduce the chance 429s due to network noise.</summary>
            /// <example>
            /// Default value:
            /// <code>
            /// 0.95f
            /// </code>
            /// </example>
            public float OverheadFactor = 0.95f;

            /// <summary>Number of times to retry a failed request (zero for no retries).</summary>
            /// <example>
            /// Default value:
            /// <code>
            /// 5
            /// </code>
            /// </example>
            public int Retries = 5;

            /// <summary>Factory for creating token buckets.</summary>
            /// <example>
            /// Default value:
            /// <code>
            /// (timespan, totalLimit, concurrentInstanceFactor, overheadFactor) => new MingweiSamuel.TokenBucket.CircularTokenBucket(timespan, totalLimit, 20, 0.5f, concurrentInstanceFactor * overheadFactor)
            /// </code>
            /// </example>
            public Util.TokenBucketFactory TokenBucketFactory = (timespan, totalLimit, concurrentInstanceFactor, overheadFactor) => new MingweiSamuel.TokenBucket.CircularTokenBucket(timespan, totalLimit, 20, 0.5f, concurrentInstanceFactor * overheadFactor);

            /// <summary>A backoff strategy for 429s with missing Retry-After headers. Returns seconds.</summary>
            /// <example>
            /// Default value:
            /// <code>
            /// (retries, num429s) => 0.5 + Math.Pow(2, num429s)
            /// </code>
            /// </example>
            public Util.BackoffStrategy BackoffStrategy = (retries, num429s) => 0.5 + Math.Pow(2, num429s);

            public Builder(string apiKey)
            {
                ApiKey = apiKey ?? throw new ArgumentException($"{nameof(apiKey)} cannot be null.");
            }

            public RiotApiConfig Build()
            {
                return new RiotApiConfig(ApiKey, MaxConcurrentRequests, ConcurrentInstanceFactor, OverheadFactor, Retries, TokenBucketFactory, BackoffStrategy);
            }
        }
    }
}
