﻿using Project1.Models;
using System.ComponentModel.DataAnnotations;

namespace Project1.ViewModels
{
    public class CourseRankViewModel
    {
        public int CourseID { get; set; }
        public int TrainerID { get; set; }
        public int? Clicks { get; set; }

        public double CourseAverageRating { get; set; }

        public int TotalQuantity { get; set; }

        public string? ThumbnailUrl { get; set; }

        public string CourseName { get; set; }

        public string? Description { get; set; }
    }
}
