﻿using System.Text.Json.Serialization;

namespace LearnCSharp.Module3.Models
{
    public class User 
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }
        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("address")]
        public Address address { get; set; }        

        [JsonPropertyName("company")]
        public Company Company { get; set; } = new Company();
    }
}
