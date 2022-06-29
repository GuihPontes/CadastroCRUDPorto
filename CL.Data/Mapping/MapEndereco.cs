using CL.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Data.Mapping
{
    public class MapEndereco : IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(EntityTypeBuilder<Movimentacao> builder)
        {
            builder.HasKey(p => new { p.Id, p.ClienteId }); 
             
            //builder.hasone(x => x.cliente)
            //     .withone(p => p.endereco)
            //     .hasforeignkey<endereco>(x => x.clienteid);
            //Esse comando cria uma chave estrangeira 
        }
    }
}
