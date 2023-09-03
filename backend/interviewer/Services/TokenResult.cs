﻿namespace interviewer.Services
{
    // TokenResult 定义
    public class TokenResult
    {
        public bool Success => Errors == null || !Errors.Any();
        public IEnumerable<string> Errors { get; set; }

        public string AccessToken { get; set; }
        public string TokenType { get; set; }
    }
}