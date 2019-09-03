﻿using CarServiceMS.Data;
using CarServiceMS.Data.Interfaces;
using CarServiceMS.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarLibraryMS.Service
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext context;

        public AdminService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void BanUser(string username)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdmin()
        {
            throw new NotImplementedException();
        }

        public IList<ApplicationUser> GetAllAdmins()
        {
            var adminRoleId = this.context.Roles.FirstOrDefault(role => role.Name == "Admin").Id;

            var adminsIds = this.context.UserRoles.Where(x => x.RoleId == adminRoleId).Select(x => x.UserId);

            var admins = this.context.User.Where(x => adminsIds.Contains(x.Id)).ToList();

            return admins;
        }

        public IList<ApplicationUser> GetAllUsers()
        {
            return this.context.Users
                .Include(user => user.Cars)
                .ToList();
        }
    }
}