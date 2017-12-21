using System;
using SQLite;
using SQLitePCL;

namespace ICT13580086FinalA.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id  { get; set; }

		[NotNull]
		[MaxLength(100)]
        public string Name { get; set; }

		[NotNull]
		[MaxLength(100)]
        public string LastName { get; set; }


        public int Age { get; set; }
        public string Sex { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        [NotNull]
        public string Address { get; set; }
        public string Status { get; set; }
        public string Baby { get; set; }
        public decimal Saraly { get; set; }


    }
}
