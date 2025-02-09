using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventEase.Models;

namespace EventEase.Services
{
	// Mock degli Utenti
	public class UserService
	{
		private List<UserModel> userList;

		public List<UserModel> Users
		{
			get { return userList; }
		}

		public UserService()
		{
			// Simulo che i dati provengono dal database
			userList = new List<UserModel>
			{
				new UserModel { Id = 1, Name = "John", Surname = "Doe", Email = "john.doe@example.com" },
				new UserModel { Id = 2, Name = "Jane", Surname = "Smith", Email = "jane.smith@example.com" },
				new UserModel { Id = 3, Name = "Alice", Surname = "Johnson", Email = "alice.johnson@example.com" },
				new UserModel { Id = 4, Name = "Bob", Surname = "Brown", Email = "bob.brown@example.com" },
				new UserModel { Id = 5, Name = "Emily", Surname = "White", Email = "emily.white@example.com" },
				new UserModel { Id = 6, Name = "Michael", Surname = "Davis", Email = "michael.davis@example.com" },
				new UserModel { Id = 7, Name = "Sarah", Surname = "Miller", Email = "sarah.miller@example.com" },
				new UserModel { Id = 8, Name = "David", Surname = "Wilson", Email = "david.wilson@example.com" }
			};
		}



		// Metodo asincrono per verificare se il nome e l'email sono presenti nella lista
		public async Task<bool> ValidateUserAsync(string name, string email)
		{
			return await Task.Run(() => userList.Any(user => user.Name == name && user.Email == email));
		}

		// Metodo asincrono per ottenere l'ID dell'utente con il nome e l'email specificati
		public async Task<int?> GetUserIdAsync(string name, string email)
		{
			var user = await Task.Run(() => userList.FirstOrDefault(user => user.Name == name && user.Email == email));
			return user?.Id;
		}

		// Async Method , return User by Id
		public async Task<UserModel?> GetUserByIdAsync(int id)
		{
			return await Task.Run(() => userList.FirstOrDefault(user => user.Id == id));
		}
		
		
		// Save the attendance for the user
		public async Task<bool> SaveAttendanceAsync(int userId, AttendenceModel attendance)
		{
			return await Task.Run(() =>
			{
				var user = userList.FirstOrDefault(u => u.Id == userId);
				if (user != null)
				{
					user.AttendenceModelList.Add(attendance);
					return true;
				}
				return false;
			});
		}

	}
}
