﻿namespace Session4.RModel
{
    public class Response
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }

        public List<string>? Errors { get; set; }
        public dynamic Data { get; set; }
    }
}
