﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectLine.Api.WPFDemo
{
    public class WebApiUserModel
    {
        public String TenantDatabaseName { get; set; }
        public String TenantDatabaseVersion { get; set; }
        public String UserKind { get; set; }
        public String LoginId { get; set; }
        public String Id { get; set; }
        public String UserName { get; set; }
        public String DisplayName { get; set; }
        public String LoginTime { get; set; }
        public String WawiUserToken { get; set; }
        public String TenantCurrencyThreeLetter { get; set; }
        public String ArtikelRundung { get; set; }

    }
}
