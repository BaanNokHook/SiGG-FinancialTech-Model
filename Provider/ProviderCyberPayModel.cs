using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GM.Model.Provider
{
    public class ProviderRequestCyberPayModel
    {
        [Required]
        public RequestHeader Header { get; set; }

        [Required]
        public List<RequestDetail> SettlementInfo { get; set; }
    }

    public class ProviderResponseCyberPayModel
    {
        [JsonProperty(PropertyName = "Header")]
        public ResponseHeader Header { get; set; }
        [JsonProperty(PropertyName = "ResponseBody")]
        public List<ResponseDetail> ResponseBody { get; set; }
    }

    public class CheckSettlementStatusRequestModel
    {
        [Required]
        public RequestHeader Header { get; set; }

        [Required]
        public List<RequestDetail> SettlementInfo { get; set; }
    }

    public class CheckSettlementStatusResponseModel
    {
        public ResponseHeader Header { get; set; }
        public List<ResponseCheckSettlementStatus> ResponseBody { get; set; }
    }

    public class InsertSettlementInfoRequestModel
    {
        [Required]
        public RequestHeader Header { get; set; }

        [Required]
        public List<RequestInsertSettlementInfo> SettlementInfo { get; set; }
    }

    public class InsertSettlementInfoResponseModel
    {
        public ResponseHeader Header { get; set; }
        public List<ResponseInsertSettlementInfo> ResponseBody { get; set; }
    }

    public class RequestHeader
    {
        [Required]
        public string SystemCode { get; set; }
        [Required]
        public string AuthorityCode { get; set; }
        [Required]
        public string RefCode { get; set; }
        [Required]
        public string RequestDate { get; set; }
        [Required]
        public string RequestTime { get; set; }
        [Required]
        public int WSMode { get; set; }
    }

    public class RequestDetail
    {
        [Required]
        public int Seq { get; set; }

        [Required]
        [StringLength(10)]
        public string SourceSystem { get; set; }

        [Required]
        [StringLength(30)]
        public string DealNo { get; set; }

        [Required]
        [StringLength(10)]
        public string DealType { get; set; }

        [StringLength(10)]
        public string Product { get; set; }

        [StringLength(10)]
        public string ProductGroup { get; set; }

        [Required]
        [StringLength(3)]
        public string Ccy { get; set; }

        [Required]
        [StringLength(10)]
        public string MTType { get; set; }

        [Required]
        [StringLength(8)]
        public string ValueDate { get; set; }
    }

    public class RequestInsertSettlementInfo
    {
        [Required]
        public int Seq { get; set; }

        [Required]
        [StringLength(10)]
        public string SourceSystem { get; set; }

        [Required]
        [StringLength(30)]
        public string DealNo { get; set; }

        [Required]
        [StringLength(10)]
        public string DealType { get; set; }

        [StringLength(10)]
        public string Product { get; set; }

        [StringLength(10)]
        public string ProductGroup { get; set; }

        [Required]
        [StringLength(10)]
        public string MTType { get; set; }

        [Required]
        [StringLength(8)]
        public string ValueDate { get; set; }

        [Required]
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
    }

    public class ResponseHeader
    {
        [JsonProperty(PropertyName = "SystemCode")]
        public string SystemCode { get; set; }

        [JsonProperty(PropertyName = "RefCode")]
        public string RefCode { get; set; }

        [JsonProperty(PropertyName = "ResponseDate")]
        public string ResponseDate { get; set; }

        [JsonProperty(PropertyName = "ResponseTime")]
        public string ResponseTime { get; set; }

        [JsonProperty(PropertyName = "ResponseId")]
        public int ResponseId { get; set; }

        [JsonProperty(PropertyName = "ResponseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty(PropertyName = "TotalNumber")]
        public int TotalNumber { get; set; }
    }

    public class ResponseDetail
    {
        [JsonProperty(PropertyName = "Seq")]
        public int Seq { get; set; }

        [JsonProperty(PropertyName = "ReturnId")]
        public int ReturnId { get; set; }

        [JsonProperty(PropertyName = "ReturnMessage")]
        [StringLength(100)]
        public string ReturnMessage { get; set; }

        [JsonProperty(PropertyName = "SourceSystem")]
        [StringLength(10)]
        public string SourceSystem { get; set; }

        [JsonProperty(PropertyName = "DealNo")]
        [StringLength(30)]
        public string DealNo { get; set; }

        [JsonProperty(PropertyName = "DealType")]
        [StringLength(10)]
        public string DealType { get; set; }

        [JsonProperty(PropertyName = "Product")]
        [StringLength(10)]
        public string Product { get; set; }

        [JsonProperty(PropertyName = "ProductGroup")]
        [StringLength(10)]
        public string ProductGroup { get; set; }

        [JsonProperty(PropertyName = "MTType")]
        [StringLength(10)]
        public string MTType { get; set; }

        [JsonProperty(PropertyName = "ValueDate")]
        [StringLength(8)]
        public string ValueDate { get; set; }

        [JsonProperty(PropertyName = "ReleaseDate")]
        [StringLength(8)]
        public string ReleaseDate { get; set; }

        [JsonProperty(PropertyName = "SettlementStatus")]
        public int? SettlementStatus { get; set; }

        [JsonProperty(PropertyName = "BankIndication")]
        [StringLength(1)]
        public string BankIndication { get; set; }

        [JsonProperty(PropertyName = "TransactionType")]
        [StringLength(2)]
        public string TransactionType { get; set; }

        [JsonProperty(PropertyName = "DebitAccount")]
        [StringLength(34)]
        public string DebitAccount { get; set; }

        [JsonProperty(PropertyName = "BaseCurrency")]
        [StringLength(3)]
        public string BaseCurrency { get; set; }

        [JsonProperty(PropertyName = "OrderCustAccount")]
        [StringLength(34)]
        public string OrderCustAccount { get; set; }

        [JsonProperty(PropertyName = "OrderCustName")]
        [StringLength(35)]
        public string OrderCustName { get; set; }

        [JsonProperty(PropertyName = "OrderCustAddrLine1")]
        [StringLength(35)]
        public string OrderCustAddrLine1 { get; set; }

        [JsonProperty(PropertyName = "OrderCustAddrLine2")]
        [StringLength(35)]
        public string OrderCustAddrLine2 { get; set; }

        [JsonProperty(PropertyName = "OrderCustAddrLine3")]
        [StringLength(35)]
        public string OrderCustAddrLine3 { get; set; }

        [JsonProperty(PropertyName = "OrderInstName")]
        [StringLength(35)]
        public string OrderInstName { get; set; }

        [JsonProperty(PropertyName = "OrderInstAddrLine1")]
        [StringLength(35)]
        public string OrderInstAddrLine1 { get; set; }

        [JsonProperty(PropertyName = "OrderInstAddrLine2")]
        [StringLength(35)]
        public string OrderInstAddrLine2 { get; set; }

        [JsonProperty(PropertyName = "OrderInstAddrLine3")]
        [StringLength(35)]
        public string OrderInstAddrLine3 { get; set; }

        [JsonProperty(PropertyName = "TransferCurrency")]
        [StringLength(3)]
        public string TransferCurrency { get; set; }

        [JsonProperty(PropertyName = "TransferAmount")]
        public Nullable<decimal> TransferAmount { get; set; }

        [JsonProperty(PropertyName = "CustomerRef")]
        [StringLength(16)]
        public string CustomerRef { get; set; }

        [JsonProperty(PropertyName = "BeneInstRef")]
        [StringLength(16)]
        public string BeneInstRef { get; set; }

        [JsonProperty(PropertyName = "PayeeCountry")]
        [StringLength(2)]
        public string PayeeCountry { get; set; }

        [JsonProperty(PropertyName = "Charges")]
        [StringLength(3)]
        public string Charges { get; set; }

        [JsonProperty(PropertyName = "BeneCustAccount")]
        [StringLength(34)]
        public string BeneCustAccount { get; set; }

        [JsonProperty(PropertyName = "BeneCustIBAN")]
        [StringLength(34)]
        public string BeneCustIBAN { get; set; }

        [JsonProperty(PropertyName = "BeneCustName")]
        [StringLength(35)]
        public string BeneCustName { get; set; }

        [JsonProperty(PropertyName = "BeneCustAddrLine1")]
        [StringLength(35)]
        public string BeneCustAddrLine1 { get; set; }

        [JsonProperty(PropertyName = "BeneCustAddrLine2")]
        [StringLength(35)]
        public string BeneCustAddrLine2 { get; set; }

        [JsonProperty(PropertyName = "BeneCustAddrLine3")]
        [StringLength(35)]
        public string BeneCustAddrLine3 { get; set; }

        [JsonProperty(PropertyName = "BeneInstRouteType")]
        [StringLength(10)]
        public string BeneInstRouteType { get; set; }

        [JsonProperty(PropertyName = "BeneInstBankIdent")]
        [StringLength(16)]
        public string BeneInstBankIdent { get; set; }

        [JsonProperty(PropertyName = "BeneInstAccount")]
        [StringLength(34)]
        public string BeneInstAccount { get; set; }

        [JsonProperty(PropertyName = "BeneInstIBAN")]
        [StringLength(34)]
        public string BeneInstIBAN { get; set; }

        [JsonProperty(PropertyName = "BeneInstName")]
        [StringLength(50)]
        public string BeneInstName { get; set; }

        [JsonProperty(PropertyName = "BeneInstAddrLine1")]
        [StringLength(35)]
        public string BeneInstAddrLine1 { get; set; }

        [JsonProperty(PropertyName = "BeneInstAddrLine2")]
        [StringLength(35)]
        public string BeneInstAddrLine2 { get; set; }

        [JsonProperty(PropertyName = "BeneInstAddrLine3")]
        [StringLength(35)]
        public string BeneInstAddrLine3 { get; set; }

        [JsonProperty(PropertyName = "AcctInstRouteType")]
        [StringLength(10)]
        public string AcctInstRouteType { get; set; }

        [JsonProperty(PropertyName = "AcctInstBankIdent")]
        [StringLength(16)]
        public string AcctInstBankIdent { get; set; }

        [JsonProperty(PropertyName = "AcctInstAccount")]
        [StringLength(34)]
        public string AcctInstAccount { get; set; }

        [JsonProperty(PropertyName = "AcctInstName")]
        [StringLength(35)]
        public string AcctInstName { get; set; }

        [JsonProperty(PropertyName = "AcctInstAddrLine1")]
        [StringLength(35)]
        public string AcctInstAddrLine1 { get; set; }

        [JsonProperty(PropertyName = "AcctInstAddrLine2")]
        [StringLength(35)]
        public string AcctInstAddrLine2 { get; set; }

        [JsonProperty(PropertyName = "AcctInstAddrLine3")]
        [StringLength(35)]
        public string AcctInstAddrLine3 { get; set; }

        [JsonProperty(PropertyName = "InterInstRouteType")]
        [StringLength(10)]
        public string InterInstRouteType { get; set; }

        [JsonProperty(PropertyName = "InterInstBankIdent")]
        [StringLength(16)]
        public string InterInstBankIdent { get; set; }

        [JsonProperty(PropertyName = "InterInstAccount")]
        [StringLength(34)]
        public string InterInstAccount { get; set; }

        [JsonProperty(PropertyName = "InterInstName")]
        [StringLength(35)]
        public string InterInstName { get; set; }

        [JsonProperty(PropertyName = "InterInstAddrLine1")]
        [StringLength(35)]
        public string InterInstAddrLine1 { get; set; }

        [JsonProperty(PropertyName = "InterInstAddrLine2")]
        [StringLength(35)]
        public string InterInstAddrLine2 { get; set; }

        [JsonProperty(PropertyName = "InterInstAddrLine3")]
        [StringLength(35)]
        public string InterInstAddrLine3 { get; set; }

        [JsonProperty(PropertyName = "BeneRefLine1")]
        [StringLength(35)]
        public string BeneRefLine1 { get; set; }

        [JsonProperty(PropertyName = "BeneRefLine2")]
        [StringLength(35)]
        public string BeneRefLine2 { get; set; }

        [JsonProperty(PropertyName = "BeneRefLine3")]
        [StringLength(35)]
        public string BeneRefLine3 { get; set; }

        [JsonProperty(PropertyName = "BeneRefLine4")]
        [StringLength(35)]
        public string BeneRefLine4 { get; set; }

        [JsonProperty(PropertyName = "BankToBankInfoLine1")]
        [StringLength(35)]
        public string BankToBankInfoLine1 { get; set; }

        [JsonProperty(PropertyName = "BankToBankInfoLine2")]
        [StringLength(35)]
        public string BankToBankInfoLine2 { get; set; }

        [JsonProperty(PropertyName = "BankToBankInfoLine3")]
        [StringLength(35)]
        public string BankToBankInfoLine3 { get; set; }

        [JsonProperty(PropertyName = "BankToBankInfoLine4")]
        [StringLength(35)]
        public string BankToBankInfoLine4 { get; set; }

        [JsonProperty(PropertyName = "BankToBankInfoLine5")]
        [StringLength(35)]
        public string BankToBankInfoLine5 { get; set; }

        [JsonProperty(PropertyName = "BankToBankInfoLine6")]
        [StringLength(35)]
        public string BankToBankInfoLine6 { get; set; }

        [JsonProperty(PropertyName = "CustomerCode")]
        [StringLength(35)]
        public string CustomerCode { get; set; }

        [JsonProperty(PropertyName = "CustomerName")]
        [StringLength(35)]
        public string CustomerName { get; set; }

        [JsonProperty(PropertyName = "A1")]
        [StringLength(250)]
        public string A1 { get; set; }

        [JsonProperty(PropertyName = "A2")]
        [StringLength(50)]
        public string A2 { get; set; }

        [JsonProperty(PropertyName = "A3")]
        [StringLength(50)]
        public string A3 { get; set; }

        [JsonProperty(PropertyName = "A4")]
        [StringLength(50)]
        public string A4 { get; set; }

        [JsonProperty(PropertyName = "A5")]
        [StringLength(50)]
        public string A5 { get; set; }

        [JsonProperty(PropertyName = "A6")]
        [StringLength(50)]
        public string A6 { get; set; }

        [JsonProperty(PropertyName = "A7")]
        [StringLength(50)]
        public string A7 { get; set; }

        [JsonProperty(PropertyName = "A8")]
        [StringLength(50)]
        public string A8 { get; set; }

        [JsonProperty(PropertyName = "A9")]
        [StringLength(50)]
        public string A9 { get; set; }

        [JsonProperty(PropertyName = "A10")]
        [StringLength(50)]
        public string A10 { get; set; }
    }

    public class ResponseCheckSettlementStatus 
    {
        public int Seq { get; set; }

        public int ReturnId { get; set; }

        [StringLength(100)]
        public string ReturnMessage { get; set; }

        [StringLength(10)]
        public string SourceSystem { get; set; }

        [StringLength(30)]
        public string DealNo { get; set; }

        [StringLength(10)]
        public string DealType { get; set; }

        [StringLength(10)]
        public string Product { get; set; }

        [StringLength(10)]
        public string ProductGroup { get; set; }

        [StringLength(3)]
        public string Ccy { get; set; }

        [StringLength(10)]
        public string MTType { get; set; }

        [StringLength(8)]
        public string ValueDate { get; set; }

        public Nullable<int> SettlementStatus { get; set; }
    }

    public class ResponseInsertSettlementInfo
    {
        public int Seq { get; set; }

        public int ReturnId { get; set; }

        [StringLength(100)]
        public string ReturnMessage { get; set; }
    }
}
