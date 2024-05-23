using FirstApp.IServices;
using FirstApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Services
{
    public class MemberService : IMemberService
    {
        private readonly SQLiteAsyncConnection _database;

        public MemberService()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyData.db3");
            _database = new SQLiteAsyncConnection(databasePath);
            _database.CreateTableAsync<Member>().Wait();
        }

        public Task<List<Member>> GetMembersAsync()
        {
            return _database.Table<Member>().ToListAsync();
        }

        public Task<Member> GetMemberAsync(int id)
        {
            return _database.Table<Member>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> AddMemberAsync(Member member)
        {
            return _database.InsertAsync(member);
        }

        public Task<int> UpdateMemberAsync(Member member)
        {
            return _database.UpdateAsync(member);
        }

        public Task<int> DeleteMemberAsync(int id)
        {
            return _database.DeleteAsync<Member>(id);
        }
    }
}
