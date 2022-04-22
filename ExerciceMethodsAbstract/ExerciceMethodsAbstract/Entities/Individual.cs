

namespace ExerciceMethodsAbstract.Entities
{
    class Individual : TaxPayer
    {
        //class atributes----------------------------
        public double heathExpenditures { get; set; }
        //-------------------------------------------

        //Builders-------------------------------------------------------------------
        public Individual(string Name, double AnualIncome, double heathExpenditures) :
            base(Name, AnualIncome)
        {
            this.heathExpenditures = heathExpenditures;
        }
        //---------------------------------------------------------------------------

        //class methods-----------------------------------------------------------------------------------------
        public override double Tax()
        {
            double percentage;
            double taxToPay = 0;
            double discountForExpensesWithAude = 0;

            //Calculating Tax--------------------------
            if (AnualIncome < 20000)
            {
                percentage = 15.0 / 100.0; // 15%
                taxToPay = AnualIncome * percentage;
            }
            else if (AnualIncome >= 20000){
                percentage = 25.0 / 100.0;//25%
                taxToPay = AnualIncome * percentage;
            }
            //-----------------------------------------

            //Checking for health expenses------------------------------------
            if (heathExpenditures > 0)
            {
                percentage = 50.0 / 100;//50%
                discountForExpensesWithAude = heathExpenditures * percentage;

            }
            //-----------------------------------------------------------------

            return taxToPay - discountForExpensesWithAude;
        }
       
        //----------------------------------------------------------------------------------------------------------
    }

}
