namespace HomeWorkThree.Model
{
    public class TimeDMModel
    {
        public ushort Day { get; set; }
        public ushort Month { get; set; }

        public TimeDMModel(ushort day, ushort month)
        {
            Day = day;
            Month = month;
        }
    }
}
