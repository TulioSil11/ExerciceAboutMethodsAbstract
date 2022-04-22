
namespace ExerciceMethodsAbstract.Entities
{
    abstract class TaxPayer
    {
        //class atributes----------------
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        //-----------------------------------

        //Builders------------------------------------
        public TaxPayer()
        {

        }
        public TaxPayer(string Name, double AnualIncome)
        {
            this.Name = Name;
            this.AnualIncome = AnualIncome;
        }
        //---------------------------------------------

        //class methods------------------
        abstract public double Tax();

        //-------------------------------

    }
}
