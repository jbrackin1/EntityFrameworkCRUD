using System;
using System.ComponentModel.DataAnnotations;

namespace EFdemo.Models
{
	public class UserModel
	{
			public int Id { get; set; }
			[Required(ErrorMessage = "Please enter a name")]
			public string Name{ get; set; }
			[Required(ErrorMessage = "Please Enter an Email")]
			public string Email { get; set; }
			[Required(ErrorMessage = "Please enter a Username")]
			public string UserName { get; set; }
			[Range(16, 99, ErrorMessage = "Age must be between 16 and 99")]
			public int Age { get; set; }
	}
}

