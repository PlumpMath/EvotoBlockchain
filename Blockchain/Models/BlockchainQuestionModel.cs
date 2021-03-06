﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Blockchain.Models
{
    public class BlockchainQuestionModel
    {
        [DataMember(Name = "num")]
        public int Number { get; set; }

        [DataMember(Name = "question")]
        public string Question { get; set; }

        [DataMember(Name = "info")]
        public string Info { get; set; }

        [DataMember(Name = "answers")]
        public List<BlockchainAnswerModel> Answers { get; set; }
    }
}