using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Project1.Models
{
    public class EcpayOrders
    {
        [Key]
        [Column("MerchantTradeNo")]
        [MaxLength(50)]
        public string MerchantTradeNo { get; set; }

        [Column("MemberID")]
        [MaxLength(50)]
        public string MemberID { get; set; }

        [Column("RtnCode")]
        public int? RtnCode { get; set; }

        [Column("RtnMsg")]
        [MaxLength(50)]
        public string RtnMsg { get; set; }

        [Column("TradeNo")]
        [MaxLength(50)]
        public string TradeNo { get; set; }

        [Column("TradeAmt")]
        public int? TradeAmt { get; set; }

        [Column("PaymentDate")]
        public DateTime? PaymentDate { get; set; }

        [Column("PaymentType")]
        [MaxLength(50)]
        public string PaymentType { get; set; }

        [Column("PaymentTypeChargeFee")]
        [MaxLength(50)]
        public string PaymentTypeChargeFee { get; set; }

        [Column("TradeDate")]
        [MaxLength(50)]
        public string TradeDate { get; set; }

        [Column("SimulatePaid")]
        public int? SimulatePaid { get; set; }
    }

}

