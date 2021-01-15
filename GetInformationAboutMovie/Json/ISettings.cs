﻿using Config.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetInformationAboutMovie.Json
{
    public interface ISettings
    {
        [Option(Alias = "apikey")]
        string ApiKey { get; }
    }
}
