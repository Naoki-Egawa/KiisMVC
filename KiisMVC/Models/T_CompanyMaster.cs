namespace KiisMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_CompanyMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int 記号 { get; set; }

        public string 社保記号 { get; set; }

        public string 番号 { get; set; }

        public string 事業所名 { get; set; }

        public string 事業主 { get; set; }

        public string 郵便番号 { get; set; }

        public string 住所01 { get; set; }

        public string 住所02 { get; set; }

        public string 電話番号 { get; set; }

        public int 被保険者数_男 { get; set; }

        public int 被保険者数_女 { get; set; }

        public int 被保険者数計 { get; set; }

        public int? T_00_事業所登録台帳_付加情報_記号 { get; set; }
    }
}
