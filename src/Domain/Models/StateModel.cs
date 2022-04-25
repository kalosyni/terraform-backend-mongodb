﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Kalosyni.TerraformBackend.Domain.Models
{
    public class StateModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.MinValue;

        public StateValueModel Value { get; set; } = new StateValueModel();
    }
}
