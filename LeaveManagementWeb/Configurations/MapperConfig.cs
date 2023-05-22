using Microsoft.Build.Framework.Profiler;
using AutoMapper;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;

namespace LeaveManagementWeb.Configurations
{
    public class MapperConfig : Profile 
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            //allows conversion between types, from LeaveType to LeaveTypeVM and viceversa
        }

    }
}
