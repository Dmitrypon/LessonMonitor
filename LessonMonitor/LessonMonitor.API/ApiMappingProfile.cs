using AutoMapper;

namespace LessonMonitor.API
{
	public class ApiMappingProfile : Profile {
		public ApiMappingProfile()
		{
			CreateMap<Contracts.NewMember, Core.Member>();
			CreateMap<Core.Member, Contracts.Member>().ReverseMap();
		}
	}
}