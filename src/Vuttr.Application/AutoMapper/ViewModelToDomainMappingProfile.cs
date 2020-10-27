using AutoMapper;

namespace Vuttr.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            //CreateMap<ContatoViewModel, InsertContatoCommand>()
            //    .ConstructUsing(c => new InsertContatoCommand(c.Id,
            //                                                  c.Nome,
            //                                                  c.TelefoneFixo,
            //                                                  c.TelefoneCelular,
            //                                                  c.Email,
            //                                                  c.Situacao,
            //                                                  c.Cadastro));
        }
    }
}
