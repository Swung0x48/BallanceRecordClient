namespace BallanceRecordApi.Contracts.V1.Requests
{
    public class CreateRecordRequest
    {
        public string Remark { get; set; }
        public int Score { get; set; }
        public double Duration { get; set; }
        public string MapHash { get; set; }
    }
}