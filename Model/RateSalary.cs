namespace Model
{
    /// <summary>
    /// Класс Оплата по окладу и ставке.
    /// </summary>
    public class RateSalary : Calc
    {
        public override string Name()
        {
            return "Оплата по окладу и ставке";
        }


        /// <summary>
        /// Метод расчёта почасовой оплаты.
        /// </summary>
        /// <returns>результат оплаты по окладу и ставке</returns>
        public override double Get()
        {
            return S + I;
        }
    }
}
