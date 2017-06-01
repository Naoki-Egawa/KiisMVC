using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KiisMVC.Models
{
    public class T_DeliveryService
    {
        [Key]
        public int ID { get; set; }
        public string 宛先 { get; set; }
        public string 送付先担当者名 { get; set; }
        public string 郵便番号 { get; set; }
        public string 住所 { get; set; }
        public string 親展Code { get; set; }
        public string 特殊郵便Code { get; set; }
        public string 敬称Code { get; set; }
        public string 登録年月日 { get; set; }
        public string UserID { get; set; }
        public string 記号 { get; set; }
        public string 番号 { get; set;}
        public string 封入物 { get; set; }
        public string 予備01 { get; set; }
        public string 予備02 { get; set; }
    }
}