﻿

using Newtonsoft.Json;

namespace MoviesBot.Data.DTO
{
    class Response
    {
        [JsonProperty(PropertyName = "ok", Required = Required.Always)]
        public bool Success { get; set; }
        [JsonProperty(PropertyName = "result", Required = Required.Default)]
        public Result[] Results { get; set; }
    }
}
