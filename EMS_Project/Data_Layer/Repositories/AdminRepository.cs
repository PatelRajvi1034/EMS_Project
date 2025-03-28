using EMS_Project.Data_Layer.DbContext;
using EMS_Project.Data_Layer.Models;

namespace EMS_Project.Data_Layer.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly EMSDbContext _context;

        public AdminRepository(EMSDbContext context)
        {
            _context = context;
        }
        public async Task<Admin> GetAdminByEmailAsync(string email)
        {
            var admin = await _context.Admins.FirstOrDefaultAsync(a => a.Email == email);
            return admin;
        }


        public async Task<Admin?> CheckAdminExistByEmailAsync(string email)
        {
            var admin = await _context.Admins.FirstOrDefaultAsync(a => a.Email == email);
            return admin;
        }

        public async Task<Admin?> UpdateAdmin(Admin admin)
        {
            _context.Admins.Update(admin);
            await _context.SaveChangesAsync();
            return admin;
        }
    }
}
