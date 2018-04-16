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
    [RoutePrefix("api/Member")]
    public class MemberController : ApiController
    {

        /// <summary>
        /// get - /api/Member/GetMembers
        /// </summary>
        /// <returns></returns>
        /// 
        
        [HttpGet]
        [Route("All")]
        //[Route("api/Member/GetMembers")]
        public List<Member> GetMemberAll()
        {

            DataLib oDataLib = new DataLib();
            List<Member> oMemberView = new List<Member>();
            oMemberView = oDataLib.getMembers();
            if (oMemberView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            
            return oMemberView;
        }
        /// <summary>
        /// get - /api/member/bycode/59
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet()]
        [Route("bycode/{Membercode}")]
        public Member GetBycode(string Membercode)
        {

            DataLib oDataLib = new DataLib();
            Member oMemberView = new Member();
            oMemberView = oDataLib.getMemberByCode(Membercode);
            if (oMemberView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oMemberView;
        }

        /// <summary>
        /// get - /api/member/byname/col
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet()]
        [Route("byname/{MemberName}")]
        public MemberBNameView GetByName(string MemberName)
        {

            DataLib oDataLib = new DataLib();
            MemberBNameView oMemberView = new MemberBNameView();
            oMemberView = oDataLib.getMemberByName(MemberName);
            if (oMemberView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oMemberView;
        }

        /// <summary>
        /// get - /api/member/byID/2
        /// </summary>
        /// <returns></returns>
        /// 
        [Route("byID/{ID}")]
        [HttpGet]
        public Member GetMemberbyID(int ID)
        {
            ResponseModel oResponseModel = new ResponseModel();

            DataLib oDataLib = new DataLib();
            Member oMemberView = new Member();
            oMemberView = oDataLib.getMemberByID(ID);
            if (oMemberView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            oResponseModel.Data = oMemberView;
            oResponseModel.Status = true;
            oResponseModel.Message = "Data Received successfully";
            return oMemberView;
        }
    }
}
