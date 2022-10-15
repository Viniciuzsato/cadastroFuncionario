
namespace cadastroFuncionario.Entities
{
    internal class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {

        }

        public OutsourceEmployee(string name, int hours, double valuePerHours, double additionalCharge)
            : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
