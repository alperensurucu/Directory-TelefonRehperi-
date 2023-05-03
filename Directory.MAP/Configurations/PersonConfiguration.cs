using Directory.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Directory.MAP.Configurations
{
	public class PersonConfiguration : IEntityTypeConfiguration<Person>
	{
		//firstname kolonu zorunlu ve max 15 karakter olsun 
		//telefon kolonu zorunlu ve max 15 karaktr 
		//lastname max 15 karakter
		//company max 15 karakter

		public void Configure(EntityTypeBuilder<Person> builder)
		{
			builder.Property(x => x.FirstName).IsRequired().HasMaxLength(15);
			builder.Property(x => x.LastName).HasMaxLength(15);
			builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(15);
			builder.Property(x => x.Company).HasMaxLength(15);

		}
	}
}
