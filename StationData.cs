using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Fire_Map___30074676
{
    //StationData class to store the data of the fire stations in the database and to map the data to the database
    public class StationData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Contact")]
        public string Contact { get; set; }

        [BsonElement("coordinates")]
        public List<double> coordinates { get; set; }
    }
}
