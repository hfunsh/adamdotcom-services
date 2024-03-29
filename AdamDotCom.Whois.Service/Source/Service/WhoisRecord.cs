﻿using System.Runtime.Serialization;

namespace AdamDotCom.Whois.Service
{
    [DataContract(Namespace = "http://adam.kahtava.com/services/whois")]
    public class WhoisRecord
    {
        [DataMember]
        public string DomainName { get; set; }

        [DataMember]
        public RegistryData RegistryData { get; set; }
    }

    [DataContract(Namespace = "http://adam.kahtava.com/services/whois")]
    public class RegistryData
    {
        [DataMember]
        public Contact AbuseContact { get; set; }

        [DataMember]
        public string CreatedDate { get; set; }

        [DataMember]
        public string UpdatedDate { get; set; }

        [DataMember]
        public Registrant Registrant { get; set; }

        [DataMember]
        public Contact AdministrativeContact { get; set; }

        [DataMember]
        public Contact BillingContact { get; set; }

        [DataMember]
        public Contact TechnicalContact { get; set; }

        [DataMember]
        public Contact ZoneContact { get; set; }

        [DataMember]
        public string RawText { get; set; }
    }

    [DataContract(Namespace = "http://adam.kahtava.com/services/whois")]
    public class Registrant
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string StateProv { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public string Country { get; set; }
    }

    [DataContract(Namespace = "http://adam.kahtava.com/services/whois")]
    public class Contact
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Phone { get; set; }
    }
}