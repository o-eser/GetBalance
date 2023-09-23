using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetBalance.DATA.Enums;

namespace GetBalance.DATA
{
	public class UserDetail
	{
		public int UserDetailId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public Gender Gender { get; set; }
		public double Height { get; set; }
		public double CurrentWeight { get; set; }
		public int UserId { get; set; }
        public ActivityLevel ActivityLevel { get; set; } //Eklendi -volkan.
        public User User { get; set; }
        public UserTarget UserTarget { get; set; }
    }
}
