using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shesha.Memebership.Domain.Enums
{
    /// <summary>
    /// Possible statuses for a member's membership
    /// </summary>
    [ReferenceList("Mem", "MembershipStatuses")]
    public enum RefListMembershipStatuses : long
    {
        /// <summary>
        /// Membership is still being processed
        /// </summary>
        [Description("In Progress")]
        InProgress = 1,
        /// <summary>
        /// Membership is active
        /// </summary>
        [Description("Active")]
        Active = 2,
        /// <summary>
        /// Membership has been cancelled
        /// </summary>
        [Description("Cancelled")]
        Cancelled = 3
    }
}
