using Newtonsoft.Json.Linq;
using ServantInfo.Objects;
using ServantInfo.Requests;
using System;
using System.Web.Http;
using System.Web.Http.Description;

namespace ServantInfo.WebApplication.Controllers
{
    [RoutePrefix("ServantFinder")]
    public class ServantInfoController : ApiController
    {
        //[ApiExplorerSettings(IgnoreApi = true)]
        [ResponseType(typeof(Servant))]
        [HttpGet]
        public Servant ServantFinder(string servantId)
        {
            try
            {
                string URI = $"https://api.atlasacademy.io/nice/NA/servant/{servantId}";
                string result = WebRequest.MethodGet(URI);
                JObject resultJson = JObject.Parse(result);
                var servantName = (string)resultJson.GetValue("name");
                var servantRarity = (string)resultJson.GetValue("rarity");
                var servantCost = (string)resultJson.GetValue("cost");
                var servantAtkBase = (string)resultJson.GetValue("atkBase");
                var servantAtkMax = (string)resultJson.GetValue("atkMax");
                var servantHpBase = (string)resultJson.GetValue("hpBase");
                var servantHpMax = (string)resultJson.GetValue("hpMax");

                return new Servant(servantName, servantId, servantRarity, servantCost, servantAtkBase, servantAtkMax, servantHpBase, servantHpMax);
            }
            catch (Exception)
            {

            }

            return new Servant(false);
        }
    }
}