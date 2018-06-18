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
    [RoutePrefix("api/Game")]
    public class GameController : ApiController
    {
        [HttpGet]
        [Route("GetHoleTypes")]
        //[Route("api/Member/GetMemberCategoryAll")]
        public List<HoleType> GetHoleTypes()
        {

            DataLib oDataLib = new DataLib();
            List<HoleType> oHoleTypeView = new List<HoleType>();
            oHoleTypeView = oDataLib.getHoleTypes();
            if (oHoleTypeView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oHoleTypeView;
        }

        [HttpGet]
        [Route("GetGameFee")]
        //[Route("api/Member/GetMemberCategoryAll")]
        public GameFee GetGameFee(string pMemberCode, int pHoleTypeID, string pGameDate)
        {

            DataLib oDataLib = new DataLib();
            GameFee oGameFeeView = new GameFee();
            oGameFeeView = oDataLib.getGameFee(pMemberCode, pHoleTypeID, pGameDate);
            if (oGameFeeView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oGameFeeView;
        }

        
        
        [HttpGet]
        [Route("GetGameCategory")]
        public List<GameCategory> GetGameCategory()
        {

            DataLib oDataLib = new DataLib();
            List<GameCategory> oGameCategoryView = new List<GameCategory>();
            oGameCategoryView = oDataLib.getGameCategorys();
            if (oGameCategoryView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oGameCategoryView;
        }
        [HttpGet]
        [Route("GetCaddie")]
        public List<Caddie> GetCaddie()
        {

            DataLib oDataLib = new DataLib();
            List<Caddie> oCaddieView = new List<Caddie>();
            oCaddieView = oDataLib.getCaddies();
            if (oCaddieView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oCaddieView;
        }
        [HttpGet]
        [Route("GetCaddieByID")]
        public Caddie GetCaddieByID(int ID)
        {
            DataLib oDataLib = new DataLib();
            Caddie oCaddieView = new Caddie();
            oCaddieView = oDataLib.getCaddie(ID);
            if (oCaddieView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oCaddieView;
        }

        [HttpGet]
        [Route("GetCaddieAvailable")]
        public Caddie GetCaddieAvailable(int ID, string GameDate)
        {
            DataLib oDataLib = new DataLib();
            Caddie oCaddieView = new Caddie();
            oCaddieView = oDataLib.getCaddieAvailable(ID, GameDate);
            if (oCaddieView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oCaddieView;
        }
        
        
        [HttpGet]
        [Route("GetBallBoy")]
        public List<BallBoy> GetBallBoy()
        {

            DataLib oDataLib = new DataLib();
            List<BallBoy> oBallBoyView = new List<BallBoy>();
            oBallBoyView = oDataLib.getBallBoys();
            if (oBallBoyView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oBallBoyView;
        }
        [HttpGet]
        [Route("Getballboybyid")]
        public BallBoy Getballboybyid(int ID)
        {
            DataLib oDataLib = new DataLib();
            BallBoy oBallBoyView = new BallBoy();
            oBallBoyView = oDataLib.getBallBoy(ID);
            if (oBallBoyView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            return oBallBoyView;
        }


        [HttpGet]
        [Route("GetballboyAvailable")]
        public BallBoy GetballboyAvailable(int ID, string GameDate)
        {
            DataLib oDataLib = new DataLib();
            BallBoy oBallBoyView = new BallBoy();
            oBallBoyView = oDataLib.getBallBoy(ID);
            if (oBallBoyView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            return oBallBoyView;
        }

        [HttpGet]
        [Route("MemberPersonalCaddieBallboy")]
        public List<MemberPersonalCaddieBallboy> GetMemberPersonalCaddieBallboy(int pMemberID)
        {

            DataLib oDataLib = new DataLib();
            List<MemberPersonalCaddieBallboy> oMemberPersonalCaddieBallboyView = new List<MemberPersonalCaddieBallboy>();
            oMemberPersonalCaddieBallboyView = oDataLib.getMemberPersonalCaddieBallboy(pMemberID);
            if (oMemberPersonalCaddieBallboyView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oMemberPersonalCaddieBallboyView;
        }

        [HttpGet]
        [Route("GetTees")]
        public List<Tee> GetTees()
        {

            DataLib oDataLib = new DataLib();
            List<Tee> oTeeView = new List<Tee>();
            oTeeView = oDataLib.getTees();
            if (oTeeView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oTeeView;
        }

        [HttpGet]
        [Route("GeTournaments")]
        public List<Tournament> GeTournaments()
        {

            DataLib oDataLib = new DataLib();
            List<Tournament> oTournamentView = new List<Tournament>();
            oTournamentView = oDataLib.getTournaments();
            if (oTournamentView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oTournamentView;
        }

        [HttpGet]
        [Route("GeTournamentFees")]
        public TournamentFee GeTournamentFees(int pTournamentID, int pMemberGroupID, int pHoleTypeID)
        {

            DataLib oDataLib = new DataLib();
            TournamentFee oTournamentFeeView = new TournamentFee();
            oTournamentFeeView = oDataLib.getTournamentFees(pTournamentID,pMemberGroupID,pHoleTypeID);
            if (oTournamentFeeView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oTournamentFeeView;
        }

        [HttpGet]
        [Route("GameRegisterMember")]
        public MemberGameReg GameRegisterMember(int pGameRegisterID)
        {
            ///string pGameDate1 = pGameDate + " 23:59:59";
            DataLib oDataLib = new DataLib();
            MemberGameReg oMemberGameRegView = new MemberGameReg();
            oMemberGameRegView = oDataLib.GetMemberGameRegister(pGameRegisterID);

            if (oMemberGameRegView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oMemberGameRegView;
        }

        [HttpGet]
        [Route("TournamentRegisterMember")]
        public TourRegisterMember TournamentRegisterMember(int pGameRegisterID)
        {
            ///string pGameDate1 = pGameDate + " 23:59:59";
            DataLib oDataLib = new DataLib();
            TourRegisterMember oTourRegisterMemberView = new TourRegisterMember();
            //oTourRegisterMemberView = oDataLib.GetMemberGameRegister(pGameRegisterID);

            //if (oMemberGameRegView == null)
            //{
            //    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            //}

            return oTourRegisterMemberView;
        }

        [HttpGet]
        [Route("GameFlightSchedules")]
        public GameBoardSchedule GameFlightSchedules(string pGameDate, string pGameDate1)
        {
            ///string pGameDate1 = pGameDate + " 23:59:59";
            DataLib oDataLib = new DataLib();
            GameBoardSchedule oGameFlightScheduleView = new GameBoardSchedule();

            oGameFlightScheduleView.Tee1 = oDataLib.GetGameBoard(pGameDate, pGameDate1,1);
            oGameFlightScheduleView.Tee2 = oDataLib.GetGameBoard(pGameDate, pGameDate1, 2);

            if (oGameFlightScheduleView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oGameFlightScheduleView;
        }

        [HttpGet]
        [Route("GameFlightScheduleWaitingPlayers")]
        public GameBoardSchedule GameFlightScheduleWaitingPlayers(string pGameDate, string pGameDate1)
        {
            bool IsWaiting = true;
            ///string pGameDate1 = pGameDate + " 23:59:59";
            DataLib oDataLib = new DataLib();
            GameBoardSchedule oGameFlightScheduleView = new GameBoardSchedule();

            oGameFlightScheduleView.Tee1 = oDataLib.GetGameBoardStatus(pGameDate, pGameDate1, 1, IsWaiting, false, false);
            oGameFlightScheduleView.Tee2 = oDataLib.GetGameBoardStatus(pGameDate, pGameDate1, 2, IsWaiting, false, false);

            if (oGameFlightScheduleView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oGameFlightScheduleView;
        }

        [HttpGet]
        [Route("GameFlightSchedulePlayingPlayers")]
        public GameBoardSchedule GameFlightSchedulePlayingPlayers(string pGameDate, string pGameDate1)
        {
            bool IsPlaying = true;
            ///string pGameDate1 = pGameDate + " 23:59:59";
            DataLib oDataLib = new DataLib();
            GameBoardSchedule oGameFlightScheduleView = new GameBoardSchedule();

            oGameFlightScheduleView.Tee1 = oDataLib.GetGameBoardStatus(pGameDate, pGameDate1, 1, false, IsPlaying, false);
            oGameFlightScheduleView.Tee2 = oDataLib.GetGameBoardStatus(pGameDate, pGameDate1, 2, false, IsPlaying, false);

            if (oGameFlightScheduleView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oGameFlightScheduleView;
        }

        [HttpGet]
        [Route("GameFlightScheduleMatchCompletePlayers")]
        public GameBoardSchedule GameFlightScheduleMatchComplete(string pGameDate, string pGameDate1)
        {
            bool IsMatchComplete = true;
            ///string pGameDate1 = pGameDate + " 23:59:59";
            DataLib oDataLib = new DataLib();
            GameBoardSchedule oGameFlightScheduleView = new GameBoardSchedule();

            oGameFlightScheduleView.Tee1 = oDataLib.GetGameBoardStatus(pGameDate, pGameDate1, 1, false, false, IsMatchComplete);
            oGameFlightScheduleView.Tee2 = oDataLib.GetGameBoardStatus(pGameDate, pGameDate1, 2, false, false, IsMatchComplete);

            if (oGameFlightScheduleView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oGameFlightScheduleView;
        }

        [HttpGet]
        [Route("TournamentFlightSch")]
        public List<TournamentFlightBoard> TournamentFlightSch(int pTournamentID, int pGameCateoryID, int pTeeID, string pTodate, string pTodate1)
        {

            DataLib oDataLib = new DataLib();
            List<TournamentFlightBoard> oTournamentFlightSchView = new List<TournamentFlightBoard>();
            oTournamentFlightSchView = oDataLib.getTournamentFlightBoards( pTournamentID,  pGameCateoryID,  pTeeID, pTodate , pTodate1);
            if (oTournamentFlightSchView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oTournamentFlightSchView;
        }

        [HttpPost()]
        [Route("CreateMemberTournamentPay")]
        public int CreateMemberTournamentPay([FromBody]dynamic GetPaymentList)
        {
            int dMemberBillID = 0;
            string CreatedBy = String.Empty;
            var master = GetPaymentList.Master;

            TourRegisterMember oTournamentRegisterMember = new TourRegisterMember();
            TourRegisterMember tour = Newtonsoft.Json.JsonConvert.DeserializeObject<TourRegisterMember>(master.ToString());
            oTournamentRegisterMember = new TourRegisterMember();
            oTournamentRegisterMember.MemberCode = tour.MemberCode;
            oTournamentRegisterMember.GameCategoryID = tour.GameCategoryID;
            oTournamentRegisterMember.TournamentFeeAmount = tour.TournamentFeeAmount;
            oTournamentRegisterMember.HoleTypeID = tour.HoleTypeID;
            //oTournamentRegisterMember.IsBooking = tour.IsBooking;
            //oTournamentRegisterMember.IsRegistration = tour.IsRegistration;
            oTournamentRegisterMember.RegDate = tour.RegDate;
            oTournamentRegisterMember.TeeID = tour.TeeID;
            oTournamentRegisterMember.TournamentFlightSchID = tour.TournamentFlightSchID;
            oTournamentRegisterMember.TournamentID = tour.TournamentID;


            if (!string.IsNullOrEmpty(tour.Credit))
            {
                oTournamentRegisterMember.Credit = "1";
                oTournamentRegisterMember.ChequeDT = tour.ChequeDT;
            }
            if (!string.IsNullOrEmpty(tour.Cash))
            {
                oTournamentRegisterMember.Cash = "1";
                oTournamentRegisterMember.ChequeDT = tour.ChequeDT;
            }
            if (!string.IsNullOrEmpty(tour.Card))
            {
                oTournamentRegisterMember.Card = "1";
                oTournamentRegisterMember.ChequeDT = tour.ChequeDT;
            }
            if (!string.IsNullOrEmpty(tour.Check))
            {
                oTournamentRegisterMember.Check = "1";
                oTournamentRegisterMember.ChequeNo = tour.ChequeNo;
                oTournamentRegisterMember.ChequeDT = tour.ChequeDT;
                if (tour.BankID == 0)
                {
                    oTournamentRegisterMember.BankID = 0;
                }
                else
                {
                    oTournamentRegisterMember.BankID = tour.BankID;
                }
            }
            if (!string.IsNullOrEmpty(tour.Card))
            {
                if (tour.BankID == 0)
                {
                    oTournamentRegisterMember.BankID = 0;
                }
                else
                {
                    oTournamentRegisterMember.BankID = tour.BankID;
                }
                oTournamentRegisterMember.Card = "1";
                oTournamentRegisterMember.ChequeNo = tour.ChequeNo;
                oTournamentRegisterMember.ChequeDT = tour.ChequeDT;
            }

            if ((oTournamentRegisterMember.Cash == "1") ||
                (oTournamentRegisterMember.BCard == "1") ||
                (oTournamentRegisterMember.Check == "1") ||
                (oTournamentRegisterMember.Credit == "1")
                )
            {
            }
            else
            {
                oTournamentRegisterMember.PayTypeID = 5;
            }

            DataLib oDataLib = new DataLib();

            if (oTournamentRegisterMember == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
                return dMemberBillID;
            }

            dMemberBillID = oDataLib.CreateMemberTournamentRegBill(oTournamentRegisterMember);

            return (dMemberBillID);
        }

        [HttpPost()]
        [Route("CreateMemberGamePay")]
        public GameBoardMemberModel CreateMemberGamePay([FromBody]dynamic GetPaymentList)
        {
            GameBoardMemberModel oGameBoardMemberModel = new GameBoardMemberModel();

            int dMemberBillID = 0;
            oGameBoardMemberModel.MemberBillID = dMemberBillID;
            
            string CreatedBy = String.Empty;
            var master = GetPaymentList.Master;

            MemberGameReg oMemberGameReg = new MemberGameReg();
            MemberGameReg Gamreg = Newtonsoft.Json.JsonConvert.DeserializeObject<MemberGameReg>(master.ToString());
            oMemberGameReg = new MemberGameReg();
            oMemberGameReg.MemberCode = Gamreg.MemberCode;
            oMemberGameReg.FlightSchID = Gamreg.FlightSchID;
            oMemberGameReg.IsSinglePlayer = Gamreg.IsSinglePlayer;
            oMemberGameReg.IsGroupPlayer = Gamreg.IsGroupPlayer;
            oMemberGameReg.BallBoyID = Gamreg.BallBoyID;
            oMemberGameReg.BallBoyFee = Gamreg.BallBoyFee;
            oMemberGameReg.CaddieFee = Gamreg.CaddieFee;
            oMemberGameReg.CaddiePermanent = Gamreg.CaddiePermanent;
            oMemberGameReg.CaddieID = Gamreg.CaddieID;
            oMemberGameReg.NeedGolfCart = Gamreg.NeedGolfCart;
            oMemberGameReg.GolfCartID = Gamreg.GolfCartID;
            oMemberGameReg.GolfCartFee = Gamreg.GolfCartFee;
            oMemberGameReg.GolfCartHoleTypeID = Gamreg.GolfCartHoleTypeID;
            oMemberGameReg.GreenFee = Gamreg.GreenFee;
            oMemberGameReg.CaddieSubsidy = Gamreg.CaddieSubsidy;
            oMemberGameReg.BallBoySubsidy = Gamreg.BallBoySubsidy;
            oMemberGameReg.BallBoyFee = Gamreg.BallBoyFee;
            oMemberGameReg.GreenFee = Gamreg.GreenFee;
            oMemberGameReg.GreenSubsidy = Gamreg.GreenSubsidy;
            oMemberGameReg.HoleTypeID = Gamreg.HoleTypeID;
            oMemberGameReg.IsBooking = Gamreg.IsBooking;
            oMemberGameReg.BookingDate = Gamreg.BookingDate;
            oMemberGameReg.RegDate = Gamreg.RegDate;
            oMemberGameReg.PlayDate = Gamreg.PlayDate;
            oMemberGameReg.TeeID = Gamreg.TeeID;
            oMemberGameReg.FlightSchID = Gamreg.FlightSchID;
            oMemberGameReg.TotalBill = Gamreg.TotalBill;
            oMemberGameReg.EstTeeOffTime = Gamreg.EstTeeOffTime;
            oMemberGameReg.NextTeeEstTime = Gamreg.NextTeeEstTime;
            oMemberGameReg.NextTeeID = Gamreg.NextTeeID;
            oMemberGameReg.NextFlightSchID = Gamreg.NextFlightSchID;
            oMemberGameReg.ChequeDT = DateTime.Now.Date;
            if (Gamreg.ChequeDT != null)
            {
                oMemberGameReg.ChequeDT = Gamreg.ChequeDT;
            }

            if (!string.IsNullOrEmpty(Gamreg.Cash))
            {
                oMemberGameReg.Cash = "1";
            }
            if (!string.IsNullOrEmpty(Gamreg.Check))
            {
                oMemberGameReg.Check = "1";
                oMemberGameReg.ChequeNo = Gamreg.ChequeNo;
                if (Gamreg.BankID == 0)
                {
                    oMemberGameReg.BankID = 0;
                }
                else
                {
                    oMemberGameReg.BankID = Gamreg.BankID;
                }
            }
            if (!string.IsNullOrEmpty(Gamreg.Card))
            {
                if (Gamreg.BankID == 0)
                {
                    oMemberGameReg.BankID = 0;
                }
                else
                {
                    oMemberGameReg.BankID = Gamreg.BankID;
                }
                oMemberGameReg.Card = "1";
                oMemberGameReg.ChequeNo = Gamreg.ChequeNo;
            }
            if (!string.IsNullOrEmpty(Gamreg.BCard))
            {
                if (Gamreg.BankID == 0)
                {
                    oMemberGameReg.BankID = 0;
                }
                else
                {
                    oMemberGameReg.BankID = Gamreg.BankID;
                }
                oMemberGameReg.BCard = "1";
                oMemberGameReg.ChequeNo = Gamreg.ChequeNo;
            }

            DataLib oDataLib = new DataLib();

            oGameBoardMemberModel.RegDate = Gamreg.RegDate.ToShortDateString();

            if (oMemberGameReg == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
                return oGameBoardMemberModel;
            }

            dMemberBillID = oDataLib.CreateMemberGameRegBill(oMemberGameReg);
            oGameBoardMemberModel.MemberBillID = dMemberBillID;
            oGameBoardMemberModel.RegDate = Gamreg.RegDate.ToShortDateString();

            return (oGameBoardMemberModel);

        }


        [HttpPost()]
        [Route("CreateMemberGameExtraPay")]
        public GameBoardMemberModel CreateMemberGameExtraPay([FromBody]dynamic GetPaymentList)
        {
            GameBoardMemberModel oGameBoardMemberModel = new GameBoardMemberModel();

            int dMemberBillID = 0;
            oGameBoardMemberModel.MemberBillID = dMemberBillID;

            string CreatedBy = String.Empty;
            var master = GetPaymentList.Master;

            MemberGameReg oMemberGameReg = new MemberGameReg();
            MemberGameReg Gamreg = Newtonsoft.Json.JsonConvert.DeserializeObject<MemberGameReg>(master.ToString());
            oMemberGameReg = new MemberGameReg();
            oMemberGameReg.MemberCode = Gamreg.MemberCode;
            oMemberGameReg.FlightSchID = Gamreg.FlightSchID;
            oMemberGameReg.GRegisterID = Gamreg.GRegisterID;
            oMemberGameReg.IsSinglePlayer = Gamreg.IsSinglePlayer;
            oMemberGameReg.IsGroupPlayer = Gamreg.IsGroupPlayer;
            oMemberGameReg.BallBoyID = Gamreg.BallBoyID;
            oMemberGameReg.BallBoyFee = Gamreg.BallBoyFee;
            oMemberGameReg.CaddieFee = Gamreg.CaddieFee;
            oMemberGameReg.CaddiePermanent = Gamreg.CaddiePermanent;
            oMemberGameReg.CaddieID = Gamreg.CaddieID;
            oMemberGameReg.NeedGolfCart = Gamreg.NeedGolfCart;
            oMemberGameReg.GolfCartID = Gamreg.GolfCartID;
            oMemberGameReg.GolfCartFee = Gamreg.GolfCartFee;
            oMemberGameReg.GolfCartHoleTypeID = Gamreg.GolfCartHoleTypeID;
            oMemberGameReg.GreenFee = Gamreg.GreenFee;
            oMemberGameReg.CaddieSubsidy = Gamreg.CaddieSubsidy;
            oMemberGameReg.BallBoySubsidy = Gamreg.BallBoySubsidy;
            oMemberGameReg.BallBoyFee = Gamreg.BallBoyFee;
            oMemberGameReg.GreenFee = Gamreg.GreenFee;
            oMemberGameReg.GreenSubsidy = Gamreg.GreenSubsidy;
            oMemberGameReg.HoleTypeID = Gamreg.HoleTypeID;
            oMemberGameReg.IsBooking = Gamreg.IsBooking;
            oMemberGameReg.BookingDate = Gamreg.BookingDate;
            oMemberGameReg.RegDate = Gamreg.RegDate;
            oMemberGameReg.PlayDate = Gamreg.PlayDate;
            oMemberGameReg.TeeID = Gamreg.TeeID;
            oMemberGameReg.FlightSchID = Gamreg.FlightSchID;
            oMemberGameReg.TotalBill = Gamreg.TotalBill;
            oMemberGameReg.EstTeeOffTime = Gamreg.EstTeeOffTime;
            oMemberGameReg.NextTeeEstTime = Gamreg.NextTeeEstTime;
            oMemberGameReg.NextTeeID = Gamreg.NextTeeID;
            oMemberGameReg.NextFlightSchID = Gamreg.NextFlightSchID;
            oMemberGameReg.ChequeDT = DateTime.Now.Date;
            if (Gamreg.ChequeDT != null)
            {
                oMemberGameReg.ChequeDT = Gamreg.ChequeDT;
            }

            if (!string.IsNullOrEmpty(Gamreg.Cash))
            {
                oMemberGameReg.Cash = "1";
            }
            if (!string.IsNullOrEmpty(Gamreg.Check))
            {
                oMemberGameReg.Check = "1";
                oMemberGameReg.ChequeNo = Gamreg.ChequeNo;
                if (Gamreg.BankID == 0)
                {
                    oMemberGameReg.BankID = 0;
                }
                else
                {
                    oMemberGameReg.BankID = Gamreg.BankID;
                }
            }
            if (!string.IsNullOrEmpty(Gamreg.Card))
            {
                if (Gamreg.BankID == 0)
                {
                    oMemberGameReg.BankID = 0;
                }
                else
                {
                    oMemberGameReg.BankID = Gamreg.BankID;
                }
                oMemberGameReg.Card = "1";
                oMemberGameReg.ChequeNo = Gamreg.ChequeNo;
            }
            if (!string.IsNullOrEmpty(Gamreg.BCard))
            {
                if (Gamreg.BankID == 0)
                {
                    oMemberGameReg.BankID = 0;
                }
                else
                {
                    oMemberGameReg.BankID = Gamreg.BankID;
                }
                oMemberGameReg.BCard = "1";
                oMemberGameReg.ChequeNo = Gamreg.ChequeNo;
            }

            DataLib oDataLib = new DataLib();

            oGameBoardMemberModel.RegDate = Gamreg.RegDate.ToShortDateString();

            if (oMemberGameReg == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
                return oGameBoardMemberModel;
            }

            dMemberBillID = oDataLib.CreateMemberGameRegExtraBill(oMemberGameReg);
            oGameBoardMemberModel.MemberBillID = dMemberBillID;
            oGameBoardMemberModel.RegDate = Gamreg.RegDate.ToShortDateString();

            return (oGameBoardMemberModel);

        }

        
        [HttpPost()]
        [Route("CreateMemberGameStart")]
        public List<GameFlightSchMember> CreateMemberGameStart([FromBody]dynamic GetGameWaitingPlayers)
        {
            ///int pFlightSchMemberID, string pMemberCode;
            DataLib oDataLib = new DataLib();
            GameFlightSchMember oGameFlightSchMemberModel = new GameFlightSchMember();
            List<GameFlightSchMember> oGameFlightSchMemberModelList = new List<GameFlightSchMember>();
            var master = GetGameWaitingPlayers.WaitingPlayers;

            List<GameFlightSchMember> GGameFlightSchMemberList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GameFlightSchMember>>(master.ToString());
            foreach(GameFlightSchMember GFSchMember in GGameFlightSchMemberList)
            {
                oGameFlightSchMemberModel = new GameFlightSchMember();
                oGameFlightSchMemberModel.FlightSchMemberID = GFSchMember.FlightSchMemberID;
                oGameFlightSchMemberModel.MemberCode = GFSchMember.MemberCode;
                oGameFlightSchMemberModel = oDataLib.CreateMemberGameStart(oGameFlightSchMemberModel.FlightSchMemberID, oGameFlightSchMemberModel.MemberCode);
                oGameFlightSchMemberModelList.Add(oGameFlightSchMemberModel);
            }


            if (oGameFlightSchMemberModel == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
                return oGameFlightSchMemberModelList;
            }

            return (oGameFlightSchMemberModelList);

        }

        [HttpPost()]
        [Route("CreateMemberGameMatchComplete")]
        public List<GameFlightSchMember> CreateMemberGameMatchComplete([FromBody]dynamic GetGameplayingPlayers)
        {
            //int pFlightSchMemberID, string pMemberCode
            DataLib oDataLib = new DataLib();
            GameFlightSchMember oGameFlightSchMemberModel = new GameFlightSchMember();
            List<GameFlightSchMember> oGameFlightSchMemberModelList = new List<GameFlightSchMember>();
            var master = GetGameplayingPlayers.PlayingPlayers;


            List<GameFlightSchMember> GGameFlightSchMemberList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GameFlightSchMember>>(master.ToString());
            foreach (GameFlightSchMember GFSchMember in GGameFlightSchMemberList)
            {
                oGameFlightSchMemberModel = new GameFlightSchMember();
                oGameFlightSchMemberModel.FlightSchMemberID = GFSchMember.FlightSchMemberID;
                oGameFlightSchMemberModel.MemberCode = GFSchMember.MemberCode;
                oGameFlightSchMemberModel = oDataLib.CreateMemberGameMatchComplete(oGameFlightSchMemberModel.FlightSchMemberID, oGameFlightSchMemberModel.MemberCode);
                oGameFlightSchMemberModelList.Add(oGameFlightSchMemberModel);
            }



            if (oGameFlightSchMemberModel == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
                return oGameFlightSchMemberModelList;
            }

            return (oGameFlightSchMemberModelList);

        }


        [HttpPost()]
        [Route("CreateGolfGameMatchComplete")]
        public void CreateGolfGameMatchComplete([FromBody]dynamic GetGameplayingPlayers)
        {
            //int pFlightSchMemberID, string pMemberCode
            //DataLib oDataLib = new DataLib();
            //GameFlightSchMember oGameFlightSchMemberModel = new GameFlightSchMember();
            //List<GameFlightSchMember> oGameFlightSchMemberModelList = new List<GameFlightSchMember>();
            //var master = GetGameplayingPlayers.PlayingPlayers;


            //List<GameFlightSchMember> GGameFlightSchMemberList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GameFlightSchMember>>(master.ToString());
            //foreach (GameFlightSchMember GFSchMember in GGameFlightSchMemberList)
            //{
            //    oGameFlightSchMemberModel = new GameFlightSchMember();
            //    oGameFlightSchMemberModel.FlightSchMemberID = GFSchMember.FlightSchMemberID;
            //    oGameFlightSchMemberModel.MemberCode = GFSchMember.MemberCode;
            //    oGameFlightSchMemberModel = oDataLib.CreateMemberGameMatchComplete(oGameFlightSchMemberModel.FlightSchMemberID, oGameFlightSchMemberModel.MemberCode);
            //    oGameFlightSchMemberModelList.Add(oGameFlightSchMemberModel);
            //}



            //if (oGameFlightSchMemberModel == null)
            //{
            //    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            //    ///return oGameFlightSchMemberModelList;
            //}

            ///return (oGameFlightSchMemberModelList);

        }


        [HttpPost()]
        [Route("CreateGameMatchScore")]
        public GameMatchScore CreateGameMatchScore([FromBody]dynamic GetGameScore)
        {
            GameMatchScore oGameBoardMemberModel = new GameMatchScore();

            int dMemberBillID = 0;

            string CreatedBy = String.Empty;
            var master = GetGameScore.MatchScore;

            GameMatchScore objGMatchScore = new GameMatchScore();
            GameMatchScore GMatchScore = Newtonsoft.Json.JsonConvert.DeserializeObject<GameMatchScore>(master.ToString());
            objGMatchScore = new GameMatchScore();
            objGMatchScore.FlightSchMemberID = GMatchScore.FlightSchMemberID;
            objGMatchScore.FlightSchID = GMatchScore.FlightSchID;
            objGMatchScore.HoleDate = GMatchScore.HoleDate;
            objGMatchScore.HoleNo = GMatchScore.HoleNo;
            objGMatchScore.HoleTime = GMatchScore.HoleTime;
            objGMatchScore.MarkerPlayerID = GMatchScore.MarkerPlayerID;
            objGMatchScore.PlayerMemberID = GMatchScore.PlayerMemberID;
            objGMatchScore.PointNoHole = GMatchScore.PointNoHole;
            objGMatchScore.TeeID = GMatchScore.TeeID;
            if (objGMatchScore.HoleTime == null)
            {
                objGMatchScore.HoleTime = DateTime.Now;
            }
            else
            {
                objGMatchScore.HoleTime = Convert.ToDateTime(GMatchScore.HoleTime);
            }
            if (objGMatchScore.HoleDate == null)
            {
                objGMatchScore.HoleDate = DateTime.Now.Date;
            }
            else
            {
                objGMatchScore.HoleDate = Convert.ToDateTime(GMatchScore.HoleDate);
            }            

            DataLib oDataLib = new DataLib();


            if (objGMatchScore == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
                return objGMatchScore;
            }

            objGMatchScore = oDataLib.CreateGameScore_Insert_Update(objGMatchScore);

            return (oGameBoardMemberModel);

        }

        [HttpPost()]
        [Route("CreateGameMatchGroup")]
        public GameMatchGroup CreateGameMatchGroup(string pGroupname, string pGroupCode)
        {
            GameMatchGroup oGameMatchGroup = new GameMatchGroup();

            int dMemberBillID = 0;

            oGameMatchGroup.GroupName = pGroupname;
            oGameMatchGroup.GroupCode = pGroupCode;

            DataLib oDataLib = new DataLib();


            if (oGameMatchGroup == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
                return oGameMatchGroup;
            }

            oGameMatchGroup = oDataLib.CreateGameMatchGroup(oGameMatchGroup);

            return (oGameMatchGroup);

        }

        [HttpGet]
        [Route("getTournamentDues")]
        public List<TournamentDue> getTournamentDues(string pMemberCode)
        {

            DataLib oDataLib = new DataLib();
            List<TournamentDue> oTournamentDueView = new List<TournamentDue>();
            oTournamentDueView = oDataLib.getTournamentDues(pMemberCode);
            if (oTournamentDueView == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return oTournamentDueView;
        }


    }

}
