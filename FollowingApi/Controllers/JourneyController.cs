using FollowingBl.Services;
using FollowingDal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FollowingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JourneyController(JourneyService service) : ControllerBase
{
    //[HttpGet("v")]
    //public async Task<IActionResult> GetDropdownOptions()
    //{
    //    var result = await service.GetDropdownOptions();
    //    return Ok(result);
    //}

    [HttpGet("all")]
    public async Task<IActionResult> GetAllJourneysAsync()
    {
        var result = await service.GetAllJourneysAsync();
        return Ok(result);
    }

    [HttpGet("byId/{id}")]
    public async Task<IActionResult> GetByIdAsync(int journeyId)
    {
        var result = await service.GetByIdAsync(journeyId);

        if (result == null) { return NotFound(); }
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync([FromBody] Journey journey)
    {
        await service.AddAsync(journey);
        return Ok();
    }

    // QUERY: api/journey?statusCode=1&typeGroupCode=2

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int journeyId)
    {
        bool result = await service.DeleteAsync(journeyId);
        if (!result) { return NotFound(); }
        return Ok();
    }

    //// PUT: api/journey/UpDateJourney
    //public void GetupdateStatusJourneyToProcedure(int journeyCode)
    //{
    //    JourneyBL.GetupdateStatusJourneyToProcedure(journeyCode);
    //}

    // PUT: api/journey/PutFlightCodeToJourney
    //public Journey PutFlightCodeToJourney(Journey journey)
    //{
    //    return JourneyBL.PutFlightCodeToJourney(journey);
    //}
    //// GET: api/journey/GetAllStatus
    //public List<Status> GetAllStatus()
    //{
    //    return JourneyBL.GetAllStatus();
    //}

    //public int AddNewdMail(CategoryProduct catr)
    //{
    //    return 1;
    //    //  string  html = @"<div class='img1' style='height: 100%;width:100%;background-image:url(C:/Users/Groups/Desktop/FollowingProj/followingProject/MyAngularApp/src/assets/image/backgroundToPdf.jpg);'>";

    //    //    //message.Body += @"  <h1>" + user.userName + "</h1>";
    //    //    html +=             "<div class='empty' ></div>" +
    //    //                        "<h1 class='foodTech' >FoodTech</h1>" +
    //    //                        "<h2 class='adress' >מלכי ישראל 57</h2>" +
    //    //                        "<div class='tel' '>טל:0777651203</div>" +
    //    //                        "<div class='fax' > פקס:03-634007</div>" +
    //    //                        "<div class='date'>" + DateTime.Now + "</div>" +
    //    //                        "<div class='title' >חשבונית מס/קבלה :</div>" +
    //    //                        "<div class='source' > מקור</div>" +
    //    //                        "<div class='num' >343566</div>" +
    //    //                        "<div class='tiur'> תיאור וקוד פריט </div>" +
    //    //                        "<div class='cost' >מחיר</div></div>";

    //    //    byte[] pdf; // result will be here

    //    //    var cssText = File.ReadAllText("C:\\Users\\Groups\\Desktop\\FollowingProj\\followingProject\\MyAngularApp\\src\\app\\exelc\\exelc.component.css");
    //    //   // var html = File.ReadAllText("C:\\Users\\Groups\\Desktop\\FollowingProj\\followingProject\\MyAngularApp\\src\\app\\exelc\\exelc.component.html");

    //    //    using (var memoryStream = new MemoryStream())
    //    //    {
    //    //        var document = new Document(PageSize.A4, 10, 10, 10, 10);
    //    //        var writer = PdfWriter.GetInstance(document, memoryStream);
    //    //        document.Open();

    //    //        using (var cssMemoryStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(cssText)))
    //    //        {
    //    //            using (var htmlMemoryStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(html)))
    //    //            {
    //    //                XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, htmlMemoryStream, cssMemoryStream);
    //    //            }
    //    //        }

    //    //        document.Close();

    //    //        pdf = memoryStream.ToArray();
    //    //    }

    //    //    string f = "USD";
    //    //    string t = "EUR";
    //    //    decimal h = 20;
    //    //    string d;
    //    //    // d =JourneyBL.CurrencyConversion(h,f,t);

    //    //    string pdflocation = "D:\\";
    //    //    string fileName = "softcoree.pdf";

    //    //    // put your base64 string converted from online platform here instead of V
    //    //    //var base64String = catr.categoryName;

    //    //    //int mod4 = base64String.Length % 4;

    //    //    // as of my research this mod4 will be greater than 0 if the base 64 string is corrupted
    //    //    //if (mod4 > 0)
    //    //    //{
    //    //    //    base64String += new string('=', 4 - mod4);
    //    //    //}
    //    //    pdflocation = pdflocation + fileName;

    //    //    //byte[] data = Convert.FromBase64String(base64String);

    //    //    using (FileStream stream = System.IO.File.Create(pdflocation))
    //    //    {
    //    //        stream.Write(pdf, 0, pdf.Length);
    //    //    }

    //    //    string _password = "tlq$3302";
    //    //    string _sender = "tehilaQuestion@gmail.com";
    //    //    string userm = "bgtehila@gmail.com";
    //    //    SmtpClient client = new SmtpClient("smtp.gmail.com");
    //    //    SmtpClient oSmtp = new SmtpClient();
    //    //    client.Port = 587;
    //    //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
    //    //    client.UseDefaultCredentials = false;
    //    //    System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(_sender, _password);
    //    //    client.EnableSsl = true;
    //    //    client.Credentials = credentials;
    //    //    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(_sender, userm);
    //    //    ///message.To.Add(new MailAddress("mb0527611016@gmail.com"));
    //    //    message.Subject = @"שלום ";
    //    //    message.Body = "קבלה מFOODTECH";
    //    //    message.SubjectEncoding = System.Text.Encoding.UTF8;
    //    //    var filename = pdflocation;
    //    //    message.Attachments.Add(new Attachment(filename));
    //    //    client.Send(message);
    //    //    return 1;
    //    //}
    //    //public int GetQuotationToCustomer(int journeyCode)
    //    //{
    //    //  return  JourneyBL.GetQuotationToCustomer(journeyCode);
    //}
}