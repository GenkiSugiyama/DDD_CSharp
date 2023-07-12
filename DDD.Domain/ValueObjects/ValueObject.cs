namespace DDD.Domain.ValueObjects
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object obj)
        {
            /// 受け取った引数を自分自身（ValueObject）に変換
            var vo = obj as T;

            /// 値がNullならTemperatureへの変換失敗 = そもそも型が違う値なのでfalseを返す
            if (vo == null)
            {
                return false;
            }

            /// 変換成功したら値同士を比較した結果を返す
            return EqualsCore(vo);
        }

        public static bool operator ==(ValueObject<T> vo1, ValueObject<T> vo2)
        {
            return Equals(vo1, vo2);
        }

        public static bool operator !=(ValueObject<T> vo1, ValueObject<T> vo2)
        {
            return !Equals(vo1, vo2);
        }

        protected abstract bool EqualsCore(T other);

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
