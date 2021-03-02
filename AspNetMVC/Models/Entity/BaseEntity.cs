﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models.Entity
{
    public class BaseEntity
    {
        [Display(Name = "建立時間")]
        public DateTime CreateTime { get; set; }

        [Display(Name = "建立者")]
        public string CreateUser { get; set; }

        [Display(Name = "編輯時間")]
        public DateTime EditTime { get; set; }

        [Display(Name = "編輯者")]
        public string EditUser { get; set; }
    }
    public interface IProduct { }
}