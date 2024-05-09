namespace Console1.Classes
{
    public class ObjectOrientedEmployeeDemo
    {
        private float _baseSalary = 300;
        private float _overTime = 20;
        private float _rate = 10;

        public float GetWage()
        {
            return _baseSalary + _overTime * _rate;
        }

        public float GetWage(float salaryOverride, float overtimeOverride, float rateOverride)
        {
            return salaryOverride + overtimeOverride * rateOverride;
        }
    }
}