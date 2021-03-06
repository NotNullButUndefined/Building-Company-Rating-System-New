﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Entities
{
    public class Comment : IIdentifiable
    {
        [Required]
        public int Id { get; set; }

        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public int BuildingId { get; set; }
        public Building Building { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
    }
}