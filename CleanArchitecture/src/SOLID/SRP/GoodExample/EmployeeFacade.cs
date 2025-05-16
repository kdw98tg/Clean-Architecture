namespace SRP
{

    public class EmployeeFacade
    {
        private string name;
        private string position;

        public EmployeeFacade(string _name, string _position)
        {
            this.name = _name;
            this.position = _position;
        }

        public void CalculatePay()
        {
            //...
            new PayCalculator().CalculatePay();
            //...
        }

        public void ReportHours()
        {
            //...
            new HourReporter().ReportHours();
            //...
        }

        public void SaveEmployees()
        {
            //...
            new EmployeeSaver().SaveDatabase();
            //...
        }
    }
}