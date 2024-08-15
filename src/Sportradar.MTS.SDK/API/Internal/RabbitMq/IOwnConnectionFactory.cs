/*
 * Copyright (C) Sportradar AG. See LICENSE for full license governing this code
 */

using RabbitMQ.Client;

namespace Sportradar.MTS.SDK.API.Internal.RabbitMq
{
    /// <summary>
    /// Compatible replacement for extensions of sealed class <see cref="ConnectionFactory"/>
    /// </summary>
    internal interface IOwnConnectionFactory
    {
        IConnection CreateConnection();
    }
}
