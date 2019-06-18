using UNPApi.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web.Http;
using DoctorPortalApi.Models;

namespace UNPApi.Controllers
{
    ///<LoginController>
    ///</LoginController>
    [RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        ///<LoginMethod>
        /// Login
        ///</LoginMethod>
        ///
        [HttpPost]
        public IHttpActionResult Login([FromBody] tbl_user objUser)
        {
            try
            {
                using (UNPEntities db = new UNPEntities())
                {
                    var obj = db.tbl_user.Where(a => a.username.Equals(objUser.username) && a.password.Equals(objUser.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        var token = createToken(obj.userid);
                        //return the token
                        var enMod = new LoginModel
                        {
                            userid = obj.userid,
                            username = obj.username,
                            user_mail = obj.user_mail,
                            token = token
                        };
                        return Ok(enMod);
                    }
                    else
                    {
                        return NotFound();
                    }
                }

            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        private string createToken(int username)
        {
            //Set issued at date
            DateTime issuedAt = DateTime.UtcNow;
            //set the time when it expires
            DateTime expires = DateTime.UtcNow.AddDays(7);

            //http://stackoverflow.com/questions/18223868/how-to-encrypt-jwt-security-token
            var tokenHandler = new JwtSecurityTokenHandler();

            //create a identity and add claims to the user which we want to log in
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, username.ToString())
            });

            //const string sec = "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b3727429090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1";
            //var now = DateTime.UtcNow;
            var securityKey = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes("sarveshsanepalli@agh"));
            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature);


            //create the jwt
            var token =
                (JwtSecurityToken)
                    tokenHandler.CreateJwtSecurityToken(issuer: "Syngymaxim", audience: "DoctorAppAgh",
                        subject: claimsIdentity, notBefore: issuedAt, expires: expires, signingCredentials: signingCredentials);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }

        ///<Summary>
        /// Gets the loggedin Username
        ///</Summary>
        public string GetUserName()
        {
            var claims = (ClaimsIdentity)ClaimsPrincipal.Current.Identity;

            if (claims == null)
            {
                return null;
            }


            //  var targetClaim = claims.FindFirst(c => c.Type == "Name");
            var targetClaim = claims.Name;
            if (targetClaim == null)
            {
                return null;
            }

            return targetClaim;
        }

    }
}
