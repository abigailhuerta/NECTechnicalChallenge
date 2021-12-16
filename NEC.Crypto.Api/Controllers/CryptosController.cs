using Microsoft.AspNetCore.Mvc;
using NEC.Crypto.Controllers.GetCryptoByConversion;
using NEC.Crypto.Controllers.GetCryptoByLimit;
using NEC.Crypto.DTOs.GetCryptoByConversion;
using NEC.Entities.Exceptions;

namespace NEC.Crypto.WebApiControllers
{
    [Route("api")]
    [ApiController]
    public class CryptosController : ControllerBase
    {
        readonly IGetCryptosByLimitController Controller;
        readonly IGetCryptoByConversionController ControllerConversion;

        public CryptosController(
            IGetCryptosByLimitController controller,IGetCryptoByConversionController controlleConversion)
        {
            Controller = controller;
            ControllerConversion = controlleConversion;
        }

        [HttpGet("Cryptos")]
        public async Task<IActionResult> GetCryptos()
        {
            IActionResult Result;
            try
            {
              var Cryptos = await Controller.GetCryptoByLimit(6);
              Result = Ok(Cryptos);
            }catch
            {
                Result = Problem("Bad Request", statusCode: 404);
            } 
            return Result;
        }

        [HttpPost("CryptoConversion")]
        public async Task<IActionResult> GetCryptoConversion(GetCryptoByConversionDTO dTO)
        {

            IActionResult Result;
            try
            {

                var Crypto = await ControllerConversion.GetCryptoByConversion(dTO);
                Result = Ok(Crypto);
            }
            catch
            {
                Result = Problem("Bad Request", statusCode: 404);
            }
            return Result;
        }
    }
}
