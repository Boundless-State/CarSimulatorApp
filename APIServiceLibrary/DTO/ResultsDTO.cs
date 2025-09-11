using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIServiceLibrary.DTO
{
    public class ResultsDTO
    {
        [Required]
        public List<ResultDTO> Results { get; set; } = new();
    }
}
