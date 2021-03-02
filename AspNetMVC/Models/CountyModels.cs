﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models {
	public class CountyModels {
		public string Name;
		public List<string> Districts;
		public static List<CountyModels> County;

		static CountyModels() {
			County = new List<CountyModels>();
			County.Add(new CountyModels("台北市", new List<string>() {
				"中正區", "大同區", "中山區", "松山區", "大安區", "萬華區",
				"信義區", "士林區", "北投區", "內湖區", "南港區", "文山區",
			}));
			County.Add(new CountyModels("新北市", new List<string>() {
				"萬里區", "金山區", "板橋區", "汐止區", "深坑區", "石碇區", "瑞芳區", "平溪區",
				"雙溪區", "貢寮區", "新店區", "坪林區", "烏來區", "永和區", "中和區", "土城區",
				"三峽區", "樹林區", "鶯歌區", "三重區", "新莊區", "泰山區", "林口區", "蘆洲區",
				"五股區", "八里區", "淡水區", "三芝區", "石門區",
			}));
		}
		public CountyModels(string name, List<string> districts) {
			Name = name;
			Districts = districts;
		}
	}
}