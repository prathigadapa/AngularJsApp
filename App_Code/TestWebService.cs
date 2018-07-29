using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

/// <summary>
/// Summary description for TestWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(false)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
 [System.Web.Script.Services.ScriptService]
public class TestWebService : System.Web.Services.WebService
{


    [WebMethod]
    public void GetStudents()
    {
        DataClassesDataContext ctx = new DataClassesDataContext();
        List<student> stu = new List<student>();
        stu = ctx.Students.Select(c=>new student() { id = c.Id,name=c.Name}).Distinct().ToList();
        JavaScriptSerializer js = new JavaScriptSerializer();
       
        Context.Response.Write(js.Serialize(stu));
    }

}
