namespace TimeTable.Models
{
    public class Lecture
    {
        public string courseName { get; set; }
        public string moduleCode { get; set; }
        public string moduleName { get; set; }
        public string lecturerName { get; set; }
        public int roomNumber { get; set; }
        public string dayOfTheWeek { get; set; }
        public string ID { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}
