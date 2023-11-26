using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {
        public Client() { }
        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Sex { get; set; }
        public string Department { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Direction { get; set; }
        // New property for image data
        public byte[] ProfileImage { get; set; }

        // Additional metadata for the image, like file name
        public string ImageFileName { get; set; }
    }
}
