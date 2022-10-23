using System;
using System.Xml.Serialization;


namespace Model
{
    /// <summary>
    /// Абстрактный класс Начисление зарплаты.
    /// </summary>
    [XmlInclude(typeof(RateSalary)), XmlInclude(typeof(Hourly))]
    public abstract class Calc
    {
        private double _S;
        private double _I; 


        public double S
        {
            set
            {
                // Если значение меньше либо равно нулю, то создаём новое исключение.
                if (value <= 0)
                    throw new ArgumentException(String.Format("{0} не может быть меньше или равно 0,",
                        S), "S");

                _S = value;
            }

            get
            {
                return _S;
            }
        }


        public double I
        {
            set
            {
                // Если значение меньше либо равно нулю, то создаём исключение.
                if (value <= 0)
                    throw new ArgumentException(String.Format("{0} не может не может быть меньше или равно 0,",
                        I), "I");

                _I = value;
            }

            get
            {
                return _I;
            }
        }

        /// <summary>
        /// Метод, возвращающий название класса.
        /// </summary>
        /// <returns>название класса</returns>
        public abstract string Name();


        /// <summary>
        /// Метод, производящий расчёт начисленной зарплаты.
        /// </summary>
        public abstract double Get();
    }
}
