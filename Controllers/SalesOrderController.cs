using ClubMemberWebAPI.DTO;
using ClubMemberWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ClubMemberWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //[EnableCors(origins: "http://45.34.4.235:8053", headers: "*", methods: "*")]
    //[EnableCors(origins: "http://45.34.4.235:8052", headers: "*", methods: "*")]
    [RoutePrefix("api/SalesOrder")]
    public class SalesOrderController : ApiController
    {
        /// <summary>
        /// get - /api/SalesOrder/All
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("All")]

        public List<SalesOrderFrom> GetSalesOrderAll()
        {

            DataLib oDataLib = new DataLib();
            List<SalesOrderFrom> oSalesOrderFromFromView = new List<SalesOrderFrom>();
            oSalesOrderFromFromView = oDataLib.getSalesOrders();
            if (oSalesOrderFromFromView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oSalesOrderFromFromView;
        }
        /// <summary>
        /// get - /api/SalesOrder/byMember/59
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet()]
        [Route("byMember/{memberid}")]
        public List<SalesOrderFrom> GetbyMember(Int32 memberid)
        {
            List<SalesOrderFrom> oSalesOrderFromView = new List<SalesOrderFrom>();
            DataLib oDataLib = new DataLib();
            oSalesOrderFromView = oDataLib.getbyMember(memberid);
            if (oSalesOrderFromView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oSalesOrderFromView;
        }

        /// <summary>
        /// get - /api/SalesOrder/bySalesOrder/1
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet()]
        [Route("bySalesOrder/{SalesOrderid}")]
        public List<SalesOrderFrom> GetbyPurchaseOrder(Int32 SalesOrderid)
        {
            List<SalesOrderFrom> oSalesOrderFromView = new List<SalesOrderFrom>();
            DataLib oDataLib = new DataLib();
            oSalesOrderFromView = oDataLib.getbySalesOrder(SalesOrderid);
            if (oSalesOrderFromView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oSalesOrderFromView;
        }

        /// <summary>
        /// post - /api/SalesOrder
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost()]
        [Route("CreateSalesOrder")]
        public SalesOrderFrom CreateSalesOrder(SalesOrderFrom oSalesOrderFrom)
        {
            //int pAccFundID,int pMemberID,DateTime pSDate,decimal pAmount,string pPaidBy,string pCreatedBy
            //SalesOrderFrom oSalesOrderFrom = new SalesOrderFrom();
            //oSalesOrderFrom.AccFundID = pAccFundID;
            //oSalesOrderFrom.SDate = pSDate.ToString();
            //oSalesOrderFrom.MemberID = pMemberID;
            //oSalesOrderFrom.Amount = pAmount;
            //oSalesOrderFrom.PaidBy = pPaidBy;
            //oSalesOrderFrom.CreatedBy = pCreatedBy;
            //oSalesOrderFrom.CreatedDT = DateTime.Now;

            SalesOrderFrom oSalesOrderFromView = new SalesOrderFrom();
            DataLib oDataLib = new DataLib();
            oSalesOrderFromView = oDataLib.CreateSalesOrder(oSalesOrderFrom);
            if (oSalesOrderFromView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oSalesOrderFromView;
        }

    }
}
