using Shesha.Domain;
using Shesha.Domain.Attributes;
using Shesha.Memebership.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shesha.Memebership.Domain.Domain
{
    [Entity(TypeShortAlias = "Mem.Member")]
    public class Member : Person
    {
        /// <summary>
        /// The membership number for the Member
        /// </summary>
        public virtual string MembershipNumber { get; set; }
        /// <summary>
        /// The date when the membership started
        /// </summary>
        public virtual DateTime? MembershipStartDate { get; set; }
        /// <summary>
        /// The date when the membership ended
        /// </summary>
        public virtual DateTime? MembershipEndDate { get; set; }
        /// <summary>
        /// Identification document for the Member
        /// </summary>
        public virtual StoredFile IdDocument { get; set; }
        /// <summary>
        /// The status of the membership
        /// </summary>
        [ReferenceList("Mem", "MembershipStatuses")]
        public virtual RefListMembershipStatuses? MembershipStatus { get; set; }
    }
}
