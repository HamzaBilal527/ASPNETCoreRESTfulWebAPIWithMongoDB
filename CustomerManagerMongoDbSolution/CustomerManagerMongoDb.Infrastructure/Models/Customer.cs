using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagerMongoDb.Infrastructure.Models
{
    public class Customer
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement]
        [Required(ErrorMessage = "CustomerId cant be null or emoty")]
        public int CustomerId { get; set; }

        [BsonElement]
        [Required(ErrorMessage = "Name cant be null or emoty")]
        public string Name { get; set; }

        [BsonElement]
        [Required(ErrorMessage = "Name cant be null or emoty")]
        [Range(18, 99, ErrorMessage = "Age must be btw 18 and 99")]
        public int Age { get; set; }

        [BsonElement]
        [Required(ErrorMessage = "Salary cant be null or emoty")]
        [Range(1000, 10000, ErrorMessage = "Salary must be btw 1000 and 10000")]

        public int Salary { get; set; }

    }
}
