﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDogSelector.Models
{
    public enum EScale {NoPreference, Low, Medium, High}
    public enum ESize {Miniature, Small, Medium, Large, Giant}
    public enum ELength { Short, Medium, Long}

    public class Dog
    {
        public string BreedName { get; set; }
        public string DisplayName { get; set; }
        public string ImageName { get; set; }
        public EScale ActivityLevel { get; set; }
        public EScale SheddingLevel { get; set; }
        public EScale GroomingLevel { get; set; }
        public EScale IntelligenceLevel { get; set; }
        public bool GoodWithChildren { get; set; }
        public bool Drools { get; set; }
        public ELength Coatlength { get; set; }
        public ESize Size { get; set; }
        public int MatchScore { get; set; }

     }
}