namespace SRP
{

    //인사팀에서 사용되는 전용 클래스
    public class HourReporter
    {
        public void CalculateExtraHour()
        {
            //...
        }

        public void ReportHours()
        {
            //...
            CalculateExtraHour();
            //...
        }
    }
}