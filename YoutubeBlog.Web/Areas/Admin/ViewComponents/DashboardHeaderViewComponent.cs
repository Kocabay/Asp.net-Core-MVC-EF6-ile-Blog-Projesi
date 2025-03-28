﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Web.Areas.Admin.ViewComponents
{
    public class DashboardHeaderViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;

        public DashboardHeaderViewComponent(UserManager<AppUser> userManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var loggedInUser = await userManager.GetUserAsync(HttpContext.User);
            //var map = mapper.Map<UserDto>(loggedInUser);

            //var role = string.Join("", await userManager.GetRolesAsync(loggedInUser));
            //map.Role = role;

            return View();
        }
    }
}
