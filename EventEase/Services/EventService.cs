using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventEase.Models;

namespace EventEase.Services
{
	public class EventService
	{
		// Short data
		private List<EventModel> eventList;

		// Data details
		private List<EventDetailModel> eventDetailList;

		// Property to get the short event list
		public List<EventModel> EventList
		{
			get { return eventList; }
		}

		// Property to get the detailed event list
		public List<EventDetailModel> EventDetailList
		{
			get { return eventDetailList; }
		}

		// Constructor to initialize the event lists
		public EventService()
		{
			// Get short event list
			eventList = GetEvents().Result;

			// Get detailed events list
			eventDetailList = GetDetailsEvents().Result;
		}

		// Method to get the short event list asynchronously
		public async Task<List<EventModel>> GetEvents()
		{
			return new List<EventModel>
			{
				new EventModel { Id = 1, Name = "Concert"},
				new EventModel { Id = 2, Name = "Art Exhibition"},
				new EventModel { Id = 3, Name = "Food Festival"},
				new EventModel { Id = 4, Name = "Tech Conference"},
				new EventModel { Id = 5, Name = "Music Festival"},
				new EventModel { Id = 6, Name = "Literary Festival"},
				new EventModel { Id = 7, Name = "Film Festival"},
				new EventModel { Id = 8, Name = "Marathon"},
				new EventModel { Id = 9, Name = "Wine Tasting"},
				new EventModel { Id = 10, Name = "Fashion Show"},
				new EventModel { Id = 11, Name = "Art Fair"},
				new EventModel { Id = 12, Name = "Charity Gala"},
				new EventModel { Id = 13, Name = "Comedy Night"},
				new EventModel { Id = 14, Name = "Culinary Workshop"},
				new EventModel { Id = 15, Name = "Jazz Night"},
				new EventModel { Id = 16, Name = "Theater Play"},
				new EventModel { Id = 17, Name = "Science Fair"},
				new EventModel { Id = 18, Name = "Circus"},
				new EventModel { Id = 19, Name = "Rock Concert"},
				new EventModel { Id = 20, Name = "Book Fair"},
				new EventModel { Id = 21, Name = "Opera Night"},
				new EventModel { Id = 22, Name = "Dance Show"},
				new EventModel { Id = 23, Name = "Auto Show"},
				new EventModel { Id = 24, Name = "History Exhibition"},
				new EventModel { Id = 25, Name = "Poetry Reading"},
				new EventModel { Id = 26, Name = "Christmas Market"},
				new EventModel { Id = 27, Name = "Art Workshop"},
				new EventModel { Id = 28, Name = "Hiking Event"},
				new EventModel { Id = 29, Name = "Yoga Retreat"},
				new EventModel { Id = 30, Name = "Beer Festival"}
				// Additional events...
			};
		}

		// Method to get the detailed event list asynchronously
		public async Task<List<EventDetailModel>> GetDetailsEvents()
		{
			return new List<EventDetailModel>
			{
				new EventDetailModel { Id = 1, Name = "Concert", Date = DateTime.Now.AddDays(5), Location="Milan", Description="Classic Concert" },
				new EventDetailModel { Id = 2, Name = "Art Exhibition", Date = DateTime.Now.AddDays(10), Location="Torino", Description="Leonardo Da Vinci" },
				new EventDetailModel { Id = 3, Name = "Food Festival", Date = DateTime.Now.AddDays(15), Location="Rome", Description="Street Food Extravaganza" },
				new EventDetailModel { Id = 4, Name = "Tech Conference", Date = DateTime.Now.AddDays(20), Location="Bologna", Description="Latest Tech Innovations" },
				new EventDetailModel { Id = 5, Name = "Music Festival", Date = DateTime.Now.AddDays(25), Location="Florence", Description="Live Bands and DJs" },
				new EventDetailModel { Id = 6, Name = "Literary Festival", Date = DateTime.Now.AddDays(30), Location="Naples", Description="Authors and Book Signings" },
				new EventDetailModel { Id = 7, Name = "Film Festival", Date = DateTime.Now.AddDays(35), Location="Venice", Description="Independent Films Showcase" },
				new EventDetailModel { Id = 8, Name = "Marathon", Date = DateTime.Now.AddDays(40), Location="Genoa", Description="Annual City Marathon" },
				new EventDetailModel { Id = 9, Name = "Wine Tasting", Date = DateTime.Now.AddDays(45), Location="Siena", Description="Local Wines and Vineyards" },
				new EventDetailModel { Id = 10, Name = "Fashion Show", Date = DateTime.Now.AddDays(50), Location="Milan", Description="Spring Collection" },
				new EventDetailModel { Id = 11, Name = "Art Fair", Date = DateTime.Now.AddDays(55), Location="Florence", Description="Contemporary Art" },
				new EventDetailModel { Id = 12, Name = "Charity Gala", Date = DateTime.Now.AddDays(60), Location="Rome", Description="Fundraiser Event" },
				new EventDetailModel { Id = 13, Name = "Comedy Night", Date = DateTime.Now.AddDays(65), Location="Turin", Description="Stand-Up Comedy Show" },
				new EventDetailModel { Id = 14, Name = "Culinary Workshop", Date = DateTime.Now.AddDays(70), Location="Bologna", Description="Cooking Classes" },
				new EventDetailModel { Id = 15, Name = "Jazz Night", Date = DateTime.Now.AddDays(75), Location="Verona", Description="Live Jazz Band" },
				new EventDetailModel { Id = 16, Name = "Theater Play", Date = DateTime.Now.AddDays(80), Location="Naples", Description="Classic Play Performance" },
				new EventDetailModel { Id = 17, Name = "Science Fair", Date = DateTime.Now.AddDays(85), Location="Pisa", Description="Science and Technology" },
				new EventDetailModel { Id = 18, Name = "Circus", Date = DateTime.Now.AddDays(90), Location="Milan", Description="Acrobats and Clowns" },
				new EventDetailModel { Id = 19, Name = "Rock Concert", Date = DateTime.Now.AddDays(95), Location="Rome", Description="Rock Bands Live" },
				new EventDetailModel { Id = 20, Name = "Book Fair", Date = DateTime.Now.AddDays(100), Location="Bologna", Description="Books and Authors" },
				new EventDetailModel { Id = 21, Name = "Opera Night", Date = DateTime.Now.AddDays(105), Location="Venice", Description="Opera Performances" },
				new EventDetailModel { Id = 22, Name = "Dance Show", Date = DateTime.Now.AddDays(110), Location="Florence", Description="Contemporary Dance" },
				new EventDetailModel { Id = 23, Name = "Auto Show", Date = DateTime.Now.AddDays(115), Location="Turin", Description="Latest Car Models" },
				new EventDetailModel { Id = 24, Name = "History Exhibition", Date = DateTime.Now.AddDays(120), Location="Rome", Description="Ancient Artifacts" },
				new EventDetailModel { Id = 25, Name = "Poetry Reading", Date = DateTime.Now.AddDays(125), Location="Milan", Description="Local Poets" },
				new EventDetailModel { Id = 26, Name = "Christmas Market", Date = DateTime.Now.AddDays(130), Location="Naples", Description="Holiday Gifts and Crafts" },
				new EventDetailModel { Id = 27, Name = "Art Workshop", Date = DateTime.Now.AddDays(135), Location="Venice", Description="Painting and Sculpture" },
				new EventDetailModel { Id = 28, Name = "Hiking Event", Date = DateTime.Now.AddDays(140), Location="Genoa", Description="Mountain Trails" },
				new EventDetailModel { Id = 29, Name = "Yoga Retreat", Date = DateTime.Now.AddDays(145), Location="Pisa", Description="Wellness and Relaxation" },
				new EventDetailModel { Id = 30, Name = "Beer Festival", Date = DateTime.Now.AddDays(150), Location="Bologna", Description="Craft Beers and Food" }
			};
		}

		// Method to get an EventModel by EventId asynchronously
		public async Task<EventModel?> GetEventByIdAsync(int eventId)
		{
			return await Task.Run(() => eventList.FirstOrDefault(eventItem => eventItem.Id == eventId));
		}
		
		
		// Method to get an EventDetailModel by EnventId asynchronously
		public async Task<EventDetailModel?> GetEventDetailByIdAsync(int eventId)
		{
			return await Task.Run(() => eventDetailList.FirstOrDefault(eventItem => eventItem.Id == eventId));
		}

	}
}