﻿using Newtonsoft.Json.Linq;

namespace MusicBeeRemote.Core.Events
{
    public class MessageEvent : IEvent
    {
        public MessageEvent(string type, object data, string connectionId, string clientId)
        {
            Type = type;
            Data = data;
            ConnectionId = connectionId;
            ClientId = clientId;
        }

        public object Data { get; }

        public string Type { get; }

        public string ConnectionId { get; }

        public string ClientId { get; }

        public object Sender { get; } = null;

        public JToken DataToken()
        {
            return Data as JToken;
        }
    }
}
