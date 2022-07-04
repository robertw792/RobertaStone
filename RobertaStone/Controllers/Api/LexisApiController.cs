using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using System.Web.Http.Controllers;
using AutoMapper;
using RobertaStone.Dtos;
using RobertaStone.Models;

namespace RobertaStone.Controllers.Api
{
    public class LexisApiController : ApiController
    {
        private ApplicationDbContext _context;
         
        public LexisApiController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api / Lexis
        public IEnumerable<LexisDto> GetAllLexis()
        {
            return _context.Lexis.ToList().Select(Mapper.Map<Lexis,LexisDto>);
        }

        public LexisDto GetLexisById(int id)
        {
            var lexisDto = _context.Lexis.SingleOrDefault(l => l.id == id);

            if (lexisDto == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Lexis,LexisDto>(lexisDto);
        }

        [HttpPost]
        public IHttpActionResult CreateLexis(LexisDto lexisDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var lexis = Mapper.Map<LexisDto, Lexis>(lexisDto);
            _context.Lexis.Add(lexis);
            _context.SaveChanges();

            // need to return the id to the client
            lexisDto.id = lexis.id;
            return Created(new Uri(Request.RequestUri + "/" + lexis.id),lexisDto);
        }

        [HttpPut]
        public void UpdateLexisById(int id, LexisDto lexisDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var lexisInDb = _context.Lexis.SingleOrDefault(l => l.id == id);

            if (lexisInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(lexisDto, lexisInDb);

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteLexisById(int id)
        {
            var lexisInDb = _context.Lexis.SingleOrDefault(l => l.id == id);
            if (lexisInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Lexis.Remove(lexisInDb);
            _context.SaveChanges();
        }
    }
}
