using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project1.Data;
using Project1.Models;
using Project1.Utilities;
using System.Data;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Project1.Controllers
{
    public class EcpayController : VerifyUserRoles
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly ProjectDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        public EcpayController(ProjectDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager):base(userManager, signInManager)
        {
            _db = db;
            _userManager = userManager;
        }
        //step1 : 網頁導入傳值到前端
        public ActionResult Index()
        {
            
            var orderId = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 20);
            //需填入你的網址
            var website = $"https://titmouse-willing-stud.ngrok-free.app";
            var order = new Dictionary<string, string>
                {
                    //綠界需要的參數
                    { "MerchantTradeNo",  orderId},
                    { "MerchantTradeDate",  DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")},
                    { "TotalAmount",  "100"},
                    { "TradeDesc",  "無"},
                    { "ItemName",  "測試商品"},
                    { "ExpireDate",  "3"},
                    { "CustomField1",  ""},
                    { "CustomField2",  ""},
                    { "CustomField3",  ""},
                    { "CustomField4",  ""},
                    { "ReturnURL",  $"{website}/Ecpay/AddPayInfo"},
                    { "OrderResultURL", $"{website}/Ecpay/PayInfo/{orderId}"},
                    { "PaymentInfoURL",  $"{website}/Ecpay/AddAccountInfo"},
                    { "ClientRedirectURL",  $"{website}/Ecpay/AccountInfo/{orderId}"},
                    { "MerchantID",  "2000132"},
                    { "IgnorePayment",  "GooglePay#WebATM#CVS#BARCODE"},
                    { "PaymentType",  "aio"},
                    { "ChoosePayment",  "ALL"},
                    { "EncryptType",  "1"},
                };
            //檢查碼
            order["CheckMacValue"] = GetCheckMacValue(order);
            
            return View(order);
        }
        private string GetCheckMacValue(Dictionary<string, string> order)
        {
            var param = order.Keys.OrderBy(x => x).Select(key => key + "=" + order[key]).ToList();
            var checkValue = string.Join("&", param);
            //測試用的 HashKey
            var hashKey = "5294y06JbISpM5x9";
            //測試用的 HashIV
            var HashIV = "v77hoKGq4kWxNNIS";
            checkValue = $"HashKey={hashKey}" + "&" + checkValue + $"&HashIV={HashIV}";
            checkValue = HttpUtility.UrlEncode(checkValue).ToLower();
            checkValue = GetSHA256(checkValue);
            return checkValue.ToUpper();
        }
        private string GetSHA256(string value)
        {
            var result = new StringBuilder();
            //var sha256 = SHA256.HashData()
            var bts = Encoding.UTF8.GetBytes(value);
            var hash = SHA256.HashData(bts);
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
        //Database1Entities db = new Database1Entities();
        //step4 : 新增訂單
        [HttpPost]
        [Route("Ecpay/AddOrders")]
        public string AddOrders([FromBody]JObject json)
        {
            int memberId = Util.getMemberId(_db, _userManager, User);
            string num = "0";
            try
            {

                EcpayOrders Orders = new EcpayOrders();
                Orders.MemberID = json["MerchantID"].ToString();
                Orders.MerchantTradeNo = json["MerchantTradeNo"].ToString();
                Orders.RtnCode = 0; //未付款
                Orders.RtnMsg = "訂單成功尚未付款";
                Orders.TradeNo = json["MerchantID"].ToString();
                //Orders.TradeAmt = Parse.Int32(json["TotalAmount"]);
                int totalAmount;
                if (int.TryParse((string?)json["TotalAmount"], out totalAmount))
                {
                    Orders.TradeAmt = totalAmount;
                }
                else
                {
                    Orders.TradeAmt = 0; // Default value or any other handling you prefer
                }
                
                Orders.PaymentDate = Convert.ToDateTime(json["MerchantTradeDate"]);
                Orders.PaymentType = json["PaymentType"].ToString();
                Orders.PaymentTypeChargeFee = "0";
                Orders.TradeDate = json["MerchantTradeDate"].ToString();
                Orders.SimulatePaid = 0;
                _db.EcpayOrders.Add(Orders);
                _db.SaveChanges();

                //寫入Order
                IEnumerable < ShoppingCart > cartItemList = _db.Cart.Where(c => c.MemberID == memberId);
                DbSet<Course> courseList = _db.Course;
                decimal total = cartItemList
                    .Join(
                        _db.Course,
                        cart => cart.CourseID,
                        course => course.CourseID,
                        (cart, course) => course.Price
                    )
                    .Sum();
                Order order = new Order();
                order.MemberID = memberId;
                order.OrderDate = DateTime.UtcNow;
                order.OrderStatus = "未付款";
                order.TotalAmount = total;
                order.MerchantTradeNo=Orders.MerchantTradeNo;
                //order.DiscountID
                _db.Order.Add(order);
                _db.SaveChanges();

                //寫入OrderDetail
                foreach (ShoppingCart cart in cartItemList)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.OrderID = order.OrderID;
                    orderDetail.CourseID=cart.CourseID;
                    orderDetail.Quantity = cart.Quantity;
                    orderDetail.UnitPrice = courseList.Where(c => c.CourseID == cart.CourseID).FirstOrDefault().Price;
                    orderDetail.SchedulerID = cart.SchedulerID;
                    _db.OrderDetail.Add(orderDetail);
                    _db.SaveChanges();
                }
                Console.WriteLine("====================================succeeded=================================");
                foreach (ShoppingCart cart in cartItemList)
                {
                    _db.Cart.Remove(cart);
                }
                _db.SaveChanges();
                num = "OK";
            }
            catch (Exception ex)
            {
                num = ex.ToString();
            }
            return num;
        }

        /// step5 : 取得付款資訊，更新資料庫
        [HttpPost]
        public ActionResult PayInfo(IFormCollection id)
        {
            var data = new Dictionary<string, string>();
            foreach (string key in id.Keys)
            {
                data.Add(key, id[key]);
            }
            
            string temp = id["MerchantTradeNo"]; //寫在LINQ(下一行)會出錯，
            var ecpayOrder = _db.EcpayOrders.Where(m => m.MerchantTradeNo == temp).FirstOrDefault();
            if (ecpayOrder != null)
            {
                ecpayOrder.RtnCode = int.Parse(id["RtnCode"]);
                if (id["RtnMsg"] == "Succeeded") ecpayOrder.RtnMsg = "已付款";
                ecpayOrder.PaymentDate = Convert.ToDateTime(id["PaymentDate"]);
                ecpayOrder.SimulatePaid = int.Parse(id["SimulatePaid"]);
                _db.Order.Where(o => o.MerchantTradeNo == ecpayOrder.MerchantTradeNo).FirstOrDefault().OrderStatus = "已付款";
                _db.SaveChanges();
            }
            return View("EcpayView", data);
        }
        /// step5 : 取得虛擬帳號 資訊
        [HttpPost]
        public ActionResult AccountInfo(FormCollection id)
        {
            var data = new Dictionary<string, string>();
            foreach (string key in id.Keys)
            {
                data.Add(key, id[key]);
            }
           
            string temp = id["MerchantTradeNo"]; //寫在LINQ會出錯
            var ecpayOrder = _db.EcpayOrders.Where(m => m.MerchantTradeNo == temp).FirstOrDefault();
            if (ecpayOrder != null)
            {
                ecpayOrder.RtnCode = int.Parse(id["RtnCode"]);
                if (id["RtnMsg"] == "Succeeded") ecpayOrder.RtnMsg = "已付款";
                ecpayOrder.PaymentDate = Convert.ToDateTime(id["PaymentDate"]);
                ecpayOrder.SimulatePaid = int.Parse(id["SimulatePaid"]);
                _db.SaveChanges();
            }
            return View("EcpayView", data);
        }

        [HttpPost]
        [Route("Ecpay/AddPayInfo")]
        public HttpResponseMessage AddPayInfo(HttpRequest request)
        {
            try
            {
                Console.WriteLine(request.ContentType);
                Console.WriteLine(request.QueryString);
                try {
                    Console.WriteLine( new StreamReader(request.Body).ReadToEnd() );
                } catch (Exception ingored) { }
                
                Console.WriteLine("Hi hi hi+++++++++++");
                //Console.WriteLine(info.ToString());
                //var cache = MemoryCache.Default;
                //cache.Set(info.Value<string>("MerchantTradeNo"), info, DateTime.Now.AddMinutes(60));
                return ResponseOK();
            }
            catch (Exception e)
            {
                return ResponseError();
            }
        }
        [HttpPost]
        [Route("Ecpay/AddAccountInfo")]
        public HttpResponseMessage AddAccountInfo(JObject info)
        {
            try
            {
                Console.WriteLine(info.ToString());
                //var cache = MemoryCache.Default;
                //cache.Set(info.Value<string>("MerchantTradeNo"), info, DateTime.Now.AddMinutes(60));
                return ResponseOK();
            }
            catch (Exception e)
            {
                return ResponseError();
            }
        }
        private HttpResponseMessage ResponseError()
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent("0|Error");
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
        private HttpResponseMessage ResponseOK()
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent("1|OK");
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}
