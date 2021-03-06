﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThoughtEncyclopedia.Models
{
    //The Heart of the website is this data model it represents the Users thoughts upon the specified Topic
    public class Thought
    {
        public int ThoughtId { get; set; }
        public string ContentText { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        //[ConcurrencyCheck]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateModified { get; set; } = DateTime.Now;
        public int ViewCount { get; set; } = 0;
        public int UpvoteCount { get; set; } = 0;
        public int DownvoteCount { get; set; } = 0;
        public int LikeCount { get; set; } = 0;
        public IdentityUser User { get; set; }
        public Topic Topic { get; set; }
    }
}
