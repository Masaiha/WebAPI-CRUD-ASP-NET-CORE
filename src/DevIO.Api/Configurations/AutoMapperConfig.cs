using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Business.Models;

namespace DevIO.Api.Extensions
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            // Mapeamento Entity => ViewModel
            CreateMap<Fornecedor, FornecedorViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(dest => dest.NomeFornecedor, opt => opt.MapFrom(src => src.Fornecedor.Nome));

            // Mapeamento ViewModel => Entity
            CreateMap<FornecedorViewModel, Fornecedor>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<ProdutoViewModel, Produto>();

        }
    }
}
