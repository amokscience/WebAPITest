using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPITest.Controllers;
using WebAPITest.Repository;

namespace Tests.Controllers
{
    [TestClass]
    public class ControllerTest : ApiController
    {
        [TestMethod]
        public void TestGetAllProducts()
        {
            var controller = new ProductController(new ProductRepository());
            var result = controller.Get();
            System.Diagnostics.Debug.WriteLine(result.Count());
            Assert.IsTrue(result.Count() > 0);
        }
    }
}
