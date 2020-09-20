﻿using System.Collections;
using System.Collections.Generic;
using PakReader.Parsers.Objects;

namespace PakReader.Parsers.Class
{
    public sealed class UAkAudioEvent : IUExport
    {
        public FObjectExport Export { get; set; }
        readonly Dictionary<string, object> Map;

        internal UAkAudioEvent(PackageReader reader)
        {
            _ = new UObject(reader, true);
            Map = new Dictionary<string, object>(1)
            {
                { "MaxAttenuationRadius", reader.ReadFloat() }
            };
        }

        public object this[string key] => Map[key];
        public IEnumerable<string> Keys => Map.Keys;
        public IEnumerable<object> Values => Map.Values;
        public int Count => Map.Count;
        public bool ContainsKey(string key) => Map.ContainsKey(key);
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => Map.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Map.GetEnumerator();

        public bool TryGetValue(string key, out object value) => Map.TryGetValue(key, out value);
    }
}