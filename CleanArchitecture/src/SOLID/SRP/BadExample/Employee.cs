namespace SRP
{

    //SRP를 위반한 예시
    public class Employee
    {
        private string name;
        private string position;

        public Employee(string _name, string _position)
        {
            this.name = _name;
            this.position = _position;
        }

        //초과 근무 시간을 계산하는 메서드
        public void CalculateExtraHour()
        {
            //...
        }

        //급여를 계산하는 메서드 (회계팀에서 사용)
        public void CalculatePay()
        {
            //...
            CalculateExtraHour();
            //...
        }

        //근무시간을 계산하는 메서드 (인사팀에서 사용)
        public void ReportHours()
        {
            //...
            CalculateExtraHour();
            //...
        }

        //변경된 정보를 DB에 저장하는 메서드 (기술팀에서 사용)
        public void SaveDatabase()
        {
            //...
        }
    }
}