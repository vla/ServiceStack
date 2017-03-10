﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServiceStack.Api.Swagger2.Specification
{
    [DataContract]
    public abstract class Swagger2DataTypeSchema
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "format")]
        public string Format { get; set; }
        [DataMember(Name = "items")]
        public Dictionary<string, string> Items { get; set; }
        [DataMember(Name = "collectionFormat")]
        public string CollectionFormat { get; set; }
        [DataMember(Name = "default")]
        public string Default { get; set; }
        [DataMember(Name = "maximum")]
        public string Maximum { get; set; }
        [DataMember(Name = "exclusiveMaximum")]
        public string ExclusiveMaximum { get; set; }
        [DataMember(Name = "minimum")]
        public string Minimum { get; set; }
        [DataMember(Name = "exclusiveMinimum")]
        public string ExclusiveMinimum { get; set; }
        [DataMember(Name = "maxLength")]
        public string MaxLength { get; set; }
        [DataMember(Name = "minLength")]
        public string MinLength { get; set; }
        [DataMember(Name = "pattern")]
        public string Pattern { get; set; }
        [DataMember(Name = "maxItems")]
        public string MaxItems { get; set; }
        [DataMember(Name = "minItems")]
        public string MinItems { get; set; }
        [DataMember(Name = "uniqueItems")]
        public bool? UniqueItems { get; set; }
        [DataMember(Name = "enum")]
        public List<string> Enum { get; set; }
        [DataMember(Name = "multipleOf")]
        public string MultipleOf { get; set; }
    }
}
