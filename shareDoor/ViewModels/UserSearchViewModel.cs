using PagedList;
using shareDoor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shareDoor.ViewModels
{
    public enum UserItemsPerPage
    {
        [Display(Name = "5")]
        p05 =5,
        [Display(Name = "10")]
        p10 = 10,
        [Display(Name = "15")]
        p15 = 15
    }

    public class UserSearchViewModel : ViewModelBase
    {


        public IPagedList<ApplicationUser> Users { get; set; }
        public UserItemsPerPage UserItemsPerPage { get; set; }

    }
}