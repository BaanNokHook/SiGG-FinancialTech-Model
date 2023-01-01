using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using GM.Model.Common;
using GM.Model.Static;


namespace GM.Model.ExternalInterface
{
    public class InterfaceCCMSearch
    {
        public DateTime search_date { get; set; }
        public string search_trans_no { get; set; }
        public virtual PagingModel paging { get; set; }
        public virtual List<OrderByModel> ordersby { get; set; }
    }

    public class CreateConfirmationRequest
    {
        public string ChannelId { get; set; }
        public string RefId { get; set; }
        public string TransDate { get; set; }
        public string TransTime { get; set; }
        public string transTypeCode { get; set; }
        public string tradeId { get; set; }
        public string confirmId { get; set; }
        public string CIFID { get; set; }
        public string CIFName { get; set; }
        public string productType { get; set; }
        public string costcenter { get; set; }
        public string instumentCode { get; set; }
        public string tradeEvent { get; set; }
        public string customerEmail { get; set; }
        public string documentType { get; set; }
        public string valueDate { get; set; }
        public string tradeDate { get; set; }
        public string createDate { get; set; }
        public string settlementDate { get; set; }
        public string maturityDate { get; set; }
        public string expiryDate { get; set; }
        public string ccy1 { get; set; }
        public string amount1 { get; set; }
        public string ccy2 { get; set; }
        public string amount2 { get; set; }
        public string rate1 { get; set; }
        public string amount3 { get; set; }
        public string amount4 { get; set; }
        public string rate2 { get; set; }
        public string counterPartyCode { get; set; }
        public string counterPartyNameThi { get; set; }
        public string counterPartyNameEng { get; set; }
        public string partyACode { get; set; }
        public string partyAName { get; set; }
        public string partyBCode { get; set; }
        public string partyBName { get; set; }
        public string val1 { get; set; }
        public string val2 { get; set; }
        public string val3 { get; set; }
        public string val4 { get; set; }
        public string val5 { get; set; }
        public string val6 { get; set; }
        public string val7 { get; set; }
        public string val8 { get; set; }
        public string val9 { get; set; }
        public string val10 { get; set; }
        public string val11 { get; set; }
        public string val12 { get; set; }
        public string val13 { get; set; }
        public string val14 { get; set; }
        public string val15 { get; set; }
        public string val16 { get; set; }
        public string val17 { get; set; }
        public string val18 { get; set; }
        public string val19 { get; set; }
        public string val20 { get; set; }
        public string fileName { get; set; }
        public byte[] fileContent { get; set; }
    }
    public class CreateConfirmationResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseDesc { get; set; }
    }

    public class InterfaceConfirmationModel : CreateConfirmationRequest
    {
        public string guid { get; set; }
        public string create_by { get; set; }
        public virtual List<RpConfigModel> RpConfigModel { get; set; }

        public string XmlPlayload(CreateConfirmationRequest req)
        {
            StringBuilder xmlData = new StringBuilder();

            xmlData.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            xmlData.Append("<x:Envelope xmlns:x=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:mod=\"http://model.cfmt.ktb.co.th/\" xmlns:ser=\"http://service.cfmt.ktb.co.th/\">");
            xmlData.Append("<x:Header/>");
            xmlData.Append("<x:Body>");
            xmlData.Append("<ser:CreateConfirmationRequest>");

            xmlData.Append("<ser:Header>");
            xmlData.Append("<mod:ChannelId>" + HtmlEncode(req.ChannelId) + "</mod:ChannelId>");
            xmlData.Append("<mod:RefId>" + HtmlEncode(req.RefId) + "</mod:RefId>");
            xmlData.Append("<mod:TransDate>" + HtmlEncode(req.TransDate) + "</mod:TransDate>");
            xmlData.Append("<mod:TransTime>" + HtmlEncode(req.TransTime) + "</mod:TransTime>");
            xmlData.Append("<mod:transTypeCode>" + HtmlEncode(req.transTypeCode) + "</mod:transTypeCode>");
            xmlData.Append("</ser:Header>");

            xmlData.Append("<ser:Detail>");
            xmlData.Append("<mod:tradeId>" + HtmlEncode(req.tradeId) + "</mod:tradeId>");
            xmlData.Append("<mod:confirmId>" + HtmlEncode(req.confirmId) + "</mod:confirmId>");
            xmlData.Append("<mod:CIFID>" + HtmlEncode(req.CIFID) + "</mod:CIFID>");
            xmlData.Append("<mod:CIFName>" + HtmlEncode(req.CIFName) + "</mod:CIFName>");
            xmlData.Append("<mod:productType>" + HtmlEncode(req.productType) + "</mod:productType>");
            xmlData.Append("<mod:costcenter>" + HtmlEncode(req.costcenter) + "</mod:costcenter>");
            xmlData.Append("<mod:instumentCode>" + HtmlEncode(req.instumentCode) + "</mod:instumentCode>");
            xmlData.Append("<mod:tradeEvent>" + HtmlEncode(req.tradeEvent) + "</mod:tradeEvent>");
            xmlData.Append("<mod:customerEmail>" + HtmlEncode(req.customerEmail) + "</mod:customerEmail>");
            xmlData.Append("<mod:documentType>" + HtmlEncode(req.documentType) + "</mod:documentType>");
            xmlData.Append("<mod:valueDate>" + HtmlEncode(req.valueDate) + "</mod:valueDate>");
            xmlData.Append("<mod:tradeDate>" + HtmlEncode(req.tradeDate) + "</mod:tradeDate>");
            xmlData.Append("<mod:createDate>" + HtmlEncode(req.createDate) + "</mod:createDate>");
            xmlData.Append("<mod:settlementDate>" + HtmlEncode(req.settlementDate) + "</mod:settlementDate>");
            xmlData.Append("<mod:maturityDate>" + HtmlEncode(req.maturityDate) + "</mod:maturityDate>");
            xmlData.Append("<mod:expiryDate>" + HtmlEncode(req.expiryDate) + "</mod:expiryDate>");
            xmlData.Append("<mod:ccy1>" + HtmlEncode(req.ccy1) + "</mod:ccy1>");
            xmlData.Append("<mod:amount1>" + req.amount1 + "</mod:amount1>");
            xmlData.Append("<mod:ccy2>" + HtmlEncode(req.ccy2) + "</mod:ccy2>");
            xmlData.Append("<mod:amount2>" + req.amount2 + "</mod:amount2>");
            xmlData.Append("<mod:rate1>" + HtmlEncode(req.rate1) + "</mod:rate1>");
            xmlData.Append("<mod:amount3>" + req.amount3 + "</mod:amount3>");
            xmlData.Append("<mod:amount4>" + req.amount4 + "</mod:amount4>");
            xmlData.Append("<mod:rate2>" + HtmlEncode(req.rate2) + "</mod:rate2>");
            xmlData.Append("<mod:counterPartyCode>" + HtmlEncode(req.counterPartyCode) + "</mod:counterPartyCode>");
            xmlData.Append("<mod:counterPartyNameThi>" + HtmlEncode(req.counterPartyNameThi) + "</mod:counterPartyNameThi>");
            xmlData.Append("<mod:counterPartyNameEng>" + HtmlEncode(req.counterPartyNameEng) + "</mod:counterPartyNameEng>");
            xmlData.Append("<mod:partyACode>" + HtmlEncode(req.partyACode) + "</mod:partyACode>");
            xmlData.Append("<mod:partyAName>" + HtmlEncode(req.partyAName) + "</mod:partyAName>");
            xmlData.Append("<mod:partyBCode>" + HtmlEncode(req.partyBCode) + "</mod:partyBCode>");
            xmlData.Append("<mod:partyBName>" + HtmlEncode(req.partyBName) + "</mod:partyBName>");
            xmlData.Append("<mod:porS>" + string.Empty + "</mod:porS>");
            xmlData.Append("<mod:porC>" + string.Empty + "</mod:porC>");
            xmlData.Append("<mod:val1>" + HtmlEncode(req.val1) + "</mod:val1>");
            xmlData.Append("<mod:val2>" + HtmlEncode(req.val2) + "</mod:val2>");
            xmlData.Append("<mod:val3>" + HtmlEncode(req.val3) + "</mod:val3>");
            xmlData.Append("<mod:val4>" + HtmlEncode(req.val4) + "</mod:val4>");
            xmlData.Append("<mod:val5>" + HtmlEncode(req.val5) + "</mod:val5>");
            xmlData.Append("<mod:val6>" + HtmlEncode(req.val6) + "</mod:val6>");
            xmlData.Append("<mod:val7>" + HtmlEncode(req.val7) + "</mod:val7>");
            xmlData.Append("<mod:val8>" + HtmlEncode(req.val8) + "</mod:val8>");
            xmlData.Append("<mod:val9>" + HtmlEncode(req.val9) + "</mod:val9>");
            xmlData.Append("<mod:val10>" + HtmlEncode(req.val10) + "</mod:val10>");
            xmlData.Append("<mod:val11>" + HtmlEncode(req.val11) + "</mod:val11>");
            xmlData.Append("<mod:val12>" + HtmlEncode(req.val12) + "</mod:val12>");
            xmlData.Append("<mod:val13>" + HtmlEncode(req.val13) + "</mod:val13>");
            xmlData.Append("<mod:val14>" + HtmlEncode(req.val14) + "</mod:val14>");
            xmlData.Append("<mod:val15>" + HtmlEncode(req.val15) + "</mod:val15>");
            xmlData.Append("<mod:val16>" + HtmlEncode(req.val16) + "</mod:val16>");
            xmlData.Append("<mod:val17>" + HtmlEncode(req.val17) + "</mod:val17>");
            xmlData.Append("<mod:val18>" + HtmlEncode(req.val18) + "</mod:val18>");
            xmlData.Append("<mod:val19>" + HtmlEncode(req.val19) + "</mod:val19>");
            xmlData.Append("<mod:val20>" + HtmlEncode(req.val20) + "</mod:val20>");
            xmlData.Append("</ser:Detail>");

            xmlData.Append("<ser:File>");
            xmlData.Append("<mod:fileName>" + req.fileName + "</mod:fileName>");
            xmlData.Append("<mod:fileContent>" + Convert.ToBase64String(req.fileContent) + "</mod:fileContent>");
            xmlData.Append("</ser:File>");

            xmlData.Append("</ser:CreateConfirmationRequest>");
            xmlData.Append("</x:Body>");
            xmlData.Append("</x:Envelope>");
            return xmlData.ToString();
        }

        private string HtmlEncode(string s)
        {
            return HttpUtility.HtmlEncode(s);
        }
    }
}
