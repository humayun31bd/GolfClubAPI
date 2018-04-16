using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClubMemberWebAPI.Models
{
    
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberCode { get; set; }
        public string MemberName { get; set; }
        public int MemberCategoryID { get; set; }
        public int MemberStatusID { get; set; }
       
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    
    public class MemberBNameView
    {
        public int MemberID { get; set; }
        public string MemberCode { get; set; }
        public string MemberName { get; set; }
        public int MemberCategoryID { get; set; }
        public int MemberStatusID { get; set; }

        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    
    public class Vendor
    {
        public int VendorID { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }

        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
    [Serializable()]
    public class ResponseModel
    {
        public string Message { set; get; }
        public bool Status { set; get; }
        public object Data { set; get; }
    }
    
    public class SalesOrderFrom 
    {
        private int m_SalesOrderID;
        private int m_AccFundID;
        private int m_MemberID;
        private string m_SDate;
        private decimal m_Amount;
        private string m_PaidBy;
        private DateTime m_CreatedDT;
        private string m_CreatedBy;
        private bool m_IsApproved;
        private string m_ApprovedBY;


        public SalesOrderFrom()
        {
        }

        public SalesOrderFrom(int salesOrderID, int accFundID, int memberID, string sDate, decimal amount, string paidBy, DateTime createdDT, string createdBy, bool isApproved, string approvedBY)
        {
            m_SalesOrderID = salesOrderID;
            m_AccFundID = accFundID;
            m_MemberID = memberID;
            m_SDate = sDate;
            m_Amount = amount;
            m_PaidBy = paidBy;
            m_CreatedDT = createdDT;
            m_CreatedBy = createdBy;
            m_IsApproved = isApproved;
            m_ApprovedBY = approvedBY;

        }

        public int SalesOrderID
        {
            get { return m_SalesOrderID; }
            set { m_SalesOrderID = value; }
        }
        public int AccFundID
        {
            get { return m_AccFundID; }
            set { m_AccFundID = value;   }
        }
        public int MemberID
        {
            get { return m_MemberID; }
            set { m_MemberID = value;   }
        }
        public string SDate
        {
            get { return m_SDate; }
            set { m_SDate = value;   }
        }
        public decimal Amount
        {
            get { return m_Amount; }
            set { m_Amount = value;   }
        }
        public string PaidBy
        {
            get { return m_PaidBy; }
            set { m_PaidBy = value;   }
        }
        public DateTime CreatedDT
        {
            get { return m_CreatedDT; }
            set { m_CreatedDT = value;   }
        }
        public string CreatedBy
        {
            get { return m_CreatedBy; }
            set { m_CreatedBy = value;   }
        }
        public bool IsApproved
        {
            get { return m_IsApproved; }
            set { m_IsApproved = value;   }
        }
        public string ApprovedBY
        {
            get { return m_ApprovedBY; }
            set { m_ApprovedBY = value;   }
        }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

    }
    
    public class PurchaseOrderFrom 
    {
        private int m_PurchaseOrderID;
        private int m_AccFundID;
        private int m_SupplierID;
        private string m_Date;
        private decimal m_PurchaseAmount;
        private decimal m_Discount;
        private decimal m_VAT;
        private decimal m_TAX;
        private string m_PaidBy;
        private string m_CreatedBy;
        private DateTime m_CreatedDT;
        private bool m_IsApproved;
        private string m_ApprovedBY;


        public PurchaseOrderFrom()
        {
        }

        public PurchaseOrderFrom(int purchaseOrderID, int accFundID, int supplierID, string date, decimal purchaseAmount, decimal discount, decimal vAT, decimal tAX, string paidBy, string createdBy, DateTime createdDT, bool isApproved, string approvedBY)
        {
            m_PurchaseOrderID = purchaseOrderID;
            m_AccFundID = accFundID;
            m_SupplierID = supplierID;
            m_Date = date;
            m_PurchaseAmount = purchaseAmount;
            m_Discount = discount;
            m_VAT = vAT;
            m_TAX = tAX;
            m_PaidBy = paidBy;
            m_CreatedBy = createdBy;
            m_CreatedDT = createdDT;
            m_IsApproved = isApproved;
            m_ApprovedBY = approvedBY;

        }

        public int PurchaseOrderID
        {
            get { return m_PurchaseOrderID; }
            set { m_PurchaseOrderID = value;   }
        }
        public int AccFundID
        {
            get { return m_AccFundID; }
            set { m_AccFundID = value;   }
        }
        public int SupplierID
        {
            get { return m_SupplierID; }
            set { m_SupplierID = value;   }
        }
        public string Date
        {
            get { return m_Date; }
            set { m_Date = value;   }
        }
        public decimal PurchaseAmount
        {
            get { return m_PurchaseAmount; }
            set { m_PurchaseAmount = value;   }
        }
        public decimal Discount
        {
            get { return m_Discount; }
            set { m_Discount = value;   }
        }
        public decimal VAT
        {
            get { return m_VAT; }
            set { m_VAT = value;   }
        }
        public decimal TAX
        {
            get { return m_TAX; }
            set { m_TAX = value;   }
        }
        public string PaidBy
        {
            get { return m_PaidBy; }
            set { m_PaidBy = value;   }
        }
        public string CreatedBy
        {
            get { return m_CreatedBy; }
            set { m_CreatedBy = value;   }
        }
        public DateTime CreatedDT
        {
            get { return m_CreatedDT; }
            set { m_CreatedDT = value;   }
        }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

    }

}