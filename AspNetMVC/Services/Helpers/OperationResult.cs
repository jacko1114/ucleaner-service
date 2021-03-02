﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVC.Services
{
    public class OperationResult
    {
        public bool IsSuccessful { get; set; }
        public Exception Exception { get; set; }
        public string MessageInfo { get; set; }
        public int Status { get; set; }
    }
    public static class OperationResultHelper
    {
        public static string WriteLog(this OperationResult value)
        {
            if (value.Exception != null)
            {
                string path = DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss");
                path = path + ".txt";
                File.WriteAllText(path, value.Exception.ToString());
                return path;
            }
            else
            {
                return "沒有存檔";
            }
        }
    }
    public static class OperationResultStatus
    {
        public const int Success = 0;

        public const int Fail = 1;

        public const int NotFound = 2;

        public const int ErrorRequest = 3;
    }
}
