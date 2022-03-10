using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebJWTToken.Models
{
	public class Users
	{
		public string Name { get; set; }
		public string Password { get; set; }
	}

	public class Tokens
	{
        public int StatusCode { get; set; }
        public string Msg { get; set; }
        public string Token { get; set; }
		public string RefreshToken { get; set; }
	}
}
