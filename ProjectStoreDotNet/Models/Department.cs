using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ProjectStoreDotNet.Models
{
    public class Department
    {
        [Key]
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
