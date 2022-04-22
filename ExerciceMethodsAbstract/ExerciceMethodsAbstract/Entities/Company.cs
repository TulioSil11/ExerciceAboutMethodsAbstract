
namespace ExerciceMethodsAbstract.Entities
{
    class Company: TaxPayer
    {
        //class Atributes-------------------------
        public int numberOfEmployees { get; set; }
        //----------------------------------------

        //Builders------------------------------------------------------------
        public Company(string Name, double AnualIncome, int numberOfEmployees)
            : base(Name, AnualIncome)
        {
            this.numberOfEmployees = numberOfEmployees;
        }
        //---------------------------------------------------------------------

        //class methods-----------------------------
        public override double Tax()
        {
            double percentage = 16.0 / 100;
            double taxToPay = 0;
            if (numberOfEmployees > 10)
            {
                percentage = 14.0 / 100;
            }

            taxToPay = AnualIncome * percentage;

            return taxToPay;
        }
        //--------------------------------------------
    }
}
