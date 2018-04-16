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
    [RoutePrefix("api/PurchaseOrder")]
    public class PurchaseOrderController : ApiController
    {
        /// <summary>
        /// get - /api/Vendor/All
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("All")]
        public List<PurchaseOrderFrom> GetPurchaseOrderAll()
        {

            DataLib oDataLib = new DataLib();
            List<PurchaseOrderFrom> oPurchaseOrderFromView = new List<PurchaseOrderFrom>();
            oPurchaseOrderFromView = oDataLib.getPurchaseOrders();
            if (oPurchaseOrderFromView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oPurchaseOrderFromView;
        }
        /// <summary>
        /// get - /api/PurchaseOrder/bySupplier/59
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet()]
        [Route("bySupplier/{supplierid}")]
        public List<PurchaseOrderFrom> GetbySupplier(Int32 supplierid)
        {
            List<PurchaseOrderFrom> oPurchaseOrderFromView = new List<PurchaseOrderFrom>();
            DataLib oDataLib = new DataLib();            
            oPurchaseOrderFromView = oDataLib.getbySupplier(supplierid);
            if (oPurchaseOrderFromView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oPurchaseOrderFromView;
        }

        /// <summary>
        /// get - /api/PurchaseOrder/byPurchaseOrder/1
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet()]
        [Route("byPurchaseOrder/{PurchaseOrderid}")]
        public List<PurchaseOrderFrom> GetbyPurchaseOrder(Int32 PurchaseOrderid)
        {
            List<PurchaseOrderFrom> oPurchaseOrderFromView = new List<PurchaseOrderFrom>();
            DataLib oDataLib = new DataLib();
            oPurchaseOrderFromView = oDataLib.getbyPurchaseOrder(PurchaseOrderid);
            if (oPurchaseOrderFromView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oPurchaseOrderFromView;
        }

        /// <summary>
        /// post - /api/PurchaseOrder
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost()]
        [Route("CreatePurchaseOrder")]
        public PurchaseOrderFrom CreatePurchaseOrder(PurchaseOrderFrom oPurchaseOrderFrom)
        {
            //int pAccFundID ,int pSupplierID ,DateTime pDate ,decimal pPurchaseAmount ,decimal pDiscount ,decimal pVAT ,decimal pTAX ,string pPaidBy ,string pCreatedBy
            //PurchaseOrderFrom oPurchaseOrderFrom = new PurchaseOrderFrom();
            //oPurchaseOrderFrom.AccFundID = pAccFundID;
            //oPurchaseOrderFrom.SupplierID = pSupplierID;
            //oPurchaseOrderFrom.Date = pDate.ToString();
            //oPurchaseOrderFrom.PurchaseAmount = pPurchaseAmount;
            //oPurchaseOrderFrom.Discount = pDiscount;
            //oPurchaseOrderFrom.VAT = pVAT;
            //oPurchaseOrderFrom.TAX = pTAX;
            //oPurchaseOrderFrom.PaidBy = pPaidBy;
            //oPurchaseOrderFrom.CreatedBy = pCreatedBy;
            //oPurchaseOrderFrom.CreatedDT = DateTime.Now;

            PurchaseOrderFrom oPurchaseOrderFromView = new PurchaseOrderFrom();
            DataLib oDataLib = new DataLib();
            oPurchaseOrderFromView = oDataLib.CreatePurchaseOrder(oPurchaseOrderFrom);
            if (oPurchaseOrderFromView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oPurchaseOrderFromView;
        }

    }
}
