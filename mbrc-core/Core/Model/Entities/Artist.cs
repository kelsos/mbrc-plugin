﻿using System.Runtime.Serialization;

namespace MusicBeeRemote.Core.Model.Entities
{
    [DataContract]
    public class Artist
    {
        public Artist(string name, int count)
        {
            Name = name;
            Count = count;
        }

        [DataMember(Name = "artist")]
        public string Name { get; set; }

        [DataMember(Name = "count")]
        public int Count { get; set; }
    }
}
