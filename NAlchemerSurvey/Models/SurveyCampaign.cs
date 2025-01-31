﻿using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace NAlchemerSurvey.Models
{
    // there are other properties, but right now we only need the id, name, and status. we'll add these when we need them.
    // uri, SSL, tokenvariables, limit_responses, close_message, language, datecreated, datemodified

    public class SurveyCampaign
    {
        [Key]
        public int id { get; set; }
        public string status { get; set; }
        public string name { get; set; }
        [JsonProperty("type")]
        public string _type { get; set; }
        [JsonProperty("subtype")]
        public string _subtype { get; set; }

        public bool Equals(SurveyCampaign sc)
        {
            return id       == sc.id
                && status   == sc.status
                && name     == sc.name
                && _type    == sc._type
                && _subtype == sc._subtype;
        }
    }
}
