﻿using System;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MusicBeeRemote.Core.Model.Entities
{
    [DataContract]
    public class SocketMessage
    {
        public SocketMessage(string context, object data = null)
        {
            Context = context;
            Data = data;
        }

        public SocketMessage(JObject jsonObject)
        {
            if (jsonObject == null)
            {
                throw new ArgumentNullException(nameof(jsonObject));
            }

            Context = (string)jsonObject["context"];

            var messageData = jsonObject["data"];
            if (messageData == null)
            {
                Data = string.Empty;
            }
            else
            {
                if (messageData.Contains("{") && messageData.Contains("}"))
                {
                    Data = jsonObject["data"];
                }
                else
                {
                    Data = messageData;
                }
            }
        }

        public SocketMessage()
        {
        }

        [DataMember(Name = "context")]
        public string Context { get; set; }

        [DataMember(Name = "data")]
        public object Data { get; set; }

        [IgnoreDataMember]
        public bool NewLineTerminated { get; set; } = false;

        public string ToJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
