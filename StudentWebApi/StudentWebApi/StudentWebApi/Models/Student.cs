using System.ComponentModel.DataAnnotations;

namespace StudentWebApi.Models
{
    namespace StudentWebApi.Models
    {
        public class Student
        {
            public int Rooln { get; set; }   
            public string Name { get; set; } = string.Empty;
            public string Batch { get; set; } = string.Empty;
            public int Marks { get; set; }
        }
    }

}
