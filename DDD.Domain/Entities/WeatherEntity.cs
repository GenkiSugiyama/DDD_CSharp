using DDD.Domain.ValueObjects;
using System;

namespace DDD.Domain.Entities
{
    public sealed class WeatherEntity
    {
        // 完全コンストラクタパターン
        // コンストラクタによるインスタンス生成時にのみ値が挿入される
        public WeatherEntity(int areaId,
                            DateTime dataDate,
                            int condition,
                            float temperature
            )
        {
            AreaId = areaId;
            DataDate = dataDate;
            Condition = condition;
            Temperature = new Temperature(temperature);
        }

        // クラスのプロパティは基本的にセッターはつけない
        // インスタンス生成後（コンストラクタ呼出し後）に値が書き換えられないのを保証するため

        // プロパティに関する処理もエンティティに集約させる
        public int AreaId { get; }
        public DateTime DataDate { get; }
        public int Condition { get; }
        public Temperature Temperature { get; }
    }
}
