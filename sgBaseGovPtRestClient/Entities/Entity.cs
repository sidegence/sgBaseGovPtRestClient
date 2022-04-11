﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgBaseGovPtRestClient.Entities
{
    public class Entity
    {
        public string? nif { get; set; }
        public string? sumTotalContractsReceived { get; set; }
        public int totalContractsGiven { get; set; }
        public int totalContractsReceived { get; set; }
        public string? sumTotalContractsGiven { get; set; }
        public string? description { get; set; }
        public string? location { get; set; }
        public int id { get; set; }
    }


}
