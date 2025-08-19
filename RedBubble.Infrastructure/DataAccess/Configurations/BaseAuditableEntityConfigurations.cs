using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedBubble.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.DataAccess.Configurations
{
    public class BaseAuditableEntityConfigurations<TEntity, TKey> : BaseEntityConfigurations<TEntity, TKey>
        where TEntity : BaseAuditableEntity<TKey> where TKey : IEquatable<TKey>
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);

            builder.Property(E => E.CreatedBy)
                .IsRequired();

            builder.Property(E => E.CreatedOn)
                .IsRequired()
                /*.HasDefaultValueSql("GETUTCDate()")*/;


            builder.Property(E => E.LastModifiedBy)
                .IsRequired();

            builder.Property(E => E.LastModifiedOn)
                .IsRequired()
                /*.HasDefaultValueSql("GETUTCDate()")*/;

        }
    }
}
