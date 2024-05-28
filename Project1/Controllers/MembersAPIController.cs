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
    //改造MVC控制器
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

        //查詢所有會員
        // GET: api/MembersAPI
        [HttpGet]
        public async Task<IEnumerable<MemberDTO>> GetMember()
        {
            return _context.Member.Select(e=>new MemberDTO
            {
                MemberID = e.MemberID,
                Name = e.Name,
                Email = e.Email,
                Phone = e.Phone,
            });
        }

        //會員查詢
        // GET: api/MembersAPI/5
        [HttpGet("{id}")]
        public async Task<MemberDTO> GetMember(int id)
        {
            var member = await _context.Member.FindAsync(id);

            MemberDTO MemDTO = null;
            if (member != null)
            {
                MemDTO = new MemberDTO
                {
                    MemberID= member.MemberID,
                    Name = member.Name,
                    Email = member.Email,
                    Phone = member.Phone,
                    //Birthday = (DateTime)member.Birthday,
                    //RegistrationDate = (DateTime)member.RegistrationDate,
                    //ResidenceArea = member.ResidenceArea,
                    //IsTrainer = (bool)member.IsTrainer,
                    //IsAdministrator = (bool)member.IsAdministrator
                };
            }
            return MemDTO;
        }

        //編輯會員
        // PUT: api/MembersAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<string> PutMember(int id, MemberDTO memberDTO)
        {
            if (id != memberDTO.MemberID)
            {
                return "修改失敗1";
            }
            Member Memb = await _context.Member.FindAsync(id);

            if (Memb == null)
            {
                return "修改失敗2";
            }
            Memb.Name = memberDTO.Name;
            Memb.Email = memberDTO.Email;
            Memb.Phone = memberDTO.Phone;
            Memb.ResidenceArea = memberDTO.ResidenceArea;
            Memb.Birthday = memberDTO.Birthday;
            Memb.RegistrationDate = memberDTO.RegistrationDate;
            Memb.IsTrainer = memberDTO.IsTrainer;
            //Memb.IsAdministrator = memberDTO.IsAdministrator;
            _context.Entry(Memb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return "修改失敗3";
            }
            return "修改成功";
        }


        //新增會員
        // POST: api/MembersAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<string> PostMember([FromBody]MemberDTO memDTO)
        {
            Member member = new Member
            {
				Name = memDTO.Name,
				Email = memDTO.Email,
				Phone = memDTO.Phone,
                Birthday = memDTO.Birthday,
                RegistrationDate = memDTO.RegistrationDate,
                ResidenceArea = memDTO.ResidenceArea,
                IsTrainer = memDTO.IsTrainer,
                //IsAdministrator = memDTO.IsAdministrator
            };
            _context.Member.Add(member);
            await _context.SaveChangesAsync();

            return $"會員編號:{member.MemberID}";
        }


        // DELETE: api/MembersAPI/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteMember(int id)
        {
            var member = await _context.Member.FindAsync(id);
            if (member == null)
            {
                return "刪除失敗1";
            }

            _context.Member.Remove(member);
            await _context.SaveChangesAsync();

            return "刪除成功";
        }

        //篩選條件查詢會員
        //POST api/MembersAPI/filter
        [HttpPost("filter")]
        public async Task<IEnumerable<MemberDTO>> FilterMembers(MemberDTO memberDTO) 
        {
            return _context.Member.Where(
                    meb => meb.MemberID == memberDTO.MemberID ||
                    meb.Name.Contains(memberDTO.Name) ||
                    meb.Email.Contains(memberDTO.Email) ||
                    meb.Phone.Contains(memberDTO.Phone)||
                    meb.ResidenceArea.Contains(memberDTO.ResidenceArea)).Select(meb => new MemberDTO
                    {
                        MemberID = meb.MemberID,
                        Name = meb.Name,
                        Email = meb.Email,
                        Phone = meb.Phone,
                        Birthday = (DateTime)meb.Birthday,
                        RegistrationDate = (DateTime)meb.RegistrationDate,
                        ResidenceArea = meb.ResidenceArea,
                        IsTrainer = (bool)meb.IsTrainer,
                        //IsAdministrator = (bool)meb.IsAdministrator
                    });
                    
        }


        private bool MemberExists(int id)
        {
            return _context.Member.Any(e => e.MemberID == id);
        }
    }
}
