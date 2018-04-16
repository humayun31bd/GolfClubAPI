using ClubMemberWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ClubMemberWebAPI.DTO
{
    public class DataLib
    {
        public DataLib()
        {

        }
        public MemberBNameView getMemberByName(string pMembername)
        {
            MemberBNameView oMemberModel = new MemberBNameView();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GolfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select  MemberID,NameOfMember,MemberCode,MemberCategoryID,MemberStatusID from dbo.MemberInfo ";
                if (!string.IsNullOrEmpty(pMembername))
                {
                    sSQL = sSQL + " where NameOfMember like '%" + pMembername + "%'";
                }
                
                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {
                   
                    adpt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            if (rw["MemberID"] != DBNull.Value)
                            {
                                oMemberModel.MemberID = Convert.ToInt32(rw["MemberID"].ToString());
                            }
                            if (rw["NameOfMember"] != DBNull.Value)
                            {
                                oMemberModel.MemberName = Convert.ToString(rw["NameOfMember"].ToString());
                            }
                            if (rw["MemberCode"] != DBNull.Value)
                            {
                                oMemberModel.MemberCode = Convert.ToString(rw["MemberCode"].ToString());
                            }
                            if (rw["MemberStatusID"] != DBNull.Value)
                            {
                                oMemberModel.MemberStatusID = Convert.ToInt32(rw["MemberStatusID"].ToString());
                            }
                            if (rw["MemberCategoryID"] != DBNull.Value)
                            {
                                oMemberModel.MemberCategoryID = Convert.ToInt32(rw["MemberCategoryID"].ToString());
                            }
                            oMemberModel.ErrorCode = 0;
                            oMemberModel.ErrorMessage = "Success";
                        }
                    }
                    else
                    {
                        oMemberModel.ErrorCode = 101;
                        oMemberModel.ErrorMessage = "Invalid Account";
                    }
                }
                catch (SqlException ex)
                {
                    oMemberModel.ErrorCode = 601;
                    oMemberModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oMemberModel;
        }
        public Member getMemberByCode(string pMemberCode)
        {
            Member oMemberModel = new Member();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GolfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select  MemberID,NameOfMember,MemberCode,MemberCategoryID,MemberStatusID from dbo.MemberInfo ";
                if (!string.IsNullOrEmpty(pMemberCode))
                {
                    sSQL = sSQL + " where MemberCode = '" + pMemberCode + "'";
                }

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            if (rw["MemberID"] != DBNull.Value)
                            {
                                oMemberModel.MemberID = Convert.ToInt32(rw["MemberID"].ToString());
                            }
                            if (rw["NameOfMember"] != DBNull.Value)
                            {
                                oMemberModel.MemberName = Convert.ToString(rw["NameOfMember"].ToString());
                            }
                            if (rw["MemberCode"] != DBNull.Value)
                            {
                                oMemberModel.MemberCode = Convert.ToString(rw["MemberCode"].ToString());
                            }
                            if (rw["MemberStatusID"] != DBNull.Value)
                            {
                                oMemberModel.MemberStatusID = Convert.ToInt32(rw["MemberStatusID"].ToString());
                            }
                            if (rw["MemberCategoryID"] != DBNull.Value)
                            {
                                oMemberModel.MemberCategoryID = Convert.ToInt32(rw["MemberCategoryID"].ToString());
                            }
                            oMemberModel.ErrorCode = 0;
                            oMemberModel.ErrorMessage = "Success";
                        }
                    }
                    else
                    {
                        oMemberModel.ErrorCode = 101;
                        oMemberModel.ErrorMessage = "Invalid Account";
                    }
                }
                catch (SqlException ex)
                {
                    oMemberModel.ErrorCode = 601;
                    oMemberModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oMemberModel;
        }
        public Member getMemberByID(Int32 pMemberID)
        {
            Member oMemberModel = new Member();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GolfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select  MemberID,NameOfMember,MemberCode,MemberCategoryID,MemberStatusID from dbo.MemberInfo ";
                if (!string.IsNullOrEmpty(pMemberID.ToString()))
                {
                    sSQL = sSQL + " where MemberID = '" + pMemberID + "'";
                }

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            if (rw["MemberID"] != DBNull.Value)
                            {
                                oMemberModel.MemberID = Convert.ToInt32(rw["MemberID"].ToString());
                            }
                            if (rw["NameOfMember"] != DBNull.Value)
                            {
                                oMemberModel.MemberName = Convert.ToString(rw["NameOfMember"].ToString());
                            }
                            if (rw["MemberCode"] != DBNull.Value)
                            {
                                oMemberModel.MemberCode = Convert.ToString(rw["MemberCode"].ToString());
                            }
                            if (rw["MemberStatusID"] != DBNull.Value)
                            {
                                oMemberModel.MemberStatusID = Convert.ToInt32(rw["MemberStatusID"].ToString());
                            }
                            if (rw["MemberCategoryID"] != DBNull.Value)
                            {
                                oMemberModel.MemberCategoryID = Convert.ToInt32(rw["MemberCategoryID"].ToString());
                            }
                            oMemberModel.ErrorCode = 0;
                            oMemberModel.ErrorMessage = "Success";
                        }
                    }
                    else
                    {
                        oMemberModel.ErrorCode = 101;
                        oMemberModel.ErrorMessage = "Invalid Account";
                    }
                }
                catch (SqlException ex)
                {
                    oMemberModel.ErrorCode = 601;
                    oMemberModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oMemberModel;
        }
        public List<Member> getMembers()
        {
            List<Member> oMemberModelList = new List<Member>();
            Member oMemberModel = new Member();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GolfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select  MemberID,NameOfMember,MemberCode,MemberCategoryID,MemberStatusID from dbo.MemberInfo ";

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {
                    
                    adpt.Fill(dt);
                    
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oMemberModel = new Member();
                            if (rw["MemberID"] != DBNull.Value)
                            {
                                oMemberModel.MemberID = Convert.ToInt32(rw["MemberID"].ToString());
                            }
                            if (rw["NameOfMember"] != DBNull.Value)
                            {
                                oMemberModel.MemberName = Convert.ToString(rw["NameOfMember"].ToString());
                            }
                            if (rw["MemberCode"] != DBNull.Value)
                            {
                                oMemberModel.MemberCode = Convert.ToString(rw["MemberCode"].ToString());
                            }
                            if (rw["MemberStatusID"] != DBNull.Value)
                            {
                                oMemberModel.MemberStatusID = Convert.ToInt32(rw["MemberStatusID"].ToString());
                            }
                            if (rw["MemberCategoryID"] != DBNull.Value)
                            {
                                oMemberModel.MemberCategoryID = Convert.ToInt32(rw["MemberCategoryID"].ToString());
                            }
                            oMemberModel.ErrorCode = 0;
                            oMemberModel.ErrorMessage = "Success";
                            oMemberModelList.Add(oMemberModel);
                        }
                    }
                    else
                    {
                        oMemberModel.ErrorCode = 101;
                        oMemberModel.ErrorMessage = "Invalid Account";
                    }
                }
                catch (SqlException ex)
                {
                    oMemberModel.ErrorCode = 601;
                    oMemberModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oMemberModelList;
        }
        public List<Vendor> getVendors()
        {
            List<Vendor> oVendorModelList = new List<Vendor>();
            Vendor oVendorModel = new Vendor();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select AccSubCode,AccSubID,AccSubName,Mobile,Email from dbo.AccSubNames where AccSubTypeID=4  ";

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oVendorModel = new Vendor();
                            oVendorModel.Email = string.Empty;
                            oVendorModel.MobileNo = string.Empty;
                            oVendorModel.VendorCode = string.Empty;
                            if (rw["AccSubCode"] != DBNull.Value)
                            {
                                oVendorModel.VendorID = Convert.ToInt32(rw["AccSubCode"].ToString());
                            }
                            if (rw["AccSubName"] != DBNull.Value)
                            {
                                oVendorModel.VendorName = Convert.ToString(rw["AccSubName"].ToString());
                            }
                            if (rw["AccSubID"] != DBNull.Value)
                            {
                                oVendorModel.VendorCode = Convert.ToString(rw["AccSubID"].ToString());
                            }
                            if (rw["Mobile"] != DBNull.Value)
                            {
                                oVendorModel.MobileNo = Convert.ToString(rw["Mobile"].ToString());
                            }
                            if (rw["Email"] != DBNull.Value)
                            {
                                oVendorModel.Email = Convert.ToString(rw["Email"].ToString());
                            }
                            oVendorModel.ErrorCode = 0;
                            oVendorModel.ErrorMessage = "Success";
                            oVendorModelList.Add(oVendorModel);
                        }
                    }
                    else
                    {
                        oVendorModel.ErrorCode = 101;
                        oVendorModel.ErrorMessage = "Invalid Account";
                    }
                }
                catch (SqlException ex)
                {
                    oVendorModel.ErrorCode = 601;
                    oVendorModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oVendorModelList;
        }
        public Vendor getVendorByID(Int32 pVendorID)
        {
            Vendor oVendorModel = new Vendor();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select  AccSubCode,AccSubName,AccSubID,Mobile,Email from dbo.AccSubNames ";
                if (!string.IsNullOrEmpty(pVendorID.ToString()))
                {
                    sSQL = sSQL + " where AccSubCode = '" + pVendorID + "'";
                }

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            if (rw["AccSubCode"] != DBNull.Value)
                            {
                                oVendorModel.VendorID = Convert.ToInt32(rw["AccSubCode"].ToString());
                            }
                            if (rw["AccSubName"] != DBNull.Value)
                            {
                                oVendorModel.VendorName = Convert.ToString(rw["AccSubName"].ToString());
                            }
                            if (rw["AccSubID"] != DBNull.Value)
                            {
                                oVendorModel.VendorCode = Convert.ToString(rw["AccSubID"].ToString());
                            }
                            if (rw["Mobile"] != DBNull.Value)
                            {
                                oVendorModel.MobileNo = Convert.ToString(rw["Mobile"].ToString());
                            }
                            if (rw["Email"] != DBNull.Value)
                            {
                                oVendorModel.Email = Convert.ToString(rw["Email"].ToString());
                            }
                            oVendorModel.ErrorCode = 0;
                            oVendorModel.ErrorMessage = "Success";
                        }
                    }
                    else
                    {
                        oVendorModel.ErrorCode = 101;
                        oVendorModel.ErrorMessage = "Invalid Account";
                    }
                }
                catch (SqlException ex)
                {
                    oVendorModel.ErrorCode = 601;
                    oVendorModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oVendorModel;
        }
        public Vendor getVendorByCode(string pVendorCode)
        {
            Vendor oVendorModel = new Vendor();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select  AccSubCode,AccSubName,AccSubID,Mobile,Email from dbo.AccSubNames ";
                if (!string.IsNullOrEmpty(pVendorCode.ToString()))
                {
                    sSQL = sSQL + " where AccSubID = '" + pVendorCode + "'";
                }

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            if (rw["AccSubCode"] != DBNull.Value)
                            {
                                oVendorModel.VendorID = Convert.ToInt32(rw["AccSubCode"].ToString());
                            }
                            if (rw["AccSubName"] != DBNull.Value)
                            {
                                oVendorModel.VendorName = Convert.ToString(rw["AccSubName"].ToString());
                            }
                            if (rw["AccSubID"] != DBNull.Value)
                            {
                                oVendorModel.VendorCode = Convert.ToString(rw["AccSubID"].ToString());
                            }
                            if (rw["Mobile"] != DBNull.Value)
                            {
                                oVendorModel.MobileNo = Convert.ToString(rw["Mobile"].ToString());
                            }
                            if (rw["Email"] != DBNull.Value)
                            {
                                oVendorModel.Email = Convert.ToString(rw["Email"].ToString());
                            }
                            oVendorModel.ErrorCode = 0;
                            oVendorModel.ErrorMessage = "Success";
                        }
                    }
                    else
                    {
                        oVendorModel.ErrorCode = 101;
                        oVendorModel.ErrorMessage = "Invalid Account";
                    }
                }
                catch (SqlException ex)
                {
                    oVendorModel.ErrorCode = 601;
                    oVendorModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oVendorModel;
        }
        public Vendor getVendorByName(string pVendorName)
        {
            Vendor oVendorModel = new Vendor();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select  AccSubCode,AccSubName,AccSubID,Mobile,Email from dbo.AccSubNames ";
                if (!string.IsNullOrEmpty(pVendorName.ToString()))
                {
                    sSQL = sSQL + " where AccSubName = '" + pVendorName + "'";
                }

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            if (rw["AccSubCode"] != DBNull.Value)
                            {
                                oVendorModel.VendorID = Convert.ToInt32(rw["AccSubCode"].ToString());
                            }
                            if (rw["AccSubName"] != DBNull.Value)
                            {
                                oVendorModel.VendorName = Convert.ToString(rw["AccSubName"].ToString());
                            }
                            if (rw["AccSubID"] != DBNull.Value)
                            {
                                oVendorModel.VendorCode = Convert.ToString(rw["AccSubID"].ToString());
                            }
                            if (rw["Mobile"] != DBNull.Value)
                            {
                                oVendorModel.MobileNo = Convert.ToString(rw["Mobile"].ToString());
                            }
                            if (rw["Email"] != DBNull.Value)
                            {
                                oVendorModel.Email = Convert.ToString(rw["Email"].ToString());
                            }
                            oVendorModel.ErrorCode = 0;
                            oVendorModel.ErrorMessage = "Success";
                        }
                    }
                    else
                    {
                        oVendorModel.ErrorCode = 101;
                        oVendorModel.ErrorMessage = "Invalid Account";
                    }
                }
                catch (SqlException ex)
                {
                    oVendorModel.ErrorCode = 601;
                    oVendorModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oVendorModel;
        }

        public List<PurchaseOrderFrom> getPurchaseOrders()
        {
            List<PurchaseOrderFrom> oPurchaseOrderFromModelList = new List<PurchaseOrderFrom>();
            PurchaseOrderFrom oPurchaseOrderFromModel = new PurchaseOrderFrom();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select PurchaseOrderID,[AccFundID],[SupplierID],[Date],[PurchaseAmount],[Discount],[VAT],[TAX],[PaidBy],[CreatedBy],[CreatedDT] from dbo.PurchaseOrderFrom  ";

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oPurchaseOrderFromModel = new PurchaseOrderFrom();
                            if (rw["AccFundID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.AccFundID = Convert.ToInt32(rw["AccFundID"].ToString());
                            }
                            if (rw["SupplierID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.SupplierID = Convert.ToInt32(rw["SupplierID"].ToString());
                            }
                            if (rw["PurchaseOrderID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PurchaseOrderID = Convert.ToInt32(rw["PurchaseOrderID"].ToString());
                            }
                            if (rw["CreatedBy"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.CreatedBy = Convert.ToString(rw["CreatedBy"].ToString());
                            }
                            if (rw["Date"] != DBNull.Value)
                            {
                                DateTime oDate = Convert.ToDateTime(rw["Date"].ToString());
                                string sDate = oDate.Month.ToString() + "/" + oDate.Day.ToString() + "/" + oDate.Year.ToString();
                                oPurchaseOrderFromModel.Date = sDate;
                            }
                            if (rw["Discount"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.Discount = Convert.ToDecimal(rw["Discount"].ToString());
                            }
                            if (rw["PaidBy"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PaidBy = Convert.ToString(rw["PaidBy"].ToString());
                            }
                            if (rw["PurchaseAmount"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PurchaseAmount = Convert.ToDecimal(rw["PurchaseAmount"].ToString());
                            }
                            if (rw["TAX"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.TAX = Convert.ToDecimal(rw["TAX"].ToString());
                            }
                            if (rw["VAT"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.VAT = Convert.ToDecimal(rw["VAT"].ToString());
                            }
                            oPurchaseOrderFromModel.ErrorCode = 0;
                            oPurchaseOrderFromModel.ErrorMessage = "Success";
                            oPurchaseOrderFromModelList.Add(oPurchaseOrderFromModel);
                        }
                    }
                    else
                    {
                        oPurchaseOrderFromModel.ErrorCode = 100;
                        oPurchaseOrderFromModel.ErrorMessage = "No Order Found";
                        oPurchaseOrderFromModelList.Add(oPurchaseOrderFromModel);
                    }
                }
                catch (SqlException ex)
                {
                    oPurchaseOrderFromModel.ErrorCode = 601;
                    oPurchaseOrderFromModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oPurchaseOrderFromModelList;
        }
        public List<PurchaseOrderFrom> getbySupplier(int pSupplierid)
        {
            List<PurchaseOrderFrom> oPurchaseOrderFromModelList = new List<PurchaseOrderFrom>();
            PurchaseOrderFrom oPurchaseOrderFromModel = new PurchaseOrderFrom();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select PurchaseOrderID,[AccFundID],[SupplierID],[Date],[PurchaseAmount],[Discount],[VAT],[TAX],[PaidBy],[CreatedBy],[CreatedDT] from dbo.PurchaseOrderFrom where SupplierID=" + pSupplierid.ToString();

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oPurchaseOrderFromModel = new PurchaseOrderFrom();
                            if (rw["AccFundID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.AccFundID = Convert.ToInt32(rw["AccFundID"].ToString());
                            }
                            if (rw["SupplierID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.SupplierID = Convert.ToInt32(rw["SupplierID"].ToString());
                            }
                            if (rw["PurchaseOrderID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PurchaseOrderID = Convert.ToInt32(rw["PurchaseOrderID"].ToString());
                            }
                            if (rw["CreatedBy"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.CreatedBy = Convert.ToString(rw["CreatedBy"].ToString());
                            }
                            if (rw["Date"] != DBNull.Value)
                            {
                                DateTime oDate = Convert.ToDateTime(rw["Date"].ToString());
                                string sDate = oDate.Month.ToString() + "/" + oDate.Day.ToString() + "/" + oDate.Year.ToString();
                                oPurchaseOrderFromModel.Date = sDate;
                            }
                            if (rw["Discount"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.Discount = Convert.ToDecimal(rw["Discount"].ToString());
                            }
                            if (rw["PaidBy"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PaidBy = Convert.ToString(rw["PaidBy"].ToString());
                            }
                            if (rw["PurchaseAmount"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PurchaseAmount = Convert.ToDecimal(rw["PurchaseAmount"].ToString());
                            }
                            if (rw["TAX"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.TAX = Convert.ToDecimal(rw["TAX"].ToString());
                            }
                            if (rw["VAT"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.VAT = Convert.ToDecimal(rw["VAT"].ToString());
                            }
                            oPurchaseOrderFromModel.ErrorCode = 0;
                            oPurchaseOrderFromModel.ErrorMessage = "Success";
                            oPurchaseOrderFromModelList.Add(oPurchaseOrderFromModel);
                        }
                    }
                    else
                    {
                        oPurchaseOrderFromModel.ErrorCode = 100;
                        oPurchaseOrderFromModel.ErrorMessage = "No Order Found";
                        oPurchaseOrderFromModelList.Add(oPurchaseOrderFromModel);
                    }
                }
                catch (SqlException ex)
                {
                    oPurchaseOrderFromModel.ErrorCode = 601;
                    oPurchaseOrderFromModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oPurchaseOrderFromModelList;
        }
        public List<PurchaseOrderFrom> getbyPurchaseOrder(int pPurchaseOrderID)
        {
            List<PurchaseOrderFrom> oPurchaseOrderFromModelList = new List<PurchaseOrderFrom>();
            PurchaseOrderFrom oPurchaseOrderFromModel = new PurchaseOrderFrom();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select PurchaseOrderID,[AccFundID],[SupplierID],[Date],[PurchaseAmount],[Discount],[VAT],[TAX],[PaidBy],[CreatedBy],[CreatedDT] from dbo.PurchaseOrderFrom where PurchaseOrderID=" + pPurchaseOrderID.ToString();

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oPurchaseOrderFromModel = new PurchaseOrderFrom();
                            if (rw["AccFundID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.AccFundID = Convert.ToInt32(rw["AccFundID"].ToString());
                            }
                            if (rw["SupplierID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.SupplierID = Convert.ToInt32(rw["SupplierID"].ToString());
                            }
                            if (rw["PurchaseOrderID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PurchaseOrderID = Convert.ToInt32(rw["PurchaseOrderID"].ToString());
                            }
                            if (rw["CreatedBy"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.CreatedBy = Convert.ToString(rw["CreatedBy"].ToString());
                            }
                            if (rw["Date"] != DBNull.Value)
                            {
                                DateTime oDate = Convert.ToDateTime(rw["Date"].ToString());
                                string sDate = oDate.Month.ToString() + "/" + oDate.Day.ToString() + "/" + oDate.Year.ToString();
                                oPurchaseOrderFromModel.Date = sDate;
                            }
                            if (rw["Discount"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.Discount = Convert.ToDecimal(rw["Discount"].ToString());
                            }
                            if (rw["PaidBy"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PaidBy = Convert.ToString(rw["PaidBy"].ToString());
                            }
                            if (rw["PurchaseAmount"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PurchaseAmount = Convert.ToDecimal(rw["PurchaseAmount"].ToString());
                            }
                            if (rw["TAX"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.TAX = Convert.ToDecimal(rw["TAX"].ToString());
                            }
                            if (rw["VAT"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.VAT = Convert.ToDecimal(rw["VAT"].ToString());
                            }
                            oPurchaseOrderFromModel.ErrorCode = 0;
                            oPurchaseOrderFromModel.ErrorMessage = "Success";
                            oPurchaseOrderFromModelList.Add(oPurchaseOrderFromModel);
                        }
                    }
                    else
                    {
                        oPurchaseOrderFromModel.ErrorCode = 100;
                        oPurchaseOrderFromModel.ErrorMessage = "No Order Found";
                        oPurchaseOrderFromModelList.Add(oPurchaseOrderFromModel);
                    }
                }
                catch (SqlException ex)
                {
                    oPurchaseOrderFromModel.ErrorCode = 601;
                    oPurchaseOrderFromModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oPurchaseOrderFromModelList;
        }
        public PurchaseOrderFrom getPurchaseOrder(int pPurchaseOrderID)
        {
            PurchaseOrderFrom oPurchaseOrderFromModel = new PurchaseOrderFrom();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select PurchaseOrderID,[AccFundID],[SupplierID],[Date],[PurchaseAmount],[Discount],[VAT],[TAX],[PaidBy],[CreatedBy],[CreatedDT] from dbo.PurchaseOrderFrom where PurchaseOrderID= " + pPurchaseOrderID.ToString();

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oPurchaseOrderFromModel = new PurchaseOrderFrom();
                            if (rw["AccFundID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.AccFundID = Convert.ToInt32(rw["AccFundID"].ToString());
                            }
                            if (rw["SupplierID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.SupplierID = Convert.ToInt32(rw["SupplierID"].ToString());
                            }
                            if (rw["PurchaseOrderID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PurchaseOrderID = Convert.ToInt32(rw["PurchaseOrderID"].ToString());
                            }
                            if (rw["CreatedBy"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.CreatedBy = Convert.ToString(rw["CreatedBy"].ToString());
                            }
                            if (rw["Date"] != DBNull.Value)
                            {
                                DateTime oDate = Convert.ToDateTime(rw["Date"].ToString());
                                string sDate = oDate.Month.ToString() + "/" + oDate.Day.ToString() + "/" + oDate.Year.ToString();
                                oPurchaseOrderFromModel.Date = sDate;
                            }
                            if (rw["Discount"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.Discount = Convert.ToDecimal(rw["Discount"].ToString());
                            }
                            if (rw["PaidBy"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PaidBy = Convert.ToString(rw["PaidBy"].ToString());
                            }
                            if (rw["PurchaseAmount"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PurchaseAmount = Convert.ToDecimal(rw["PurchaseAmount"].ToString());
                            }
                            if (rw["TAX"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.TAX = Convert.ToDecimal(rw["TAX"].ToString());
                            }
                            if (rw["VAT"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.VAT = Convert.ToDecimal(rw["VAT"].ToString());
                            }
                            oPurchaseOrderFromModel.ErrorCode = 0;
                            oPurchaseOrderFromModel.ErrorMessage = "Success";
                            
                        }
                    }
                    else
                    {
                        oPurchaseOrderFromModel.ErrorCode = 101;
                        oPurchaseOrderFromModel.ErrorMessage = "Invalid Order";
                    }
                }
                catch (SqlException ex)
                {
                    oPurchaseOrderFromModel.ErrorCode = 601;
                    oPurchaseOrderFromModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oPurchaseOrderFromModel;
        }
        public PurchaseOrderFrom getPurchaseOrder(int pCompanyID, int pSupplierID, string pDate,string pPaidBy)
        {
            DateTime purDate = new DateTime();
            try
            {
                purDate = Convert.ToDateTime(pDate);
            }
            catch
            {
            }

            List<PurchaseOrderFrom> oPurchaseOrderFromModelList = new List<PurchaseOrderFrom>();
            PurchaseOrderFrom oPurchaseOrderFromModel = new PurchaseOrderFrom();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = " ";
                sSQL = sSQL + "    Select  PurchaseOrderID,[AccFundID],[SupplierID],[Date],[PurchaseAmount],[Discount],[VAT],[TAX],[PaidBy],[CreatedBy],[CreatedDT] ";
                sSQL = sSQL + "    from [dbo].[PurchaseOrderFrom]"; 
                sSQL = sSQL + "    Where AccFundID = " + pCompanyID.ToString();
                sSQL = sSQL + "    And SupplierID = " + pSupplierID.ToString();
                sSQL = sSQL + "    And Year(Date) = Year(" + purDate.ToString() + ")";
                sSQL = sSQL + "    And Month(Date) = Month(" + purDate.ToString()+ ")";
                sSQL = sSQL + "    And Day(Date) = Day(" + pDate.ToString()+ ")";
                sSQL = sSQL + "    And Hour(Date) = Hour(" + pDate.ToString() + ")";
                sSQL = sSQL + "    And Minute(Date) = Minute(" + pDate.ToString() + ")";
                sSQL = sSQL + "    And PaidBy= " + pPaidBy.ToString();

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oPurchaseOrderFromModel = new PurchaseOrderFrom();
                            if (rw["AccFundID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.AccFundID = Convert.ToInt32(rw["AccFundID"].ToString());
                            }
                            if (rw["SupplierID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.SupplierID = Convert.ToInt32(rw["SupplierID"].ToString());
                            }
                            if (rw["PurchaseOrderID"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PurchaseOrderID = Convert.ToInt32(rw["PurchaseOrderID"].ToString());
                            }
                            if (rw["CreatedBy"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.CreatedBy = Convert.ToString(rw["CreatedBy"].ToString());
                            }
                            if (rw["Date"] != DBNull.Value)
                            {
                                DateTime oDate = Convert.ToDateTime(rw["Date"].ToString());
                                string sDate = oDate.Month.ToString() + "/" + oDate.Day.ToString() + "/" + oDate.Year.ToString();
                                oPurchaseOrderFromModel.Date = sDate;
                            }
                            if (rw["Discount"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.Discount = Convert.ToDecimal(rw["Discount"].ToString());
                            }
                            if (rw["PaidBy"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PaidBy = Convert.ToString(rw["PaidBy"].ToString());
                            }
                            if (rw["PurchaseAmount"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.PurchaseAmount = Convert.ToDecimal(rw["PurchaseAmount"].ToString());
                            }
                            if (rw["TAX"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.TAX = Convert.ToDecimal(rw["TAX"].ToString());
                            }
                            if (rw["VAT"] != DBNull.Value)
                            {
                                oPurchaseOrderFromModel.VAT = Convert.ToDecimal(rw["VAT"].ToString());
                            }
                            oPurchaseOrderFromModel.ErrorCode = 0;
                            oPurchaseOrderFromModel.ErrorMessage = "Success";
                            oPurchaseOrderFromModelList.Add(oPurchaseOrderFromModel);
                        }
                    }
                    else
                    {
                        oPurchaseOrderFromModel.ErrorCode = 101;
                        oPurchaseOrderFromModel.ErrorMessage = "Invalid Account";
                    }
                }
                catch (SqlException ex)
                {
                    oPurchaseOrderFromModel.ErrorCode = 601;
                    oPurchaseOrderFromModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oPurchaseOrderFromModel;
        }

        public PurchaseOrderFrom CreatePurchaseOrder(PurchaseOrderFrom oPurchaseOrderFrom)
        {


            bool IsCreateOrder = false;
            List<PurchaseOrderFrom> oPurchaseOrderFromModelList = new List<PurchaseOrderFrom>();
            PurchaseOrderFrom oPurchaseOrderFromModel = new PurchaseOrderFrom();

            PurchaseOrderFrom DupPurchaseOrder = getPurchaseOrder(oPurchaseOrderFrom.AccFundID, oPurchaseOrderFrom.SupplierID, oPurchaseOrderFrom.Date, oPurchaseOrderFrom.PaidBy);
            if (DupPurchaseOrder.PurchaseOrderID>0)
            {
                IsCreateOrder = false;
                oPurchaseOrderFromModel.ErrorCode = 102;
                oPurchaseOrderFromModel.ErrorMessage = "Duplicate Order Found";
                return oPurchaseOrderFromModel;
            }
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //

                string sSQL = "INSERT INTO [dbo].[PurchaseOrderFrom]([AccFundID],[SupplierID],[Date],[PurchaseAmount],[Discount],[VAT],[TAX],[PaidBy],[CreatedBy],[CreatedDT])";
                sSQL = sSQL + "VALUES(" + oPurchaseOrderFrom.AccFundID + "," + oPurchaseOrderFrom.SupplierID + "," + oPurchaseOrderFrom.Date + "," + oPurchaseOrderFrom.PurchaseAmount + "," + oPurchaseOrderFrom.Discount + "," + oPurchaseOrderFrom.VAT + "," + oPurchaseOrderFrom.TAX + "," + oPurchaseOrderFrom.PaidBy + "," + oPurchaseOrderFrom.CreatedBy + "," + oPurchaseOrderFrom.CreatedDT + ")";

                SqlCommand cmd = new SqlCommand(sSQL, con);
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {
                    cmd.ExecuteNonQuery();

                    PurchaseOrderFrom InsertedPurchaseOrder = getPurchaseOrder(oPurchaseOrderFrom.AccFundID, oPurchaseOrderFrom.SupplierID, oPurchaseOrderFrom.Date, oPurchaseOrderFrom.PaidBy);
                    oPurchaseOrderFrom.PurchaseOrderID = InsertedPurchaseOrder.PurchaseOrderID;
                    oPurchaseOrderFrom.ErrorCode = 0;
                    oPurchaseOrderFrom.ErrorMessage = "Success";
                }
                catch (SqlException ex)
                {
                    oPurchaseOrderFrom.ErrorCode = 601;
                    oPurchaseOrderFrom.ErrorMessage = ex.Message.ToString();
                }
            }
            return oPurchaseOrderFrom;
        }

        public List<SalesOrderFrom> getSalesOrders()
        {
            List<SalesOrderFrom> oSalesOrderFromModelList = new List<SalesOrderFrom>();
            SalesOrderFrom oSalesOrderFromModel = new SalesOrderFrom();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select SalesOrderID,AccFundID,MemberID,SDate,Amount,PaidBy,CreatedDT,CreatedBy from dbo.SalesOrderFrom where 1=1 ";

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oSalesOrderFromModel = new SalesOrderFrom();
                            if (rw["AccFundID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.AccFundID = Convert.ToInt32(rw["AccFundID"].ToString());
                            }
                            if (rw["MemberID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.MemberID = Convert.ToInt32(rw["MemberID"].ToString());
                            }
                            if (rw["SalesOrderID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.SalesOrderID = Convert.ToInt32(rw["SalesOrderID"].ToString());
                            }
                            if (rw["CreatedDT"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.CreatedDT = Convert.ToDateTime(rw["CreatedDT"].ToString());
                            }
                            if (rw["CreatedBy"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.CreatedBy = Convert.ToString(rw["CreatedBy"].ToString());
                            }
                            if (rw["SDate"] != DBNull.Value)
                            {
                                DateTime oDate = Convert.ToDateTime(rw["SDate"].ToString());
                                string sDate = oDate.Month.ToString() + "/" + oDate.Day.ToString() + "/" + oDate.Year.ToString();
                                oSalesOrderFromModel.SDate = sDate;
                            }
                            if (rw["PaidBy"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.PaidBy = Convert.ToString(rw["PaidBy"].ToString());
                            }
                            oSalesOrderFromModel.ErrorCode = 0;
                            oSalesOrderFromModel.ErrorMessage = "Success";
                            oSalesOrderFromModelList.Add(oSalesOrderFromModel);
                        }
                    }
                    else
                    {
                        oSalesOrderFromModel.ErrorCode = 100;
                        oSalesOrderFromModel.ErrorMessage = "No Order Found";
                        oSalesOrderFromModelList.Add(oSalesOrderFromModel);
                    }
                }
                catch (SqlException ex)
                {
                    oSalesOrderFromModel.ErrorCode = 601;
                    oSalesOrderFromModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oSalesOrderFromModelList;
        }
        public List<SalesOrderFrom> getbyMember(int pMemberID)
        {
            List<SalesOrderFrom> oSalesOrderFromModelList = new List<SalesOrderFrom>();
            SalesOrderFrom oSalesOrderFromModel = new SalesOrderFrom();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select SalesOrderID,AccFundID,MemberID,SDate,Amount,PaidBy,CreatedDT,CreatedBy from dbo.SalesOrderFrom where 1=1 and MemberID=" + pMemberID.ToString();

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oSalesOrderFromModel = new SalesOrderFrom();
                            if (rw["AccFundID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.AccFundID = Convert.ToInt32(rw["AccFundID"].ToString());
                            }
                            if (rw["MemberID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.MemberID = Convert.ToInt32(rw["MemberID"].ToString());
                            }
                            if (rw["SalesOrderID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.SalesOrderID = Convert.ToInt32(rw["SalesOrderID"].ToString());
                            }
                            if (rw["CreatedDT"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.CreatedDT = Convert.ToDateTime(rw["CreatedDT"].ToString());
                            }
                            if (rw["CreatedBy"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.CreatedBy = Convert.ToString(rw["CreatedBy"].ToString());
                            }
                            if (rw["SDate"] != DBNull.Value)
                            {
                                DateTime oDate = Convert.ToDateTime(rw["SDate"].ToString());
                                string sDate = oDate.Month.ToString() + "/" + oDate.Day.ToString() + "/" + oDate.Year.ToString();
                                oSalesOrderFromModel.SDate = sDate;
                            }
                            if (rw["PaidBy"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.PaidBy = Convert.ToString(rw["PaidBy"].ToString());
                            }
                            oSalesOrderFromModel.ErrorCode = 0;
                            oSalesOrderFromModel.ErrorMessage = "Success";
                            oSalesOrderFromModelList.Add(oSalesOrderFromModel);
                        }
                    }
                    else
                    {
                        oSalesOrderFromModel.ErrorCode = 100;
                        oSalesOrderFromModel.ErrorMessage = "No Order Found";
                        oSalesOrderFromModelList.Add(oSalesOrderFromModel);
                    }
                }
                catch (SqlException ex)
                {
                    oSalesOrderFromModel.ErrorCode = 601;
                    oSalesOrderFromModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oSalesOrderFromModelList;
        }
        public List<SalesOrderFrom> getbySalesOrder(int pSalesOrderID)
        {
            List<SalesOrderFrom> oSalesOrderFromModelList = new List<SalesOrderFrom>();
            SalesOrderFrom oSalesOrderFromModel = new SalesOrderFrom();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select SalesOrderID,AccFundID,MemberID,SDate,Amount,PaidBy,CreatedDT,CreatedBy from dbo.SalesOrderFrom where 1=1 and SalesOrderID=" + pSalesOrderID.ToString();

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oSalesOrderFromModel = new SalesOrderFrom();
                            if (rw["AccFundID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.AccFundID = Convert.ToInt32(rw["AccFundID"].ToString());
                            }
                            if (rw["MemberID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.MemberID = Convert.ToInt32(rw["MemberID"].ToString());
                            }
                            if (rw["SalesOrderID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.SalesOrderID = Convert.ToInt32(rw["SalesOrderID"].ToString());
                            }
                            if (rw["CreatedDT"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.CreatedDT = Convert.ToDateTime(rw["CreatedDT"].ToString());
                            }
                            if (rw["CreatedBy"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.CreatedBy = Convert.ToString(rw["CreatedBy"].ToString());
                            }
                            if (rw["SDate"] != DBNull.Value)
                            {
                                DateTime oDate = Convert.ToDateTime(rw["SDate"].ToString());
                                string sDate = oDate.Month.ToString() + "/" + oDate.Day.ToString() + "/" + oDate.Year.ToString();
                                oSalesOrderFromModel.SDate = sDate;
                            }
                            if (rw["PaidBy"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.PaidBy = Convert.ToString(rw["PaidBy"].ToString());
                            }
                            oSalesOrderFromModel.ErrorCode = 0;
                            oSalesOrderFromModel.ErrorMessage = "Success";
                            oSalesOrderFromModelList.Add(oSalesOrderFromModel);
                        }
                    }
                    else
                    {
                        oSalesOrderFromModel.ErrorCode = 100;
                        oSalesOrderFromModel.ErrorMessage = "No Order Found";
                        oSalesOrderFromModelList.Add(oSalesOrderFromModel);
                    }
                }
                catch (SqlException ex)
                {
                    oSalesOrderFromModel.ErrorCode = 601;
                    oSalesOrderFromModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oSalesOrderFromModelList;
        }

        public SalesOrderFrom getSalesOrder(int pSalesOrderID)
        {
            List<SalesOrderFrom> oSalesOrderFromModelList = new List<SalesOrderFrom>();
            SalesOrderFrom oSalesOrderFromModel = new SalesOrderFrom();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select SalesOrderID,AccFundID,MemberID,SDate,Amount,PaidBy,CreatedDT,CreatedBy from dbo.SalesOrderFrom where 1=1 and SalesOrderID= " + pSalesOrderID.ToString();

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oSalesOrderFromModel = new SalesOrderFrom();
                            if (rw["AccFundID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.AccFundID = Convert.ToInt32(rw["AccFundID"].ToString());
                            }
                            if (rw["MemberID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.MemberID = Convert.ToInt32(rw["MemberID"].ToString());
                            }
                            if (rw["SalesOrderID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.SalesOrderID = Convert.ToInt32(rw["SalesOrderID"].ToString());
                            }
                            if (rw["CreatedDT"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.CreatedDT = Convert.ToDateTime(rw["CreatedDT"].ToString());
                            }
                            if (rw["CreatedBy"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.CreatedBy = Convert.ToString(rw["CreatedBy"].ToString());
                            }
                            if (rw["SDate"] != DBNull.Value)
                            {
                                DateTime oDate = Convert.ToDateTime(rw["SDate"].ToString());
                                string sDate = oDate.Month.ToString() + "/" + oDate.Day.ToString() + "/" + oDate.Year.ToString();
                                oSalesOrderFromModel.SDate = sDate;
                            }
                            if (rw["PaidBy"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.PaidBy = Convert.ToString(rw["PaidBy"].ToString());
                            }
                            oSalesOrderFromModel.ErrorCode = 0;
                            oSalesOrderFromModel.ErrorMessage = "Success";
                            
                        }
                    }
                    else
                    {
                        oSalesOrderFromModel.ErrorCode = 101;
                        oSalesOrderFromModel.ErrorMessage = "Invalid Account";
                    }
                }
                catch (SqlException ex)
                {
                    oSalesOrderFromModel.ErrorCode = 601;
                    oSalesOrderFromModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oSalesOrderFromModel;
        }
        public SalesOrderFrom getSalesOrder(int pCompanyID, int pMemberID, string pDate, string pPaidBy)
        {
            DateTime purDate = new DateTime();
            try
            {
                purDate = Convert.ToDateTime(pDate);
            }
            catch
            {
            }

            List<SalesOrderFrom> oSalesOrderFromModelList = new List<SalesOrderFrom>();
            SalesOrderFrom oSalesOrderFromModel = new SalesOrderFrom();
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //
                string sSQL = "select SalesOrderID,AccFundID,MemberID,SDate,Amount,PaidBy,CreatedDT,CreatedBy from dbo.SalesOrderFrom where 1=1  " ;
                sSQL = sSQL + "    Where AccFundID = " + pCompanyID.ToString();
                sSQL = sSQL + "    And MemberID = " + pMemberID.ToString();
                sSQL = sSQL + "    And Year(SDate) = Year(" + purDate.ToString() + ")";
                sSQL = sSQL + "    And Month(SDate) = Month(" + purDate.ToString() + ")";
                sSQL = sSQL + "    And Day(SDate) = Day(" + pDate.ToString() + ")";
                sSQL = sSQL + "    And Hour(SDate) = Hour(" + pDate.ToString() + ")";
                sSQL = sSQL + "    And Minute(SDate) = Minute(" + pDate.ToString() + ")";
                sSQL = sSQL + "    And PaidBy= " + pPaidBy.ToString();

                SqlCommand cmd = new SqlCommand(sSQL, con);

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {

                    adpt.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dt.Rows)
                        {
                            oSalesOrderFromModel = new SalesOrderFrom();
                            if (rw["AccFundID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.AccFundID = Convert.ToInt32(rw["AccFundID"].ToString());
                            }
                            if (rw["MemberID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.MemberID = Convert.ToInt32(rw["MemberID"].ToString());
                            }
                            if (rw["SalesOrderID"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.SalesOrderID = Convert.ToInt32(rw["SalesOrderID"].ToString());
                            }
                            if (rw["CreatedDT"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.CreatedDT = Convert.ToDateTime(rw["CreatedDT"].ToString());
                            }
                            if (rw["CreatedBy"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.CreatedBy = Convert.ToString(rw["CreatedBy"].ToString());
                            }
                            if (rw["SDate"] != DBNull.Value)
                            {
                                DateTime oDate = Convert.ToDateTime(rw["SDate"].ToString());
                                string sDate = oDate.Month.ToString() + "/" + oDate.Day.ToString() + "/" + oDate.Year.ToString();
                                oSalesOrderFromModel.SDate = sDate;
                            }
                            if (rw["PaidBy"] != DBNull.Value)
                            {
                                oSalesOrderFromModel.PaidBy = Convert.ToString(rw["PaidBy"].ToString());
                            }
                            oSalesOrderFromModel.ErrorCode = 0;
                            oSalesOrderFromModel.ErrorMessage = "Success";

                        }
                    }
                    else
                    {
                        oSalesOrderFromModel.ErrorCode = 101;
                        oSalesOrderFromModel.ErrorMessage = "Invalid Order";
                    }
                }
                catch (SqlException ex)
                {
                    oSalesOrderFromModel.ErrorCode = 601;
                    oSalesOrderFromModel.ErrorMessage = ex.Message.ToString();
                }
            }
            return oSalesOrderFromModel;
        }

        public SalesOrderFrom CreateSalesOrder(SalesOrderFrom oSalesOrderFrom)
        {
            bool IsCreateOrder = false;
            List<SalesOrderFrom> oSalesOrderFromModelList = new List<SalesOrderFrom>();
            SalesOrderFrom oSalesOrderFromModel = new SalesOrderFrom();

            SalesOrderFrom DupSalesOrder = getSalesOrder(oSalesOrderFrom.AccFundID, oSalesOrderFrom.MemberID, oSalesOrderFrom.SDate, oSalesOrderFrom.PaidBy);
            if (DupSalesOrder.SalesOrderID > 0)
            {
                IsCreateOrder = false;
                oSalesOrderFromModel.ErrorCode = 102;
                oSalesOrderFromModel.ErrorMessage = "Duplicate Order Found";
                return oSalesOrderFromModel;
            }
            DataTable dt = new DataTable();
            string CONN_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GalfClub"].ConnectionString;
            SqlConnection con = new SqlConnection(CONN_STRING);
            {
                //

                string sSQL = "INSERT INTO [dbo].[SalesOrderFrom]([AccFundID],[MemberID],[SDate],[Amount],[PaidBy],[CreatedBy],[CreatedDT])";
                sSQL = sSQL + "VALUES(" + oSalesOrderFrom.AccFundID + "," + oSalesOrderFrom.MemberID + "," + oSalesOrderFrom.SDate + "," + oSalesOrderFrom.Amount + "," + oSalesOrderFrom.PaidBy + "," + oSalesOrderFrom.CreatedBy + "," + oSalesOrderFrom.CreatedDT + ")";

                SqlCommand cmd = new SqlCommand(sSQL, con);
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@VoucherHeadID", SqlDbType.NVarChar).Value = pVoucherHeadID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                try
                {
                    cmd.ExecuteNonQuery();

                    SalesOrderFrom InsertedSalesOrder = getSalesOrder(oSalesOrderFrom.AccFundID, oSalesOrderFrom.MemberID, oSalesOrderFrom.SDate, oSalesOrderFrom.PaidBy);
                    oSalesOrderFrom.SalesOrderID = InsertedSalesOrder.SalesOrderID;
                    oSalesOrderFrom.ErrorCode = 0;
                    oSalesOrderFrom.ErrorMessage = "Success";
                }
                catch (SqlException ex)
                {
                    oSalesOrderFrom.ErrorCode = 601;
                    oSalesOrderFrom.ErrorMessage = ex.Message.ToString();
                }
            }
            return oSalesOrderFrom;
        }
    }
}