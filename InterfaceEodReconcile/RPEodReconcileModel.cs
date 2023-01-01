using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GM.Model.Static;

namespace GM.Model.InterfaceEodReconcile
{

    public class RPEodReconcileModel
    {

        [Required]
        [StringLength(50)]
        public string TRANS_EOD_NO { get; set; }

        [Required]
        public System.DateTime? ASOF_DATE { get; set; }

        [Required]
        public int BILATERAL_TRADE_TOTAL { get; set; }

        [Required]
        public int BILATERAL_TRADE_VERIFY { get; set; }

        [Required]
        public int BILATERAL_TRADE_PENDING { get; set; }

        [StringLength(500)]
        public string BILATERAL_TRADE_REMARK { get; set; }

        [Required]
        public int BILATERAL_SATTLEMENT_DVP_TOTAL { get; set; }

        [Required]
        public int BILATERAL_SATTLEMENT_DVP_PTI { get; set; }

        [Required]
        public int BILATERAL_SATTLEMENT_DVP_PENDING { get; set; }

        [StringLength(500)]
        public string BILATERAL_SATTLEMENT_DVP_REMARK { get; set; }

        [Required]
        public int BILATERAL_SATTLEMENT_RVP_TOTAL { get; set; }

        [Required]
        public int BILATERAL_SATTLEMENT_RVP_PTI { get; set; }

        [Required]
        public int BILATERAL_SATTLEMENT_RVP_PENDING { get; set; }

        [StringLength(500)]
        public string BILATERAL_SATTLEMENT_RVP_REMARK { get; set; }

        [Required]
        public int BILATERAL_SATTLEMENT_MT202_TOTAL { get; set; }

        [Required]
        public int BILATERAL_SATTLEMENT_MT202_BAHTNET { get; set; }

        [Required]
        public int BILATERAL_SATTLEMENT_MT202_PENDING { get; set; }

        [StringLength(500)]
        public string BILATERAL_SATTLEMENT_MT202_REMARK { get; set; }

        [Required]
        public int PRIVATE_TRADE_TOTAL { get; set; }

        [Required]
        public int PRIVATE_TRADE_VERIFY { get; set; }

        [Required]
        public int PRIVATE_TRADE_PENDING { get; set; }

        [StringLength(500)]
        public string PRIVATE_TRADE_REMARK { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_DVP_TOTAL { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_DVP_PTI { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_DVP_PENDING { get; set; }

        [StringLength(500)]
        public string PRIVATE_SATTLEMENT_DVP_REMARK { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_RVP_TOTAL { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_RVP_PTI { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_RVP_PENDING { get; set; }

        [StringLength(500)]
        public string PRIVATE_SATTLEMENT_RVP_REMARK { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_DF_TOTAL { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_DF_PTI { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_DF_PENDING { get; set; }

        [StringLength(500)]
        public string PRIVATE_SATTLEMENT_DF_REMARK { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_RF_TOTAL { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_RF_PTI { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_RF_PENDING { get; set; }

        [StringLength(500)]
        public string PRIVATE_SATTLEMENT_RF_REMARK { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_MT103_TOTAL { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_MT103_BAHTNET { get; set; }

        [Required]
        public int PRIVATE_SATTLEMENT_MT103_PENDING { get; set; }

        [StringLength(500)]
        public string PRIVATE_SATTLEMENT_MT103_REMARK { get; set; }

        [Required]
        public int BILATERAL_MARGIN_PAY_TOTAL { get; set; }

        [Required]
        public int BILATERAL_MARGIN_PAY_BAHTNET { get; set; }

        [Required]
        public int BILATERAL_MARGIN_PAY_PENDING { get; set; }

        [StringLength(500)]
        public string BILATERAL_MARGIN_PAY_REMARK { get; set; }

        [Required]
        public int BILATERAL_MARGIN_RECEIVE_TOTAL { get; set; }

        [Required]
        public int BILATERAL_MARGIN_RECEIVE_MANUAL { get; set; }

        [Required]
        public int BILATERAL_MARGIN_RECEIVE_PENDING { get; set; }

        [StringLength(500)]
        public string BILATERAL_MARGIN_RECEIVE_REMARK { get; set; }

        [Required]
        public int PRIVATE_MARGIN_PAY_TOTAL { get; set; }

        [Required]
        public int PRIVATE_MARGIN_PAY_BAHTNET { get; set; }

        [Required]
        public int PRIVATE_MARGIN_PAY_PENDING { get; set; }

        [StringLength(500)]
        public string PRIVATE_MARGIN_PAY_REMARK { get; set; }

        [Required]
        public int PRIVATE_MARGIN_RECEIVE_TOTAL { get; set; }

        [Required]
        public int PRIVATE_MARGIN_RECEIVE_MANUAL { get; set; }

        [Required]
        public int PRIVATE_MARGIN_RECEIVE_PENDING { get; set; }

        [StringLength(500)]
        public string PRIVATE_MARGIN_RECEIVE_REMARK { get; set; }

        [StringLength(255)]
        public string CREATE_BY { get; set; }

        public Nullable<System.DateTime> CREATE_DATE { get; set; }

        [StringLength(255)]
        public string UPDATE_BY { get; set; }

        public Nullable<System.DateTime> UPDATE_DATE { get; set; }

        public virtual List<RpConfigModel> RpConfigModel { get; set; }

    }
}
