﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace shareDoor.Models.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetUserNickName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("NickName");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetUserRole(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("Name");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static int CalculateAge(this DateTime theDateTime)
        {
            var age = DateTime.Today.Year - theDateTime.Year;
            if (theDateTime.AddYears(age) > DateTime.Today)
                age--;
            return age;
        }
    }
}