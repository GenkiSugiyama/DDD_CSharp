using System;

namespace DDD.Domain.Helpers
{
    public static class FloatHelper
    {
        // 拡張メソッド
        // 静的メソッドをインスタンスメソッドと同じ形式で呼び出せるようにするもの
        // 拡張メソッドの定義の仕方は 「静的クラス」中に、 第一引数に this キーワードを修飾子として付けた static メソッドを書く。
        // 通常の静的メソッドはFloatHeler.RoundString(value, 2)のような形で呼び出すが
        // this修飾子をつけた拡張メソッドはvalue.RoundString()のようにthis修飾子がついた引数のインスタンスメソッドとして呼び出せる
        /// <summary>
        /// 小数点以下を指定桁数で四捨五入します
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimalPoint"></param>
        /// <returns></returns>
        public static string RoundString(this float value, int decimalPoint)
        {
            float temp = Convert.ToSingle(Math.Round(value, decimalPoint));
            return temp.ToString("F" + decimalPoint);
        }
    }
}
