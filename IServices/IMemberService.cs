using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.IServices
{
    public interface IMemberService
    {
        Task<List<Member>> GetMembersAsync();
        Task<Member> GetMemberAsync(int id);
        Task<int> AddMemberAsync(Member member);
        Task<int> UpdateMemberAsync(Member member);
        Task<int> DeleteMemberAsync(int id);
    }
}
