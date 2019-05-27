﻿using System;
using CoreDX.Application.Domain.Model.Entity.Core;

namespace CoreDX.Application.Domain.Model.Entity.Identity
{
    public class ApplicationUserOrganization : ApplicationUserOrganization<Guid, ApplicationUser, Organization>
    {
    }

    public class ApplicationUserOrganization<TIdentityKey, TIdentityUser, TOrganization> : ManyToManyReferenceEntityBase<TIdentityKey, TIdentityUser>
        where TIdentityKey : struct, IEquatable<TIdentityKey>
        where TIdentityUser : IEntity<TIdentityKey>
        where TOrganization : Organization<TIdentityKey, TOrganization, TIdentityUser>
    {
        public TIdentityKey UserId { get; set; }

        public virtual TIdentityUser User { get; set; }

        public virtual TIdentityKey OrganizationId { get; set; }

        public virtual TOrganization Organization { get; set; }
    }
}