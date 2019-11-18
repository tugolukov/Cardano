﻿namespace Cardano.Abstractions.Client
{
    /// <summary>
    /// Responce from server
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Response<T>
    {
        /// <inheritdoc cref="T"/>
        public T Data { get; set; }

        /// <summary>
        /// Meta
        /// </summary>
        public Meta Meta { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public Status Status { get; set; }
    }
}