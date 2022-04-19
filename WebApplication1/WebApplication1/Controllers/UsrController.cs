using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class UsrController : ApiController
    {
        // GET: api/Usr
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Usr/5
        public object Get(string nickname, string password)
        {
            oldmansoldgameEntities entities = new oldmansoldgameEntities();
            Usr logado = entities.Usr.FirstOrDefault(u => u.nickname == nickname && u.password == password);

            if (logado == null)
            {
                return new 
                { 
                    message = "Senha ou login incorreto" 
                };
            }

            return new
            {
                ID = logado.id,
                nickname = logado.nickname,
                scoreRegular = logado.scoreRegular,
                scoreSuper = logado.scoreSuper,
            };
        }

        // POST: api/Usr
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usr/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usr/5
        public void Delete(int id)
        {
        }
    }
}
