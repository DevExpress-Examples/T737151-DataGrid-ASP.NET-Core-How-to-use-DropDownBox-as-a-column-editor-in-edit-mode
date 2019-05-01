using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace CS.Models {
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Priority { High, Normal, Low, Urgent }
    public class EmployeeTask
    {
        public int Completion { get; set; }
        public DateTime DueDate { get; set; }
        public int ID { get; set; }
        public Priority Priority { get; set; }
        public DateTime StartDate { get; set; }
        public string Status { get; set; }
        public string Subject { get; set; }
    }
}