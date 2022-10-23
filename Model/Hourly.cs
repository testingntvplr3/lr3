namespace Model
{
    /// <summary>
    /// Класс Почасовая Оплата.
    /// </summary>
    public class Hourly : Calc
    {
        
        public override string Name()
        {
            return "Почасовая оплата";
        }


        /// <summary>
        /// Метод расчёта почасовой оплаты.
        /// </summary>
        /// <returns>результат расчёта почасовой оплаты</returns>
        public override double Get()
        {
            return S * I;
        }
    }
}
