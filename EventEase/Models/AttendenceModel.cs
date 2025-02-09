using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventEase.Models
{
    public class AttendenceModel
    {
        public int Id { get; set; }
        public UserModel? UserModel { get; set; }
        public EventDetailModel? EventDetailModel { get; set; }
        public DateTime AttendanceDate { get; set; }
        //public bool Present { get; set; }

        // Costruttore completo
        public AttendenceModel(UserModel? userModel, EventDetailModel? eventDetailModel, DateTime attendanceDate)
        {
            //Id = id;
            UserModel = userModel;
            EventDetailModel = eventDetailModel;
            AttendanceDate = attendanceDate;
            //Present = present;
        }
    }
}
