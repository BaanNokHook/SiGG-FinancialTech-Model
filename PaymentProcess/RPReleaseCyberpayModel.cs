using System;
using System.ComponentModel.DataAnnotations;

namespace GM.Model.PaymentProcess
{
    public class RPReleaseCyberPayModel
    {
        public Nullable<int> cyberpay_id { get; set; }

        public Nullable<int> message_no { get; set; }

        [StringLength(50)]
        public string RefCode { get; set; }

        public int Seq { get; set; }

        [StringLength(20)]
        public string SourceSystem { get; set; }

        [StringLength(30)]
        public string DealNo { get; set; }

        [StringLength(10)]
        public string DealType { get; set; }

        [StringLength(10)]
        public string Product { get; set; }

        [StringLength(10)]
        public string ProductGroup { get; set; }

        [StringLength(10)]
        public string MTType { get; set; }

        [StringLength(8)]
        public string ValueDate { get; set; }

        [StringLength(8)]
        public string ReleaseDate { get; set; }

        public Nullable<int> SettlementStatus { get; set; }

        [StringLength(1)]
        public string BankIndication { get; set; }

        [StringLength(2)]
        public string TransactionType { get; set; }

        [StringLength(34)]
        public string DebitAccount { get; set; }

        [StringLength(3)]
        public string BaseCurrency { get; set; }

        [StringLength(34)]
        public string OrderCustAccount { get; set; }

        [StringLength(35)]
        public string OrderCustName { get; set; }

        [StringLength(35)]
        public string OrderCustAddrLine1 { get; set; }

        [StringLength(35)]
        public string OrderCustAddrLine2 { get; set; }

        [StringLength(35)]
        public string OrderCustAddrLine3 { get; set; }

        [StringLength(35)]
        public string OrderInstName { get; set; }

        [StringLength(35)]
        public string OrderInstAddrLine1 { get; set; }

        [StringLength(35)]
        public string OrderInstAddrLine2 { get; set; }

        [StringLength(35)]
        public string OrderInstAddrLine3 { get; set; }

        [StringLength(3)]
        public string TransferCurrency { get; set; }

        public Nullable<decimal> TransferAmount { get; set; }

        [StringLength(16)]
        public string CustomerRef { get; set; }

        [StringLength(16)]
        public string BeneInstRef { get; set; }

        [StringLength(2)]
        public string PayeeCountry { get; set; }

        [StringLength(3)]
        public string Charges { get; set; }

        [StringLength(34)]
        public string BeneCustAccount { get; set; }

        [StringLength(34)]
        public string BeneCustIBAN { get; set; }

        [StringLength(35)]
        public string BeneCustName { get; set; }

        [StringLength(35)]
        public string BeneCustAddrLine1 { get; set; }

        [StringLength(35)]
        public string BeneCustAddrLine2 { get; set; }

        [StringLength(35)]
        public string BeneCustAddrLine3 { get; set; }

        [StringLength(10)]
        public string BeneInstRouteType { get; set; }

        [StringLength(16)]
        public string BeneInstBankIdent { get; set; }

        [StringLength(34)]
        public string BeneInstAccount { get; set; }

        [StringLength(34)]
        public string BeneInstIBAN { get; set; }

        [StringLength(50)]
        public string BeneInstName { get; set; }

        [StringLength(35)]
        public string BeneInstAddrLine1 { get; set; }

        [StringLength(35)]
        public string BeneInstAddrLine2 { get; set; }

        [StringLength(35)]
        public string BeneInstAddrLine3 { get; set; }

        [StringLength(10)]
        public string AcctInstRouteType { get; set; }

        [StringLength(16)]
        public string AcctInstBankIdent { get; set; }

        [StringLength(34)]
        public string AcctInstAccount { get; set; }

        [StringLength(35)]
        public string AcctInstName { get; set; }

        [StringLength(35)]
        public string AcctInstAddrLine1 { get; set; }

        [StringLength(35)]
        public string AcctInstAddrLine2 { get; set; }

        [StringLength(35)]
        public string AcctInstAddrLine3 { get; set; }

        [StringLength(10)]
        public string InterInstRouteType { get; set; }

        [StringLength(16)]
        public string InterInstBankIdent { get; set; }

        [StringLength(34)]
        public string InterInstAccount { get; set; }

        [StringLength(35)]
        public string InterInstName { get; set; }

        [StringLength(35)]
        public string InterInstAddrLine1 { get; set; }

        [StringLength(35)]
        public string InterInstAddrLine2 { get; set; }

        [StringLength(35)]
        public string InterInstAddrLine3 { get; set; }

        [StringLength(35)]
        public string BeneRefLine1 { get; set; }

        [StringLength(35)]
        public string BeneRefLine2 { get; set; }

        [StringLength(35)]
        public string BeneRefLine3 { get; set; }

        [StringLength(35)]
        public string BeneRefLine4 { get; set; }

        [StringLength(35)]
        public string BankToBankInfoLine1 { get; set; }

        [StringLength(35)]
        public string BankToBankInfoLine2 { get; set; }

        [StringLength(35)]
        public string BankToBankInfoLine3 { get; set; }

        [StringLength(35)]
        public string BankToBankInfoLine4 { get; set; }

        [StringLength(35)]
        public string BankToBankInfoLine5 { get; set; }

        [StringLength(35)]
        public string BankToBankInfoLine6 { get; set; }

        [StringLength(35)]
        public string CustomerCode { get; set; }

        [StringLength(35)]
        public string CustomerName { get; set; }

        [StringLength(250)]
        public string A1 { get; set; }

        [StringLength(50)]
        public string A2 { get; set; }

        [StringLength(50)]
        public string A3 { get; set; }

        [StringLength(50)]
        public string A4 { get; set; }

        [StringLength(50)]
        public string A5 { get; set; }

        [StringLength(50)]
        public string A6 { get; set; }

        [StringLength(50)]
        public string A7 { get; set; }

        [StringLength(50)]
        public string A8 { get; set; }

        [StringLength(50)]
        public string A9 { get; set; }

        [StringLength(50)]
        public string A10 { get; set; }

        public Nullable<bool> active_flag { get; set; }

        public Nullable<bool> send_status { get; set; }

        public Nullable<System.DateTime> create_date { get; set; }

        [StringLength(50)]
        public string create_by { get; set; }

        public Nullable<System.DateTime> update_date { get; set; }

        [StringLength(50)]
        public string update_by { get; set; }

        public string counter_party_id { get; set; }

        public string ccy { get; set; }
    }

}
