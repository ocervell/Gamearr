﻿using System;
using Gamearr.Http.REST;

namespace Gamearr.Api.V1.Logs
{
    public class LogFileResource : RestResource
    {
        public string Filename { get; set; }
        public DateTime LastWriteTime { get; set; }
        public string ContentsUrl { get; set; }
        public string DownloadUrl { get; set; }
    }
}
