﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certify.Models
{
    public class RegistrationItem : VaultItem
    {
        public IEnumerable<string> Contacts { get; set; }
    }

    public class IdentifierItem : VaultItem
    {
        public string Dns { get; set; }
        public string Status { get; set; }
        public DateTime? AuthorizationExpiry { get; set; }
        public bool IsAuthorizationPending { get; set; }
        public string ValidationError { get; set; }
        public string ValidationErrorType { get; set; }
    }

    public class CertificateItem : VaultItem
    {
    }

    public class VaultItem
    {
        public string Id { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public string ItemType { get; set; }

        public List<VaultItem> Children { get; set; }
    }
}