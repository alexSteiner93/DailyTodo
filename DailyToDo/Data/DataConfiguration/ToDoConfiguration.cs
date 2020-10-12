using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyToDo.Data;


namespace DailyToDo.Data.DataConfiguration
{
    public class ToDoConfiguration : IEntityTypeConfiguration<ToDo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ToDo> builder)
        {
            builder.ToTable("todo");
            builder.Property(prop => prop.Todo_id).HasColumnName("todo_id");
            builder.Property(prop => prop.Description).HasColumnName("description");
            builder.Property(prop => prop.Done).HasColumnName("done");
            builder.Property(prop => prop.Creationdate).HasColumnName("creationdate");
            builder.Property(prop => prop.Priority).HasColumnName("priority");
            builder.HasKey(prop => prop.Todo_id);
            builder.Property(prop => prop.Creationdate)
                .HasColumnType("TIMESTAMP(0)")
                .IsRequired();
       
        }
    }
}
