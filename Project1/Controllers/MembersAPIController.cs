using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.DTO;
using Project1.Models;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersAPIController : ControllerBase
    {
        private readonly ProjectDbContext _context;

        public MembersAPIController(ProjectDbContext context)
        {
            _context = context;
        }

        //會員總覽
        // GET: api/MembersAPI
        [HttpGet]
        public async Task<IEnumerable<MemberDTO>> GetMember()
        {
            return _context.Member.Select(e => new MemberDTO
            {
                MemberID = e.MemberID,
                //Photo=e.Photo,
                Name = e.Name,
                Email = e.Email,
                Phone = e.Phone,
                //IsTrainer = e.IsTrainer,
            });
        }

        //員工查詢
        // GET: api/MembersAPI/5
        [HttpGet("{id}")]
        public async Task<MemberDTO> GetMember(int id)
        {
            var Member = await _context.Member.FindAsync(id);

            MemberDTO MemDTO = null; 

            if (Member != null)
            {
                MemDTO = new MemberDTO
                {
                    MemberID = Member.MemberID,
                    Name = Member.Name,
                    Email = Member.Email,
                    Phone = Member.Phone,
                    //IsTrainer = Member.IsTrainer,
                };
            }
            return MemDTO;
        }


        //員工編輯
        // PUT: api/MembersAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<string> PutMember(int id, MemberDTO memberDTO)
        {
            if (id != memberDTO.MemberID)
            {
                return "修改失敗1";
            }

            Member Mem = await _context.Member.FindAsync(id);
            if (Mem == null) {
                return "修改失敗";
            }
            Mem.Name = memberDTO.Name;
            Mem.Email = memberDTO.Email;
            Mem.Phone = memberDTO.Phone;
            //Mem.IsTrainer = memberDTO.IsTrainer;
            _context.Entry(Mem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MemberExists(id))
                {
                    return "修改失敗3";
                }
                
            }

            return "修改成功";
        }


        //新增員工
        // POST: api/MembersAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<string> PostMember([FromBody]MemberDTO memberDTO)
        {
            Member mem = new Member 
            {
                Name = memberDTO.Name,
                Email = memberDTO.Email,
                Phone = memberDTO.Phone,
                //IsTrainer = memberDTO.IsTrainer,    
            };
            _context.Member.Add(mem);
            await _context.SaveChangesAsync();

            return $"員工編號:{mem.MemberID}";
        }

        // DELETE: api/MembersAPI/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteMember(int id)
        {
            var member = await _context.Member.FindAsync(id);
            if (member == null)
            {
                return "刪除失敗";
            }

            _context.Member.Remove(member);
            await _context.SaveChangesAsync();

            return "刪除成功";
        }

        private bool MemberExists(int id)
        {
            return _context.Member.Any(e => e.MemberID == id);
        }
    }
}
