﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class Attendance
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int SessionId { get; set; }
        public bool IsPresent { get; set; }
        public DateTime Date { get; set; }
    }
}
