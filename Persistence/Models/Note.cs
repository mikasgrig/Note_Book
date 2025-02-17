﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class Note
    {
        public int Id { get; set; }
        public DateTime DateCreated  { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} Date Crate: {DateCreated} Title: {Title} Text: {Text}";
        }
    }
    
}
