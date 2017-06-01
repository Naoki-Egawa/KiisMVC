using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KiisMVC.Models;
using System.Data.Entity;

namespace KiisMVC.Data
{
    public class DeliveryServiceDbInitializer : CreateDatabaseIfNotExists<KiisDbContext>
    {
        protected override void Seed(KiisDbContext context)
        {
            //// あらかじめ必要なデータを追加する
            //context.T_DeliveryServices.Add(new T_DeliveryService());

            //// 変更を保存
            //context.SaveChanges();
            base.Seed(context);
        }
    }
}