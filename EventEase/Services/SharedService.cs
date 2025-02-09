using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventEase.Models;

namespace EventEase.Services
{
	
	//Must be Singleton
	public class SharedService
	{
		//show the selected link of navbar menu
		public string SelectedLink{ get; set; }
		//User's list
		//public List<UserModel> UserList {get; set;} 
		
		public SharedService()
		{
			SelectedLink = "Home";
			//UserList = new List<UserModel>();
		}
		
	}
}