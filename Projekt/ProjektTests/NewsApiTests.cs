using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using NewsApi;

namespace ProjektTests
{
    [TestClass]
    public class NewsApiTests
    {
        private string token = "46491296cc1342edb76a89e49524896a";


        [TestMethod]
        public void getTopHeadlines_Returns_List()
        {
            List<string> categories = new List<string>();
            categories.Add("health");
            categories.Add("science");
            List<Articles> result = newsApiLogic.getTopHeadlines(token, categories);
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void getTopHeadlines_Doesnt_Return_Empty()
        {
            List<string> categories = new List<string>();
            categories.Add("health");
            categories.Add("science");
            List<Articles> result = newsApiLogic.getTopHeadlines(token, categories);
            Assert.IsTrue(result.Count>0);
        }


    }
}
