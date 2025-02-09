using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventEase.Models
{
	public class UserModel
	{
		public int Id {get;set;}
		public string Name {get;set;}
		public string Surname {get;set;}
		public string Email {get;set;}
		
		//in case the list is Empty , the user is not present to the event
		public List<AttendenceModel> AttendenceModelList {get; set;}
		
		public UserModel()
		{
			AttendenceModelList = new List<AttendenceModel>();

		}
		
	}
}