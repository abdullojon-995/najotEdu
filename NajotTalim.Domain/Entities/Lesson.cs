﻿namespace NajotTalim.Domain.Entities
{
    public class Lesson
    {
        public Lesson()
        {
            Attendances = new List<Attendance>();
        }
        public int Id { get; set; }
        public int GroupId { get; set; }
        public bool IsDone { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public Group Group { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
