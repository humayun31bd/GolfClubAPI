using ClubMemberWebAPI.DTO;
using ClubMemberWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ClubVendorWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //[EnableCors(origins: "http://45.34.4.235:8053", headers: "*", methods: "*")]
    //[EnableCors(origins: "http://45.34.4.235:8052", headers: "*", methods: "*")]
    [RoutePrefix("api/Vendor")]
    public class VendorController : ApiController
    {
        /// <summary>
        /// get - /api/Vendor/All
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("All")]

        public List<Vendor> GetVendorAll()
        {

            DataLib oDataLib = new DataLib();
            List<Vendor> oVendorView = new List<Vendor>();
            oVendorView = oDataLib.getVendors();
            if (oVendorView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oVendorView;
        }
        /// <summary>
        /// get - /api/Vendor/bycode/59
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet()]
        [Route("bycode/{Vendorcode}")]
        public Vendor GetBycode(string Vendorcode)
        {

            DataLib oDataLib = new DataLib();
            Vendor oVendorView = new Vendor();
            oVendorView = oDataLib.getVendorByCode(Vendorcode);
            if (oVendorView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oVendorView;
        }

        /// <summary>
        /// get - /api/Vendor/byname/col
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet()]
        [Route("byname/{VendorName}")]
        public Vendor GetByName(string VendorName)
        {

            DataLib oDataLib = new DataLib();
            Vendor oVendorView = new Vendor();
            oVendorView = oDataLib.getVendorByName(VendorName);
            if (oVendorView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oVendorView;
        }

        /// <summary>
        /// get - /api/Vendor/byID/2
        /// </summary>
        /// <returns></returns>
        /// 
        [Route("byID/{ID}")]
        [HttpGet]
        public Vendor GetVendorbyID(int ID)
        {
            ResponseModel oResponseModel = new ResponseModel();

            DataLib oDataLib = new DataLib();
            Vendor oVendorView = new Vendor();
            oVendorView = oDataLib.getVendorByID(ID);
            if (oVendorView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            oResponseModel.Data = oVendorView;
            oResponseModel.Status = true;
            oResponseModel.Message = "Data Received successfully";
            return oVendorView;
        }

    }
}
