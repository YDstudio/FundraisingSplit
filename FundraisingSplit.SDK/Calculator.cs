using System.Security.Cryptography.X509Certificates;
using System;

namespace FundraisingSplit.SDK
{
    public static class Calculator
    {

        /// <summary>
        /// 計算NAV
        /// </summary>
        /// <param name="total">總值</param>
        /// <param name="stock">股數</param>
        /// <returns></returns>
        public static float CalculateNAV(float total , float stock) {
            return total/stock;
        }

        /// <summary>
        /// 計算買取股數
        /// </summary>
        /// <param name="total">總值</param>
        /// <param name="total_stock">總股數</param>
        /// <param name="amount">投入金額</param>
        /// <returns></returns>
        public static float CalculateStock(float nav , float amount) {
            var buy_stock = amount/nav;
            return buy_stock;
        }

        /// <summary>
        /// 計算出金股數金額
        /// </summary>
        /// <param name="nav"></param>
        /// <param name="stock"></param>
        /// <returns></returns>
        public static float CalculateWithdrawAmount(float nav, float stock ) {
            return nav*stock;
        }

        /// <summary>
        /// 計算出金金額股數
        /// </summary>
        /// <param name="nav"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static float CalculateWithdrawStock(float nav, float amount)
        {
            return  amount/nav;
        }
    }
}
