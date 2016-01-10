﻿using System;
using NetMQ.Core;

namespace NetMQ.Sockets
{
    /// <summary>
    /// A PushSocket is a NetMQSocket intended to be used as the "Push" part of the Push-Pull pattern.
    /// This will "push" messages to be pulled by the "pull" socket.
    /// </summary>
    public class PushSocket : NetMQSocket
    {
        /// <summary>
        /// Create new PushSocket
        /// </summary>
        public PushSocket() : base(ZmqSocketType.Push)
        {
            
        }

        /// <summary>
        /// Create a new PushSocket based upon the given SocketBase.
        /// </summary>
        /// <param name="socketHandle">the SocketBase to create the new socket from</param>
        internal PushSocket(SocketBase socketHandle)
            : base(socketHandle)
        {
        }

        /// <summary><see cref="PushSocket"/> doesn't support sending, so this override throws <see cref="NotSupportedException"/>.</summary>
        /// <exception cref="NotSupportedException">Receive is not supported.</exception>
        [Obsolete("Use Receive(ref Msg) or TryReceive(ref Msg,TimeSpan) instead.")]
        public override void Receive(ref Msg msg, SendReceiveOptions options)
        {
            throw new NotSupportedException("PushSocket doesn't support receiving");
        }

        /// <summary><see cref="PushSocket"/> doesn't support sending, so this override throws <see cref="NotSupportedException"/>.</summary>
        /// <exception cref="NotSupportedException">Receive is not supported.</exception>
        public override bool TryReceive(ref Msg msg, TimeSpan timeout)
        {
            throw new NotSupportedException("PushSocket doesn't support receiving");
        }
    }
}
